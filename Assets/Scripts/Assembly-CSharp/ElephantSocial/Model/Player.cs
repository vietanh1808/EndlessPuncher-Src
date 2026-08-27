using System;
using ElephantSocial.Team.Model;
using ElephantSocial.Team.Model.Enum;
using ElephantSocial.Team.Model.Response;
using ElephantUniTask.Threading.Tasks;
using Newtonsoft.Json;

namespace ElephantSocial.Model
{
	[Serializable]
	public class Player
	{
		[JsonProperty("player_name")]
		public string playerName;

		[JsonProperty]
		public string country;

		[JsonProperty("social_id")]
		public string socialId;

		[JsonProperty("profile_picture")]
		public string profilePicture;

		public string content;

		public int status;

		public int badge;

		[JsonProperty("level")]
		public long level;

		[JsonProperty("server_id")]
		public int serverId;

		[JsonProperty("team")]
		public TeamResponse team;

		[JsonProperty("stats")]
		public MemberStat[] stats;

		public long GetStatValue(string statMetaId)
		{
			return 0L;
		}

		public UniTask UpdateStatAsync(string statMetaId, StatOp op, long val)
		{
			return default;
		}

		public void FillBaseData(Player player)
		{
		}

		public Player Clone()
		{
			return null;
		}
	}
}
