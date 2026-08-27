using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class BottomMenu : Singleton<BottomMenu>
{
	[SerializeField]
	private int startTabIndex;

	[SerializeField]
	private List<BottomMenuTab> bottomMenuTabs;

	[CompilerGenerated]
	private Action<BottomMenuTab> m_OnCurrentTabChanged;

	[CompilerGenerated]
	private Action<int> m_OnCurrentTabIndexChanged;

	public BottomMenuTab CurrentTab { get; private set; }

	public int CurrentTabIndex { get; private set; }

	public bool IsOpen => false;

	public event Action<BottomMenuTab> OnCurrentTabChanged
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

	public event Action<int> OnCurrentTabIndexChanged
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

	private void Start()
	{
	}

	public void SelectTab(BottomMenuTab tab)
	{
	}

	public void SelectTab(int index)
	{
	}

	public void ForceSelectTab(int index)
	{
	}

	public void ClearSelection(bool notify = false)
	{
	}

	public BottomMenuTab GetTab(int index)
	{
		return null;
	}

	public Button GetButton(int index)
	{
		return null;
	}

	public Button[] GetButtons()
	{
		return null;
	}

	public void SetTabsInteractable(bool interactable)
	{
	}

	private void NotifyCurrentTabChanged()
	{
	}
}
