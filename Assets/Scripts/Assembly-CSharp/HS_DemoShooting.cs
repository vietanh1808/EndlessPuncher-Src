using UnityEngine;

public class HS_DemoShooting : MonoBehaviour
{
	[Header("Fire rate")]
	private int Prefab;

	[Range(0f, 1f)]
	public float fireRate;

	private float fireCountdown;

	public GameObject FirePoint;

	public Camera Cam;

	public float MaxLength;

	public GameObject[] Prefabs;

	private Ray RayMouse;

	private Vector3 direction;

	private Quaternion rotation;

	private float buttonSaver;

	public Animation camAnim;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Counter(int count)
	{
	}

	private void RotateToMouseDirection(GameObject obj, Vector3 destination)
	{
	}
}
