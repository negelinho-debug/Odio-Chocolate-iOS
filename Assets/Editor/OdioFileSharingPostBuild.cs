#if UNITY_EDITOR && UNITY_IOS
using System.IO;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.iOS.Xcode;
using UnityEngine;

public static class OdioFileSharingPostBuild
{
    [PostProcessBuild(100)]
    public static void EnableFiles(BuildTarget target, string buildPath)
    {
        if (target != BuildTarget.iOS) return;

        string infoPath = Path.Combine(buildPath, "Info.plist");
        PlistDocument plist = new PlistDocument();
        plist.ReadFromFile(infoPath);
        plist.root.SetBoolean("UIFileSharingEnabled", true);
        plist.root.SetBoolean("LSSupportsOpeningDocumentsInPlace", true);
        plist.WriteToFile(infoPath);

        Debug.Log("Odio FIX 6: Files app sharing enabled");
    }
}
#endif
