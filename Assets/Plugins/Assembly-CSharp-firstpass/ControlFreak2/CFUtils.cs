using System;
using UnityEngine;

namespace ControlFreak2
{
	public static class CFUtils
	{
		public const float SqrtOf2 = 1.4142135f;

		public const float SqrtOf3 = 1.7320508f;

		public const float OneOverSqrtOf2 = 0.70710677f;

		public const float OneOverSqrtOf3 = 0.57735026f;

		public const float TanLenFor45Tri = 0.76536685f;

		public const float TanLenFor90Tri = 1.4142135f;

		public const float MAX_DELTA_TIME = 0.5f;

		private const float MAX_LEFT_FACTOR = 0.75f;

		public static float realDeltaTime => 0f;

		public static float realDeltaTimeClamped => 0f;

		public static bool editorStopped => false;

		public static bool forcedMobileModeEnabled => false;

		public static string LogPrefixFull()
		{
			return null;
		}

		public static string LogPrefix()
		{
			return null;
		}

		public static float ApplyDeltaInput(float accum, float delta)
		{
			return 0f;
		}

		public static int ApplyDeltaInputInt(int accum, int delta)
		{
			return 0;
		}

		public static float ApplyPositveDeltaInput(float positiveAccum, float delta)
		{
			return 0f;
		}

		public static float ApplyNegativeDeltaInput(float negativeAccum, float delta)
		{
			return 0f;
		}

		public static void ApplySignedDeltaInput(float v, ref float plusAccum, ref float minusAccum)
		{
		}

		public static void ApplySignedDeltaInputInt(int v, ref int plusAccum, ref int minusAccum)
		{
		}

		public static int GetScrollValue(float drag, int prevScroll, float thresh, float magnet)
		{
			return 0;
		}

		public static float MoveTowards(float a, float b, float secondsPerUnit, float deltaTime, float epsilon)
		{
			return 0f;
		}

		private static float GetLerpFactor(float smoothingTime, float deltaTime, float maxLerpFactor)
		{
			return 0f;
		}

		public static float SmoothTowards(float a, float b, float smoothingTime, float deltaTime, float epsilon, float maxLeftFactor = 0.75f)
		{
			return 0f;
		}

		public static float SmoothTowardsAngle(float a, float b, float smoothingTime, float deltaTime, float epsilon, float maxLeftFactor = 0.75f)
		{
			return 0f;
		}

		public static Vector2 SmoothTowardsVec2(Vector2 a, Vector2 b, float smoothingTime, float deltaTime, float sqrEpsilon, float maxLeftFactor = 0.75f)
		{
			return default;
		}

		public static Vector3 SmoothTowardsVec3(Vector3 a, Vector3 b, float smoothingTime, float deltaTime, float sqrEpsilon, float maxLeftFactor = 0.75f)
		{
			return default;
		}

		public static Color SmoothTowardsColor(Color a, Color b, float smoothingTime, float deltaTime, float maxLeftFactor = 0.75f)
		{
			return default;
		}

		public static Quaternion SmoothTowardsQuat(Quaternion a, Quaternion b, float smoothingTime, float deltaTime, float maxLeftFactor = 0.75f)
		{
			return default;
		}

		public static float SmoothDamp(float valFrom, float valTo, ref float vel, float smoothingTime, float deltaTime, float epsilon)
		{
			return 0f;
		}

		public static Color ScaleColorAlpha(Color color, float alphaScale)
		{
			return default;
		}

		public static Component GetComponentHereOrInParent(Component comp, Type compType)
		{
			return null;
		}

		public static bool IsStretchyRectTransform(Transform tr)
		{
			return false;
		}

		public static Rect TransformRect(Rect r, Matrix4x4 tr, bool round)
		{
			return default;
		}

		public static Bounds TransformRectAsBounds(Rect r, Matrix4x4 tr, bool round)
		{
			return default;
		}

		public static Matrix4x4 ChangeMatrixTranl(Matrix4x4 m, Vector3 newTransl)
		{
			return default;
		}

		public static Bounds GetWorldAABB(Matrix4x4 tf, Vector3 center, Vector3 size)
		{
			return default;
		}

		public static Bounds GetWorldAABB(Matrix4x4 tf, Bounds localBounds)
		{
			return default;
		}

		public static Rect GetWorldRect(Matrix4x4 tf, Bounds localBounds)
		{
			return default;
		}

		public static Vector2 ClampRectInside(Rect rect, bool rectIsRound, Rect limiterRect, bool limiterIsRound)
		{
			return default;
		}

		public static Vector2 ClampRectInsideEllipse(Rect rect, Rect limiterRect)
		{
			return default;
		}

		public static Vector2 ClampEllipseInsideEllipse(Rect rect, Rect limiterRect)
		{
			return default;
		}

		public static Vector2 ClampRectInsideRect(Rect rect, Rect limiterRect)
		{
			return default;
		}

		public static Vector2 ClampInsideUnitCircle(Vector2 np)
		{
			return default;
		}

		public static Vector2 ClampInsideUnitSquare(Vector2 np)
		{
			return default;
		}

		public static Vector2 ClampPerAxisInsideUnitSquare(Vector2 np)
		{
			return default;
		}

		public static Vector2 ClampInsideRect(Vector2 v, Rect r)
		{
			return default;
		}

		public static bool IsDirDiagonal(Dir dir)
		{
			return false;
		}

		public static float VecToAngle(Vector2 vec)
		{
			return 0f;
		}

		public static float VecToAngle(Vector2 vec, float defaultAngle, float deadZoneSq)
		{
			return 0f;
		}

		public static float DirToAngle(Dir d)
		{
			return 0f;
		}

		public static Dir DirFromAngle(float ang, bool as8way)
		{
			return Dir.N;
		}

		public static Dir DirFromAngleEx(float ang, bool as8way, Dir lastDir, float magnetPow)
		{
			return Dir.N;
		}

		public static int DirDeltaAngle(Dir dirFrom, Dir dirTo)
		{
			return 0;
		}

		public static Vector2 DirToNormal(Dir dir)
		{
			return default;
		}

		public static Vector2 DirToTangent(Dir dir)
		{
			return default;
		}

		public static Dir GetOppositeDir(Dir dir)
		{
			return Dir.N;
		}

		public static Vector2 DirToVector(Dir dir, bool circular)
		{
			return default;
		}

		public static Dir VecToDir(Vector2 vec, bool as8way)
		{
			return Dir.N;
		}

		public static Dir VecToDir(Vector2 vec, Dir defaultDir, float deadZoneSq, bool as8way)
		{
			return Dir.N;
		}

		public static float NormalizeAnglePositive(float a)
		{
			return 0f;
		}

		public static float SmartDeltaAngle(float startAngle, float curAngle, float lastDelta)
		{
			return 0f;
		}

		public static Dir DigitalToDir(bool digiU, bool digiR, bool digiD, bool digiL)
		{
			return Dir.N;
		}

		public static Vector2 CircularToSquareJoystickVec(Vector2 circularVec)
		{
			return default;
		}

		public static Vector2 SquareToCircularJoystickVec(Vector2 squareVec)
		{
			return default;
		}

		public static int GetLineNumber(string str, int index)
		{
			return 0;
		}

		public static int GetEnumMaxValue(Type enumType)
		{
			return 0;
		}

		public static int CycleInt(int curId, int dir, int maxId)
		{
			return 0;
		}

		public static void SetEventSystemSelectedObject(GameObject o)
		{
		}
	}
}
