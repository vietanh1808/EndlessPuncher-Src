using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
	[SerializeField]
	[Min(0f)]
	private float moveSpeed;

	[SerializeField]
	[Min(0f)]
	private float rotationSpeed;

	[SerializeField]
	private CharacterController characterController;

	private bool missingControllerLogged;

	private void Awake()
	{
	}

	public void MoveTowards(Vector3 targetPosition)
	{
	}

	public void Stop()
	{
	}

	public void FaceTowards(Vector3 targetPosition)
	{
	}

	private bool HasCharacterController()
	{
		return false;
	}
}
