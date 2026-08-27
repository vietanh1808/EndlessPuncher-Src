using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using TMPro;
using UnityEngine;

namespace Fubu.Essentials
{
	public class DungeonGameController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003COutcomeFlowRoutine_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool isSuccess;

			public DungeonGameController _003C_003E4__this;

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
			public _003COutcomeFlowRoutine_003Ed__26(int _003C_003E1__state)
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
		private sealed class _003CPreDungeonSelectionRoutine_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DungeonGameController _003C_003E4__this;

			private int _003CremainingSelectionCount_003E5__2;

			private int _003Ci_003E5__3;

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
			public _003CPreDungeonSelectionRoutine_003Ed__30(int _003C_003E1__state)
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

		private static DungeonGameController instance;

		[Header("Dungeon Cameras")]
		[SerializeField]
		private CinemachineVirtualCamera playerCam;

		[SerializeField]
		private CinemachineVirtualCamera enemyCam;

		[SerializeField]
		private float cameraBlendDuration;

		[Header("Outcome Timing")]
		[SerializeField]
		private float outcomeTimeScale;

		[SerializeField]
		private float failNotifyDelay;

		[SerializeField]
		private float successNotifyDelay;

		[Header("Scene Load Selection")]
		[SerializeField]
		private bool select5SkillStat;

		[SerializeField]
		private int preDungeonSelectionCount;

		[SerializeField]
		private TextMeshProUGUI preDungeonSelectionText;

		[SerializeField]
		private bool startBackCounter;

		private Coroutine outcomeRoutine;

		private Coroutine preDungeonSelectionRoutine;

		private bool isResolvingOutcome;

		private bool isPreparingDungeonStart;

		public static DungeonGameController Instance => null;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		public bool ShouldBlockDungeonStart()
		{
			return false;
		}

		public bool HandleDungeonFail()
		{
			return false;
		}

		public bool HandleDungeonSuccess()
		{
			return false;
		}

		public void SwitchToPlayerCamera()
		{
		}

		public void SwitchToEnemyCamera()
		{
		}

		private bool StartOutcomeFlow(bool isSuccess)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003COutcomeFlowRoutine_003Ed__26))]
		private IEnumerator OutcomeFlowRoutine(bool isSuccess)
		{
			return null;
		}

		private void SwitchCamera(CinemachineVirtualCamera targetCam)
		{
		}

		private void ApplyOutcomeSlowMotion()
		{
		}

		private void RestoreNormalTimeScale()
		{
		}

		[IteratorStateMachine(typeof(_003CPreDungeonSelectionRoutine_003Ed__30))]
		private IEnumerator PreDungeonSelectionRoutine()
		{
			return null;
		}
	}
}
