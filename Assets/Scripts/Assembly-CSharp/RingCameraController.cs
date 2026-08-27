using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;
using UnityEngine.UI;

public class RingCameraController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateZoomRoutine_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RingCameraController _003C_003E4__this;

		public float duration;

		public float targetValue;

		private float _003CstartValue_003E5__2;

		private float _003Ct_003E5__3;

		private float _003CsafeDuration_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CAnimateZoomRoutine_003Ed__40(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Header("Refs")]
	[SerializeField]
	private CinemachineFreeLook freeLook;

	[Header("Auto Rotate")]
	[SerializeField]
	private float autoRotateDegPerSec;

	[SerializeField]
	private bool isAutoRotate;

	[Header("One Finger / Mouse Drag")]
	[Tooltip("Ekranda 1 px yatay sürükleme kaç derece döndürsün?")]
	[SerializeField]
	private float dragRotateDegPerPixel;

	[Tooltip("Ekranda 1 px dikey sürükleme zoom'u ne kadar değiştirsin? (radius scale)")]
	[SerializeField]
	private float dragZoomPerPixel;

	[Tooltip("Dikey sürüklemede yönü ters çevirmek istersen true yap.")]
	[SerializeField]
	private bool invertZoomDrag;

	[Header("Zoom (radius scale)")]
	[SerializeField]
	private float zoom;

	[SerializeField]
	private float minZoom;

	[SerializeField]
	private float maxZoom;

	[SerializeField]
	private float scrollSensitivity;

	[SerializeField]
	private float zoomTransitionDuration;

	[SerializeField]
	private AnimationCurve zoomTransitionEase;

	[SerializeField]
	private float startRunZoomValue;

	[Header("Ring Camera Blend")]
	[SerializeField]
	private float zoomInBlendDuration;

	[SerializeField]
	private float closestZoomInBlendDuration;

	[SerializeField]
	private float zoomOutBlendDuration;

	[SerializeField]
	private float endRunBlendDuration;

	private CinemachineFreeLook.Orbit[] baseOrbits;

	[SerializeField]
	private GameObject activeButton;

	private Coroutine zoomRoutine;

	public Slider zoomSlider;

	private float _zoomSave;

	public MeshRenderer ringRender;

	public Vector2[] ringScales;

	public void LevelFinished()
	{
	}

	private void Awake()
	{
	}

	private void EnsureZoomEaseCurve()
	{
	}

	private void Update()
	{
	}

	public void ToggleAutoRotate()
	{
	}

	private void HandleOneFingerOrbitAndZoom()
	{
	}

	private void HandleScrollZoom()
	{
	}

	public void ApplyZoom()
	{
	}

	public void ZoomIn(int tt = 1)
	{
	}

	public void ZoomOut()
	{
	}

	public void ZoomOutStart()
	{
	}

	public void SwitchToGameplayCamera(float blendDuration = -1f)
	{
	}

	public void SwitchToPresentationCamera(float blendDuration = -1f)
	{
	}

	public void SwitchToBossCamera(float blendDuration = -1f)
	{
	}

	public void SwitchToEndRunCamera()
	{
	}

	private float GetSavedZoomAxisValue()
	{
		return 0f;
	}

	private void SetZoomImmediate(float targetValue)
	{
	}

	private void AnimateZoomTo(float targetValue, float duration = -1f)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateZoomRoutine_003Ed__40))]
	private IEnumerator AnimateZoomRoutine(float targetValue, float duration)
	{
		return null;
	}

	private void DisableLegacyFreeLook()
	{
	}

	private void SwitchToRingCamera(Cams camType, float blendDuration)
	{
	}

	public void RefreshRingVisuals()
	{
	}

	private void SetRingColor()
	{
	}
}
