using System;
using System.Collections.Generic;
using Fubu.Inventory;
using UnityEngine;

public class PlayerCostumeController : MonoBehaviour
{
	[Serializable]
	public class ExtraItems
	{
		public GameObject[] itemObjects;

		public GameObject[] itemObjectsRight1;

		public GameObject[] itemObjectsLeft2;

		public GameObject[] itemObjectsRight3;

		public GameObject[] itemObjectsLeft4;

		private bool isItemActive;

		public void ActivateItems(bool isActive)
		{
		}

		public void CollectRenderers(List<Renderer> target)
		{
		}

		private static void CollectRenderers(GameObject[] objects, List<Renderer> target)
		{
		}

		private static void SetObjectsActive(GameObject[] objects, bool isActive)
		{
		}
	}

	[Serializable]
	public class ItemInfo
	{
		public ItemSlot Slot;

		public ExtraItems[] items;

		public bool hasFakeItem;

		public GameObject[] fakeItems;

		public void OpenItem(int id, ParticleSystem particleSystem, bool isStart)
		{
		}

		public void CloseItem(int id)
		{
		}
	}

	public ItemInfo[] ItemInfos;

	private readonly List<Renderer> activeCostumeRenderers;

	private readonly Dictionary<Renderer, Material[]> originalRendererMaterials;

	private PlayerBehaviour playerBehaviour;

	public ParticleSystem equipParticle;

	public ExtraItems gloveExtras;

	public GameObject[] extraArmRegularPunches;

	public GameObject[] regularPunches;

	public Material matRegular;

	public Material matGray;

	public void OpenItem(ItemSlot slot, int id, bool isStart)
	{
	}

	public void CloseItem(ItemSlot slot, int id)
	{
	}

	private void Awake()
	{
	}

	private void RefreshActiveCostumeRenderers()
	{
	}

	private void CollectRenderersFromPlayerArms(List<Renderer> target)
	{
	}

	private static void CollectRenderersFromObjects(GameObject[] objects, List<Renderer> target)
	{
	}

	private static Material[] BuildMaterialArray(Renderer renderer, Material targetMaterial)
	{
		return null;
	}

	public void SetMaterialsGray()
	{
	}

	public void SetMaterialsRegular()
	{
	}
}
