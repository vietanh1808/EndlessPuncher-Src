using System;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

namespace FOW
{
	public sealed class AsyncFogTextureReader : IDisposable
	{
		public bool HasData;

		public HiderRevealer HiderSeeker;

		public float HiderSeeingThreshold;

		private NativeArray<half> _front;

		private NativeArray<half> _back;

		private int _w;

		private int _h;

		private bool _requestPending;

		private AsyncGPUReadbackRequest _request;

		public void Update(RenderTexture rt)
		{
		}

		public void SeekHiders()
		{
		}

		private bool CanSeeHider(FogOfWarHider hider)
		{
			return false;
		}

		public half SampleAsyncData(float2 uv)
		{
			return default;
		}

		private void Resize(int w, int h)
		{
		}

		public void UnseeAllHiders()
		{
		}

		public void Dispose()
		{
		}
	}
}
