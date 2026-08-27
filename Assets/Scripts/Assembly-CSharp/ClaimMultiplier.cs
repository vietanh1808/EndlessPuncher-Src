using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class ClaimMultiplier : MonoBehaviour
{
	[Serializable]
	public class RewardEndGame
	{
		public EndGameRewardType type;

		public TextMeshProUGUI amount;

		public GameObject holder;

		public GameObject holderMultiplier;

		public TextMeshProUGUI bonusText;
	}

	[CompilerGenerated]
	private sealed class _003CAnimatePrizeRoutine_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public ClaimMultiplier _003C_003E4__this;

		public TextMeshProUGUI amountText;

		public bool highlightDoubleLoot;

		public float fromValue;

		public float toValue;

		private float _003CsafeDuration_003E5__2;

		private float _003Celapsed_003E5__3;

		private Vector3 _003CdefaultScale_003E5__4;

		private Color _003CdefaultColor_003E5__5;

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
		public _003CAnimatePrizeRoutine_003Ed__24(int _003C_003E1__state)
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

	private const float PrizeCountingScaleMultiplier = 1.5f;

	private const float MultiplierHolderBounceDuration = 0.35f;

	private const float MultiplierHolderBounceOvershoot = 2f;

	private static readonly Color DoubleLootAmountColor;

	[SerializeField]
	private GameObject multiplierHolder;

	[SerializeField]
	private TextMeshProUGUI multiplierText;

	private readonly Dictionary<TextMeshProUGUI, Vector3> defaultPrizeTextScales;

	private readonly Dictionary<TextMeshProUGUI, Color> defaultPrizeTextColors;

	private Vector3 multiplierHolderDefaultScale;

	private bool hasMultiplierHolderDefaultScale;

	private Tween multiplierHolderTween;

	private readonly Dictionary<GameObject, Vector3> defaultMultiplierScales;

	private readonly Dictionary<GameObject, Tween> multiplierTweens;

	public List<RewardEndGame> rewardHolder;

	public void ResetCloseAll()
	{
	}

	public void WritePrize(EndGameRewardType type, float value, Sprite iconOverride = null)
	{
	}

	public void HidePrize(EndGameRewardType type)
	{
	}

	public void SetPrizeAmount(EndGameRewardType type, float value)
	{
	}

	public void BouncePrizeFrame(EndGameRewardType type, float punchScale = 0.25f)
	{
	}

	public void BlinkPrizeAmount(EndGameRewardType type, float duration = 0.2f)
	{
	}

	public Vector3 GetRewardPosition(EndGameRewardType type)
	{
		return default;
	}

	private static Transform FindRewardIcon(Transform holder)
	{
		return null;
	}

	public Coroutine AnimatePrize(EndGameRewardType type, float fromValue, float toValue, float duration, bool highlightDoubleLoot = false)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAnimatePrizeRoutine_003Ed__24))]
	private IEnumerator AnimatePrizeRoutine(TextMeshProUGUI amountText, float fromValue, float toValue, float duration, bool highlightDoubleLoot)
	{
		return null;
	}

	private Vector3 GetDefaultPrizeTextScale(TextMeshProUGUI amountText)
	{
		return default;
	}

	private Color GetDefaultPrizeTextColor(TextMeshProUGUI amountText)
	{
		return default;
	}

	private void ResetPrizeTextScales()
	{
	}

	public void WriteMultiplier(float multiplierValue, params EndGameRewardType[] excludedRewardTypes)
	{
	}

	private void SetMultiplierHolderVisible(bool isVisible)
	{
	}

	private void CacheMultiplierHolderDefaultScale()
	{
	}

	private void ResetMultiplierHolderScale()
	{
	}

	private void SetRewardMultiplierVisible(GameObject rewardMultiplier, bool isVisible)
	{
	}

	private Vector3 GetDefaultMultiplierScale(GameObject rewardMultiplier)
	{
		return default;
	}

	private void KillMultiplierTween(GameObject rewardMultiplier)
	{
	}

	private static string FormatClaimValue(float value)
	{
		return null;
	}

	private static string FormatMultiplierValue(float value)
	{
		return null;
	}
}
