using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ElephantSocial.Tournament.Network;

namespace ElephantSocial.Tournament
{
	internal class TournamentManagerService
	{
		private class TournamentManagerState
		{
			public List<Tournament> Tournaments;

			public List<TournamentResult> TournamentResults;

			public long ServerTime;

			public bool IsInitialized;
		}

		private class UpdateConfig
		{
			public float CheckInterval;

			public float EndingSoonInterval;
		}

		[CompilerGenerated]
		private sealed class _003CUpdateTournamentsRoutine_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TournamentManagerService _003C_003E4__this;

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
			public _003CUpdateTournamentsRoutine_003Ed__21(int _003C_003E1__state)
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
		private Action m_OnTournamentsUpdated;

		private readonly TournamentRepository _tournamentRepository;

		private TournamentManagerState _tournamentManagerState;

		private readonly UpdateConfig _config;

		private float _lastServerTimeUpdateTime;

		private readonly TournamentOps _tournamentOps;

		public event Action OnTournamentsUpdated
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

		public void Init(Action onComplete)
		{
		}

		public List<Tournament> GetTournaments()
		{
			return null;
		}

		public Tournament GetTournamentById(int tournamentId)
		{
			return null;
		}

		public TournamentResult GetTournamentResultById(int tournamentId)
		{
			return null;
		}

		public long GetServerTime()
		{
			return 0L;
		}

		public void IsOnline(Action<bool> onResult)
		{
		}

		private void FetchTournamentData(bool isInitialFetch, Action onComplete = null)
		{
		}

		private void ProcessJoinedTournaments(List<TournamentAndScheduleId> tournamentIds)
		{
		}

		private void FetchBoardsForJoinedTournaments(List<Tournament> joinedTournaments, Action onComplete)
		{
		}

		private void SyncOfflineScores()
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateTournamentsRoutine_003Ed__21))]
		private IEnumerator UpdateTournamentsRoutine()
		{
			return null;
		}

		private bool CheckTournamentStates(List<Tournament> newTournaments, long time)
		{
			return false;
		}

		private void UpdateTournamentState(List<Tournament> newTournaments, long time)
		{
		}

		private bool AreTournamentDatasEqual(TournamentData a, TournamentData b)
		{
			return false;
		}

		private float GetUpdateInterval()
		{
			return 0f;
		}

		private void HandleTournamentClaimed(int tournamentId, int scheduleId)
		{
		}

		private void HandleTournamentJoined()
		{
		}

		private bool EnsureInitialized()
		{
			return false;
		}
	}
}
