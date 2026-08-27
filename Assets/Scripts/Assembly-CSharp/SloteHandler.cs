using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SloteHandler : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSetPanelActiveEnum_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool isDelay;

		public bool value;

		public SloteHandler _003C_003E4__this;

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
		public _003CSetPanelActiveEnum_003Ed__52(int _003C_003E1__state)
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

	private const CurrencyTypes PurchaseCurrencyType = CurrencyTypes.Gem;

	private static SloteHandler _instance;

	private InGameUI gameUI;

	private int _slotePurchaseCurrency;

	[Header("Talent Slot Pricing")]
	[Min(0f)]
	[SerializeField]
	private int purchasePriceStart;

	[Min(0f)]
	[SerializeField]
	private int purchasePriceIncrease;

	[SerializeField]
	private GameObject frame;

	[SerializeField]
	private Animator anim;

	[SerializeField]
	private Button purchaseButton;

	[SerializeField]
	private GameObject purchasedText;

	[SerializeField]
	private GameObject shineObje;

	[SerializeField]
	private TMP_Text missingText;

	[SerializeField]
	private TMP_Text buttonPrice;

	[SerializeField]
	private TMP_Text nameText;

	[SerializeField]
	private TMP_Text descriptionText;

	[SerializeField]
	private TMP_Text effectText;

	[SerializeField]
	private TMP_Text levelText;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private GameObject[] iconBGs;

	[SerializeField]
	private GameObject[] nameBGs;

	private bool IsActive;

	private TalentDB.Talent _talent;

	private TalentSlot _talentSlot;

	public GameObject paretnObje;

	private Coroutine corOpenClose;

	private bool _isClosed;

	public static SloteHandler Instance => null;

	private void Awake()
	{
	}

	public bool GetActivity()
	{
		return false;
	}

	public Transform GetPurchaseButtonTransform()
	{
		return null;
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void HandleRemoteConfigLoaded()
	{
	}

	private void ApplyRemoteTalentSlotPricing()
	{
	}

	private void DelayCurrencyAdd()
	{
	}

	private void OnDestroy()
	{
	}

	public void CheckCurrency()
	{
	}

	public void ShowPanel(TalentSlot talentSlot)
	{
	}

	public void RefreshActiveTalentPanel()
	{
	}

	private void UpdateUI()
	{
	}

	public static int GetCurrentPurchasePrice()
	{
		return 0;
	}

	public bool HasAffordableTalentSlotPurchase()
	{
		return false;
	}

	private bool CanAffordCurrentPrice(int price)
	{
		return false;
	}

	private void RefreshPurchaseState()
	{
	}

	private string GetDescriptionText(TalentDB.Talent talent)
	{
		return null;
	}

	private string GetEffectText(TalentDB.Talent talent)
	{
		return null;
	}

	private string GetFormattedTalentValueText(TalentDB.Talent talent)
	{
		return null;
	}

	private string FormatTalentValue(float value)
	{
		return null;
	}

	private Sprite GetTalentIcon(TalentDB.Talent talent)
	{
		return null;
	}

	private bool TryGetSkillType(TalentType talentType, out SkillType skillType)
	{
		skillType = default;
		return false;
	}

	public void CompletePurchase()
	{
	}

	[IteratorStateMachine(typeof(_003CSetPanelActiveEnum_003Ed__52))]
	private IEnumerator SetPanelActiveEnum(bool value, bool isDelay = false)
	{
		return null;
	}

	public bool GetIsClosed()
	{
		return false;
	}

	public void ClosePanel()
	{
	}
}
