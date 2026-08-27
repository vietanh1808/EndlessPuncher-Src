using UnityEngine;

[CreateAssetMenu(fileName = "PiggyBankSO", menuName = "DBs/Piggy Bank")]
public class PiggyBankSO : ScriptableObject
{
	public int needEnergyToActivateOffer;

	public float offerPercentage;

	public int stageValueFPanel;

	public float waveValueFPanelPercentage;
}
