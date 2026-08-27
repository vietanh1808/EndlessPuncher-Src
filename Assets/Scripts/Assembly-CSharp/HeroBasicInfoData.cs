using System;
using UnityEngine;

[Serializable]
public class HeroBasicInfoData
{
	public string heroID;

	public string heroName;

	public Sprite heroIcon;

	[TextArea(2, 4)]
	public string shortDescription;

	[InspectorName("Hero Rank / Rarity")]
	public Rarity heroRarity;

	public HeroAttackType attackType;
}
