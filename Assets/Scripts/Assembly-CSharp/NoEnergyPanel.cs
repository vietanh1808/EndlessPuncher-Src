using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NoEnergyPanel : Singleton<NoEnergyPanel>
{
	[Header("Panel References")]
	[SerializeField]
	private GameObject _panelRoot;

	[SerializeField]
	private RectTransform _panelContent;

	[SerializeField]
	private Button _closeButton;

	[SerializeField]
	private TextMeshProUGUI _energyText;

	[Header("Dungeon Card")]
	[Tooltip("Energy Dungeon unlock olduysa görünen kart container'ı (DungeonCard GameObject).")]
	[SerializeField]
	private GameObject _dungeonCardHolder;

	[Tooltip("DungeonCard'ın üstündeki başlık (List_TitleRibbon (2) gibi). Kart ile birlikte gizlenir/gösterilir.")]
	[SerializeField]
	private GameObject _dungeonCardTitleObject;

	[Tooltip("DungeonCard içindeki GO butonu. Tıklayınca panel kapanır ve Dungeon tab'ına geçer.")]
	[SerializeField]
	private Button _goToDungeonButton;

	[Header("Watch Ad Button")]
	[Tooltip("RW izleme butonu. Tıklayınca AdManager üzerinden RW açılır, başarılıysa energy verilir.")]
	[SerializeField]
	private Button _watchAdButton;

	[SerializeField]
	private Button _weeklyFreeAdButton;

	[SerializeField]
	private GameObject watchAdButtonTimer;

	[SerializeField]
	private GameObject weeklyTimerIcon;

	[SerializeField]
	private GameObject rewardedTimerIcon;

	[SerializeField]
	private TextMeshProUGUI rewardedCounter;

	[Tooltip("Bottom menu'deki Dungeon tab butonu Animator trigger'ları çalışsın diye tıklamayı bu buton üzerinden yapıyoruz.")]
	[SerializeField]
	private Button _dungeonTabButton;

	[SerializeField]
	private Button _energyFrameOpenPanelButton;

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

	[Header("Debug")]
	[SerializeField]
	private bool _showDebugLogs;

	private bool _isOpen;

	private Tween _animTween;

	[CompilerGenerated]
	private Action m_OnPanelOpened;

	[CompilerGenerated]
	private Action m_OnPanelClosed;

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

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void HandleDailyReset()
	{
	}

	private void RefreshRewardedBtnActivation()
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

	private void RefreshDungeonCard()
	{
	}

	private void OnGoToDungeonClicked()
	{
	}

	private void HandleEnergyChanged()
	{
	}

	public void RefreshEnergyText()
	{
	}

	private void OnWatchAdButtonClicked()
	{
	}

	public void WeeklyButtonClicked()
	{
	}

	private void PlayOpenAnimation()
	{
	}

	private void PlayCloseAnimation(Action onComplete)
	{
	}

	private void Log(string message)
	{
	}
}
