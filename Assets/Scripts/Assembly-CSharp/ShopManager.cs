using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Purchasing;

public class ShopManager : PersistentSingleton<ShopManager>, IDetailedStoreListener, IStoreListener
{
	[Header("Products")]
	[Tooltip("Tüm satılabilir ürünler. Inspector'da elle eklenir.")]
	[SerializeField]
	private List<ShopProductDataSO> _products;

	[Header("Editor Settings")]
	[Tooltip("Editor'da Elephant ban check ve verify'ı atlayarak fake purchase yapar. Build'de etkisi yok.")]
	[SerializeField]
	private bool _bypassElephantInEditor;

	[Header("Debug")]
	[SerializeField]
	private bool _showDebugLogs;

	private IStoreController _storeController;

	private IExtensionProvider _extensionProvider;

	private bool _isInitialized;

	private bool _isPurchaseInProgress;

	private ShopProductDataSO _currentPurchaseProduct;

	private Vector3 _purchaseRewardSpawnPosition;

	private bool _purchaseRewardSpawnPositionIsUI;

	private bool _hasPurchaseRewardSpawnPosition;

	private readonly HashSet<string> _transactionsBeingVerified;

	private Dictionary<string, ShopProductDataSO> _productLookup;

	[CompilerGenerated]
	private Action m_OnShopInitialized;

	[CompilerGenerated]
	private Action m_OnShopInitializationFailed;

	[CompilerGenerated]
	private Action<ShopProductDataSO> m_OnShopPurchaseSuccess;

	[CompilerGenerated]
	private Action<ShopProductDataSO, string> m_OnShopPurchaseFailed;

	[CompilerGenerated]
	private Action<bool> m_OnShopNoAdsStatusChanged;

	public bool IsInitialized => false;

	public bool IsPurchaseInProgress => false;

	public bool IsNoAdsActive => false;

	public bool IsWeeklyAddActive => false;

	public IReadOnlyList<ShopProductDataSO> Products => null;

	public event Action OnShopInitialized
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnShopInitializationFailed
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<ShopProductDataSO> OnShopPurchaseSuccess
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<ShopProductDataSO, string> OnShopPurchaseFailed
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<bool> OnShopNoAdsStatusChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void BuildProductLookup()
	{
	}

	private void InitializePurchasing()
	{
	}

	public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
	}

	public void OnInitializeFailed(InitializationFailureReason error)
	{
	}

	public void OnInitializeFailed(InitializationFailureReason error, string message)
	{
	}

	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
	{
		return PurchaseProcessingResult.Complete;
	}

	private bool HasProcessedTransaction(string transactionId)
	{
		return false;
	}

	private void MarkTransactionProcessed(string transactionId, string productId)
	{
	}

	private void RemoveTransactionFromVerification(string transactionId)
	{
	}

	public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
	{
	}

	public void OnPurchaseFailed(Product product, PurchaseFailureDescription failureDescription)
	{
	}

	public void TryPurchase(ShopProductDataSO product)
	{
	}

	public void TryPurchase(ShopProductDataSO product, Vector3 rewardSpawnPosition, bool rewardSpawnPositionIsUI)
	{
	}

	private void TryPurchase(ShopProductDataSO product, Vector3 rewardSpawnPosition, bool rewardSpawnPositionIsUI, bool hasRewardSpawnPosition)
	{
	}

	public void RestorePurchases()
	{
	}

	private int ProcessRestoredPurchases()
	{
		return 0;
	}

	private void HandleRestoreResult(int restoredCount)
	{
	}

	public string GetLocalizedPrice(ShopProductDataSO product)
	{
		return null;
	}

	public double GetAnalyticsPriceUsd(ShopProductDataSO product)
	{
		return 0.0;
	}

	public string GetLocalizedTitle(ShopProductDataSO product)
	{
		return null;
	}

	public ShopProductDataSO GetProductByType(ShopProductType type)
	{
		return null;
	}

	public ShopProductDataSO GetProductById(string productId)
	{
		return null;
	}

	private void InitiatePurchase(ShopProductDataSO product)
	{
	}

	private string GetAppleJwsRepresentation(Product product)
	{
		return null;
	}

	private void VerifyWithElephant(Product unityProduct, ShopProductDataSO productData, Action<bool> onComplete)
	{
	}

	private void ConfirmPendingPurchase(string productId)
	{
	}

	private void HandlePurchaseReward(ShopProductDataSO product)
	{
	}

	private void ActivateNoAds()
	{
	}

	private void ActivateWeeklyAds()
	{
	}

	private void ActivateEventPass()
	{
	}

	private void GrantEnergy(int amount)
	{
	}

	private void GrantGem(int amount)
	{
	}

	private Vector3 GetPurchaseRewardSpawnPosition()
	{
		return default;
	}

	private bool IsPurchaseRewardSpawnPositionUI()
	{
		return false;
	}

	private void FinalizePurchase(ShopProductDataSO product, bool success, string failureReason = null)
	{
	}

	private void RefreshNonConsumableState()
	{
	}

	private bool IsSavedNoAdsActive()
	{
		return false;
	}

	private bool HasNoAdsReceipt()
	{
		return false;
	}

	private bool ShouldBypassElephant()
	{
		return false;
	}

	private void ShowToast(string message, toastType type)
	{
	}

	private void Log(string message)
	{
	}
}
