using UnityEngine;

public class LoadingPanelHandler : MonoBehaviour
{
	public Animator loadingPanelAnim;

	public static LoadingPanelHandler Instance { get; private set; }

	private void Awake()
	{
	}
}
