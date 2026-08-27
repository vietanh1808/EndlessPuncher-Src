using System;
using Newtonsoft.Json;

namespace ElephantSocial.Model
{
	[Serializable]
	public class BoardPlayer
	{
		[JsonProperty("player_name")]
		public string playerName;

		[JsonProperty]
		public string country;

		[JsonProperty("social_id")]
		public string socialId;

		[JsonProperty("profile_picture")]
		public string profilePicture;

		public int status;

		public int badge;

		public int score;

		[JsonProperty("server_id")]
		public int serverId;

		[JsonProperty("team_info")]
		public TeamInfo teamInfo;

		public TeamInfo GetTeamInfo()
		{
			return null;
		}

		public void FillBaseData(Player player)
		{
		}

		public void FillBaseData(BoardPlayer player)
		{
		}

		public BoardPlayer Clone()
		{
			return null;
		}
	}
}
