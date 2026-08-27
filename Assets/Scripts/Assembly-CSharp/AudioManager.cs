using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public string nextTrack;

		public AudioManager _003C_003E4__this;

		internal bool _003CSwitchBackgroundMusicRoutine_003Eb__0(Sound sounds)
		{
			return false;
		}

		internal bool _003CSwitchBackgroundMusicRoutine_003Eb__1(Sound sounds)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CLevelUpLowPass_003Ed__92 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool isFadeIn;

		public bool isDirect;

		public AudioManager _003C_003E4__this;

		private float _003Ct_003E5__2;

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
		public _003CLevelUpLowPass_003Ed__92(int _003C_003E1__state)
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
	private sealed class _003CSwitchBackgroundMusicRoutine_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string nextTrack;

		public AudioManager _003C_003E4__this;

		public bool restartSameTrack;

		private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

		private Sound _003CnextSound_003E5__2;

		private Sound _003CcurrentSound_003E5__3;

		private float _003CtargetVolume_003E5__4;

		private float _003CfadeT_003E5__5;

		private float _003CstartVolume_003E5__6;

		private float _003Ct_003E5__7;

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
		public _003CSwitchBackgroundMusicRoutine_003Ed__27(int _003C_003E1__state)
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
	private sealed class _003CfadeIn_003Ed__94 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Sound s;

		private float _003Cvolume_003E5__2;

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
		public _003CfadeIn_003Ed__94(int _003C_003E1__state)
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
	private sealed class _003CfadeOut_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Sound s;

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
		public _003CfadeOut_003Ed__95(int _003C_003E1__state)
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

	private const int MenuMusicStartIndex = 0;

	private const int MenuMusicEndIndexExclusive = 4;

	private const int FightMusicStartIndex = 4;

	private const int FightMusicEndIndexExclusive = 8;

	private static AudioManager instance;

	public Sound[] sounds;

	private AudioLowPassFilter lowPassFilter;

	private AudioSource currencyArrivalAudioSource;

	private string selectedMenuBackground;

	private string selectedFightBackground;

	private string previousSelectedMenuBackground;

	private string previousSelectedFightBackground;

	private float nextAllowedGruntTime;

	public string currentBackground;

	private Coroutine backgroundSwitchRoutine;

	private int _petAttackCount;

	private int _petHitCount;

	private int _cardCount;

	private int _bossAhh;

	private int _talentGetCount;

	private int _lighningHit;

	private int _knifeVolleyCounter;

	private int _agreeCount;

	private int _constractionItemFall;

	private int _bodyFall;

	private int _breakSound;

	private int _bigExpoCounter;

	private int _smallExpoCounter;

	private int _expoCounter;

	private int _bosspounchCounter;

	private int _pounchCounter;

	private int _simplePounchCounter;

	private int _gruntCounter;

	private int _clickCounter;

	private int _coinCounter;

	private bool _isFacein;

	public static AudioManager GetInstance()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void LoadBGSound()
	{
	}

	public void setBackgroundSound(bool isDefault, string name = "")
	{
	}

	public void PlayMenuBackgroundMusic(bool forceRestart = false)
	{
	}

	public void PlayFightBackgroundMusic(bool forceRestart = false)
	{
	}

	public void ResetRunBackgroundMusicSelection()
	{
	}

	private string GetSelectedMenuBackground()
	{
		return null;
	}

	private string GetSelectedFightBackground()
	{
		return null;
	}

	private string GetRandomBackgroundTrack(int startInclusive, int endExclusive, string excludedTrack)
	{
		return null;
	}

	private void SwitchBackgroundMusic(string nextTrack, bool forceRestart)
	{
	}

	[IteratorStateMachine(typeof(_003CSwitchBackgroundMusicRoutine_003Ed__27))]
	private IEnumerator SwitchBackgroundMusicRoutine(string nextTrack, bool restartSameTrack)
	{
		return null;
	}

	public void PetAttack()
	{
	}

	public void PetHit()
	{
	}

	public void CardSound()
	{
	}

	public void BossAhhSound()
	{
	}

	public void BossAhhDieSound()
	{
	}

	public void TalenPurchaseSound()
	{
	}

	public void LightningHit()
	{
	}

	public void KnifeVolley()
	{
	}

	public void PlayAgree()
	{
	}

	public void PlayConstractionItemFall()
	{
	}

	public void BodyFall()
	{
	}

	public void BreakSound()
	{
	}

	public void BigExplosion()
	{
	}

	public void SmallExplosion()
	{
	}

	public void NormalExplosion()
	{
	}

	public void PlayBuild()
	{
	}

	private void PlayBuildDelay()
	{
	}

	public void PlayItemEquipt()
	{
	}

	public void PlayItemUnEquipt()
	{
	}

	public void PlayItemUpgrade()
	{
	}

	public void PlayChestUnlock()
	{
	}

	public void PlayAbilityPunch(EffectType id)
	{
	}

	public void ChangeVolume()
	{
	}

	public void ChangeMusicVolume()
	{
	}

	public void PlayBossPunch()
	{
	}

	public void PlayPunch()
	{
	}

	public void PlaySimplePunch()
	{
	}

	public void GruntPlay()
	{
	}

	public void ClickPlay()
	{
	}

	public void CoincPlay()
	{
	}

	public void PlopPlay()
	{
	}

	public void PlayEquipt()
	{
	}

	public void PlayNonEquipt()
	{
	}

	public void PlayFreezeEffectSound()
	{
	}

	public void PlayLevelUp()
	{
	}

	public void Play(string name)
	{
	}

	public void Stop(string name)
	{
	}

	public void FadeIn(string name)
	{
	}

	public void FadeOutBgMusic()
	{
	}

	public void FadeOut(string name)
	{
	}

	public void LevelUpFadeIn(bool isDirect = false)
	{
	}

	public void LevelUpFadeOut()
	{
	}

	public void ResetBackgroundLowPass()
	{
	}

	[IteratorStateMachine(typeof(_003CLevelUpLowPass_003Ed__92))]
	private IEnumerator LevelUpLowPass(bool isFadeIn, bool isDirect = false)
	{
		return null;
	}

	public void LevelUpFadeInComplete()
	{
	}

	[IteratorStateMachine(typeof(_003CfadeIn_003Ed__94))]
	private IEnumerator fadeIn(Sound s)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CfadeOut_003Ed__95))]
	private IEnumerator fadeOut(Sound s)
	{
		return null;
	}
}
