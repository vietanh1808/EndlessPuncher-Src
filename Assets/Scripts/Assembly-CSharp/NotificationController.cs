using UnityEngine;

public class NotificationController : MonoBehaviour
{
	[Header("References")]
	[SerializeField]
	private GameObject notificationDot;

	[Header("Settings")]
	[SerializeField]
	private CurrencyTypes currencyType;

	public long requiredAmount;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void CheckAffordability()
	{
	}

	public void UpdateRequiredAmount(long newAmount)
	{
	}
}
