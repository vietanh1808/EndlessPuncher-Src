using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BossHPControl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLoadLateSlider_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BossHPControl _003C_003E4__this;

		private float _003Ct_003E5__2;

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
		public _003CLoadLateSlider_003Ed__25(int _003C_003E1__state)
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

	private static BossHPControl _instance;

	private float _maxHpValue;

	private float _totalHp;

	public TextMeshProUGUI textMeshHP;

	private EnemyHPControl bossHP;

	public Slider hpSlinder;

	public Slider lateHpSlider;

	[SerializeField]
	private GameObject bossBarRoot;

	public Animator animBoss;

	private Coroutine corLate;

	public static BossHPControl instance => null;

	[HideInInspector]
	public float TotalHp
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void SetSliderAndText()
	{
	}

	private void TextHP()
	{
	}

	public void SetTotalHp(float hp)
	{
	}

	public void SetHpValue(float damage)
	{
	}

	public void BossDead()
	{
	}

	public void CloseBossBar()
	{
	}

	public void BossArrived()
	{
	}

	public void ResetForNewRun()
	{
	}

	private void ApplyBossBarVisible(bool isVisible)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadLateSlider_003Ed__25))]
	private IEnumerator LoadLateSlider()
	{
		return null;
	}
}
