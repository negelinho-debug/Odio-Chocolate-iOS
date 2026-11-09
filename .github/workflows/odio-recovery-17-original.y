
name: Odio Recovery 17 - Original Exit Logic

on:
  workflow_dispatch:

permissions:
  contents: write

jobs:
  original-exits:
    runs-on: ubuntu-latest
    timeout-minutes: 12
    steps:
      - uses: actions/checkout@v4
        with:
          ref: main

      - name: Restore exit logic from the original APK
        shell: bash
        run: |
          python3 - <<'PY'
          from pathlib import Path
          import re

          root = Path('Assets/Scripts/Assembly-CSharp')
          foundation = Path('Assets/OdioDiagnostics/OdioPlayableFix12.cs')
          controller = root / 'GameControllerScript.cs'
          entrance = root / 'EntranceScript.cs'
          near = root / 'NearExitTriggerScript.cs'
          finish = root / 'ExitTriggerScript.cs'

          for path in (foundation, controller, entrance, near, finish):
              if not path.is_file():
                  raise SystemExit('Missing: ' + str(path))

          def method_bounds(source, signature):
              m = re.search(
                  r'(?m)^[ \t]*' + re.escape(signature) + r'\s*\{',
                  source
              )
              if not m:
                  raise SystemExit('Missing method: ' + signature)

              start = source.find('{', m.start())
              depth = 0
              for i in range(start, len(source)):
                  if source[i] == '{':
                      depth += 1
                  elif source[i] == '}':
                      depth -= 1
                      if not depth:
                          return start, i

              raise SystemExit('Unbalanced method: ' + signature)

          def patch_method(path, signature, body, expected=None):
              source = path.read_text(encoding='utf-8-sig')
              a, b = method_bounds(source, signature)
              old = source[a+1:b]

              if 'ODIO RECOVERY17 ORIGINAL' in old:
                  print('Already patched:', signature)
                  return

              if expected is None and old.strip():
                  raise SystemExit(
                      'Refusing to overwrite nonempty ' + signature
                  )

              if expected is not None and expected not in old:
                  raise SystemExit(
                      'Unexpected current method: ' + signature
                  )

              source = (
                  source[:a+1]
                  + '\n        // ODIO RECOVERY17 ORIGINAL\n'
                  + body.strip('\n')
                  + '\n    '
                  + source[b:]
              )

              path.write_text(source, encoding='utf-8')
              print('Patched:', path.name, signature)

          # Original APK: entrances move 10 units vertically.
          patch_method(
              entrance,
              'public void Raise()',
              '''
              transform.position += new Vector3(0f, 10f, 0f);
              '''
          )

          patch_method(
              entrance,
              'public void Lower()',
              '''
              transform.position -= new Vector3(0f, 10f, 0f);
              if (gc != null && gc.finaleMode &&
                  wall != null && map != null)
                  wall.material = map;
              '''
          )

          # Original finale triggers and Baldi hearing.
          patch_method(
              near,
              'private void OnTriggerEnter(Collider other)',
              '''
              if (other == null || !other.CompareTag("Player"))
                  return;

              if (gc == null)
                  gc = FindObjectOfType<GameControllerScript>();

              if (gc == null || !gc.finaleMode ||
                  gc.exitsReached > 2)
                  return;

              gc.ExitReached();

              if (es != null)
                  es.Lower();

              if (gc.baldiScrpt != null &&
                  gc.baldiScrpt.isActiveAndEnabled)
                  gc.baldiScrpt.Hear(transform.position, 8f);
              '''
          )

          # Actual original APK exit conditions.
          patch_method(
              finish,
              'private void OnTriggerEnter(Collider other)',
              '''
              if (other == null || !other.CompareTag("Player"))
                  return;

              if (gc == null)
                  gc = FindObjectOfType<GameControllerScript>();

              if (gc == null || gc.notebooks < 7)
                  return;

              string target = gc.failedNotebooks >= 7
                  ? SecretScene : ResultsScene;

              if (string.IsNullOrEmpty(target) ||
                  !Application.CanStreamedLevelBeLoaded(target))
              {
                  Debug.LogError(
                      "ODIO RECOVERY17: Missing scene " + target
                  );
                  return;
              }

              UnityEngine.SceneManagement.SceneManager.LoadScene(target);
              '''
          )

          # Raise four original school exits.
          patch_method(
              controller,
              'private void ActivateFinaleMode()',
              '''
              if (finaleMode)
                  return;

              finaleMode = true;

              if (entrance_0 != null) entrance_0.Raise();
              if (entrance_1 != null) entrance_1.Raise();
              if (entrance_2 != null) entrance_2.Raise();
              if (entrance_3 != null) entrance_3.Raise();

              Debug.Log(
                  "ODIO RECOVERY17: Original final phase activated"
              );
              '''
          )

          # Original stage speeds and text.
          patch_method(
              controller,
              'public void ExitReached()',
              '''
              exitsReached = Mathf.Min(exitsReached + 1, 3);

              if (player == null)
                  player = FindObjectOfType<PlayerScript>();

              if (player != null)
              {
                  if (exitsReached == 1)
                  {
                      player.walkSpeed = 36f;
                      player.runSpeed = 41f;
                  }
                  else if (exitsReached == 2)
                  {
                      player.walkSpeed = 38f;
                      player.runSpeed = 43f;
                  }
                  else
                  {
                      player.walkSpeed = 40f;
                      player.runSpeed = 45f;
                  }
              }

              if (notebookCount != null)
                  notebookCount.text =
                      exitsReached == 1 ? "1 Exit Reached" :
                      exitsReached == 2 ? "Almost There" :
                      "GO TO THE LAST EXIT!";

              if (audioDevice == null)
                  audioDevice = GetComponent<AudioSource>();

              if (audioDevice != null && aud_Switch != null)
                  audioDevice.PlayOneShot(aud_Switch);
              '''
          )

          # Finale starts at 13 chocolates in the original.
          source = controller.read_text(encoding='utf-8-sig')
          a, b = method_bounds(
              source, 'private void UpdateNotebookCount()'
          )
          old = source[a+1:b]

          if 'ODIO RECOVERY17 ORIGINAL' not in old:
              if 'ODIO RECOVERY13' not in old or \
                 'notebookCount.text' not in old:
                  raise SystemExit('Recovery 13 counter missing')

              addition = '''
              // ODIO RECOVERY17 ORIGINAL
              if (!finaleMode && notebooks == 13 &&
                  mode != "endless")
                  ActivateFinaleMode();
              '''

              source = source[:b] + addition + source[b:]
              controller.write_text(source, encoding='utf-8')
              print('Patched: finale trigger after 13')

          # Remove fake instant victory from FIX12.
          source = foundation.read_text(encoding='utf-8-sig')

          if 'ODIO RECOVERY17 ORIGINAL: exit via scene trigger' not in source:
              start = source.find(
                  '        else if (kind == 4)\n        {'
              )

              if start < 0:
                  raise SystemExit('Prototype exit interaction missing')

              a, b = method_bounds(
                  source[start:], 'else if (kind == 4)'
              )
              a += start
              b += start

              if 'Prototype level completed' not in source[a:b]:
                  raise SystemExit(
                      'Unexpected prototype exit body'
                  )

              source = (
                  source[:a+1]
                  + '''
                  // ODIO RECOVERY17 ORIGINAL: exit via scene trigger.
                  ShowNotice("Walk through the exit to finish!");
                  '''
                  + source[b:]
              )

              foundation.write_text(source, encoding='utf-8')
              print('Patched: disabled prototype instant win')

          assert 'ODIO RECOVERY14' in source
          assert 'ODIO RECOVERY15' in source
          assert 'ODIO RECOVERY16' not in source
          assert 'Prototype level completed' not in source
          assert 'notebooks == 13' in controller.read_text()
          assert 'failedNotebooks >= 7' in finish.read_text()
          assert 'Hear(transform.position, 8f)' in near.read_text()
          assert 'new Vector3(0f, 10f, 0f)' in entrance.read_text()

          print('RECOVERY 17 ORIGINAL: STATIC CHECKS PASSED')
          print('Unity compilation and gameplay NOT tested')
          PY

      - name: Commit restored scripts
        shell: bash
        run: |
          git config user.name 'github-actions[bot]'
          git config user.email \
            '41898282+github-actions[bot]@users.noreply.github.com'

          sed -i 's/[[:blank:]]*$//' \
            Assets/Scripts/Assembly-CSharp/EntranceScript.cs \
            Assets/Scripts/Assembly-CSharp/NearExitTriggerScript.cs \
            Assets/Scripts/Assembly-CSharp/ExitTriggerScript.cs \
            Assets/Scripts/Assembly-CSharp/GameControllerScript.cs \
            Assets/OdioDiagnostics/OdioPlayableFix12.cs

          git add \
            Assets/Scripts/Assembly-CSharp/EntranceScript.cs \
            Assets/Scripts/Assembly-CSharp/NearExitTriggerScript.cs \
            Assets/Scripts/Assembly-CSharp/ExitTriggerScript.cs \
            Assets/Scripts/Assembly-CSharp/GameControllerScript.cs \
            Assets/OdioDiagnostics/OdioPlayableFix12.cs

          git diff --cached --check

          if ! git diff --cached --quiet; then
            git commit -m 'Recovery 17: restore original exit logic'
            git push origin HEAD:main
          fi

          echo 'Recovery 17 saved; Unity not built'
