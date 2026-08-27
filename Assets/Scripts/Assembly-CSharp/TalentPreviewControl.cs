using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TalentPreviewControl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDelayHolderResize_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentPreviewControl _003C_003E4__this;

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
		public _003CDelayHolderResize_003Ed__12(int _003C_003E1__state)
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

	private readonly int comeHash;

	private readonly int goHash;

	[SerializeField]
	private Animator animPanel;

	private List<TalentUiPreviewPoint> allTalentsUI;

	[SerializeField]
	private TalentUiPreviewPoint talentuiPrefab;

	[SerializeField]
	private Transform holderUiobje;

	[SerializeField]
	private Slider slider;

	[SerializeField]
	private Color selectedColor;

	[SerializeField]
	private TextMeshProUGUI[] namesStage;

	private RectTransform rct;

	private List<int> sizeTalentStageLevels;

	private int _totalCheckPoint;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayHolderResize_003Ed__12))]
	private IEnumerator DelayHolderResize()
	{
		return null;
	}

	private void CheckNameColors()
	{
	}

	private void SetSlider()
	{
	}

	public void LoadPanel()
	{
	}

	public void ClosePanel()
	{
	}

	private void SetCurrentPos()
	{
	}
}
