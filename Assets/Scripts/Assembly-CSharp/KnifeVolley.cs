using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KnifeVolley : SkillBehaviour
{
	[Serializable]
	public class KnifeSet
	{
		[CompilerGenerated]
		private sealed class _003CScaleDown_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public KnifeSet _003C_003E4__this;

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
			public _003CScaleDown_003Ed__6(int _003C_003E1__state)
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
		private sealed class _003CThrowKnifes_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public KnifeSet _003C_003E4__this;

			public int i;

			private Vector3 _003CpunchStart_003E5__2;

			private Vector3 _003CpunchEnd_003E5__3;

			private float _003Ct_003E5__4;

			private bool _003CisScaledDown_003E5__5;

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
			public _003CThrowKnifes_003Ed__5(int _003C_003E1__state)
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

		internal readonly Collider[] enemyColliderBuffer;

		internal readonly HashSet<int> damagedEnemyIds;

		public GameObject knife;

		public float knifeRange;

		private TrailRenderer trailRenderer;

		[IteratorStateMachine(typeof(_003CThrowKnifes_003Ed__5))]
		public IEnumerator ThrowKnifes(int i)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CScaleDown_003Ed__6))]
		private IEnumerator ScaleDown()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CStartKnifesInDelay_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KnifeVolley _003C_003E4__this;

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
		public _003CStartKnifesInDelay_003Ed__10(int _003C_003E1__state)
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

	public float rangeSpawnArea;

	public float rangePunchHit;

	public KnifeSet[] knifes;

	public float dotFrequancy;

	public static KnifeVolley Instance { get; private set; }

	private void Awake()
	{
	}

	public override void StartAbility()
	{
	}

	[IteratorStateMachine(typeof(_003CStartKnifesInDelay_003Ed__10))]
	private IEnumerator StartKnifesInDelay()
	{
		return null;
	}

	private Vector3 GetSpawnPoint()
	{
		return default;
	}

	private void CheckEnemyForKnife(Transform target, float range, KnifeSet knifeSet)
	{
	}
}
