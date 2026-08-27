using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HeroInfoPanel : MonoBehaviour, ITabPanel
{
	[Serializable]
	private class HeroInfoTabBinding
	{
		public HeroInfoTab tab;

		public Button button;

		public Animator animator;

		public GameObject contentRoot;

		public void Select()
		{
		}

		public void PlaySelectionAnimation(bool isSelected)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CHidePanelAfterDelay_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HeroInfoPanel _003C_003E4__this;

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
		public _003CHidePanelAfterDelay_003Ed__46(int _003C_003E1__state)
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

	private const string PowerPlaceholderText = "-";

	[Header("Data")]
	[SerializeField]
	private HeroDatabaseSO heroDatabase;

	[SerializeField]
	private GameObject panelRoot;

	[SerializeField]
	private Animator animPanel;

	[SerializeField]
	[Min(0f)]
	private float hidePanelDelay;

	[Header("Header")]
	[SerializeField]
	private Image heroIconImage;

	[SerializeField]
	private TMP_Text heroNameText;

	[SerializeField]
	private TMP_Text shortDescriptionText;

	[SerializeField]
	private TMP_Text heroPowerText;

	[Header("Rarity Objects")]
	[SerializeField]
	private GameObject[] srRarityObjects;

	[SerializeField]
	private GameObject[] ssrRarityObjects;

	[SerializeField]
	private GameObject[] urRarityObjects;

	[Header("Tabs")]
	[SerializeField]
	private HeroInfoTab defaultTab;

	[SerializeField]
	private List<HeroInfoTabBinding> tabs;

	[Header("Views")]
	[SerializeField]
	private HeroLevelUpView levelUpView;

	[SerializeField]
	private HeroAscendView ascendView;

	[SerializeField]
	private HeroAutoAttackView autoAttackView;

	[SerializeField]
	private HeroActiveSkillView activeSkillView;

	[SerializeField]
	private HeroPassiveSkillView passiveSkillView;

	private HeroData selectedHeroData;

	private HeroProgressData selectedProgressData;

	private HeroInfoTab selectedTab;

	private bool hasSelectedTab;

	private Coroutine hidePanelRoutine;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Show(HeroData heroData, HeroProgressData progressData)
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void Refresh()
	{
	}

	public void SelectTab(HeroInfoTab tab)
	{
	}

	public void SelectLevelUpTab()
	{
	}

	public void SelectAscendTab()
	{
	}

	public void SelectAutoAttackTab()
	{
	}

	public void SelectActiveSkillTab()
	{
	}

	public void SelectPassiveSkillTab()
	{
	}

	private void RefreshHeader()
	{
	}

	private void RefreshRarityObjects(Rarity rarity)
	{
	}

	private static string NormalizeRarityName(string rarityName)
	{
		return null;
	}

	private static void SetActive(GameObject[] targets, bool isActive)
	{
	}

	private void RefreshSelectedView()
	{
	}

	private void RegisterTabButtons()
	{
	}

	private GameObject GetPanelRoot()
	{
		return null;
	}

	private void PlayPanelAnimation(bool isShowing)
	{
	}

	private void StartHidePanelRoutine()
	{
	}

	private void StopHidePanelRoutine()
	{
	}

	[IteratorStateMachine(typeof(_003CHidePanelAfterDelay_003Ed__46))]
	private IEnumerator HidePanelAfterDelay()
	{
		return null;
	}

	private void UnregisterTabButtons()
	{
	}
}
