using System;

namespace ControlFreak2.Internal
{
	public class FixedTimeStepController
	{
		public static float deltaTime;

		private float fixedTime;

		private float fixedDeltaTime;

		private float fixedDeltaTimeCombined;

		private float timeAccum;

		private int totalFrameCount;

		private int frameSteps;

		public FixedTimeStepController(int framesPerSecond)
		{
		}

		public float GetDeltaTime()
		{
			return 0f;
		}

		public float GetDeltaTimeCombined()
		{
			return 0f;
		}

		public int GetFrameCount()
		{
			return 0;
		}

		public int GetFrameSteps()
		{
			return 0;
		}

		public float GetTime()
		{
			return 0f;
		}

		public void Reset()
		{
		}

		public void SetFPS(int framesPerSecond)
		{
		}

		public void Update(float deltaTime)
		{
		}

		public void Execute(Action updateCallback)
		{
		}

		public void SetStaticData()
		{
		}
	}
}
