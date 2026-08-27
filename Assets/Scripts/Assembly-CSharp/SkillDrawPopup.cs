using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillDrawPopup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateCollectOne_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillDrawPopup _003C_003E4__this;

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
		public _003CAnimateCollectOne_003Ed__17(int _003C_003E1__state)
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
	private sealed class _003CAnimateDrawCards_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillDrawPopup _003C_003E4__this;

		private List<DrawSkillCard>.Enumerator _003C_003E7__wrap1;

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
		public _003CAnimateDrawCards_003Ed__16(int _003C_003E1__state)
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

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private Transform skillCardContainer;

	[SerializeField]
	private DrawSkillCard drawSkillCardPrefab;

	private readonly List<DrawSkillCard> drawnCards;

	private Coroutine animateDrawCardsRoutine;

	[Header("Level")]
	[SerializeField]
	private TextMeshProUGUI levelTxt;

	[SerializeField]
	private Slider levelSlider;

	[SerializeField]
	private TextMeshProUGUI cardCountTxt;

	private int displayLevel;

	private int displayCount;

	private int displayNeed;

	public bool IsShowing => false;

	public void DrawCards(int count)
	{
	}

	public void Clear()
	{
	}

	public void Hide()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateDrawCards_003Ed__16))]
	private IEnumerator AnimateDrawCards()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAnimateCollectOne_003Ed__17))]
	private IEnumerator AnimateCollectOne()
	{
		return null;
	}

	private Tween TweenSlider(float target)
	{
		return null;
	}

	private void SyncUI()
	{
	}
}
