using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GunPuncher : SkillBehaviour
{
	[Serializable]
	public class PunchSet
	{
		[CompilerGenerated]
		private sealed class _003CScaleDown_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PunchSet _003C_003E4__this;

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
			public _003CScaleDown_003Ed__8(int _003C_003E1__state)
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
		private sealed class _003CThrowKnifes_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PunchSet _003C_003E4__this;

			private Vector3 _003CpunchStart_003E5__2;

			private Vector3 _003CpunchEnd_003E5__3;

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
			public _003CThrowKnifes_003Ed__4(int _003C_003E1__state)
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

		private List<DamagedEnemyModel> damagedEnemies;

		public GameObject bullet;

		public float knifeRange;

		public ParticleSystem particleFire;

		private bool onGround;

		private readonly Collider[] colGrounds;

		[IteratorStateMachine(typeof(_003CThrowKnifes_003Ed__4))]
		public IEnumerator ThrowKnifes(int i)
		{
			return null;
		}

		private bool CheckGround()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CScaleDown_003Ed__8))]
		private IEnumerator ScaleDown()
		{
			return null;
		}
	}

	private class DamagedEnemyModel
	{
		public float tempTimer;

		public GameObject enemy;

		public DamagedEnemyModel(float tempTimer, GameObject enemy)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CScaleDown_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GunPuncher _003C_003E4__this;

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
		public _003CScaleDown_003Ed__14(int _003C_003E1__state)
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
	private sealed class _003CStartGunInDelay_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GunPuncher _003C_003E4__this;

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
		public _003CStartGunInDelay_003Ed__13(int _003C_003E1__state)
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

	private static readonly int fireHash;

	public Animator animGun;

	public GameObject gunObje;

	public ParticleSystem fireParticle;

	public float rangeSpawnArea;

	public PunchSet[] knifes;

	public LayerMask maskGround;

	private readonly Collider[] checkedEnemies;

	public float dotFrequancy;

	public static GunPuncher Instance { get; private set; }

	private void Awake()
	{
	}

	public override void StartAbility()
	{
	}

	[IteratorStateMachine(typeof(_003CStartGunInDelay_003Ed__13))]
	private IEnumerator StartGunInDelay()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CScaleDown_003Ed__14))]
	public IEnumerator ScaleDown()
	{
		return null;
	}

	private Vector3 GetSpawnPoint()
	{
		return default;
	}

	private void CheckEnemyForPunches(Transform target, float range, List<DamagedEnemyModel> damagedEnemies)
	{
	}
}
