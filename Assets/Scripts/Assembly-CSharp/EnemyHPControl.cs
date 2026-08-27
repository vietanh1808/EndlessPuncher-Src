using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyHPControl : MonoBehaviour, IEnemyHealth, ICombatHealthSource
{
	private enum EnemyVisualState
	{
		Regular = 0,
		RegularHalfHp1 = 1,
		RegularHalfHp2 = 2,
		TakeDamage = 3,
		Ice = 4,
		Gray = 5
	}

	[CompilerGenerated]
	private sealed class _003CMatChange_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyHPControl _003C_003E4__this;

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
		public _003CMatChange_003Ed__47(int _003C_003E1__state)
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
	private sealed class _003CScaleObje_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyHPControl _003C_003E4__this;

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
		public _003CScaleObje_003Ed__58(int _003C_003E1__state)
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

	private static readonly int BaseColorId;

	private static readonly int ColorId;

	private GameObject enemyObje;

	private IEnemy enemy;

	private int _maxHpValue;

	private float _currentHp;

	private MaterialPropertyBlock _propertyBlock;

	private bool _isDebugYellow;

	private Vector3 localposSaved;

	private bool _isDead;

	[Header("SliderBar-MaterialChange")]
	public GameObject hpParent;

	private Coroutine corSlider;

	[SerializeField]
	private SkinnedMeshRenderer[] targetRenderers;

	[SerializeField]
	private Color regularColor;

	[SerializeField]
	private Color regularHalfHp1Color;

	[SerializeField]
	private Color regularHalfHp2Color;

	[SerializeField]
	private Color grayColor;

	[SerializeField]
	private Color takeDamage;

	[SerializeField]
	private Color iceColor;

	private bool isIceEffectActive;

	private Coroutine corMatChange;

	public AnimationCurve bouncPopCurve;

	private bool _isScaled;

	public int MaxHp => 0;

	public float CurrentHp => 0f;

	public float CurrentHealth => 0f;

	public float MaxHealth => 0f;

	public float HealthRatio => 0f;

	public bool IsAlive => false;

	public bool IsLastHit(float value)
	{
		return false;
	}

	private void Start()
	{
	}

	public void CreateEnemy(float hpValue)
	{
	}

	public void ResetHealthBar(float hpValue)
	{
	}

	public void TakeDamage(float damage, bool isCrit)
	{
	}

	public void TakeDamageFromEffect(float damage)
	{
	}

	private void DieSection()
	{
	}

	private void ReduceHP(float valueDamage)
	{
	}

	private bool IsBossEnemy()
	{
		return false;
	}

	public void SetDebugYellow(bool isYellow)
	{
	}

	public void SetIceEffectActive(bool isActive)
	{
	}

	private void MatChanger()
	{
	}

	[IteratorStateMachine(typeof(_003CMatChange_003Ed__47))]
	private IEnumerator MatChange()
	{
		return null;
	}

	private void ChangeGrayMat()
	{
	}

	public void ResetDebugColor()
	{
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

	private EnemyVisualState GetRegularVisualState()
	{
		return EnemyVisualState.Regular;
	}

	private void ApplyVisualState(EnemyVisualState visualState)
	{
	}

	private void ApplyColorToMaterialIndex(SkinnedMeshRenderer renderer, Color color, int materialIndex)
	{
	}

	private Color GetColorForState(EnemyVisualState visualState)
	{
		return default;
	}

	[IteratorStateMachine(typeof(_003CScaleObje_003Ed__58))]
	private IEnumerator ScaleObje()
	{
		return null;
	}
}
