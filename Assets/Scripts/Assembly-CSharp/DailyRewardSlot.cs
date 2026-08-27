using System;
using System.Collections.Generic;
using DG.Tweening;
using Fubu.Essentials;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DailyRewardSlot : MonoBehaviour
{
	[Serializable]
	public class RewardSlot
	{
		public Image rewardIcon;

		public TextMeshProUGUI rewardTitle;

		public TextMeshProUGUI amountText;
	}

	private static readonly int BreathHash;

	private static readonly int PopHash;

	public RewardSlot slot1;

	public RewardSlot slot2;

	[SerializeField]
	[HideInInspector]
	private Image rewardIcon;

	[SerializeField]
	[HideInInspector]
	private TextMeshProUGUI rewardTitle;

	[SerializeField]
	[HideInInspector]
	private TextMeshProUGUI amountText;

	[SerializeField]
	private TextMeshProUGUI dayText;

	[SerializeField]
	private GameObject todayBG;

	[SerializeField]
	private GameObject todayFocus;

	[SerializeField]
	private GameObject cover;

	[SerializeField]
	private Button claimButton;

	[SerializeField]
	private Transform breathTarget;

	[SerializeField]
	private Animator anim;

	[SerializeField]
	private float breathScale;

	[SerializeField]
	private float breathDuration;

	[SerializeField]
	private ParticleSystem claimParticle;

	[SerializeField]
	private float claimPopScale;

	[SerializeField]
	private float claimPopDuration;

	private int dayIndex;

	private Vector3 defaultScale;

	private Tween breathTween;

	private Tween claimTween;

	private Action<int, DailyRewardSlot> onClicked;

	private bool isTodayReward;

	public Vector3 RewardIconPosition => default;

	public Transform TutorialTarget => null;

	private void Awake()
	{
	}

	public void Setup(int index, IReadOnlyList<RewardEntry> rewardEntries, DailyRewardSlotState state, bool isTodayReward, Action<int, DailyRewardSlot> clicked)
	{
	}

	public void RefreshState(DailyRewardSlotState state)
	{
	}

	private void SetRewardIconAlpha(float alpha)
	{
	}

	private void SetRewardSlotAlpha(RewardSlot rewardSlot, float alpha)
	{
	}

	public void PlayClaimFeedback()
	{
	}

	private void RefreshReward(IReadOnlyList<RewardEntry> rewardEntries, bool isTodayReward)
	{
	}

	private RewardEntry GetRewardEntry(IReadOnlyList<RewardEntry> rewardEntries, int index)
	{
		return null;
	}

	private void SetupRewardSlot(RewardSlot rewardSlot, RewardEntry rewardEntry)
	{
	}

	public Vector3 GetRewardIconPosition(int rewardIndex)
	{
		return default;
	}

	private string GetRewardTitle(RewardItem rewardItem)
	{
		return null;
	}

	private string GetKeyRewardTitle(ChestTypes chestType)
	{
		return null;
	}

	private string GetCurrencyRewardTitle(CurrencyTypes currencyType)
	{
		return null;
	}

	private string ToDisplayName(string value)
	{
		return null;
	}

	private void BindButton()
	{
	}

	private void OnClicked()
	{
	}

	private Transform GetBreathTarget()
	{
		return null;
	}

	private void SetBreath(bool isActive)
	{
	}

	private void EnsureRewardSlots()
	{
	}

	private void OnDestroy()
	{
	}
}
