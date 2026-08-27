using Fubu.Cards;
using UnityEngine;
using UnityEngine.UI;

namespace Fubu.Forge
{
	public class TurretButtonControl : MonoBehaviour
	{
		public enum ButtonState
		{
			Empty = 0,
			Ready = 1,
			Reloading = 2,
			Inactive = 3
		}

		[SerializeField]
		private Image icon;

		[SerializeField]
		private Image reloadImage;

		[SerializeField]
		private GameObject yellowOutline;

		[SerializeField]
		private Sprite deactiveSprite;

		[SerializeField]
		private Sprite emptySprite;

		private Card _card;

		private ButtonState _currentState;

		private float _cooldownTimer;

		private float _cooldownDuration;

		public bool IsReady => false;

		private void Update()
		{
		}

		public void AssignCard(Card card)
		{
		}

		public void StartCooldown()
		{
		}

		public void SetInactive()
		{
		}

		public void ResetToReady()
		{
		}

		private void HandleCooldown()
		{
		}

		public void SetState(ButtonState newState)
		{
		}
	}
}
