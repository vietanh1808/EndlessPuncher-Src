using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace PolygonArsenal
{
	public class PolygonFireProjectile : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CShoot_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PolygonFireProjectile _003C_003E4__this;

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
			public _003CShoot_003Ed__16(int _003C_003E1__state)
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

		public GameObject[] projectiles;

		[Header("GUI Links")]
		public Text missileNameText;

		public Toggle fullAutoButton;

		public Slider speedSlider;

		[Header("Projectile Settings")]
		public Transform spawnPosition;

		[HideInInspector]
		public int currentProjectile;

		public float speed;

		public float spawnOffset;

		[Header("Firing Settings")]
		public float fireRate;

		public bool isFullAuto;

		[Header("Gun Settings")]
		public GameObject gunPrefab;

		public float gunOffset;

		private bool canShoot;

		private GameObject instantiatedGun;

		private void Start()
		{
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CShoot_003Ed__16))]
		private IEnumerator Shoot()
		{
			return null;
		}

		private void ShootProjectile()
		{
		}

		private void UpdateGunPositionAndRotation()
		{
		}

		public void nextEffect()
		{
		}

		public void previousEffect()
		{
		}

		private void UpdateDisplayName()
		{
		}

		private void OnSpeedSliderChanged(float value)
		{
		}
	}
}
