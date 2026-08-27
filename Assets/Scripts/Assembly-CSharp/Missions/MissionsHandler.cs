using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Missions
{
	public class MissionsHandler : MonoBehaviour
	{
		[Serializable]
		private struct Mission
		{
			[SerializeReference]
			public MissionBase mission;
		}

		public enum MissionType
		{
			Default = 0
		}

		[CompilerGenerated]
		private sealed class _003CLookAtRoutine_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int order;

			public MissionsHandler _003C_003E4__this;

			public Transform target;

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
			public _003CLookAtRoutine_003Ed__43(int _003C_003E1__state)
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

		public static MissionsHandler instance;

		[SerializeField]
		private Mission[] missions;

		[SerializeField]
		private GameObject missionPanel;

		[SerializeField]
		private Animator panelAnim;

		[SerializeField]
		private GameObject rewardPanel;

		[SerializeField]
		private TMP_Text nameText;

		[SerializeField]
		private TMP_Text descriptionText;

		[SerializeField]
		private TMP_Text progressText;

		[SerializeField]
		private Slider progressBar;

		[SerializeField]
		private GameObject progressBarHolder;

		[SerializeField]
		private GameObject magnifyingGlassHolder;

		[SerializeField]
		private TMP_Text rewardText;

		[SerializeField]
		private TMP_Text rewardText1;

		[SerializeField]
		private Transform rewardPos;

		[SerializeField]
		private Transform arrow;

		[SerializeField]
		private GameObject arrowHolder;

		[SerializeField]
		private GameObject crossHolder;

		[SerializeField]
		private GameObject navHolder;

		[SerializeField]
		private TMP_Text distanceText;

		[SerializeField]
		private ParticleSystem rewardFX;

		[SerializeField]
		private CinemachineVirtualCamera vcam;

		[SerializeField]
		[Tooltip("The rate at which the missions are updated.")]
		private float updateRate;

		private int currentMissionIndex;

		private bool isMissionActive;

		private int updateCounter;

		private float lastLookTime;

		private Transform dummyLookAt;

		private Vector3 lastLookAt;

		private int cameraQueueuOrder;

		private int cameraCurrentOrder;

		private float missionStartTime;

		private static readonly int PopKey;

		private static readonly int ResetKey;

		private static readonly int ShowKey;

		private MissionBase CurrentMission => null;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void SyncRemote()
		{
		}

		private void Update()
		{
		}

		private void TriggerNextMission(bool increase)
		{
		}

		private void CheckMission()
		{
		}

		private void ShowReward()
		{
		}

		public void CollectReward()
		{
		}

		public void LookAtMission()
		{
		}

		public void CompleteCurrentMission()
		{
		}

		public void LookAt(Vector3 pos)
		{
		}

		[IteratorStateMachine(typeof(_003CLookAtRoutine_003Ed__43))]
		private IEnumerator LookAtRoutine(Transform target, int order)
		{
			return null;
		}

		public void UpdateUI()
		{
		}

		private void SetUI()
		{
		}

		private void UpdateArrow()
		{
		}

		public void Save()
		{
		}

		private void Load()
		{
		}

		public void OnPrestige()
		{
		}
	}
}
