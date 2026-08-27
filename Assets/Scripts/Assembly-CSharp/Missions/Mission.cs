using System;
using Missions.Reflection;
using UnityEngine;

namespace Missions
{
	public class Mission : MissionBase
	{
		[Serializable]
		public class Condition
		{
			public enum CompareType
			{
				Equal = 0,
				NotEqual = 1,
				Greater = 2,
				Less = 3,
				GreaterOrEqual = 4,
				LessOrEqual = 5
			}

			[Tooltip("If true, the condition will be compared to a value. If false, the condition will be a boolean.")]
			public bool comparison;

			[Tooltip("The type of comparison to be made.")]
			public CompareType compareType;

			[Tooltip("The control method.")]
			public MethodCatcher boolMethod;

			[Tooltip("The method to compare.")]
			public MethodCatcher compMethod;

			[Tooltip("If true, the comparison will be made to a variable. If false, the comparison will be made to a constant value.")]
			public bool compareToVariable;

			[Tooltip("The value to compare to.")]
			public double constantValue;

			[Tooltip("The variable to compare to.")]
			public MethodCatcher varMethod;

			[HideInInspector]
			public bool isDone;

			private object calculatedComp;

			private object calculatedValue;

			public float Progress => 0f;

			public float Target => 0f;

			public bool Check()
			{
				return false;
			}
		}

		[SerializeField]
		private Condition[] conditions;

		private float progress;

		private float target;

		public override float MissionRatio => 0f;

		public override string MissionRatioStr => null;

		public override bool IsCompleted()
		{
			return false;
		}

		public override void Init()
		{
		}
	}
}
