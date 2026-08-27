using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{
	[Serializable]
	public class EndGameReward
	{
		public GameObject reward;

		public TextMeshProUGUI textReward;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass156_0
	{
		public int arrivedCoinIcons;

		public InGameUI _003C_003E4__this;

		public int displayedEnergyAmount;

		public bool coinFlowFinished;

		internal void _003CPlayCompleteCoinToEnergyConversion_003Eb__0()
		{
		}

		internal void _003CPlayCompleteCoinToEnergyConversion_003Eb__1()
		{
		}

		internal bool _003CPlayCompleteCoinToEnergyConversion_003Eb__3()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CCompletePanelConversionAndRewards_003Ed__158 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameUI _003C_003E4__this;

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
		public _003CCompletePanelConversionAndRewards_003Ed__158(int _003C_003E1__state)
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
	private sealed class _003CCompleteRewardMultiplierSequence_003Ed__187 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameUI _003C_003E4__this;

		public float runRewardMultiplier;

		public int completeGold;

		public int completeGem;

		public int completeRedGem;

		public int completeShopGem;

		public int completeEventCurrency;

		public int completeEnergy;

		private Animator _003CanimComplete_003E5__2;

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
		public _003CCompleteRewardMultiplierSequence_003Ed__187(int _003C_003E1__state)
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
	private sealed class _003CCreateMoney_003Ed__167 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameUI _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CCreateMoney_003Ed__167(int _003C_003E1__state)
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
	private sealed class _003CDelanLoadScene_003Ed__229 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string sceneName;

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
		public _003CDelanLoadScene_003Ed__229(int _003C_003E1__state)
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
	private sealed class _003CDelanLoadScene_003Ed__230 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int sceneIndex;

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
		public _003CDelanLoadScene_003Ed__230(int _003C_003E1__state)
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
	private sealed class _003CFailRewardMultiplierSequence_003Ed__185 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameUI _003C_003E4__this;

		public float runRewardMultiplier;

		public int failGold;

		public int failGem;

		public int failRedGem;

		public int failShopGem;

		public int failEventCurrency;

		public int failEnergy;

		private Animator _003CanimFail_003E5__2;

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
		public _003CFailRewardMultiplierSequence_003Ed__185(int _003C_003E1__state)
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
	private sealed class _003CGeneratePrizeMoney_003Ed__165 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameUI _003C_003E4__this;

		private float _003Ct_003E5__2;

		private bool _003CcreatedMoney_003E5__3;

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
		public _003CGeneratePrizeMoney_003Ed__165(int _003C_003E1__state)
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
	private sealed class _003CHandlePercentage_003Ed__164 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameUI _003C_003E4__this;

		public float percentage;

		private float _003Ct_003E5__2;

		private float _003Cp_003E5__3;

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
		public _003CHandlePercentage_003Ed__164(int _003C_003E1__state)
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
	private sealed class _003CLevelComplete_003Ed__133 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameUI _003C_003E4__this;

		private int _003CpreviousChapter_003E5__2;

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
		public _003CLevelComplete_003Ed__133(int _003C_003E1__state)
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
	private sealed class _003CLevelFail_003Ed__183 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameUI _003C_003E4__this;

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
		public _003CLevelFail_003Ed__183(int _003C_003E1__state)
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
	private sealed class _003CLoad_003Ed__112 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameUI _003C_003E4__this;

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
		public _003CLoad_003Ed__112(int _003C_003E1__state)
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
	private sealed class _003CLoadBase_003Ed__125 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameUI _003C_003E4__this;

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
		public _003CLoadBase_003Ed__125(int _003C_003E1__state)
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
	private sealed class _003CLoadFight_003Ed__116 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameUI _003C_003E4__this;

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
		public _003CLoadFight_003Ed__116(int _003C_003E1__state)
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
	private sealed class _003CLoadGiant_003Ed__118 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameUI _003C_003E4__this;

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
		public _003CLoadGiant_003Ed__118(int _003C_003E1__state)
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
	private sealed class _003CLoadSkillSceneRator_003Ed__127 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameUI _003C_003E4__this;

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
		public _003CLoadSkillSceneRator_003Ed__127(int _003C_003E1__state)
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
	private sealed class _003CPerformSoftRunResetRoutine_003Ed__224 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameUI _003C_003E4__this;

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
		public _003CPerformSoftRunResetRoutine_003Ed__224(int _003C_003E1__state)
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
	private sealed class _003CPlayCompleteCoinToEnergyConversion_003Ed__156 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameUI _003C_003E4__this;

		private _003C_003Ec__DisplayClass156_0 _003C_003E8__1;

		private float _003Celapsed_003E5__2;

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
		public _003CPlayCompleteCoinToEnergyConversion_003Ed__156(int _003C_003E1__state)
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
	private sealed class _003CRestart_003Ed__114 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameUI _003C_003E4__this;

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
		public _003CRestart_003Ed__114(int _003C_003E1__state)
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
	private sealed class _003CSoftRestartRunRoutine_003Ed__223 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameUI _003C_003E4__this;

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
		public _003CSoftRestartRunRoutine_003Ed__223(int _003C_003E1__state)
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
	private sealed class _003CWaitForPendingWorldRewardCollections_003Ed__221 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameUI _003C_003E4__this;

		private CurrenciesHandler _003Ccurrencies_003E5__2;

		private FxManager _003CfxManager_003E5__3;

		private float _003CwaitDeadline_003E5__4;

		private float _003CsettledSince_003E5__5;

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
		public _003CWaitForPendingWorldRewardCollections_003Ed__221(int _003C_003E1__state)
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

	public static InGameUI instance;

	public bool isSceneDungeon;

	public bool isSceneGaint;

	public GameObject enemyMenuParent;

	[Header("LEVEL COMPONENTS")]
	public int levelCountOfGame;

	public int levelEndPrizeMoney;

	public TextMeshProUGUI levelText;

	public TextMeshProUGUI stageText;

	[Header("CANVAS GAMEOBJECTS")]
	public GameObject openPackPanel;

	public GameObject pausePanel;

	public GameObject tapToStartPanel;

	public GameObject dungeontapToStartPanel;

	public GameObject receivedRewardsPanel;

	public GameObject rewardsHolder;

	public GameObject pauseButton;

	public GameObject coinCounter;

	[Header("LEVEL COMPLETE COMPONENTS")]
	public GameObject winCam;

	public GameObject levelCompletePanel;

	public GameObject confettiRain;

	public GameObject moneyPrefab;

	public Transform happyEmojisHolder;

	public TextMeshProUGUI prizeMoneyText;

	public TextMeshProUGUI completedPercentageText;

	[Header("LEVEL FAIL COMPONENTS")]
	public GameObject levelFailPanel;

	public Transform sadEmojisHolder;

	[Header("SETTINGS SOUND COMPONENTS")]
	public Image soundIcon;

	public Sprite soundOnSprite;

	public Sprite soundOffSprite;

	public Slider volumeSlider;

	[Header("SETTINGS MUSIC COMPONENTS")]
	public Image musicIcon;

	public Sprite musicOnSprite;

	public Sprite musicOffSprite;

	public Slider volumeMusicSlider;

	[Header("SETTINGS HAPTIC COMPONENTS")]
	public GameObject hapticToggleOnImg;

	public GameObject hapticToggleOffImg;

	[Header("SETTINGS NOTIFICATION COMPONENTS")]
	public GameObject notificationToggleOnImg;

	public GameObject notificationToggleOffImg;

	[Header("SETTINGS TOGGLE BUTTON COMPONENTS")]
	public Sprite fillToggleOnSprite;

	public Sprite fillToggleOffSprite;

	public Sprite handleToggleOnSprite;

	public Sprite handleToggleOffSprite;

	[Header("ANIMATORS")]
	public Animator chestAnim;

	public Animator pausePanelAnim;

	public Animator animBackCounter;

	[Header("DEBUG COMPONENTS")]
	public GameObject debugConsole;

	private InGameUIMenuController menuController;

	public CanvasScaler[] canvasScalers;

	private bool soundIsOn;

	private bool hapticIsOn;

	private bool isNotificationOn;

	[HideInInspector]
	public bool levelFinished;

	[HideInInspector]
	public bool levelStarted;

	[SerializeField]
	private int maxLevelPrizeIconCount;

	private AudioManager audioManager;

	private int runEarnedGold;

	private int runEarnedGem;

	private int runEarnedRedGem;

	private int runEarnedPetGem;

	private int runEarnedShopGem;

	private int runEarnedRingCurrency;

	private int runEarnedEventCurrency;

	private int runEarnedBaseEnergy;

	private int runEarnedEnergy;

	private int runEarnedChest;

	private int runEarnedChestEpic;

	private int runEarnedChestCollectible;

	private readonly Dictionary<ChestTypes, int> runEarnedChestByType;

	private readonly Dictionary<CurrencyTypes, int> immediatelyGrantedRunCurrencyRewards;

	private int lastTrackedGold;

	private int lastTrackedGem;

	private int lastTrackedRedGem;

	private int lastTrackedShopGem;

	private bool resetRunCurrenciesOnSoftRestart;

	private float currentRunRewardMultiplier;

	private Coroutine failRewardMultiplierSequenceRoutine;

	private Coroutine completeRewardMultiplierSequenceRoutine;

	private bool pendingRunRewardsClaimed;

	private bool pendingRunRewardFlightsActive;

	private bool endGameRewardActionLocked;

	private bool baseSceneLoadRequested;

	private const int CompleteCoinConversionFloatingIconCount = 75;

	private const float CompleteCoinConversionDuration = 2f;

	private const float CompleteRewardMultiplierSequenceDelay = 0.75f;

	private const float PendingRunRewardFlightsWaitDuration = 3f;

	private int totalGoldAtLevelComplete;

	private int pendingBossGoldReward;

	private bool completePanelConversionStarted;

	private float completeRewardMultiplierSnapshot;

	private int completeCommonChestSnapshot;

	private int completeEpicChestSnapshot;

	private int completeCollectibleChestSnapshot;

	public GameObject bottomMenues;

	public int energyPerLevel;

	private bool isLoading;

	private bool isFailInterstitialFlowRunning;

	private int timescalePressCount;

	[Header("Complete Cond")]
	public ClaimMultiplier comleteRewards;

	public ClaimMultiplier comleteRewardsX2;

	private Transform bossPos;

	private Vector3 bossRewardWorldPos;

	private bool _bossChestRewardGrantedThisLevel;

	private bool _bossCompletionCoinsSpawnedThisLevel;

	private ChestTypes _bossChestRewardType;

	private int _bossChestRewardAmount;

	private int _completedStageForBossRewards;

	private const int LevelCompleteEnergyRewardMin = 10;

	private const int LevelCompleteEnergyRewardMax = 15;

	private const int RingUpgradePreviewCurrencyGrantStage = 3;

	private const int RingUpgradePreviewCurrencyAmount = 500;

	private const string RingUpgradePreviewCurrencyGrantKey = "RingUpgradePreviewCurrencyGrant";

	private int startCollectedGold;

	private int startCollectedGem;

	private int startCollectedGreenGem;

	private int startCollectedChest;

	[Header("Fail Cond")]
	public ClaimMultiplier failRewards;

	public ClaimMultiplier endGameRewardsX2;

	private const float MinFailRewardMultiplierSequenceDelay = 1.5f;

	[SerializeField]
	private float failPanelCurrencyWaitTimeout;

	[SerializeField]
	private float failPanelCurrencySettleDuration;

	[SerializeField]
	private float failRewardMultiplierSequenceDelay;

	[SerializeField]
	private float failRewardMultiplierSequenceDuration;

	public TextMeshProUGUI rewardedX2ClaimText;

	public TextMeshProUGUI rewardedX2ClaimTextWeeklyFree;

	public Button rewardedX2Claim;

	public Button rewardedX2ClaimWeeklyFree;

	public Button returnFailButton100Gem;

	public Button rewardedX2ClaimComplete;

	public Button rewardedX2ClaimCompleteWeeklyFree;

	public Button returnFailButton100GemComplete;

	public TextMeshProUGUI[] claimX2Texts;

	public Animator animChestPanel;

	public CamFollower cmFollower;

	public int lastMenuID => 0;

	private void Awake()
	{
	}

	private void EnsureCompletePanelAnimationEventRelay()
	{
	}

	public void OpenTalentMenu()
	{
	}

	private void Start()
	{
	}

	private void StageWriter()
	{
	}

	private void ApplyBaseTimeScale(float baseTimeScale)
	{
	}

	private void RescaleCanvas()
	{
	}

	private void Update()
	{
	}

	public void StartLevel()
	{
	}

	public void StartLevel(int energyCost)
	{
	}

	public void StartDungeon()
	{
	}

	public void DungeonAnimator()
	{
	}

	public void PauseGame()
	{
	}

	public void ResumeGame()
	{
	}

	private void ClosePausePanel()
	{
	}

	public void RestorePurchase()
	{
	}

	public void LoadNextLevel()
	{
	}

	[IteratorStateMachine(typeof(_003CLoad_003Ed__112))]
	private IEnumerator Load()
	{
		return null;
	}

	public void RestartLevel()
	{
	}

	[IteratorStateMachine(typeof(_003CRestart_003Ed__114))]
	private IEnumerator Restart()
	{
		return null;
	}

	public void LoadFightScene()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadFight_003Ed__116))]
	private IEnumerator LoadFight()
	{
		return null;
	}

	public void LoadGiantScene()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadGiant_003Ed__118))]
	private IEnumerator LoadGiant()
	{
		return null;
	}

	public void SkipDoubleLoot()
	{
	}

	public void LoadBaseScene()
	{
	}

	public void LoadBaseSceneAfterFailInterstitial()
	{
	}

	private void HandleFailInterstitialDismissed()
	{
	}

	private void ContinueAfterFailInterstitial()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadBase_003Ed__125))]
	private IEnumerator LoadBase()
	{
		return null;
	}

	public void LoadSkillScene()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadSkillSceneRator_003Ed__127))]
	private IEnumerator LoadSkillSceneRator()
	{
		return null;
	}

	public void IncreaseTimeScale()
	{
	}

	public void BGSoundFadeOut()
	{
	}

	[IteratorStateMachine(typeof(_003CLevelComplete_003Ed__133))]
	public IEnumerator LevelComplete()
	{
		return null;
	}

	private bool ShouldShowCompleteGoldRewards()
	{
		return false;
	}

	private int GetActiveUpgradeCardCount()
	{
		return 0;
	}

	public void BossDiePos(Transform posBoss)
	{
	}

	public void SpawnBossCompletionRewardsImmediately()
	{
	}

	private void BossRewardAdd()
	{
	}

	private int GetLevelCompleteEnergyReward()
	{
		return 0;
	}

	private bool IsStageThreeCompletionRingReward()
	{
		return false;
	}

	public void SpawnBossCompletionCoinsImmediately(Vector3 worldPosition)
	{
	}

	public void SpawnBossCompletionChestImmediately(Vector3 worldPosition)
	{
	}

	private void ResetCoinsAtStageCompletion()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayCompleteCoinToEnergyConversion_003Ed__156))]
	private IEnumerator PlayCompleteCoinToEnergyConversion()
	{
		return null;
	}

	public void OnCompletePanelBeforeDoubleLoot()
	{
	}

	[IteratorStateMachine(typeof(_003CCompletePanelConversionAndRewards_003Ed__158))]
	private IEnumerator CompletePanelConversionAndRewards()
	{
		return null;
	}

	private void GrantRingUpgradePreviewCurrencyIfNeeded(CurrenciesHandler currenciesHandler, Vector3 rewardWorldPos)
	{
	}

	public float GetCurrentRunRewardMultiplier()
	{
		return 0f;
	}

	private float ResolveSelectedRunRewardMultiplier()
	{
		return 0f;
	}

	public int GetCollectedRunRewardAmount(float baseAmount, CurrencyTypes currencyType)
	{
		return 0;
	}

	public int GetStageRewardAmount(int collectedAmount)
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CHandlePercentage_003Ed__164))]
	private IEnumerator HandlePercentage(float percentage)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGeneratePrizeMoney_003Ed__165))]
	private IEnumerator GeneratePrizeMoney()
	{
		return null;
	}

	private void HideCompletePrizeMoney()
	{
	}

	[IteratorStateMachine(typeof(_003CCreateMoney_003Ed__167))]
	private IEnumerator CreateMoney()
	{
		return null;
	}

	public void CollectedChestSave(ChestTypes chestType, int amount = 1)
	{
	}

	public void RegisterRunCurrencyReward(CurrencyTypes type, float amount, Sprite icon = null)
	{
	}

	public void RegisterImmediatelyGrantedRunCurrencyReward(CurrencyTypes type, float amount, Sprite icon = null)
	{
	}

	public void RegisterRunEnergyReward(int baseAmount, int amount)
	{
	}

	[IteratorStateMachine(typeof(_003CLevelFail_003Ed__183))]
	public IEnumerator LevelFail()
	{
		return null;
	}

	private void StartFailRewardMultiplierSequence(float runRewardMultiplier, int failGold, int failGem, int failRedGem, int failShopGem, int failEventCurrency, int failBaseEnergy, int failEnergy, int earnedFailCommonChest, int earnedFailEpicChest, int earnedFailCollectibleChest)
	{
	}

	[IteratorStateMachine(typeof(_003CFailRewardMultiplierSequence_003Ed__185))]
	private IEnumerator FailRewardMultiplierSequence(float runRewardMultiplier, int failGold, int failGem, int failRedGem, int failShopGem, int failEventCurrency, int failBaseEnergy, int failEnergy, int earnedFailCommonChest, int earnedFailEpicChest, int earnedFailCollectibleChest)
	{
		return null;
	}

	private void StartCompleteRewardMultiplierSequence(float runRewardMultiplier, int completeGold, int completeGem, int completeRedGem, int completeShopGem, int completeEventCurrency, int completeBaseEnergy, int completeEnergy, int earnedCommonChest, int earnedEpicChest, int earnedCollectibleChest)
	{
	}

	[IteratorStateMachine(typeof(_003CCompleteRewardMultiplierSequence_003Ed__187))]
	private IEnumerator CompleteRewardMultiplierSequence(float runRewardMultiplier, int completeGold, int completeGem, int completeRedGem, int completeShopGem, int completeEventCurrency, int completeBaseEnergy, int completeEnergy, int earnedCommonChest, int earnedEpicChest, int earnedCollectibleChest)
	{
		return null;
	}

	private void AnimateFailDoubleLootRewards(int failGold, int failGem, int failRedGem, int failEnergy, float duration)
	{
	}

	private void AnimateCompleteDoubleLootRewards(int completeGem, int completeRedGem, int completeEnergy, float duration)
	{
	}

	private void AnimateRewardPrize(ClaimMultiplier rewardPanel, EndGameRewardType rewardType, float fromValue, float toValue, float duration, bool highlightDoubleLoot = false)
	{
	}

	public void FailBtnVisualizer()
	{
	}

	private void LockEndGameRewardActions()
	{
	}

	private void UnlockX2ClaimActionsForRetry()
	{
	}

	private static void SetButtonInteractable(Button button, bool interactable)
	{
	}

	public void CompleteX2RewardWShopGem()
	{
	}

	private void OpenNoCrystalPanel()
	{
	}

	public void CompleteX2RewardClaim()
	{
	}

	public void CompleteWeeklyBtnClaimX2()
	{
	}

	private float GetDisplayedX2RewardAmount(CurrencyTypes type, float runRewardMultiplier)
	{
		return 0f;
	}

	private float GetDisplayedX2EnergyAmount()
	{
		return 0f;
	}

	private float GetDisplayedActiveX2EnergyAmount()
	{
		return 0f;
	}

	private float GetDisplayedFailX2RewardAmount(CurrencyTypes type, int failGold, int failGem, int failRedGem = 0)
	{
		return 0f;
	}

	private float GetDisplayedActiveX2RewardAmount(CurrencyTypes type)
	{
		return 0f;
	}

	private void ClaimPendingRunRewards(bool x2)
	{
	}

	private void ClaimRunCurrency(CurrenciesHandler currencies, CurrencyTypes type, int amount, bool x2)
	{
	}

	private bool ShouldClaimRunCurrency(CurrencyTypes type, bool x2)
	{
		return false;
	}

	private Vector3 GetRewardSpawnPosition(EndGameRewardType type, bool x2 = false)
	{
		return default;
	}

	private void ResolveEndGameRewardPanels()
	{
	}

	private static void ResolveRewardPanel(GameObject root, ref ClaimMultiplier normalPanel, ref ClaimMultiplier x2Panel)
	{
	}

	private static EndGameRewardType GetEndGameRewardType(CurrencyTypes type)
	{
		return EndGameRewardType.Gold;
	}

	private void DelayActivateRewardedBtn()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForPendingWorldRewardCollections_003Ed__221))]
	private IEnumerator WaitForPendingWorldRewardCollections()
	{
		return null;
	}

	private void DisableUIObjs()
	{
	}

	[IteratorStateMachine(typeof(_003CSoftRestartRunRoutine_003Ed__223))]
	private IEnumerator SoftRestartRunRoutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPerformSoftRunResetRoutine_003Ed__224))]
	private IEnumerator PerformSoftRunResetRoutine()
	{
		return null;
	}

	private void ResetEndGameRewardMultiplierPanels()
	{
	}

	private bool IsEpicChestType(ChestTypes chestType)
	{
		return false;
	}

	public void ChangeScene(int sceneIndex)
	{
	}

	public void ChangeScene(string sceneName)
	{
	}

	[IteratorStateMachine(typeof(_003CDelanLoadScene_003Ed__229))]
	private IEnumerator DelanLoadScene(string sceneName)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDelanLoadScene_003Ed__230))]
	private IEnumerator DelanLoadScene(int sceneIndex)
	{
		return null;
	}

	private void HandleSoundandHapticStates()
	{
	}

	private void HandleVolume()
	{
	}

	private void HandleMusicVolume()
	{
	}

	public void ToggleHaptic()
	{
	}

	public void ToggleNotification()
	{
	}

	public static void SendCustomEvent(string eventName, int parameter)
	{
	}

	private void SendLevelEvents(int id)
	{
	}

	public void RefreshBackgroundMusicState(bool forceRestart = false)
	{
	}

	public void RefreshStageIndicatorVisibility()
	{
	}

	public void RefreshTalentMenuUnlockState()
	{
	}

	public void SetMenuButtonsLocked(bool isLocked)
	{
	}

	public void LoadHapticScene()
	{
	}

	private void OnDestroy()
	{
	}

	private void TrackRunGold()
	{
	}

	private void TrackRunGem()
	{
	}

	private void TrackRunGreenGem()
	{
	}

	private void TrackRunShopGem()
	{
	}

	private void TrackRunCurrency(CurrencyTypes type, ref int lastTrackedValue, ref int runEarnedValue)
	{
	}

	private void LogRunResourceCollection(string resourceName, int amount)
	{
	}

	private void SetEarnedTextState(EndGameReward text, int value)
	{
	}
}
