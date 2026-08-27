using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FOW
{
	public class HiderRevealer
	{
		public List<FogOfWarHider> HidersSeen;

		private BitArray seenBits;

		[CompilerGenerated]
		private Action<FogOfWarHider> m_OnHiderDeactivated;

		public event Action<FogOfWarHider> OnHiderDeactivated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool ProcessSeen(FogOfWarHider hider, bool seen)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void RemoveSwapBack(FogOfWarHider hider)
		{
		}

		public void HiderDeactivated(FogOfWarHider hider)
		{
		}

		public void ClearRevealedList()
		{
		}
	}
}
