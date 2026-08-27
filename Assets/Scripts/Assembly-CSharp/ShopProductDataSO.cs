using UnityEngine;
using UnityEngine.Purchasing;

[CreateAssetMenu(fileName = "New Shop Product", menuName = "Fubu/Shop/Product Data")]
public class ShopProductDataSO : ScriptableObject
{
	[Header("Identity")]
	[Tooltip("Store'da tanımlanan product ID. iOS ve Android'de aynı olmalı.")]
	[SerializeField]
	private string _productId;

	[SerializeField]
	private ShopProductType _productType;

	[SerializeField]
	private ShopProductCategory _category;

	[Header("Reward")]
	[Tooltip("Energy paketleri için verilecek energy miktarı. NoAds için kullanılmaz.")]
	[SerializeField]
	private int _rewardAmount;

	[Header("Pricing")]
	[Tooltip("Store metadata fiyatı alınamazsa verify request ve analytics için kullanılan fallback USD fiyat.")]
	[SerializeField]
	private float _originalPriceUSD;

	[Header("Display Info (Fallback)")]
	[Tooltip("Store'dan localized fiyat alınamazsa gösterilecek fallback fiyat. UI içindir.")]
	[SerializeField]
	private string _fallbackPriceText;

	[Tooltip("Store'dan localized title alınamazsa gösterilecek fallback isim.")]
	[SerializeField]
	private string _fallbackDisplayName;

	[SerializeField]
	private Sprite _icon;

	public string ProductId => null;

	public ShopProductType ProductType => ShopProductType.NoAds;

	public ShopProductCategory Category => ShopProductCategory.Consumable;

	public int RewardAmount => 0;

	public float OriginalPriceUSD => 0f;

	public string FallbackPriceText => null;

	public string FallbackDisplayName => null;

	public Sprite Icon => null;

	public void ApplyRemotePriceUSD(float priceUsd, string fallbackPriceText = null)
	{
	}

	private static string FormatUsdPrice(float priceUsd)
	{
		return null;
	}

	public ProductType ToUnityProductType()
	{
		return UnityEngine.Purchasing.ProductType.Consumable;
	}
}
