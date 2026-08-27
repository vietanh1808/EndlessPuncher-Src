using UnityEngine;

namespace FOW.Demos
{
	public class FowCharacterDemo : MonoBehaviour
	{
		public float WalkingSpeed;

		public float RunningMultiplier;

		public float Acceleration;

		private float yRot;

		private CharacterController cc;

		private bool CursorLocked;

		private Vector2 inputDirection;

		private Vector2 velocityXZ;

		private Vector3 velocity;

		private float speedTarget;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void setInput()
		{
		}

		private void move()
		{
		}
	}
}
