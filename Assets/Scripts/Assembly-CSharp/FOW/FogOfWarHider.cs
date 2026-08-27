using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;

namespace FOW
{
	public class FogOfWarHider : MonoBehaviour
	{
		public delegate void OnChangeActive(bool isActive);

		[Tooltip("Leaving this empty will make the hider use its own transform as a sample point.")]
		[FormerlySerializedAs("samplePoints")]
		public Transform[] SamplePoints;

		[Tooltip("If Enabled, the hider will never be hidden again after being revealed once.")]
		public bool PermanentlyReveal;

		private float maxSamplePointLocalPosition;

		private int numObservers;

		private List<HiderRevealer> observers;

		private Transform cachedTransform;

		private float2 cachedPosition;

		private bool IsRegistered;

		[NonSerialized]
		public int HiderArrayPosition;

		[NonSerialized]
		public int HiderPermanantID;

		[NonSerialized]
		public List<int> SpatialHashBuckets;

		[NonSerialized]
		public int2 MinBucket;

		[NonSerialized]
		public int2 MaxBucket;

		[CompilerGenerated]
		private OnChangeActive m_OnActiveChanged;

		public float MaxSamplePointLocalPosition => 0f;

		public int NumObservers => 0;

		public List<HiderRevealer> CurrentObservers => null;

		public Transform CachedTransform => null;

		public float2 CachedPosition => default;

		public event OnChangeActive OnActiveChanged
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void CalculateSamplePointData()
		{
		}

		public void RegisterHider()
		{
		}

		public void DeregisterHider()
		{
		}

		public void AddObserver(HiderRevealer Observer)
		{
		}

		public void RemoveObserver(HiderRevealer Observer)
		{
		}

		private void SetActive(bool isActive)
		{
		}

		public void UpdateBuckets()
		{
		}
	}
}
