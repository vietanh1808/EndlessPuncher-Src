using System;
using UnityEngine;

namespace Fubu.Essentials
{
	public class EnergyHandler : MonoBehaviour, ISaveable
	{
		public Action OnEnergyChange;

		public Action<int> OnEnergyUsed;

		private EnergyFrame energyFrame;

		[Header("Settings")]
		[SerializeField]
		private int maxEnergy;

		[SerializeField]
		private int maxEnergyWeekly;

		[Tooltip("Energy restored per regen cycle")]
		[SerializeField]
		private int regenAmount;

		[Tooltip("Time between regen cycles (seconds)")]
		[SerializeField]
		private float regenInterval;

		private static EnergyHandler instance;

		public int MaxEnergy => 0;

		public int Energy { get; private set; }

		public DateTime LastRegenDate { get; private set; }

		public static EnergyHandler GetInstance()
		{
			return null;
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void LoadRemoteConfig()
		{
		}

		public bool UseEnergy(int amount = 1)
		{
			return false;
		}

		public void AddEnergy(int amount = 1)
		{
		}

		private void ChangeEnergy(int amount)
		{
		}

		public void ShowEnergyUI()
		{
		}

		public void HideEnergyUI()
		{
		}

		private void TryRegen()
		{
		}

		private void UpdateUI()
		{
		}

		private string FormatTime(float seconds)
		{
			return null;
		}

		private void SaveLastRegenTime(DateTime time)
		{
		}

		public void OnLoad(SaveData data)
		{
		}

		public void OnSave(SaveData data)
		{
		}

		private bool IsWeeklyEnergyActive()
		{
			return false;
		}
	}
}
