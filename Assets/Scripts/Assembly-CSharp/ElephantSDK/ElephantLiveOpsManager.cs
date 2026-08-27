using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ElephantSDK
{
	public class ElephantLiveOpsManager : ILiveOpsElephantAdapter, IElephantAdapter
	{
		[CompilerGenerated]
		private sealed class _003CDownloadTextureCoroutine_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string url;

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
			public _003CDownloadTextureCoroutine_003Ed__7(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CWaitForAllDownloads_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ElephantLiveOpsManager _003C_003E4__this;

			private List<Coroutine>.Enumerator _003C_003E7__wrap1;

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
			public _003CWaitForAllDownloads_003Ed__9(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private bool isOfferAssetsReady;

		private bool isOfferProductsReady;

		private List<Coroutine> _activeDownloads;

		public Offer GetCurrentOfferResponse()
		{
			return null;
		}

		public void RetrieveOfferAssetUrls()
		{
		}

		private void DownloadAndCacheOfferAssets(OfferUiUrls offerUiUrls)
		{
		}

		private void DownloadTexture(string url)
		{
		}

		[IteratorStateMachine(typeof(_003CDownloadTextureCoroutine_003Ed__7))]
		private IEnumerator DownloadTextureCoroutine(string url)
		{
			return null;
		}

		public void OfferGenerateRequest(OfferMetaData offerMetaData, Action<OfferData> callback)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitForAllDownloads_003Ed__9))]
		private IEnumerator WaitForAllDownloads()
		{
			return null;
		}

		private void CleanupUnusedAssets(List<string> currentUrls)
		{
		}

		private void DeleteAllAssets()
		{
		}

		private void AddOfferUIManager()
		{
		}

		public void ReceiveLocalizedPrice(string concatenatedPrices)
		{
		}
	}
}
