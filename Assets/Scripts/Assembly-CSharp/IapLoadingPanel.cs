using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IapLoadingPanel : Singleton<IapLoadingPanel>
{
	[CompilerGenerated]
	private sealed class _003CAutoHideRoutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IapLoadingPanel _003C_003E4__this;

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
		public _003CAutoHideRoutine_003Ed__19(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CLoadingCircleLoop_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IapLoadingPanel _003C_003E4__this;

		private int _003CchildCount_003E5__2;

		private int _003CcurrentIndex_003E5__3;

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
		public _003CLoadingCircleLoop_003Ed__18(int _003C_003E1__state)
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

	[Header("Root")]
	[SerializeField]
	private GameObject _iapLoadingRoot;

	[Header("Loading State")]
	[SerializeField]
	private GameObject _checkingPurchaseObjects;

	[SerializeField]
	private Transform _loadingCircle;

	[SerializeField]
	private float _loadingStepDelay;

	[Header("Result State")]
	[SerializeField]
	private GameObject _successObjects;

	[SerializeField]
	private Transform _successImage;

	[SerializeField]
	private GameObject _failedObjects;

	[SerializeField]
	private Transform _failedImage;

	[Header("Result Animation")]
	[SerializeField]
	private float _resultBounceDuration;

	[SerializeField]
	private float _resultBounceOvershoot;

	[SerializeField]
	private float _autoHideDelay;

	private Coroutine _loadingLoopCoroutine;

	private Coroutine _autoHideCoroutine;

	private void OnDestroy()
	{
	}

	public void ShowLoading()
	{
	}

	public void ShowSuccess()
	{
	}

	public void ShowFailed()
	{
	}

	private void ShowResult(GameObject resultObjects, Transform resultImage)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadingCircleLoop_003Ed__18))]
	private IEnumerator LoadingCircleLoop()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAutoHideRoutine_003Ed__19))]
	private IEnumerator AutoHideRoutine()
	{
		return null;
	}

	private void StopAllPanelCoroutines()
	{
	}
}
