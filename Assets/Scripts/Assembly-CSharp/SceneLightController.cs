using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SceneLightController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateLights_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneLightController _003C_003E4__this;

		public bool isNormalState;

		private float _003CstartSceneIntensity_003E5__2;

		private float _003CstartCharacterIntensity_003E5__3;

		private float _003CstartRingIntensity_003E5__4;

		private float _003CstartBossIntensity_003E5__5;

		private float _003CtargetSceneIntensity_003E5__6;

		private float _003CtargetCharacterIntensity_003E5__7;

		private float _003CtargetRingIntensity_003E5__8;

		private float _003CtargetBossIntensity_003E5__9;

		private float _003Ct_003E5__10;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CAnimateLights_003Ed__39(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CAnimateTalentMenuSceneLight_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneLightController _003C_003E4__this;

		private float _003CstartIntensity_003E5__2;

		private float _003CtargetIntensity_003E5__3;

		private float _003Ct_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CAnimateTalentMenuSceneLight_003Ed__37(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Header("Lights")]
	[SerializeField]
	private Light sceneLight;

	[SerializeField]
	private Light characterLight;

	[SerializeField]
	private Light[] ringLights;

	[SerializeField]
	private Light[] bossLights;

	[Header("Normal State")]
	[SerializeField]
	private float normalSceneLightIntensity;

	[SerializeField]
	private float normalCharacterLightIntensity;

	[SerializeField]
	private float normalRingLightIntensity;

	[Header("Tap To Start State")]
	[SerializeField]
	private float dimSceneLightIntensity;

	[SerializeField]
	private float dimCharacterLightIntensity;

	[SerializeField]
	private float dimRingLightIntensity;

	[SerializeField]
	private float transitionSpeed;

	[Header("Talent Menu State")]
	[SerializeField]
	private float talentMenuSceneLightIntensity;

	[SerializeField]
	private float talentMenuTransitionSpeed;

	[SerializeField]
	private float fightSceneLightYRotation;

	[SerializeField]
	private float talentSceneLightYRotation;

	[Header("Boss State")]
	[SerializeField]
	private float bossSceneLightIntensity;

	[SerializeField]
	private float bossCharacterLightIntensity;

	[SerializeField]
	private float bossRingLightIntensity;

	[SerializeField]
	private float bossLightIntensity;

	private Coroutine lightRoutine;

	private Coroutine talentMenuRoutine;

	private bool isNormalStateActive;

	private bool isTalentMenuLightActive;

	private bool isBossLightActive;

	private void Start()
	{
	}

	public void LightsOff()
	{
	}

	public void LightsOn()
	{
	}

	public void SetTalentMenuLight(bool isActive)
	{
	}

	public void SetBossLight(bool isActive)
	{
	}

	private void ApplyImmediateLights(bool isNormalState)
	{
	}

	private void ApplySceneLightRotation()
	{
	}

	private float GetBaseSceneLightTarget()
	{
		return 0f;
	}

	private float GetTargetSceneIntensity(bool isNormalState)
	{
		return 0f;
	}

	private float GetTargetCharacterIntensity(bool isNormalState)
	{
		return 0f;
	}

	private float GetTargetRingIntensity(bool isNormalState)
	{
		return 0f;
	}

	private float GetTargetBossLightIntensity()
	{
		return 0f;
	}

	private void ApplyBossLightsImmediate(float targetIntensity)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateTalentMenuSceneLight_003Ed__37))]
	private IEnumerator AnimateTalentMenuSceneLight()
	{
		return null;
	}

	private void StartLightTransition(bool isNormalState)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateLights_003Ed__39))]
	private IEnumerator AnimateLights(bool isNormalState)
	{
		return null;
	}
}
