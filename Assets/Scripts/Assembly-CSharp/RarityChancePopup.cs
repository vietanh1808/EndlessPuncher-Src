using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class RarityChancePopup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateLevelUp_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RarityChancePopup _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CAnimateLevelUp_003Ed__11(int _003C_003E1__state)
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

	[Header("Level")]
	[SerializeField]
	private TextMeshProUGUI currentLevelTxt;

	[SerializeField]
	private TextMeshProUGUI nextLevelTxt;

	[Header("Rarity Chance Frames")]
	[SerializeField]
	private RarityChanceFrame rarityChanceFramePrefab;

	[SerializeField]
	private Transform rarityChanceFramesContainer;

	private readonly List<RarityChanceFrame> rarityChanceFrames;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void InitializeRarityChanceFrames()
	{
	}

	private void SetLevelTexts()
	{
	}

	public void Show()
	{
	}

	public void LevelUp()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateLevelUp_003Ed__11))]
	private IEnumerator AnimateLevelUp()
	{
		return null;
	}

	public void Hide()
	{
	}
}
