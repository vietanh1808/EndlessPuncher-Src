using System;

[Serializable]
public class EffectTypeDuration
{
	public EffectType typeEffect;

	public float duration;

	public SkillType sourceSkillType;

	public float sourceDamage;

	public EffectTypeDuration(EffectType typeEffect, float duration)
	{
	}

	public EffectTypeDuration(EffectType typeEffect, float duration, SkillType sourceSkillType, float sourceDamage)
	{
	}

	public EffectTypeDuration()
	{
	}
}
