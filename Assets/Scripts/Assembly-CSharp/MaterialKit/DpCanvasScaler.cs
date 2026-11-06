using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace MaterialKit
{
	[ExecuteInEditMode]
	public class DpCanvasScaler : UIBehaviour
	{
		[SerializeField]
		protected float m_ReferencePixelsPerUnit;

		private const float kLogBase = 2f;

		[SerializeField]
		protected float m_FallbackScreenDPI;

		[SerializeField]
		protected float m_DefaultSpriteDPI;

		[SerializeField]
		protected float m_DynamicPixelsPerUnit;

		private Canvas m_Canvas;

		[NonSerialized]
		private float m_PrevScaleFactor;

		[NonSerialized]
		private float m_PrevReferencePixelsPerUnit;

		public float referencePixelsPerUnit
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float fallbackScreenDPI
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float defaultSpriteDPI
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float dynamicPixelsPerUnit
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected DpCanvasScaler()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void Handle()
		{
		}

		protected virtual void HandleWorldCanvas()
		{
		}

		protected virtual void HandleConstantPhysicalSize()
		{
		}

		protected void SetScaleFactor(float scaleFactor)
		{
		}

		protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit)
		{
		}
	}
}
