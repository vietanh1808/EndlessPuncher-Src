using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;

public class CamFollower : MonoBehaviour
{
	[Serializable]
	public class CameraSetter
	{
		public Cams cam;

		public CinemachineVirtualCamera camvirtual;

		public CinemachineFreeLook freeLook;

		public bool HasCamera => false;

		public void SetPriority(int priority)
		{
		}

		public void SetNoise(float amplitude, float frequency)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CShakeCamCoroutine_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CamFollower _003C_003E4__this;

		public float power;

		public float time;

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
		public _003CShakeCamCoroutine_003Ed__15(int _003C_003E1__state)
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

	private const int ActiveCameraPriority = 25;

	private static CamFollower _instance;

	public CameraSetter[] camSetter;

	public CinemachineFreeLook cmFreeCam;

	[SerializeField]
	private CinemachineBrain cinemachineBrain;

	private Coroutine camShaker;

	public static CamFollower Instance => null;

	private static CamFollower FindExistingInstance()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void ResetCameraSetterNoise()
	{
	}

	public void ShakeCam(float time, float power)
	{
	}

	[IteratorStateMachine(typeof(_003CShakeCamCoroutine_003Ed__15))]
	private IEnumerator ShakeCamCoroutine(float time, float power)
	{
		return null;
	}

	public void SetCam(int towerSize)
	{
	}

	public void SetCam(Cams camType, bool instantBlend = true)
	{
	}

	public void SetCam(Cams camType, int priority, bool instantBlend = true)
	{
	}

	public void DisableCam(Cams camType, bool instantBlend = true)
	{
	}

	private static void SetFreeLookNoise(CinemachineFreeLook freeLook, float amplitude, float frequency)
	{
	}

	public void SetDefaultBlendDuration(float duration)
	{
	}
}
