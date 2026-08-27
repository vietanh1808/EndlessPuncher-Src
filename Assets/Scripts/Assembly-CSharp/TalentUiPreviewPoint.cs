using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TalentUiPreviewPoint : MonoBehaviour
{
	[Serializable]
	public class PrizeTypeAndIcons
	{
		public GameObject prizeIcons;

		public PrizeTalentType typeTalentPrize;
	}

	[SerializeField]
	private Animator animatorPanel;

	[SerializeField]
	private GameObject mileStoneBubble;

	[SerializeField]
	private GameObject mileStoneIconRegular;

	[SerializeField]
	private GameObject mileStoneIconElite;

	[SerializeField]
	private TextMeshProUGUI textMileStone;

	[SerializeField]
	private GameObject prizeBubble;

	[SerializeField]
	private TextMeshProUGUI textPrize;

	[SerializeField]
	private TextMeshProUGUI textLineOrder;

	[SerializeField]
	private List<PrizeTypeAndIcons> prizeIcons;

	[SerializeField]
	private Color colorYellow;

	[SerializeField]
	private GameObject shiner;

	private int _totalOrder;

	private int _mileStoneId;

	private bool _isMileStoneActive;

	private CappybaraTalentDB.CappyTalent _cappyTalent;

	private CappybaraTalentDB.PrizeTalent _prizeTalent;

	[SerializeField]
	private Slider slider;

	[SerializeField]
	private GameObject[] checkDone;

	[SerializeField]
	private ParticleSystem[] completePArticle;

	private static readonly int hashPop;

	public void LoadTalentUISlot(CappybaraTalentDB.CappyTalent cappyTalent, CappybaraTalentDB.PrizeTalent prizeTalent, int order, int mileStoneID)
	{
	}

	private string GetPrizeValueHelper(CappybaraTalentDB.PrizeTalent prizeTalent)
	{
		return null;
	}

	private bool IsTypeSkill()
	{
		return false;
	}

	public void SetSlider()
	{
	}

	public void ShowDetails()
	{
	}

	public void CompletedPrize()
	{
	}
}
