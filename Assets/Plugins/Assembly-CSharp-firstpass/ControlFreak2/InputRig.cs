using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ControlFreak2.Internal;
using UnityEngine;

namespace ControlFreak2
{
	public class InputRig : ComponentBase, IBindingContainer
	{
		[StructLayout((LayoutKind)0, Size = 68)]
		public struct Touch
		{
			public TouchPhase phase;

			public float deltaTime;

			public int fingerId;

			public int tapCount;

			public Vector2 position;

			public Vector2 rawPosition;

			public Vector2 deltaPosition;

			public float altitudeAngle;

			public float azimuthAngle;

			public float maximumPossiblePressure;

			public float pressure;

			public float radius;

			public float radiusVariance;

			public TouchType type;

			public static Touch Dummy;

			public static Touch[] EmptyArray;

			private static Touch[] mTranslatedArray;

			static Touch()
			{
			}

			public Touch(UnityEngine.Touch t)
			{
				phase = TouchPhase.Began;
				deltaTime = 0f;
				fingerId = 0;
				tapCount = 0;
				position = default;
				rawPosition = default;
				deltaPosition = default;
				altitudeAngle = 0f;
				azimuthAngle = 0f;
				maximumPossiblePressure = 0f;
				pressure = 0f;
				radius = 0f;
				radiusVariance = 0f;
				type = TouchType.Direct;
			}

			public static Touch[] TranslateUnityTouches(UnityEngine.Touch[] tarr)
			{
				return null;
			}
		}

		private class EmulatedTouchState
		{
			private int fingerId;

			public TouchGestureBasicState touch;

			public Touch outputTouch;

			private bool isUsed;

			private bool updatedThisFrame;

			public EmulatedTouchState()
			{
			}

			public bool IsUsed()
			{
				return false;
			}

			public bool IsActive()
			{
				return false;
			}

			public void Start(Vector2 pos)
			{
			}

			public void UpdatePos(Vector2 pos)
			{
			}

			public void EndTouch(bool cancel)
			{
			}

			public EmulatedTouchState(int fingerId)
			{
			}

			public void Reset()
			{
			}

			private void SyncOutputTouch()
			{
			}

			public void Update()
			{
			}
		}

		[Serializable]
		public class RigSwitchCollection : NamedConfigCollection<RigSwitch>
		{
			private bool _changed;

			public bool changed
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public RigSwitchCollection(InputRig rig)
				: base((InputRig)null, 0)
			{
			}

			public RigSwitch Add(string name, bool undoable)
			{
				return null;
			}

			public void SetSwitchState(string name, ref int cachedId, bool state)
			{
			}

			public void SetSwitchState(string name, bool state)
			{
			}

			public bool GetSwitchState(string name, ref int cachedId, bool fallbackValue)
			{
				return false;
			}

			public bool GetSwitchState(string name, bool fallbackValue)
			{
				return false;
			}

			public bool ToggleSwitchState(string name, ref int cachedId, bool fallbackValue)
			{
				return false;
			}

			public bool ToggleSwitchState(string name, bool fallbackValue)
			{
				return false;
			}

			public void SetAll(bool state)
			{
			}

			public void ResetSwitch(string name, ref int cachedId)
			{
			}

			public void ResetSwitch(string name)
			{
			}

			public void Reset()
			{
			}

			public int GetSwitchId(string name)
			{
				return 0;
			}
		}

		[Serializable]
		public class RigSwitch : NamedConfigElement
		{
			public bool defaultState;

			private bool state;

			public RigSwitch()
			{
			}

			public RigSwitch(string name)
			{
			}

			public void SetState(bool state)
			{
			}

			public bool GetState()
			{
				return false;
			}

			public bool ToggleState()
			{
				return false;
			}

			public override void Reset()
			{
			}
		}

		[Serializable]
		public class GamepadConfig : IBindingContainer
		{
			public bool enabled;

			public DigitalBinding digiFaceDownBinding;

			public DigitalBinding digiFaceRightBinding;

			public DigitalBinding digiFaceLeftBinding;

			public DigitalBinding digiFaceUpBinding;

			public DigitalBinding digiStartBinding;

			public DigitalBinding digiSelectBinding;

			public DigitalBinding digiL1Binding;

			public DigitalBinding digiR1Binding;

			public DigitalBinding digiL2Binding;

			public DigitalBinding digiR2Binding;

			public DigitalBinding digiL3Binding;

			public DigitalBinding digiR3Binding;

			public AxisBinding analogL2Binding;

			public AxisBinding analogR2Binding;

			public JoystickStateBinding leftStickStateBinding;

			public JoystickStateBinding rightStickStateBinding;

			public JoystickStateBinding dpadStateBinding;

			[NonSerialized]
			private JoystickState leftStickState;

			[NonSerialized]
			private JoystickState rigthStickState;

			[NonSerialized]
			private JoystickState dpadState;

			private void BasicConstructor(InputRig rig)
			{
			}

			public GamepadConfig(InputRig rig)
			{
			}

			public void SyncGamepad(GamepadManager.Gamepad gamepad, InputRig rig)
			{
			}

			public void GetSubBindingDescriptions(BindingDescriptionList descList, UnityEngine.Object undoObject, string parentMenuPath)
			{
			}

			public bool IsBoundToKey(KeyCode key, InputRig rig)
			{
				return false;
			}

			public bool IsBoundToAxis(string axisName, InputRig rig)
			{
				return false;
			}

			public bool IsEmulatingTouches()
			{
				return false;
			}

			public bool IsEmulatingMousePosition()
			{
				return false;
			}
		}

		[Serializable]
		public class VirtualJoystickConfig : NamedConfigElement, IBindingContainer
		{
			public bool disableOnMobile;

			public JoystickConfig joystickConfig;

			public JoystickState joystickState;

			public KeyCode keyboardUp;

			public KeyCode keyboardRight;

			public KeyCode keyboardDown;

			public KeyCode keyboardLeft;

			public JoystickStateBinding joyStateBinding;

			private void BasicConstructor()
			{
			}

			public VirtualJoystickConfig()
			{
			}

			public VirtualJoystickConfig(string targetName, KeyCode keyUp, KeyCode keyRight, KeyCode keyDown, KeyCode keyLeft)
			{
			}

			public override void Reset()
			{
			}

			public override void Update(InputRig rig)
			{
			}

			public void SetState(JoystickState state)
			{
			}

			public bool IsBoundToAxis(string axisName, InputRig rig)
			{
				return false;
			}

			public bool IsBoundToKey(KeyCode key, InputRig rig)
			{
				return false;
			}

			public bool IsEmulatingTouches()
			{
				return false;
			}

			public bool IsEmulatingMousePosition()
			{
				return false;
			}

			public void GetSubBindingDescriptions(BindingDescriptionList descList, UnityEngine.Object undoObject, string parentMenuPath)
			{
			}
		}

		[Serializable]
		public class VirtualJoystickConfigCollection : NamedConfigCollection<VirtualJoystickConfig>
		{
			public VirtualJoystickConfigCollection(InputRig rig, int capacity)
				: base((InputRig)null, 0)
			{
			}

			public VirtualJoystickConfig Add(string name, bool undoable)
			{
				return null;
			}
		}

		public enum AxisType
		{
			UnsignedAnalog = 0,
			SignedAnalog = 1,
			Digital = 2,
			ScrollWheel = 3,
			Delta = 4
		}

		public enum InputSource
		{
			Digital = 0,
			Analog = 1,
			MouseDelta = 2,
			TouchDelta = 3,
			NormalizedDelta = 4,
			Scroll = 5
		}

		public enum DeltaTransformMode
		{
			Universal = 0,
			EmulateMouse = 1,
			Raw = 2
		}

		[Serializable]
		public class AxisConfig : NamedConfigElement
		{
			public AxisType axisType;

			public DeltaTransformMode deltaMode;

			public bool snap;

			public float scale;

			public bool affectSourceKeys;

			public KeyCode affectedKeyPositive;

			public KeyCode affectedKeyNegative;

			public KeyCode keyboardPositive;

			public KeyCode keyboardPositiveAlt0;

			public KeyCode keyboardPositiveAlt1;

			public KeyCode keyboardPositiveAlt2;

			public KeyCode keyboardNegative;

			public KeyCode keyboardNegativeAlt0;

			public KeyCode keyboardNegativeAlt1;

			public KeyCode keyboardNegativeAlt2;

			public float analogToDigitalThresh;

			public float rawSmoothingTime;

			public float smoothingTime;

			public float digitalToAnalogAccelTime;

			public float digitalToAnalogDecelTime;

			public bool digitalToScrollAutoRepeat;

			public float digitalToScrollRepeatInterval;

			public float digitalToScrollDelay;

			public float scrollToAnalogSmoothingTime;

			public float scrollToAnalogStepDuration;

			public float scrollToDeltaSmoothingTime;

			private float valRaw;

			private float val;

			private int scrollPrev;

			private int scrollCur;

			private bool digiCur;

			private bool digiPrev;

			private bool muteUntilRelease;

			private float digitalToAnalogVal;

			private bool analogToDigitalNegCur;

			private bool analogToDigitalPosCur;

			private float valSmoothVel;

			private float valRawSmoothVel;

			private float scrollToAnalogTimeRemaining;

			private float scrollToAnalogValue;

			private int scrollToDigitalClicksRemaining;

			private bool scrollToDigitalClickOn;

			private float deltaAccumTarget;

			private float deltaAccumSmoothCur;

			private float deltaAccumSmoothPrev;

			private float deltaAccumRawCur;

			private float deltaAccumRawPrev;

			private float scrollElapsedSinceChange;

			private bool digiToScrollPositivePrev;

			private bool digiToScrollNegativePrev;

			private bool digiToScrollDelayPhase;

			public bool frDigitalPos { get; protected set; }

			public bool frDigitalNeg { get; protected set; }

			public float frAnalogPos { get; protected set; }

			public float frAnalogNeg { get; protected set; }

			public float frMouseDeltaPos { get; protected set; }

			public float frMouseDeltaNeg { get; protected set; }

			public float frTouchDeltaPos { get; protected set; }

			public float frTouchDeltaNeg { get; protected set; }

			public float frNormalizedDeltaPos { get; protected set; }

			public float frNormalizedDeltaNeg { get; protected set; }

			public int frScrollDelta { get; protected set; }

			public static AxisConfig CreateDigital(string name, KeyCode key)
			{
				return null;
			}

			public static AxisConfig CreateScrollWheel(string name, KeyCode keyPositive, KeyCode keyNegative)
			{
				return null;
			}

			public static AxisConfig CreateAnalog(string name, KeyCode keyPositive)
			{
				return null;
			}

			public static AxisConfig CreateSignedAnalog(string name, KeyCode keyPositive, KeyCode keyNegative)
			{
				return null;
			}

			public static AxisConfig CreateDelta(string name, KeyCode keyPositive, KeyCode keyNegative)
			{
				return null;
			}

			public override void Reset()
			{
			}

			public void MuteUntilRelease()
			{
			}

			public bool IsMuted()
			{
				return false;
			}

			public void ApplyKeyboardInput()
			{
			}

			public override void Update(InputRig rig)
			{
			}

			public void Set(float v, InputSource source)
			{
			}

			public void SetAnalog(float v)
			{
			}

			public void SetDigital()
			{
			}

			public void SetSignedDigital(bool vpositive)
			{
			}

			public void SetScrollDelta(int scrollDelta)
			{
			}

			public void SetTouchDelta(float touchDelta)
			{
			}

			public void SetMouseDelta(float mouseDelta)
			{
			}

			public void SetNormalizedDelta(float normalizedDelta)
			{
			}

			public float GetAnalog()
			{
				return 0f;
			}

			public float GetAnalogRaw()
			{
				return 0f;
			}

			public bool IsControlledByInput()
			{
				return false;
			}

			public bool GetButton()
			{
				return false;
			}

			public bool GetButtonDown()
			{
				return false;
			}

			public bool GetButtonUp()
			{
				return false;
			}

			public int GetSupportedInputSourceMask()
			{
				return 0;
			}

			public bool DoesSupportInputSource(InputSource source)
			{
				return false;
			}

			private bool IsSignedAxis()
			{
				return false;
			}

			public bool DoesAffectKeyCode(KeyCode key)
			{
				return false;
			}
		}

		[Serializable]
		public class AxisConfigCollection : NamedConfigCollection<AxisConfig>
		{
			public AxisConfigCollection(InputRig rig, int capacity)
				: base((InputRig)null, 0)
			{
			}

			public AxisConfig Add(string name, AxisType axisType, bool undoable)
			{
				return null;
			}

			public void ApplyKeyboardInput()
			{
			}

			public void MuteAllUntilRelease()
			{
			}
		}

		[Serializable]
		public class AutomaticInputConfig : NamedConfigElement
		{
			[Serializable]
			public class RelatedAxis
			{
				public string axisName;

				public bool mustBeControlledByInput;

				private int axisId;

				public bool IsEnabling(InputRig rig)
				{
					return false;
				}
			}

			[Serializable]
			public class RelatedKey
			{
				public KeyCode key;

				public bool mustBeControlledByInput;

				public bool IsEnabling(InputRig rig)
				{
					return false;
				}
			}

			public DigitalBinding targetBinding;

			public DisablingConditionSet disablingConditions;

			[NonSerialized]
			private bool disabledByConditions;

			public List<RelatedAxis> relatedAxisList;

			public List<RelatedKey> relatedKeyList;

			public void SetRig(InputRig rig)
			{
			}

			public void OnDisablingConditionsChange()
			{
			}

			public override void Update(InputRig rig)
			{
			}
		}

		[Serializable]
		public class AutomaticInputConfigCollection : NamedConfigCollection<AutomaticInputConfig>
		{
			public AutomaticInputConfigCollection(InputRig rig)
				: base((InputRig)null, 0)
			{
			}

			public void SetRig(InputRig rig)
			{
			}

			public AutomaticInputConfig Add(string name, bool createUndo)
			{
				return null;
			}

			public void OnDisablingConditionsChange()
			{
			}
		}

		public class NamedConfigElement
		{
			public string name;

			public virtual void Reset()
			{
			}

			public virtual void Update(InputRig rig)
			{
			}
		}

		[Serializable]
		public class NamedConfigCollection<T> where T : NamedConfigElement, new()
		{
			public List<T> list;

			[NonSerialized]
			protected InputRig rig;

			public NamedConfigCollection(InputRig rig, int capacity)
			{
			}

			public void ResetAll()
			{
			}

			public void Update(InputRig rig)
			{
			}

			public T Get(string name, ref int cachedId)
			{
				return null;
			}

			public T Get(string name)
			{
				return null;
			}
		}

		[Serializable]
		public class TiltConfig : IBindingContainer
		{
			[NonSerialized]
			private InputRig rig;

			public TiltState tiltState;

			private int digitalRollDirection;

			private int digitalPitchDirection;

			private bool disabledByRigSwitches;

			public DisablingConditionSet disablingConditions;

			public AnalogConfig rollAnalogConfig;

			public AnalogConfig pitchAnalogConfig;

			public AxisBinding rollBinding;

			public AxisBinding pitchBinding;

			public DigitalBinding rollLeftBinding;

			public DigitalBinding rollRightBinding;

			public DigitalBinding pitchForwardBinding;

			public DigitalBinding pitchBackwardBinding;

			public TiltConfig(InputRig rig)
			{
			}

			public void Reset()
			{
			}

			public void OnDisablingConditionsChange()
			{
			}

			public bool IsEnabled()
			{
				return false;
			}

			public void Update()
			{
			}

			public bool IsBoundToAxis(string axisName, InputRig rig)
			{
				return false;
			}

			public bool IsBoundToKey(KeyCode key, InputRig rig)
			{
				return false;
			}

			public bool IsEmulatingTouches()
			{
				return false;
			}

			public bool IsEmulatingMousePosition()
			{
				return false;
			}

			public void GetSubBindingDescriptions(BindingDescriptionList descList, UnityEngine.Object undoObject, string parentMenuPath)
			{
			}
		}

		[Serializable]
		public class ScrollWheelState : IBindingContainer
		{
			private InputRig rig;

			public ScrollDeltaBinding horzScrollDeltaBinding;

			public ScrollDeltaBinding vertScrollDeltaBinding;

			public ScrollWheelState(InputRig rig)
			{
			}

			public void Reset()
			{
			}

			public void Update()
			{
			}

			public Vector2 GetDelta()
			{
				return default;
			}

			public bool IsBoundToAxis(string axisName, InputRig rig)
			{
				return false;
			}

			public bool IsBoundToKey(KeyCode key, InputRig rig)
			{
				return false;
			}

			public bool IsEmulatingTouches()
			{
				return false;
			}

			public bool IsEmulatingMousePosition()
			{
				return false;
			}

			public void GetSubBindingDescriptions(BindingDescriptionList descList, UnityEngine.Object undoObject, string parentMenuPath)
			{
			}
		}

		[Serializable]
		public class MouseConfig : IBindingContainer
		{
			private InputRig rig;

			public AxisBinding horzDeltaBinding;

			public AxisBinding vertDeltaBinding;

			private Vector2 mousePos;

			private Vector2 frMousePos;

			private int frMousePosPrio;

			public MouseConfig(InputRig rig)
			{
			}

			public void Reset()
			{
			}

			public void SetPosition(Vector2 pos, int prio)
			{
			}

			public Vector3 GetPosition()
			{
				return default;
			}

			private bool IsMouseDeltaUsable()
			{
				return false;
			}

			private bool IsMousePositionUsable()
			{
				return false;
			}

			public void Update()
			{
			}

			public bool IsBoundToAxis(string axisName, InputRig rig)
			{
				return false;
			}

			public bool IsBoundToKey(KeyCode key, InputRig rig)
			{
				return false;
			}

			public bool IsEmulatingTouches()
			{
				return false;
			}

			public bool IsEmulatingMousePosition()
			{
				return false;
			}

			public void GetSubBindingDescriptions(BindingDescriptionList descList, UnityEngine.Object undoObject, string parentMenuPath)
			{
			}
		}

		[CompilerGenerated]
		private Action m_onSwitchesChanged;

		[CompilerGenerated]
		private Action m_onAddExtraInput;

		[CompilerGenerated]
		private static Action m_onAddExtraInputToActiveRig;

		public const string CF_EMPTY_AXIS = "cfEmpty";

		public const string CF_SCROLL_WHEEL_X_AXIS = "cfScroll0";

		public const string CF_SCROLL_WHEEL_Y_AXIS = "cfScroll1";

		public const string CF_MOUSE_DELTA_X_AXIS = "cfMouseX";

		public const string CF_MOUSE_DELTA_Y_AXIS = "cfMouseY";

		public const string DEFAULT_LEFT_STICK_NAME = "LeftStick";

		public const string DEFAULT_RIGHT_STICK_NAME = "RightStick";

		public const string DEFAULT_VERT_SCROLL_WHEEL_NAME = "Mouse ScrollWheel";

		public const string DEFAULT_HORZ_SCROLL_WHEEL_NAME = "Mouse ScrollWheel Secondary";

		public bool autoActivate;

		public bool overrideActiveRig;

		public bool hideWhenDisactivated;

		public bool disableWhenDisactivated;

		public bool hideWhenTouchScreenIsUnused;

		public float hideWhenTouchScreenIsUnusedDelay;

		public bool hideWhenGamepadIsActivated;

		public float hideWhenGamepadIsActivatedDelay;

		public float fingerRadiusInCm;

		public bool swipeOverFromNothing;

		public float controlBaseAlphaAnimDuration;

		public float animatorMaxAnimDuration;

		public float ninetyDegTurnMouseDelta;

		public float ninetyDegTurnTouchSwipeInCm;

		public float ninetyDegTurnAnalogDuration;

		public float virtualScreenDiameterInches;

		public int scrollStepsPerNinetyDegTurn;

		public const float TOUCH_SMOOTHING_MAX_TIME = 0.1f;

		[NonSerialized]
		private float elapsedSinceLastTouch;

		[NonSerialized]
		private bool touchControlsSleeping;

		public VirtualJoystickConfigCollection joysticks;

		public AxisConfigCollection axes;

		public List<KeyCode> keyboardBlockedCodes;

		[NonSerialized]
		private BitArray keysPrev;

		[NonSerialized]
		private BitArray keysCur;

		[NonSerialized]
		private BitArray keysNext;

		[NonSerialized]
		private BitArray keysMuted;

		[NonSerialized]
		private BitArray keysBlocked;

		[NonSerialized]
		private bool keysNextSomeDown;

		[NonSerialized]
		private bool keysNextSomeOn;

		[NonSerialized]
		private bool keysCurSomeOn;

		[NonSerialized]
		private bool keysCurSomeDown;

		public JoystickConfig dpadConfig;

		public JoystickConfig leftStickConfig;

		public JoystickConfig rightStickConfig;

		public AnalogConfig leftTriggerAnalogConfig;

		public AnalogConfig rightTriggerAnalogConfig;

		public GamepadConfig[] gamepads;

		public GamepadConfig anyGamepad;

		public RigSwitchCollection rigSwitches;

		public AutomaticInputConfigCollection autoInputList;

		[NonSerialized]
		private List<TouchControl> touchControls;

		public TiltConfig tilt;

		public MouseConfig mouseConfig;

		public ScrollWheelState scrollWheel;

		private FixedTimeStepController fixedTimeStep;

		private const float MAX_DELTA_TIME = 0.2f;

		private const float DELTA_TIME_SMOOTHING_FACTOR = 0.1f;

		private const float DELTA_TIME_SMOOTHING_TIME = 1f;

		private const int FIXED_FPS = 120;

		private bool touchControlsHidden;

		private float analogToEmuMouseScale;

		private float analogToUniversalScale;

		private float analogToRawDeltaScale;

		private float scrollToEmuMouseScale;

		private float scrollToUniversalScale;

		private float mousePointsToUniversalScale;

		private float touchPixelsToEmuMouseScale;

		private float touchPixelsToUniversalScale;

		private int storedHorzRes;

		private int storedVertRes;

		private float storedDPCM;

		private const int MAX_EMU_TOUCHES = 8;

		private List<EmulatedTouchState> emuTouches;

		private List<EmulatedTouchState> emuTouchesOrdered;

		private Touch[] emuOutputTouches;

		private bool emuOutputTouchesDirty;

		public int axisConfigCount => 0;

		public event Action onSwitchesChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action onAddExtraInput
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action onAddExtraInputToActiveRig
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void OnActivateRig()
		{
		}

		public void OnDisactivateRig()
		{
		}

		private void BasicConstructor()
		{
		}

		protected override void OnInitComponent()
		{
		}

		protected override void OnDestroyComponent()
		{
		}

		protected override void OnEnableComponent()
		{
		}

		protected override void OnDisableComponent()
		{
		}

		private void OnMobileModeChange()
		{
		}

		private void OnCursorLockStateChange()
		{
		}

		private void OnApplicationPause(bool paused)
		{
		}

		private void Update()
		{
		}

		public void ResetState()
		{
		}

		public void MuteUntilRelease()
		{
		}

		private void UpdateConfigs()
		{
		}

		private void UpdateKeyCodes()
		{
		}

		private void InvalidateBlockedKeys()
		{
		}

		public static bool GetSourceKeyState(KeyCode key)
		{
			return false;
		}

		public static bool IsMouseKeyCode(KeyCode key)
		{
			return false;
		}

		public void AddControl(TouchControl c)
		{
		}

		public void RemoveControl(TouchControl c)
		{
		}

		public List<TouchControl> GetTouchControls()
		{
			return null;
		}

		public TouchControl FindTouchControl(string name)
		{
			return null;
		}

		public void ShowOrHideTouchControls(bool show, bool skipAnim)
		{
		}

		public bool AreTouchControlsHiddenManually()
		{
			return false;
		}

		public bool AreTouchControlsSleeping()
		{
			return false;
		}

		public void WakeTouchControlsUp()
		{
		}

		public void PutTouchControlsToSleep()
		{
		}

		public bool AreTouchControlsVisible()
		{
			return false;
		}

		private void SyncDisablingConditions(bool noAnim)
		{
		}

		public static bool IsTiltAvailable()
		{
			return false;
		}

		public bool IsTiltCalibrated()
		{
			return false;
		}

		public void CalibrateTilt()
		{
		}

		public void ResetTilt()
		{
		}

		public bool GetSwitchState(string name, ref int cachedId, bool fallbackVal)
		{
			return false;
		}

		public bool GetSwitchState(string name, bool fallbackVal)
		{
			return false;
		}

		public void SetSwitchState(string name, ref int cachedId, bool state)
		{
		}

		public void SetSwitchState(string name, bool state)
		{
		}

		public void SetAllSwitches(bool state)
		{
		}

		public void ResetSwitch(string name, ref int cachedId)
		{
		}

		public void ResetSwitch(string name)
		{
		}

		public void ResetAllSwitches(bool skipAnim)
		{
		}

		public bool IsSwitchDefined(string name, ref int cachedId)
		{
			return false;
		}

		public bool IsSwitchDefined(string name)
		{
			return false;
		}

		public void ApplySwitches(bool skipAnim)
		{
		}

		public void ResetInputAxes()
		{
		}

		public bool IsAxisDefined(string name, ref int cachedId)
		{
			return false;
		}

		public bool IsAxisDefined(string name)
		{
			return false;
		}

		public float GetAxis(string axisName)
		{
			return 0f;
		}

		public float GetAxis(string axisName, ref int cachedId)
		{
			return 0f;
		}

		public float GetAxisRaw(string axisName)
		{
			return 0f;
		}

		public float GetAxisRaw(string axisName, ref int cachedId)
		{
			return 0f;
		}

		public bool GetButton(string axisName)
		{
			return false;
		}

		public bool GetButton(string axisName, ref int cachedId)
		{
			return false;
		}

		public bool GetButtonDown(string axisName)
		{
			return false;
		}

		public bool GetButtonDown(string axisName, ref int cachedId)
		{
			return false;
		}

		public bool GetButtonUp(string axisName)
		{
			return false;
		}

		public bool GetButtonUp(string axisName, ref int cachedId)
		{
			return false;
		}

		public bool GetKey(KeyCode keyCode)
		{
			return false;
		}

		public bool GetKeyDown(KeyCode keyCode)
		{
			return false;
		}

		public bool GetKeyUp(KeyCode keyCode)
		{
			return false;
		}

		public bool GetKey(string keyName)
		{
			return false;
		}

		public bool GetKeyDown(string keyName)
		{
			return false;
		}

		public bool GetKeyUp(string keyName)
		{
			return false;
		}

		public bool AnyKey()
		{
			return false;
		}

		public bool AnyKeyDown()
		{
			return false;
		}

		public bool GetMouseButton(int mouseButton)
		{
			return false;
		}

		public bool GetMouseButtonDown(int mouseButton)
		{
			return false;
		}

		public bool GetMouseButtonUp(int mouseButton)
		{
			return false;
		}

		public bool IsAxisAvailableOnMobile(string axisName)
		{
			return false;
		}

		public bool IsKeyAvailableOnMobile(KeyCode keyCode)
		{
			return false;
		}

		public bool IsTouchEmulatedOnMobile()
		{
			return false;
		}

		public bool IsMousePositionEmulatedOnMobile()
		{
			return false;
		}

		public bool IsScrollWheelEmulatedOnMobile()
		{
			return false;
		}

		public bool IsJoystickDefined(string name, ref int cachedId)
		{
			return false;
		}

		public bool IsJoystickDefined(string name)
		{
			return false;
		}

		public JoystickState GetJoystickState(string name, ref int cachedId)
		{
			return null;
		}

		public static KeyCode MouseButtonToKey(int mouseButton)
		{
			return KeyCode.None;
		}

		public AxisConfig GetAxisConfig(int id)
		{
			return null;
		}

		public AxisConfig GetAxisConfig(string name, ref int cachedId)
		{
			return null;
		}

		public AxisConfig GetAxisConfig(string name)
		{
			return null;
		}

		public void SetAxis(string name, ref int cachedId, float v, InputSource source)
		{
		}

		public void SetAxisScroll(string name, ref int cachedId, int v)
		{
		}

		public void SetAxisDigital(string name, ref int cachedId, bool negSide)
		{
		}

		public void SetJoystickState(string name, ref int joyId, JoystickState state)
		{
		}

		public void SetKeyCode(KeyCode keyCode)
		{
		}

		public bool GetNextFrameKeyState(KeyCode key)
		{
			return false;
		}

		public void RecalcPixelConversionParams()
		{
		}

		private void CheckResolution(bool forceRecalc = false)
		{
		}

		public float TransformMousePointDelta(float mousePoints, DeltaTransformMode mode)
		{
			return 0f;
		}

		public float TransformTouchPixelDelta(float touchPix, DeltaTransformMode mode)
		{
			return 0f;
		}

		public float TransformNormalizedDelta(float normDelta, DeltaTransformMode mode)
		{
			return 0f;
		}

		public float TransformScrollDelta(float scrollDelta, DeltaTransformMode mode)
		{
			return 0f;
		}

		public float TransformAnalogDelta(float analogVal, DeltaTransformMode mode)
		{
			return 0f;
		}

		public void GetSubBindingDescriptions(BindingDescriptionList descList, UnityEngine.Object undoObject, string parentMenuPath)
		{
		}

		public bool IsBoundToKey(KeyCode key, InputRig rig)
		{
			return false;
		}

		public bool IsBoundToAxis(string axisName, InputRig rig)
		{
			return false;
		}

		public bool IsEmulatingTouches()
		{
			return false;
		}

		public bool IsEmulatingMousePosition()
		{
			return false;
		}

		private void InitEmuTouches()
		{
		}

		public int InternalStartEmuTouch(Vector2 pos)
		{
			return 0;
		}

		public void InternalEndEmuTouch(int emuTouchId, bool cancel)
		{
		}

		public void InternalUpdateEmuTouch(int emuTouchId, Vector2 pos)
		{
		}

		public Touch[] GetEmuTouchArray()
		{
			return null;
		}

		public int GetEmuTouchCount()
		{
			return 0;
		}

		public Touch GetEmuTouch(int i)
		{
			return default;
		}

		private void ResetEmuTouches()
		{
		}

		private void UpdateEmuTouches()
		{
		}

		public void SyncEmuTouch(TouchGestureBasicState touch, ref int emuTouchId)
		{
		}

		public static KeyCode NameToKeyCode(string keyName)
		{
			return KeyCode.None;
		}
	}
}
