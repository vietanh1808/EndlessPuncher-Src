using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Fubu.Forge
{
	public class Skill : MonoBehaviour
	{
		[Serializable]
		public class StatBar
		{
			[SerializeField]
			private StatType effectType;

			[SerializeField]
			private TextMeshProUGUI valueText;

			[SerializeField]
			private string prefix;

			[SerializeField]
			private string suffix;

			[SerializeField]
			private Slider slider;

			[SerializeField]
			private Animator barAnimator;

			private static readonly int IncreaseTrigger;

			private static readonly int DecreaseTrigger;

			private float value;

			public float Value => 0f;

			public StatType EffectType => StatType.Damage;

			public void SetText()
			{
			}

			public void SetText(float min, float max)
			{
			}

			public void AddValue(float amount)
			{
			}

			public void SetValue(float newValue)
			{
			}
		}

		[SerializeField]
		private StatBar[] statBars;

		public static Skill Instance { get; private set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void SetValues()
		{
		}

		private StatBar GetStatBar(StatType effectType)
		{
			return null;
		}

		public float GetValue(StatType effectType)
		{
			return 0f;
		}
	}
}
