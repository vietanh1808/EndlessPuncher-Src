using UnityEngine;

[CreateAssetMenu(fileName = "New PetTrait", menuName = "Fubu/Pets/Trait")]
public class PetTrait : ScriptableObject
{
	public string traitName;

	public string traitDescription;

	public PetTraitTypes traitType;

	public Sprite icon;

	public float[] traitRarityPowers;
}
