using System;
using TMPro;
using UnityEngine;

public class InfoPanel : MonoBehaviour
{
	[Serializable]
	private struct Info
	{
		public string label;

		public string description;
	}

	private bool started;

	private static InfoPanel Instance;

	[SerializeField]
	private Info[] infos;

	[SerializeField]
	private GameObject panel;

	[SerializeField]
	private TMP_Text labelText;

	[SerializeField]
	private TMP_Text descriptionText;

	[SerializeField]
	private TMP_Text levelFromText;

	[SerializeField]
	private TMP_Text levelToText;

	public bool ByPassTutorialLimitation { get; set; }

	private void Awake()
	{
	}

	public static InfoPanel GetInstance()
	{
		return null;
	}

	public void ShowPanel(int i, int from, int to)
	{
	}

	public void OnTutorialStarted()
	{
	}
}
