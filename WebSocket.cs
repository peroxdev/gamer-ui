using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;
using sxlib;
using sxlib.Specialized;

/// <summary>
/// Created a WebSocket server with Synapse X Web Socket API interoperability
/// </summary>

namespace GamerUI
{
    internal sealed class EditorService : WebSocketBehavior
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
    internal sealed class ExecuteService : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            if (SynXLib.attached && SynXLib.isReady)
            {
                SynXLib.Syn.Execute(e.Data);
                Send("OK");
            } else
            {
                Send("NOT_READY");
            }
        }
    }
    internal sealed class ScriptHubService : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            if (SynXLib.attached && SynXLib.isReady)
            {
                SxLibBase.SynHubEntry entry = null;
                try
                {
                    entry = SynXLib.GetHubEntryByName(e.Data);
                } catch (Exception)
                {
                    Send("INVALID_ENTRY");
                }
                if (entry != null)
                {
                    entry.Execute();
                    Send("OK");
                }
            } else
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
            WSServer.AddWebSocketService<ExecuteService>("/execute");
            WSServer.AddWebSocketService<ScriptHubService>("/scripthub");
            WSServer.Start();
        }
        public static WebSocketServer WSServer = new WebSocketServer("ws://localhost:24892");
    }
}
