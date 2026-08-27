using UnityEngine;

public class HeroMovementController : MonoBehaviour
{
	[SerializeField]
	[Min(0f)]
	private float moveSpeed;

	[SerializeField]
	[Min(0f)]
	private float turnSpeed;

	[SerializeField]
	private bool rotateTowardsMoveTarget;

	[SerializeField]
	private CharacterController characterController;

	private bool isMoving;

	private Vector3 targetPosition;

	private bool missingControllerLogged;

	public bool IsMoving => false;

	public float MoveSpeed => 0f;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void MoveTowards(Vector3 position)
	{
	}

	public void Stop()
	{
	}

	public void FaceTowards(Vector3 position)
	{
	}

	private bool HasCharacterController()
	{
		return false;
	}
}
