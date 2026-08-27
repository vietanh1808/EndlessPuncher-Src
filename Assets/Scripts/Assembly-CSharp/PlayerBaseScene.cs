using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerBaseScene : MonoBehaviour
{
	[Serializable]
	public class AttackArmConf
	{
		public Vector3 targetPosa;

		public Animator animArm;

		public GameObject[] armObje;

		public PlayerArm arm;

		public bool isAttackActive;

		public Func<float, float>? xFunc;
	}

	private enum PlayerSections
	{
		boxing = 0,
		bored = 1,
		pushUp = 2,
		warmUp = 3
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public float f;

		public float yDiff;

		internal float _003CSetTargetEnum_003Eb__0(float x)
		{
			return 0f;
		}
	}

	[CompilerGenerated]
	private sealed class _003CSetTargetEnum_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AttackArmConf arc;

		public PlayerBaseScene _003C_003E4__this;

		private _003C_003Ec__DisplayClass25_0 _003C_003E8__1;

		public Transform targetPosition;

		private float _003CfastSpeed_003E5__2;

		private Vector3 _003CstartPos_003E5__3;

		private float _003Ct_003E5__4;

		private float _003CarmScaleTime_003E5__5;

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
		public _003CSetTargetEnum_003Ed__25(int _003C_003E1__state)
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

	public List<AttackArmConf> allAttackArmConfs;

	public PlayerArm[] arms;

	public Transform target;

	public TrainingBag trainingBag;

	public bool CanAtack;

	public bool isRingCharacter;

	public Animator animator;

	public Transform[] targetPos;

	private InGameUI gameUI;

	private PlayerSections sections;

	private float _timerAttack;

	private bool _isRightPunch;

	public float punchAnimDelay;

	public AnimationCurve targetMoveCurve;

	private static readonly int attackSpeedHash;

	private static readonly int attackHash;

	private static readonly int isLeftHash;

	public PlayerArm selectedArm;

	private int BoneCount => 0;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private void Update()
	{
	}

	private void CheckAttack()
	{
	}

	[IteratorStateMachine(typeof(_003CSetTargetEnum_003Ed__25))]
	private IEnumerator SetTargetEnum(Transform targetPosition, AttackArmConf arc)
	{
		return null;
	}
}
