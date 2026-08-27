using System;
using System.Collections.Generic;
using UnityEngine;

public class SkillStarter : MonoBehaviour
{
	[Serializable]
	public class SkillPrefabAndType
	{
		public SkillType typeSkill;

		public GameObject skillObje;
	}

	private static SkillStarter _instance;

	public List<SkillPrefabAndType> allSkills;

	public SkillBehaviour skillBehaviour;

	public ParticleSystem[] handFireParticles;

	public ParticleSystem[] handIceParticles;

	public ParticleSystem[] handLighningParticles;

	public List<SkillType> skillOrder;

	public bool FireActive;

	public bool IceActive;

	public bool LightActive;

	public static SkillStarter Instance => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void AddSkillinOrder(SkillType type)
	{
	}

	public SkillType GetPunchSkillType()
	{
		return SkillType.skill1_PunchMeteor;
	}

	private void RemoveQueuedPunchSkill(SkillType type)
	{
	}

	public void ActivateFireParticles(bool isActive)
	{
	}

	public void ActivateIceParticles(bool isActive)
	{
	}

	public void ActivateLightningParticles(bool isActive)
	{
	}

	public void SkillSpawn(SkillType skillType)
	{
	}

	public void ResetForNewRun()
	{
	}
}
