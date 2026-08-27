using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NoCrystalPanel : Singleton<NoCrystalPanel>
{
	[Header("Panel References")]
	[SerializeField]
	private GameObject _panelRoot;

	[SerializeField]
	private RectTransform _panelContent;

	[SerializeField]
	private Button _closeButton;

	[Header("Animation")]
	[SerializeField]
	private float _openDuration;

	[SerializeField]
	private float _closeDuration;

	[SerializeField]
	private Ease _openEase;

	[SerializeField]
	private Ease _closeEase;

	[SerializeField]
	private Vector3 _closedScale;

	private bool _isOpen;

	private Tween _animTween;

	[CompilerGenerated]
	private Action m_OnPanelOpened;

	[CompilerGenerated]
	private Action m_OnPanelClosed;

	[SerializeField]
	private TextMeshProUGUI rewardedCounter;

	[SerializeField]
	private TextMeshProUGUI rewardedCounterWeekly;

	[SerializeField]
	private Button freeClaim;

	[SerializeField]
	private Button rewardedClaim;

	[SerializeField]
	private Button rewardedTimer;

	[SerializeField]
	private Button weeklyRewardedClaim;

	[SerializeField]
	private GameObject weeklyTimerIcon;

	[SerializeField]
	private GameObject rewardedTimerIcon;

	public bool IsOpen => false;

	public event Action OnPanelOpened
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnPanelClosed
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void HandleDailyReset()
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	private void OpenNoEnergyPanelFromFrameButton()
	{
	}

	private void PlayOpenAnimation()
	{
	}

	private void PlayCloseAnimation(Action onComplete)
	{
	}

	public void CheckRewardedAndFreeButtons()
	{
	}

	public void FreeShopGemClaim()
	{
	}

	public void RewardedStartShopGemClaim()
	{
	}
}
