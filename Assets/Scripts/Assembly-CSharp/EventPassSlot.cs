using System;
using Fubu.Essentials;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class EventPassSlot : MonoBehaviour
{
	private static readonly int PopHash;

	private static readonly int BreathHash;

	[Header("Regular Reward")]
	[SerializeField]
	private Image regularRewardIcon;

	[SerializeField]
	private TextMeshProUGUI regularRewardText;

	[SerializeField]
	private GameObject regularCheckObject;

	[SerializeField]
	private GameObject regularGlowObject;

	[SerializeField]
	private GameObject activeGlowRegular;

	[SerializeField]
	private Animator animRegular;

	[SerializeField]
	private ParticleSystem partRegular;

	[SerializeField]
	private Button regularBtn;

	[Header("Pass Reward")]
	[SerializeField]
	private Image passRewardIcon;

	[SerializeField]
	private TextMeshProUGUI passRewardText;

	[SerializeField]
	private GameObject passCheckObject;

	[SerializeField]
	private GameObject passLockObject;

	[SerializeField]
	private GameObject activeGlowPass;

	[SerializeField]
	private Animator animPass;

	[SerializeField]
	private ParticleSystem partPass;

	[SerializeField]
	private Button passBtn;

	[Header("Progress")]
	[FormerlySerializedAs("regularSlider")]
	[SerializeField]
	private Slider startSlider;

	[FormerlySerializedAs("passSlider")]
	[SerializeField]
	private Slider endSlider;

	[SerializeField]
	private GameObject pointYellow;

	[SerializeField]
	private GameObject pointGray;

	[SerializeField]
	private TextMeshProUGUI pointText;

	private EventPassRewardEntry rewardEntry;

	private int rewardIndex;

	private int previousTargetCurrencyValue;

	private int targetCurrencyValue;

	private int nextTargetCurrencyValue;

	private bool isRegularClaimed;

	private bool isPassClaimed;

	private bool isRegularReady;

	private bool isPassReady;

	private bool isPassActive;

	private Action<int> onRegularClaimClicked;

	private Action<int> onPassClaimClicked;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Setup(int rewardIndex, EventPassRewardEntry entry, float rewardPassMultiplier, int currentCurrencyValue, int previousTargetCurrencyValue, int nextTargetCurrencyValue, bool isRegularClaimed, bool isPassClaimed, bool isRegularReady, bool isPassReady, bool isPassActive, Action<int> onRegularClaimClicked, Action<int> onPassClaimClicked)
	{
	}

	public void SetProgress(int currentCurrencyValue)
	{
	}

	public void SetRegularClaimed(bool isClaimed)
	{
	}

	public void SetPassClaimed(bool isClaimed)
	{
	}

	public void SetRegularReady(bool isReady)
	{
	}

	public void SetPassReady(bool isReady, bool isPassActive)
	{
	}

	public void PlayRegularClaimFeedback()
	{
	}

	public void PlayPassClaimFeedback()
	{
	}

	private void AddButtonListeners()
	{
	}

	private void RemoveButtonListeners()
	{
	}

	private void HandleRegularButtonClicked()
	{
	}

	private void HandlePassButtonClicked()
	{
	}

	private void RefreshRegularClaimState()
	{
	}

	private void RefreshPassClaimState()
	{
	}

	private static float GetStartProgress(int currentCurrencyValue, int previousTargetCurrencyValue, int targetCurrencyValue)
	{
		return 0f;
	}

	private static float GetEndProgress(int currentCurrencyValue, int targetCurrencyValue, int nextTargetCurrencyValue)
	{
		return 0f;
	}

	private static float GetRangeProgress(int currentValue, int startValue, int endValue)
	{
		return 0f;
	}

	private static void RefreshRewardUI(Image icon, TextMeshProUGUI amountText, RewardItem rewardItem, int amount, bool isClaimed)
	{
	}

	private static void SetAlpha(Graphic graphic, float alpha)
	{
	}

	private static void SetRewardAlpha(Image icon, TextMeshProUGUI amountText, bool isClaimed)
	{
	}

	private static void PlayFeedback(Animator animator, ParticleSystem particle)
	{
	}

	private static void SetBreath(Animator animator, bool isActive)
	{
	}

	private static void SetCheckObject(GameObject checkObject, bool isActive)
	{
	}

	private static void SetSliderValue(Slider slider, float value)
	{
	}
}
