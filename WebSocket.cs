using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

/// <summary>
/// this class aims at creating a WebSocket API that is interoperable with synapse x's native one, while adding useful features
/// </summary>

namespace GamerUI
{
    internal class EditorService : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            var msg = e.Data;
            if (Editor.EditorIsReady)
            {
                Editor.SetText(msg);
                Send("OK");
            }
            else
            {
                Send("NOT_READY");
            }
        }
    }
    internal class WebSocket
    {
        public static void StartSocket()
        {
            WSServer.AddWebSocketService<EditorService>("/editor");
            WSServer.Start();
        }
        public static WebSocketServer WSServer = new WebSocketServer("ws://localhost:24892");
    }
}
