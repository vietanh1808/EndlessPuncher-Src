using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-100)]
public class SaveManager : MonoBehaviour
{
	[Header("Settings")]
	[SerializeField]
	private string fileName;

	[SerializeField]
	private string encryptionKey;

	[SerializeField]
	private bool showDebugLogs;

	private SaveData saveData;

	private List<ISaveable> saveableObjects;

	private bool saveDeletedForShutdown;

	public static SaveManager Instance { get; private set; }

	public SaveData Data => null;

	private void Awake()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	private void OnApplicationQuit()
	{
	}

	public void Register(ISaveable saveable)
	{
	}

	public void Unregister(ISaveable saveable)
	{
	}

	public void ForceSave()
	{
	}

	public void SaveGame()
	{
	}

	public void LoadGame()
	{
	}

	private void EnsureRequiredSaveSections()
	{
	}

	public int GetHeroStage()
	{
		return 0;
	}

	public void SetHeroStage(int heroStage, bool saveImmediately = true)
	{
	}

	public HeroProgressData GetHeroProgressData(string heroId)
	{
		return null;
	}

	public HeroProgressData GetOrCreateHeroProgressData(string heroId, bool saveImmediately = false)
	{
		return null;
	}

	public CollectibleSaveData GetCollectibleSaveData(string collectibleId)
	{
		return null;
	}

	public CollectibleSaveData GetOrCreateCollectibleSaveData(string collectibleId)
	{
		return null;
	}

	public int GetCollectibleLevelStar(string collectibleId)
	{
		return 0;
	}

	public int GetCollectiblePieces(string collectibleId)
	{
		return 0;
	}

	public bool IsCollectibleActivated(string collectibleId)
	{
		return false;
	}

	public void SetCollectibleActivated(string collectibleId, bool isActivated, bool saveImmediately = true)
	{
	}

	public void SetCollectibleProgress(string collectibleId, int levelStar, int pieces, bool saveImmediately = true)
	{
	}

	public CollectibleSaveData AddCollectiblePieces(CollectiblesSO.CollectibleData collectibleData, int amount, bool saveImmediately = true)
	{
		return null;
	}

	public void DeleteSaveData()
	{
	}

	private string GetPath()
	{
		return null;
	}

	private string Encrypt(string text)
	{
		return null;
	}

	private string Decrypt(string text)
	{
		return null;
	}
}
