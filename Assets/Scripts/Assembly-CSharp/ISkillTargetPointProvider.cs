using UnityEngine;

public interface ISkillTargetPointProvider
{
	Transform GetSkillTargetPoint(SkillType skillType);
}
