using UnityEngine;

namespace Fubu.Essentials
{
	[RequireComponent(typeof(CharacterController))]
	public class MovementHandler : MonoBehaviour
	{
		private enum UpdateType
		{
			Update = 0,
			FixedUpdate = 1
		}

		public static MovementHandler instance;

		private Animator anim;

		private static readonly int IsRunning;

		private VariableJoystick joystick;

		private CharacterController characterController;

		[SerializeField]
		private float speed;

		[SerializeField]
		private float gravity;

		[SerializeField]
		[Range(0f, 1f)]
		private float joyistickDeadZone;

		[SerializeField]
		[Range(0f, 1f)]
		private float rotationLerpRate;

		[SerializeField]
		private UpdateType updateType;

		public Vector3 PlayerPosition => default;

		public float GetRemainingDistanceToPos(Vector3 targetPosition)
		{
			return 0f;
		}

		public float GetRemainingDistanceToTarget(Transform targetTransform)
		{
			return 0f;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void HandleMovement(float timeDiff)
		{
		}
	}
}
