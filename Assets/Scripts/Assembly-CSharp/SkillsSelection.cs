using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillsSelection : MonoBehaviour
{
	[Serializable]
	public class StatSet
	{
		public SkillUpgradeType typeStat;

		public GameObject statObje;

		public TextMeshProUGUI statText;

		public TextMeshProUGUI statTextEnd;
	}

	[CompilerGenerated]
	private sealed class _003CChangeColor_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillsSelection _003C_003E4__this;

		private Color _003CcolorbgStart_003E5__2;

		private Color _003CcolorObligStart_003E5__3;

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
		public _003CChangeColor_003Ed__40(int _003C_003E1__state)
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
	private sealed class _003CCompStatRator_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillsSelection _003C_003E4__this;

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
		public _003CCompStatRator_003Ed__42(int _003C_003E1__state)
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
	private sealed class _003CCompStatRatorRewarded_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillsSelection _003C_003E4__this;

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
		public _003CCompStatRatorRewarded_003Ed__44(int _003C_003E1__state)
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
	private sealed class _003COrderDelay_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillsSelection _003C_003E4__this;

		public int order;

		private Vector3 _003Cstart_003E5__2;

		private Vector3 _003Cend_003E5__3;

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
		public _003COrderDelay_003Ed__19(int _003C_003E1__state)
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

	private int popHash;

	public Animator anim;

	public TextMeshProUGUI textCharacterName;

	public TextMeshProUGUI textCharacterDescription;

	public TextMeshProUGUI textLevel;

	public Image iconCharacter;

	public List<StatSet> allstatForNewSkill;

	public List<StatSet> allstatForUpgrade;

	private StatDB.Skill _skill;

	private StatDB.SkillUpgradeStatSaver _cardUpgradeStat;

	private bool _isCompleting;

	private Color firstSkillBackgroundColor;

	private Color firstSkillObligColor;

	private Color[] firstSkillBorderColors;

	private bool firstSkillBorderEpicActive;

	private bool hasFirstSkillColors;

	[SerializeField]
	private GameObject borderEpic;

	[SerializeField]
	private GameObject[] rarityNames;

	[SerializeField]
	private GameObject[] rarityShines;

	[SerializeField]
	private GameObject[] effectNames;

	[SerializeField]
	private Color[] rarityColorsBg;

	[SerializeField]
	private Color[] rarityColorsOblig;

	[SerializeField]
	private Color[] rarityColorsBorder;

	[SerializeField]
	private Image[] imageBorder;

	[SerializeField]
	private Image imageBg;

	[SerializeField]
	private Image imageOblig;

	[SerializeField]
	private Color bgColor;

	[SerializeField]
	private Color obligColor;

	private void Awake()
	{
	}

	public void SetStat(StatDB.Skill skill, int order)
	{
	}

	[IteratorStateMachine(typeof(_003COrderDelay_003Ed__19))]
	private IEnumerator OrderDelay(int order)
	{
		return null;
	}

	private string GetSymbolSuff(SkillUpgradeType type)
	{
		return null;
	}

	private string GetSymbolPrefix(SkillUpgradeType type)
	{
		return null;
	}

	private float GetDisplayStatValue(StatDB.Skill skill, SkillUpgradeType typeStat)
	{
		return 0f;
	}

	private float GetDisplayEndStatValue(StatDB.Skill skill, SkillUpgradeType typeStat, StatDB.SkillUpgradeStatSaver upgradeStat)
	{
		return 0f;
	}

	private float GetDisplayCooldown(float cooldown)
	{
		return 0f;
	}

	private float GetFinalSkillDamage(float skillDamageCoefficient)
	{
		return 0f;
	}

	private string FormatSkillStatValue(SkillUpgradeType typeStat, float value)
	{
		return null;
	}

	public void ActivateSlote()
	{
	}

	[IteratorStateMachine(typeof(_003CChangeColor_003Ed__40))]
	private IEnumerator ChangeColor()
	{
		return null;
	}

	public void CompleteStat()
	{
	}

	[IteratorStateMachine(typeof(_003CCompStatRator_003Ed__42))]
	private IEnumerator CompStatRator()
	{
		return null;
	}

	public void CompleteStatFromRewarded()
	{
	}

	[IteratorStateMachine(typeof(_003CCompStatRatorRewarded_003Ed__44))]
	private IEnumerator CompStatRatorRewarded()
	{
		return null;
	}
}
