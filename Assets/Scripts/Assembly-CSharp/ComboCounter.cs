using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fubu.Inventory.DB;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ComboCounter : MonoBehaviour
{
	[Serializable]
	public class ComboMeterKillSteps
	{
		public int id;

		public int needKill;

		public float waitTimeToReset;

		public float timeToRefillPerEnemy;
	}

	[Serializable]
	public class PrizeAndPosition
	{
		public Vector3 pos;

		public GameObject prizeObje;

		public PrizeAndPosition(GameObject prizeObje, Vector3 pos)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CSpawnPRizzeCheckIsGameStopped_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ComboCounter _003C_003E4__this;

		public int comboMultiplier;

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
		public _003CSpawnPRizzeCheckIsGameStopped_003Ed__57(int _003C_003E1__state)
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

	private const bool ComboSystemEnabled = false;

	private static ComboCounter _instance;

	public List<ComboMeterKillSteps> comboMeterSteps;

	private int _comboMeterIDInGame;

	private int _comboMeterID;

	private int _comboNeedKillCount;

	private float _comboWaitTimeToReset;

	private float _comboWaitTimeToResetInGame;

	private float _comboTimeToRefillPerEnemy;

	private float _comboTimeToRefillPerEnemyInGame;

	private PlayerBehaviour pb;

	private int _ingameComboKillCount;

	private bool _isSpawnPrizeRoutineRunning;

	private float _valueTalentComboHunter;

	private float _fillValue;

	private float _fillValueScale;

	[SerializeField]
	private Animator animComboX;

	[SerializeField]
	private Animator animComboPanel;

	[SerializeField]
	private TextMeshProUGUI textComboMultiplier;

	[SerializeField]
	private TextMeshProUGUI textComboSliderKill;

	[SerializeField]
	private Slider comboSlider;

	[SerializeField]
	private ParticleSystem[] hitParticles;

	[SerializeField]
	private ParticleSystem[] fireLoopParticles;

	[SerializeField]
	private Image sliderFillBar;

	[SerializeField]
	private Color startColor;

	[SerializeField]
	private Color endColor;

	private bool _comboDrainSlowerIsActive;

	private float _comboDrainSlowerSpeed;

	private ItemsBonusInGame itemBonus;

	private bool _isGameStopped;

	private bool _comboIsWorking;

	private bool _isPanelActive;

	private float _sliderStepValueBtwnKills;

	public GameObject prize;

	public GameObject prizePunchBox;

	public List<PrizeAndPosition> createdComboPoses;

	private Coroutine _spawnPrizeRoutine;

	public static ComboCounter Instance => null;

	public int GetCurrentComboMultiplier => 0;

	private void GetComboMeterSteps()
	{
	}

	private void PlayComboParticle()
	{
	}

	private void Start()
	{
	}

	private void CheckIsStopped()
	{
	}

	private void ComboDrainCheck()
	{
	}

	public void AddCombo()
	{
	}

	private void DelayGetComboSteps()
	{
	}

	private void RemoveCombo()
	{
	}

	private void KillCounterText()
	{
	}

	private void SetComboMeterText()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void SpawnPrize(int comboMultiplier)
	{
	}

	public void RemovePrizeInList(GameObject prize)
	{
	}

	[IteratorStateMachine(typeof(_003CSpawnPRizzeCheckIsGameStopped_003Ed__57))]
	private IEnumerator SpawnPRizzeCheckIsGameStopped(int comboMultiplier)
	{
		return null;
	}

	private void OnDisable()
	{
	}

	public void ResetForNewRun()
	{
	}

	private void ApplyDisabledState()
	{
	}

	private Vector3 GetSpawnPoint()
	{
		return default;
	}

	private bool IsComboPosActive(Vector3 pp)
	{
		return false;
	}
}
