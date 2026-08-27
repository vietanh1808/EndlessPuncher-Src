using System;
using UnityEngine;
using UnityEngine.Events;

namespace Missions
{
	[Serializable]
	public abstract class MissionBase
	{
		public string missionName;

		public string missionDescription;

		public Transform missionPosition;

		public Renderer missionRenderer;

		public bool showPanel;

		public bool showProgress;

		public float rewardAmount;

		public int targetCompleteCount;

		protected int completeCount;

		public CurrencyTypes rewardType;

		public UnityEvent onMissionStart;

		public UnityEvent onMissionComplete;

		public virtual float MissionRatio => 0f;

		public virtual string MissionRatioStr => null;

		public virtual string SaveData => null;

		public virtual void OnMissionStart(int index)
		{
		}

		public virtual void OnMissionComplete(int index)
		{
		}

		public abstract bool IsCompleted();

		public virtual void LoadData(string data)
		{
		}

		public virtual void Init()
		{
		}
	}
}
