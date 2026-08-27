using UnityEngine;

public class HandController : MonoBehaviour
{
	[Header("Animator")]
	public Animator _animator;

	[Header("Settings")]
	public bool _hideMouse;

	public bool _swayActive;

	[Header("Sway Settings")]
	public float intensity;

	public float smooth;

	[Header("Camera")]
	public Camera UICamera;

	private Quaternion origin_rotation;

	private bool _isHolding;

	private RectTransform rectTransform;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void SetAnimator()
	{
	}

	private void UpdateSway()
	{
	}
}
