using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChestHeroDrop : MonoBehaviour
{
	public enum DropRarity
	{
		SR = 0,
		SSR = 1,
		UR = 2
	}

	public GameObject iconBG;

	public Image icon;

	public GameObject shardIconBG;

	public Image shardicon;

	public GameObject[] srObjects;

	public GameObject[] ssrObjects;

	public GameObject[] urObjects;

	public TextMeshProUGUI textAmount;

	public void LoadHero(Sprite heroIcon, int amount, DropRarity rarity, bool isShard)
	{
	}

	public void LoadCurrency(Sprite currencyIcon, int amount)
	{
	}

	public void Clear()
	{
	}

	private void SetAmount(int amount)
	{
	}

	private void SetRarityObjects(DropRarity rarity)
	{
	}

	private void SetObjectsActive(GameObject[] objects, bool isActive)
	{
	}

	private void SetImage(Image targetImage, Sprite sprite)
	{
	}

	private void SetActive(GameObject targetObject, bool isActive)
	{
	}
}
