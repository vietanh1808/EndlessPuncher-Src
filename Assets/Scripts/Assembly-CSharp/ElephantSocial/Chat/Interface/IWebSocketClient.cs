using System;
using System.Collections.Generic;
using ElephantUniTask.Threading.Tasks;

namespace ElephantSocial.Chat.Interface
{
	public interface IWebSocketClient
	{
		WebSocketState State { get; }

		event Action OnOpen;

		event Action<string> OnClose;

		event Action<string> OnError;

		event Action<byte[]> OnMessage;

		UniTask ConnectAsync(string url, Dictionary<string, string> headers = null);

		UniTask CloseAsync();

		UniTask SendTextAsync(string data);
	}
}
