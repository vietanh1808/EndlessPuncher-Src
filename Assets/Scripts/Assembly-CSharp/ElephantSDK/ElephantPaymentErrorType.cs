namespace ElephantSDK
{
	public enum ElephantPaymentErrorType
	{
		Unknown = 0,
		ProductsFetchFailed = 1,
		StartCheckoutFailed = 2,
		NoEscrowCode = 3,
		PendingCheckFailed = 4,
		ConfirmPurchaseInvalidTransaction = 5,
		ConfirmPurchaseBackendFailed = 6
	}
}
