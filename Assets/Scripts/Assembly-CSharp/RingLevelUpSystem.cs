using System;
using UnityEngine;

public class RingLevelUpSystem : MonoBehaviour
{
	[Serializable]
	public class RingModel
	{
		[SerializeField]
		private GameObject modelRoot;

		[SerializeField]
		private GameObject chain;

		[SerializeField]
		private GameObject ground;

		[SerializeField]
		private GameObject pillars;

		[SerializeField]
		private float popScale;

		[SerializeField]
		private float popUpDuration;

		[SerializeField]
		private float popDownDuration;

		public bool SetActive(bool chainActive, bool groundActive, bool pillarsActive, bool animate = false)
		{
			return false;
		}

		public bool SetChainActive(bool isActive, bool animate = false)
		{
			return false;
		}

		public bool SetGroundActive(bool isActive, bool animate = false)
		{
			return false;
		}

		public bool SetPillarsActive(bool isActive, bool animate = false)
		{
			return false;
		}

		private void SetRootActive(bool isActive)
		{
		}

		private void PlayPop(Transform target)
		{
		}
	}

	[SerializeField]
	private RingModel[] ringModels;

	[SerializeField]
	private RingModel[] ringModelsForCamera;

	[SerializeField]
	private int nextGroundStarLevel;

	[SerializeField]
	private int nextPillarsStarLevel;

	[SerializeField]
	private ParticleSystem confettie;

	public void Refresh(int specialLevel, int currentSpecialStarLevel)
	{
	}

	private bool RefreshModels(RingModel[] models, int specialLevel, int currentSpecialStarLevel)
	{
		return false;
	}

	private int GetModelIndex(RingModel[] models, int specialLevel)
	{
		return 0;
	}

	private void OnValidate()
	{
	}
}
