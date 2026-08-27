using UnityEngine;
using VolumetricFogAndMist2;

public class SceneEnvironmentControl : MonoBehaviour
{
	public GameObject[] environments;

	public Color[] cameraBgColor;

	public Color[] fogColor;

	public Color[] fowColor;

	public Vector2[] fogDistaces;

	public float[] fogStrength;

	public VolumetricFog fog;

	public Camera cam;

	public GameObject characterLight;

	public GameObject ringLight;

	private void Start()
	{
	}

	public void SoftRestart()
	{
	}

	public void SetRingLightMode(bool isRingMode)
	{
	}
}
