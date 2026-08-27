using UnityEngine;

public class RotationScript : MonoBehaviour
{
	public enum RotationAxis
	{
		X = 0,
		Y = 1,
		Z = 2
	}

	public RotationAxis rotationAxis;

	public float rotationSpeed;

	private void Update()
	{
	}
}
