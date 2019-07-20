
## Gamer UI  
![Gamer UI Screenshot](https://i.imgur.com/tB0IE6g.png)  
[![forthebadge](https://forthebadge.com/images/badges/designed-in-ms-paint.svg)](https://forthebadge.com)
[![forthebadge](https://forthebadge.com/images/badges/made-with-c-sharp.svg)](https://forthebadge.com)
[![forthebadge](https://forthebadge.com/images/badges/mom-made-pizza-rolls.svg)](https://forthebadge.com)  

I made this project so that others could learn how to make a Synapse X custom UI using WinForms. I've seen a lot of people who are clueless on how to do it, so this should serve as a good example. I myself am not very experienced in C#, so the code might not be the best.

### Features
  * Monaco Editor with custom Synapse global highlighting and intellisense
  * Synapse X WebSocket API Interoperability
  * Script Hub
  * Automatically add custom globals on inject

### To-do
  * Local HTTP server for relaying information across Gamer UI and Roblox
  * Finish WebSocket API (interop. and add other services)
  * Themes

### Dependencies
  * [SxLib](https://github.com/LoukaMB/SynapseX/wiki/SxLib-API)
  * [CefSharp](http://cefsharp.github.io/)
  * [WebSocket-Sharp](https://github.com/sta/websocket-sharp)
  * [Syncfusion Enterprise Studio for WinForms](https://www.syncfusion.com/products/communitylicense)

## WebSocket API Re-Implementation 
Gamer UI has a WebSocket API that aims to be interoperable with the native Synapse X API. The following services are to be implemented:  

 - [x] Execute 
 - [x] Editor
 - [x] Script Hub
 - [ ] Attach
 - [ ] Custom

### Script Hub Service
Gamer UI not only emulates the Synapse X WebSocket API, it expands upon it. With the Script Hub service, you can execute scripts from the Synapse X script hub. Below are response codes and examples in Node.js and C#.  

**Response Codes**
  * OK - The script was successfully executed.
  * NOT_READY - SxLib is either not loaded or not attached.
  * INVALID_ENTRY - The entry provided was not found in the script hub.

**Examples:**

  * ***Node***
```js
const WebSocket = require("ws");
const ws = new WebSocket("ws://localhost:24892/scripthub");

ws.on("open", function open() 
{
  ws.send("Dark Dex");
});

ws.on("message", function incoming(data)
{
  console.log(data); //Response Code
});
```
  * ***C#***
```csharp
using System;
using WebSocketSharp;

namespace TestWebSocket
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var ws = new WebSocket("ws://localhost:24892/scripthub"))
            {
                ws.OnMessage += (sender, e) =>
                    Console.WriteLine(e.Data); //Response Code"

                ws.Connect();
                ws.Send("Dark Dex");

                Console.ReadKey(true);
            }
        }
    }
}
```


