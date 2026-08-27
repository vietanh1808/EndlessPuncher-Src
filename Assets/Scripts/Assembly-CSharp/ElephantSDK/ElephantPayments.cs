using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ElephantSDK
{
	public static class ElephantPayments
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass34_0
		{
			public bool isComplete;

			internal void _003CPollForPendingPayments_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CPollForPendingPayments_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private _003C_003Ec__DisplayClass34_0 _003C_003E8__1;

			private int _003CmaxAttempts_003E5__2;

			private float _003CmaxInterval_003E5__3;

			private float _003Ctimeout_003E5__4;

			private int _003CinitialCount_003E5__5;

			private float _003CcurrentInterval_003E5__6;

			private int _003Ci_003E5__7;

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
			public _003CPollForPendingPayments_003Ed__34(int _003C_003E1__state)
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

		public static Action<List<ElephantProduct>> OnProductsFetched;

		public static Action<ElephantPayment> OnPaymentPending;

		public static Action<ElephantPaymentsError> OnError;

		public static Action OnPaymentDialogueClosed;

		private static bool _isPurchaseFlowActive;

		private static Coroutine _activePollingCoroutine;

		private static bool _isTestMode;

		private static bool _isInitialized;

		private static bool _isCheckingPurchases;

		private static bool _hasLoggedCheckingEvent;

		private static HashSet<string> _confirmationQueue;

		private static HashSet<string> _activeConfirmations;

		private static HashSet<string> _knownPendingTransactionIds;

		private static Dictionary<string, ElephantPayment> _pendingPaymentInfo;

		private static HashSet<string> _notifiedPendingThisSession;

		private const string PlayerPrefsQueueKey = "ELEPHANT_CONFIRM_QUEUE";

		private const string EVENT_ESCROW_STARTED = "elephant_ds_escrow_started";

		private const string EVENT_ESCROW_COMPLETED = "elephant_ds_escrow_completed";

		private const string EVENT_ESCROW_FAILED = "elephant_ds_escrow_failed";

		private const string EVENT_CHECKOUT_STARTED = "elephant_ds_checkout_started";

		private const string EVENT_CHECKOUT_COMPLETED = "elephant_ds_checkout_completed";

		private const string EVENT_PAYMENT_CHECKING = "elephant_ds_payment_checking";

		private const string EVENT_PAYMENT_PENDING = "elephant_ds_payment_pending";

		private const string EVENT_PAYMENT_COMPLETED = "elephant_ds_payment_completed";

		private const string EVENT_PRODUCT_FETCHING = "elephant_ds_product_fetching";

		private const string EVENT_PRODUCT_FETCHED = "elephant_ds_product_fetched";

		public static void Initialize(Action<List<ElephantProduct>> onProductsFetched, Action<ElephantPayment> onPaymentPending, Action<ElephantPaymentsError> onError)
		{
		}

		public static void FetchProducts()
		{
		}

		public static void PurchaseWeb(string productId, Action onPaymentDialogueClosed = null)
		{
		}

		public static void CheckForPendingPurchases()
		{
		}

		public static void ConfirmPurchase(ElephantPayment payment)
		{
		}

		private static void OnAppFocus()
		{
		}

		private static void OnWebViewClosed(string reason)
		{
		}

		private static void StartPollingIfNeeded()
		{
		}

		[IteratorStateMachine(typeof(_003CPollForPendingPayments_003Ed__34))]
		private static IEnumerator PollForPendingPayments()
		{
			return null;
		}

		private static void CheckPendingPayments(float? timeout = null, Action onComplete = null)
		{
		}

		private static void OnPendingPurchasesReceived(GenericResponse<List<ElephantPayment>> response)
		{
		}

		private static void ProcessConfirmationQueue()
		{
		}

		private static IEnumerator NotifyPurchaseClaimed(string transactionId, Action onSuccess, Action<string> onError)
		{
			return null;
		}

		private static void SaveConfirmationQueue()
		{
		}

		private static void LoadConfirmationQueue()
		{
		}

		private static string BuildCheckoutUrl(string escrowCode, long expiry, bool useWebView)
		{
			return null;
		}

		private static void RaiseError(ElephantPaymentErrorType type, string message, string rawError = null, string productId = null, string transactionId = null)
		{
		}
	}
}
