using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ZombieHPControl : MonoBehaviour, IEnemyHealth, ICombatHealthSource
{
	private enum ZombieVisualState
	{
		Regular = 0,
		RegularHalfHp1 = 1,
		RegularHalfHp2 = 2,
		TakeDamage = 3,
		Gray = 4
	}

	[CompilerGenerated]
	private sealed class _003CDamageVisualRoutine_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ZombieHPControl _003C_003E4__this;

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
		public _003CDamageVisualRoutine_003Ed__43(int _003C_003E1__state)
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
	private static Action m_OnAnyZombieHpChanged;

	private static readonly int BaseColorId;

	private static readonly int ColorId;

	[Header("SliderBar-MaterialChange")]
	[SerializeField]
	private GameObject hpParent;

	[SerializeField]
	private Renderer[] targetRenderers;

	[SerializeField]
	private Material regularColor;

	[SerializeField]
	private Material regularHalfHp1Color;

	[SerializeField]
	private Material regularHalfHp2Color;

	[SerializeField]
	private Material grayColor;

	[SerializeField]
	private Material takeDamage;

	private IEnemy enemy;

	private GameObject enemyObject;

	private MaterialPropertyBlock propertyBlock;

	private Coroutine materialRoutine;

	private Vector3 savedScale;

	private int maxHpValue;

	private float currentHp;

	private bool isDead;

	private bool isIceEffectActive;

	public int MaxHp => 0;

	public float CurrentHp => 0f;

	public float CurrentHealth => 0f;

	public float MaxHealth => 0f;

	public float HealthRatio => 0f;

	public bool IsAlive => false;

	public static event Action OnAnyZombieHpChanged
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

	private void Start()
	{
	}

	public void CreateEnemy(float hpValue)
	{
	}

	public bool IsLastHit(float value)
	{
		return false;
	}

	public void TakeDamage(float damage, bool isCrit)
	{
	}

	public void TakeDamageFromEffect(float damage)
	{
	}

	public void SetIceEffectActive(bool isActive)
	{
	}

	private void ReduceHp(float damage)
	{
	}

	private void DieSection()
	{
	}

	private void StartDamageVisual()
	{
	}

	[IteratorStateMachine(typeof(_003CDamageVisualRoutine_003Ed__43))]
	private IEnumerator DamageVisualRoutine()
	{
		return null;
	}

	private void SpawnResets()
	{
	}

	private void CacheRenderers()
	{
	}

	private void ApplyCurrentVisualState()
	{
	}

	private ZombieVisualState GetRegularVisualState()
	{
		return ZombieVisualState.Regular;
	}

	private void ApplyVisualState(ZombieVisualState visualState)
	{
	}

	private void ApplyColor(Renderer renderer, Material color, int materialIndex)
	{
	}

	private Material GetColorForState(ZombieVisualState visualState)
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private static void NotifyHpChanged()
	{
	}
}
