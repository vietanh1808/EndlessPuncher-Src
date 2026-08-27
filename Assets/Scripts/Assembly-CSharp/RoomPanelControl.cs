using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RoomPanelControl : MonoBehaviour
{
	[Serializable]
	public class MileStonePrize
	{
		public Slider prizeSlider;

		public Image icon;

		public ParticleSystem particleSpark;

		public bool isGotPrize;

		public Animator animPrize;

		public RoomPurchaseDB.Prize prize;

		public int lineValue;

		public void SetPrize(RoomPurchaseDB.Prize prize, Sprite icon, bool isPrizeReceived = false)
		{
		}

		public void PrizeRecieved()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CLoadNextRoom_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoomPanelControl _003C_003E4__this;

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
		public _003CLoadNextRoom_003Ed__22(int _003C_003E1__state)
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

	private static RoomPanelControl _instance;

	public List<MileStonePrize> allMileStonePrizes;

	public Sprite[] prizeIcons;

	private RoomPurchaseDB.Room selectedRoom;

	public Button btnPurchase;

	public TextMeshProUGUI textPurchase;

	public Slider slider;

	public TextMeshProUGUI sliderText;

	private float _price;

	private string lastPurchaseText;

	private string lastSliderText;

	private string lastPrizeText;

	public TextMeshProUGUI nameText;

	public TextMeshProUGUI descriptionText;

	public TextMeshProUGUI prizeText;

	public Image icon;

	public Animator animPanel;

	public RoomBehaviour roomBehaviour;

	public RoomEarnedUIPanel earnedUIPanel;

	public static RoomPanelControl Instance => null;

	public bool IsPurchaseActive => false;

	private void Awake()
	{
	}

	private void UpdateBtn()
	{
	}

	public void PurchaseCompleted()
	{
	}

	private void SliderSet()
	{
	}

	private void CompletePrize(RoomPurchaseDB.Prize prize)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadNextRoom_003Ed__22))]
	private IEnumerator LoadNextRoom()
	{
		return null;
	}

	public void SetPanelUI()
	{
	}

	private Sprite GetClotestIcon()
	{
		return null;
	}

	private void Start()
	{
	}

	private string GetSymbol(PrizeType type)
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private static void SetTextIfChanged(TextMeshProUGUI text, ref string cachedValue, string value)
	{
	}
}
