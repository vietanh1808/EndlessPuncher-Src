using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class StarLevelManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAwardStarsRoutine_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StarLevelManager _003C_003E4__this;

		public Vector3 startPos;

		public int amount;

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
		public _003CAwardStarsRoutine_003Ed__22(int _003C_003E1__state)
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

	[Header("UI References")]
	[SerializeField]
	private Canvas canvas;

	[SerializeField]
	private Camera canvasCam;

	[SerializeField]
	private TextMeshProUGUI starCounterText;

	[SerializeField]
	private RectTransform targetPosition;

	[SerializeField]
	private GameObject starPrefab;

	[SerializeField]
	private Transform animationParent;

	[Header("Animation Settings")]
	[SerializeField]
	private float moveDuration;

	[SerializeField]
	private float arcHeight;

	[SerializeField]
	private float targetPopScale;

	[SerializeField]
	private float popDuration;

	[SerializeField]
	private float startPopScale;

	[SerializeField]
	private float startPopDuration;

	private const string STARS_PREFS_KEY = "TotalPlayerStars";

	private int totalStars;

	private Vector3 originalTargetScale;

	public static StarLevelManager Instance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void AwardStars(Vector3 startScreenPosition, int amount)
	{
	}

	[IteratorStateMachine(typeof(_003CAwardStarsRoutine_003Ed__22))]
	private IEnumerator AwardStarsRoutine(Vector3 startPos, int amount)
	{
		return null;
	}

	private void AnimateStar(Vector3 startPos)
	{
	}

	private void PopTargetAnimation()
	{
	}

	private void AddStar(int amount, bool updateUI)
	{
	}

	private void UpdateStarCounterUI()
	{
	}

	private void SaveStars()
	{
	}

	private void LoadStars()
	{
	}
}
