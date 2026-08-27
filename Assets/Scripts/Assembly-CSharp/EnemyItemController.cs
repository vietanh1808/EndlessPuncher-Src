using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemyItemController : MonoBehaviour
{
	[Serializable]
	public class EnemyExtraItem
	{
		public GameObject[] items;

		public GameObject[] regularItems1;

		public GameObject[] regularItems2;

		public GameObject[] tdItems;

		public GameObject[] grayItems;

		public void DeactivateAll()
		{
		}
	}

	public bool IsPowerfullEnemy;

	public List<EnemyExtraItem> extraGloves;

	public List<EnemyExtraItem> extraHelmets;

	public SkinnedMeshRenderer renderRegular;

	public SkinnedMeshRenderer renderRegular1;

	public SkinnedMeshRenderer renderRegular2;

	public Material[] matsRegular;

	public Material[] matsRegular1;

	public Material[] matsRegular2;

	private int selectedGloveId;

	private int selectedHelmetId;

	private static void SetPrimarySharedMaterial(SkinnedMeshRenderer renderer, Material material)
	{
	}

	public void SetItems()
	{
	}

	public void LoadRegular()
	{
	}

	public void LoadRegular1()
	{
	}

	public void LoadRegular2()
	{
	}

	public void LoadTD()
	{
	}

	public void LoadGray()
	{
	}
}
