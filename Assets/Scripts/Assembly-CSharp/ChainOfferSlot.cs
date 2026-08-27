using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChainOfferSlot : MonoBehaviour
{
	private static readonly int PopHash;

	[SerializeField]
	private ChainOfferRewardView rewardPrefab;

	[SerializeField]
	private Transform rewardParent;

	[SerializeField]
	private GameObject checkButton;

	[SerializeField]
	private GameObject checkButtonBG;

	[SerializeField]
	private GameObject freeButton;

	[SerializeField]
	private GameObject freeButtonBG;

	[SerializeField]
	private GameObject dolarButton;

	[SerializeField]
	private GameObject dolarButtonBG;

	[SerializeField]
	private TextMeshProUGUI dolarButtonText;

	[SerializeField]
	private Animator anim;

	[SerializeField]
	private ParticleSystem confettie;

	[SerializeField]
	private GameObject arrow;

	[SerializeField]
	private GameObject lockObje;

	private int index;

	private ChainOfferReward rewardData;

	private Action<int> onFreeClicked;

	private Action<int> onPaidClicked;

	private Button freeButtonComponent;

	private Button dolarButtonComponent;

	private bool currentIsClaimed;

	private bool currentIsUnlocked;

	private readonly List<ChainOfferRewardView> rewardViews;

	public void Setup(int rewardIndex, ChainOfferReward reward, bool isClaimed, bool isUnlocked, Action<int> freeClicked, Action<int> paidClicked)
	{
	}

	public void SetClaimed(bool isClaimed)
	{
	}

	public void SetArrowVisible(bool isVisible)
	{
	}

	public void SetState(bool isClaimed, bool isUnlocked)
	{
	}

	public void PlayClaimFeedback()
	{
	}

	private void RefreshRewardTexts()
	{
	}

	private void SpawnRewardViews()
	{
	}

	private void ClearRewardViews()
	{
	}

	private void BindButtons()
	{
	}

	private void OnFreeButtonClicked()
	{
	}

	private void OnPaidButtonClicked()
	{
	}

	private bool CanClaimSlot()
	{
		return false;
	}

	private void OnDestroy()
	{
	}
}
