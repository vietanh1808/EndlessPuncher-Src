using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TalentUpgradeSystem : MonoBehaviour
{
	[Serializable]
	public class IncrementalButtons
	{
		public int id;

		public Image bg;

		public Image glowImage;

		public Sprite activeSprite;

		public Sprite deactiveSprite;

		public Sprite maxSprite;

		public Button button;

		public Animator anim;

		public ParticleSystem particle;

		public TextMeshProUGUI priceText;

		public TextMeshProUGUI levelText;

		public TextMeshProUGUI statValueText;

		private int _price;

		private int _increaseAmounth;

		public int GetPrice => 0;

		public void UpgradeInc()
		{
		}

		public void LoadButtonValues()
		{
		}

		public void SetIncButton(bool isThereEffect = true)
		{
		}

		public void ResetButton()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CGoBackLoader_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentUpgradeSystem _003C_003E4__this;

		private Vector2 _003CposLocal_003E5__2;

		private Vector2 _003CendPos_003E5__3;

		private float _003Ct_003E5__4;

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
		public _003CGoBackLoader_003Ed__23(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CLoadSlider_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentUpgradeSystem _003C_003E4__this;

		private int _003CtotalUpgradeCount_003E5__2;

		private float _003CstartSlider_003E5__3;

		private float _003CendSliderValue_003E5__4;

		private float _003Ct_003E5__5;

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
		public _003CLoadSlider_003Ed__20(int _003C_003E1__state)
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

	private static TalentUpgradeSystem _instance;

	public List<IncrementalButtons> incrementalButtons;

	[SerializeField]
	private TextMeshProUGUI generalTalentTitle;

	[SerializeField]
	private TextMeshProUGUI textTotalTalentValue;

	[SerializeField]
	private Slider slider;

	[SerializeField]
	private Transform holderUiobje;

	[SerializeField]
	private GameObject talentUiPrefab;

	private List<TalentUiPreviewPoint> allTalentUi;

	private Coroutine coroSlider;

	private bool _isDeactiveButtons;

	private RectTransform targetRect;

	[SerializeField]
	private TextMeshProUGUI damageStat;

	[SerializeField]
	private TextMeshProUGUI hpStat;

	[SerializeField]
	private TextMeshProUGUI defenceStat;

	public static TalentUpgradeSystem Instance => null;

	public bool IsPurchaseActive => false;

	private void Start()
	{
	}

	private void SliderStartConfigs()
	{
	}

	public void CheckUpgradeInteract()
	{
	}

	public void UpgradeIncrementals(int id)
	{
	}

	public void SetTitle(string title)
	{
	}

	private void WriteText()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadSlider_003Ed__20))]
	private IEnumerator LoadSlider()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGoBackLoader_003Ed__23))]
	private IEnumerator GoBackLoader()
	{
		return null;
	}

	private void CompleteCheck()
	{
	}

	public void SetStats()
	{
	}
}
