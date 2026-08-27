using System;
using UnityEngine;

public class HeroAnimationController : MonoBehaviour
{
	[Serializable]
	private class HeroAnimationTrigger
	{
		public HeroAnimationType animationType;

		public string triggerName;
	}

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private HeroAnimationTrigger[] animationTriggers;

	[SerializeField]
	private HeroAnimationEventReceiver eventReceiver;

	public Animator Animator => null;

	private void Awake()
	{
	}

	public void Play(HeroAnimationType animationType)
	{
	}

	private void EnsureEventReceiver()
	{
	}

	private bool TryGetTriggerName(HeroAnimationType animationType, out string triggerName)
	{
		triggerName = null;
		return false;
	}
}
