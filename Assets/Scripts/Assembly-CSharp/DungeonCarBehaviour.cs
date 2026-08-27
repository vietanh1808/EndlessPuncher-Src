using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DungeonCarBehaviour : MonoBehaviour, IEnemy
{
	[CompilerGenerated]
	private sealed class _003CDespawnRoutine_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DungeonCarBehaviour _003C_003E4__this;

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
		public _003CDespawnRoutine_003Ed__38(int _003C_003E1__state)
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

	[Header("References")]
	[SerializeField]
	private CarHPControl carHpControl;

	[SerializeField]
	private Transform takeDamagePos;

	[SerializeField]
	private GameObject visualsRoot;

	[SerializeField]
	private Rigidbody rigidbodyRef;

	[Header("Death")]
	[SerializeField]
	private float destroyDelay;

	[SerializeField]
	private bool disableColliderOnDeath;

	[SerializeField]
	private float explosionForwardForce;

	[Header("FX")]
	[SerializeField]
	private ParticleSystem explosionParticle;

	[SerializeField]
	private ParticleSystem smokeParticle;

	private Collider[] cachedColliders;

	private PoolControl poolControl;

	private Coroutine despawnRoutine;

	private bool isDead;

	[CompilerGenerated]
	private Action<float, float> m_OnHpChanged;

	public float CurrentHp => 0f;

	public int MaxHp => 0;

	public event Action<float, float> OnHpChanged
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

	private void Awake()
	{
	}

	public void AttackCompleted()
	{
	}

	public void TakeDamage(float damage, bool isCrit, EffectTypeDuration type)
	{
	}

	public void TakeDamageOnlyEffect(EffectTypeDuration type)
	{
	}

	public void TakeDamage(float damage, bool isCrit, bool isOnlyTDHit = false)
	{
	}

	public void TakeDamage(Vector3 directionKnockback, float damage)
	{
	}

	public void AddForce(Vector3 directionKnockback, float force)
	{
	}

	public void VoidEffect()
	{
	}

	public void Die()
	{
	}

	public bool IsAlive()
	{
		return false;
	}

	public bool IsLifeStealActive(float value)
	{
		return false;
	}

	public GameObject GetGameObject()
	{
		return null;
	}

	public void StartEnemy(float hpValue, float damage)
	{
	}

	public void StartEnemyForSkillTestScene(float hpValue, float damage, bool isCanMove)
	{
	}

	public Transform GetTDPos()
	{
		return null;
	}

	public void Freeze(bool slowStarted)
	{
	}

	public void StunActive()
	{
	}

	public bool IsElitEnemy()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CDespawnRoutine_003Ed__38))]
	private IEnumerator DespawnRoutine()
	{
		return null;
	}

	private void RestoreColliders()
	{
	}

	private void SetPhysicsLayerForCachedColliders(int layer)
	{
	}

	private void NotifyHpChanged()
	{
	}

	private void ApplyExplosionForwardForce()
	{
	}

	private void StopDeathParticles()
	{
	}

	private float GetDeathFxDuration()
	{
		return 0f;
	}

	private float GetParticleDuration(ParticleSystem particleSystem)
	{
		return 0f;
	}
}
