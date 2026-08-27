using UnityEngine;

namespace Fubu.Essentials
{
	public abstract class RewardItem : ScriptableObject
	{
		public string rewardName;

		public Sprite icon;

		public abstract void Grant(int amount);
	}
}
