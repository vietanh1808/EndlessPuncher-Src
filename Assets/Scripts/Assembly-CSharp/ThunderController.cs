using System;
using UnityEngine;

public class ThunderController : MonoBehaviour
{
	private Func<float, float>? xFunc;

	[SerializeField]
	private Animator animator;

	public PlayerArm[] allArms;

	public PlayerArm leftArm;

	public PlayerArm rightArm;

	public bool isAttackActive;

	public Transform targetRPos;

	private int BoneCount => 0;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}
}
