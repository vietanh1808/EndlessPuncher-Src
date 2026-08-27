using UnityEngine;

public class InventoryCamController : MonoBehaviour
{
	[Header("Rotation Settings")]
	[SerializeField]
	private float rotationSpeed;

	[SerializeField]
	private float maxYRotation;

	[SerializeField]
	private float returnSpeed;

	[SerializeField]
	private Transform turnObje;

	private Quaternion startRotation;

	private float currentYAngle;

	private bool isDragging;

	private bool inputBlockedByUI;

	private Vector2 lastInputPosition;

	private InGameUI gameUI;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void HandleMouseInput()
	{
	}

	private void RotateObject(float deltaX)
	{
	}

	private void ReturnToStartRotation()
	{
	}

	private bool IsPointerOverUI()
	{
		return false;
	}

	private bool IsTouchOverUI(int fingerId)
	{
		return false;
	}
}
