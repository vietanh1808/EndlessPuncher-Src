using System;
using System.Runtime.CompilerServices;
using TMPro;

public class WeeklyShopManager : PersistentSingleton<WeeklyShopManager>
{
	private const float RefreshInterval = 1f;

	private float refreshTimer;

	private bool lastActiveState;

	private string lastDeactiveButtonTimerText;

	[CompilerGenerated]
	private Action<bool> m_OnWeeklyAdsStatusChanged;

	[CompilerGenerated]
	private Action<TimeSpan> m_OnWeeklyAdsTimeChanged;

	public TextMeshProUGUI timerForWeelyDeactiveBtn;

	public bool IsWeeklyAdsActive => false;

	public event Action<bool> OnWeeklyAdsStatusChanged
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

	public event Action<TimeSpan> OnWeeklyAdsTimeChanged
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

	private void Update()
	{
	}

	public void ActivateFromPurchase()
	{
	}

	public TimeSpan GetRemainingTime()
	{
		return default;
	}

	private void BroadcastState(bool force = false)
	{
	}

	private void RefreshWeeklyDeactiveButtonTimer(TimeSpan remaining)
	{
	}

	private string FormatRemainingTime(TimeSpan remaining)
	{
		return null;
	}

	private DateTime GetExpireTime()
	{
		return default;
	}

	private void SetExpireTime(DateTime expireTime)
	{
	}
}
