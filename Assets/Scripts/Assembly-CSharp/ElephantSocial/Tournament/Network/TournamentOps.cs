using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ElephantSDK;
using ElephantSocial.Tournament.Model;
using UnityEngine.Networking;

namespace ElephantSocial.Tournament.Network
{
	public class TournamentOps : GenericResponseOps
	{
		[CompilerGenerated]
		private sealed class _003CCheckServerHealth_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TournamentOps _003C_003E4__this;

			public Action onError;

			public Action onSuccess;

			private UnityWebRequest _003Crequest_003E5__2;

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
			public _003CCheckServerHealth_003Ed__12(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private IEnumerator MakeRequest<T>(string url, object data, Action<GenericResponse<T>> onResponse, Action<string> onError, int timeout = 30) where T : new()
		{
			return null;
		}

		public IEnumerator AddScore(int score, int tournamentId, int scheduleId, int timeout, Action<GenericResponse<TournamentAddScoreResponse>> onResponse, Action<string> onError, Action<UnityWebRequest> onFailedResponse)
		{
			return null;
		}

		public IEnumerator AddScores(int tournamentId, int scheduleId, List<PlayerScore> scores, int timeout, Action<GenericResponse<TournamentBulkAddScoresResponse>> onResponse, Action<string> onError, Action<UnityWebRequest> onFailedResponse)
		{
			return null;
		}

		public IEnumerator GetBoard(int tournamentId, int scheduleId, Action<GenericResponse<TournamentBoardResponse>> onResponse, Action<string> onError)
		{
			return null;
		}

		public IEnumerator AddMatch(int tournamentId, int scheduleId, List<ScoreUpdate> scoreUpdates, Action<GenericResponse<object>> onResponse, Action<string> onError)
		{
			return null;
		}

		public IEnumerator ListMatches(int tournamentId, int scheduleId, Action<GenericResponse<List<TournamentMatchItem>>> onResponse, Action<string> onError)
		{
			return null;
		}

		public IEnumerator JoinTournament(int tournamentId, int scheduleId, int segmentId, Action<GenericResponse<TournamentJoinResponse>> onResponse, Action<string> onError)
		{
			return null;
		}

		public IEnumerator ClaimTournament(int tournamentId, int scheduleId, Action<GenericResponse<TournamentFinishResponse>> onResponse, Action<string> onError)
		{
			return null;
		}

		public IEnumerator GetTournaments(Action<GenericResponse<TournamentsResponse>> onResponse, Action<string> onError)
		{
			return null;
		}

		public IEnumerator GetMyTournaments(Action<GenericResponse<MyTournamentsResponse>> onResponse, Action<string> onError)
		{
			return null;
		}

		public IEnumerator GetMyTournamentResults(Action<GenericResponse<MyTournamentResultsResponse>> onResponse, Action<string> onError)
		{
			return null;
		}

		public void TournamentHealthCheck(Action onSuccess, Action onError)
		{
		}

		[IteratorStateMachine(typeof(_003CCheckServerHealth_003Ed__12))]
		private IEnumerator CheckServerHealth(Action onSuccess, Action onError)
		{
			return null;
		}
	}
}
