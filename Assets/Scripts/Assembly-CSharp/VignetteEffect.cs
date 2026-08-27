using UnityEngine;

public class VignetteEffect : MonoBehaviour
{
	private static VignetteEffect _instance;

	private int playPopanim;

	private int blackComeHash;

	private int comeDarkHash;

	private int goDarkHash;

	private int comeHash;

	private int goHash;

	private Animator anim;

	public static VignetteEffect instance => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void PlayVignette()
	{
	}

	public void PlayBlackVignette()
	{
	}

	public void LoadDarkVignette(bool isActive)
	{
	}

	public void ActivateVignette(bool isActive)
	{
	}

	public void ResetForNewRun()
	{
	}
}
