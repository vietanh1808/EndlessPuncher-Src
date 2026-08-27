using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BouncingPunches : SkillBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStartBouncing_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BouncingPunches _003C_003E4__this;

		public Vector3 point;

		public int bouncCount;

		private float _003Cts_003E5__2;

		private int _003Ci_003E5__3;

		private GameObject _003CtargetEnemy_003E5__4;

		private Vector3 _003CstrtPos_003E5__5;

		private float _003Ct_003E5__6;

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
		public _003CStartBouncing_003Ed__19(int _003C_003E1__state)
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

	private GameManager _gm;

	private bool _isActive;

	private EffectType _typePunch;

	public float bouncRange;

	public float punchRange;

	public float clonePunchSpeed;

	public GameObject punchClone;

	public AnimationCurve curveLerpY;

	public ParticleSystem particleLight;

	private GameObject initialEnemyThisCast;

	private readonly Dictionary<GameObject, int> hitCountsThisCast;

	public static BouncingPunches Instance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public bool IsActive()
	{
		return false;
	}

	public override void StartAbility()
	{
	}

	public override void ResetForNewRun()
	{
	}

	public void ActivatePunch(GameObject startObje, EffectType type)
	{
	}

	[IteratorStateMachine(typeof(_003CStartBouncing_003Ed__19))]
	private IEnumerator StartBouncing(int bouncCount, Vector3 point)
	{
		return null;
	}

	public void Attack(GameObject enemy)
	{
	}

	private GameObject GetEnemy()
	{
		return null;
	}

	private bool CanHitEnemyAgain(GameObject enemy)
	{
		return false;
	}

	private void RegisterEnemyHit(GameObject enemy)
	{
	}

	private int GetMaxHitsPerCast(GameObject enemy)
	{
		return 0;
	}

	private Vector3 GetBounceTargetPosition(GameObject enemy)
	{
		return default;
	}
}
