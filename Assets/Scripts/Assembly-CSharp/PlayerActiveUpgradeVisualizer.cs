using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PlayerActiveUpgradeVisualizer : MonoBehaviour
{
	[Serializable]
	public class Visualizer
	{
		[CompilerGenerated]
		private sealed class _003CCounterActive_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float tt;

			public Visualizer _003C_003E4__this;

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
			public _003CCounterActive_003Ed__8(int _003C_003E1__state)
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

		public Coroutine corVisul;

		public bool isActive;

		public ActiveUpgradesType typActiveUpgrade;

		public Animator icon;

		public Image imageicon;

		public void ActivateIcon()
		{
		}

		public void DeActivateIcon()
		{
		}

		public void ActivateInTime(MonoBehaviour mb, float timer)
		{
		}

		[IteratorStateMachine(typeof(_003CCounterActive_003Ed__8))]
		private IEnumerator CounterActive(float tt)
		{
			return null;
		}
	}

	private static PlayerActiveUpgradeVisualizer _instance;

	public List<Visualizer> visualizerControl;

	public static PlayerActiveUpgradeVisualizer Instance => null;

	private void Awake()
	{
	}

	public void ActivateEffect(ActiveUpgradesType type, bool isActive)
	{
	}

	public void ActivateEffect(ActiveUpgradesType type, float timeToDeactiveIt)
	{
	}

	private void Start()
	{
	}
}
