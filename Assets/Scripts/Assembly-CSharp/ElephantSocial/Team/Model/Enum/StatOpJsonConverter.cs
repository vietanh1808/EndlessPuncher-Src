using System;
using Newtonsoft.Json;

namespace ElephantSocial.Team.Model.Enum
{
	public class StatOpJsonConverter : JsonConverter<StatOp>
	{
		public override void WriteJson(JsonWriter writer, StatOp value, JsonSerializer serializer)
		{
		}

		public override StatOp ReadJson(JsonReader reader, Type objectType, StatOp existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			return StatOp.Incr;
		}
	}
}
