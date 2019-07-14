using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;

namespace GamerUI
{
    static class Editor
    {
        public static void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            Monaco = new ChromiumWebBrowser(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Monaco.html"))
            {
                Location = new System.Drawing.Point(8, 36),
                MinimumSize = new System.Drawing.Size(20, 20),
                Name = "Editor",
                Size = new System.Drawing.Size(628, 312),
                TabIndex = 2,
                Dock = System.Windows.Forms.DockStyle.None
            };
            MainUI.form.Controls.Add(Monaco);
            Monaco.LoadingStateChanged += (sender, args) =>
            {
                if (args.IsLoading == false)
                {
                    EditorIsReady = true;
                    // :grimacing:
                    var KeywordsValue = new List<string>
                    {
                        "_G", "true", "nil", "shared", "repeat", "return","game", "Enum", "script", "workspace","and", "break", "do", "else", "elseif", "end", "false", "for", "function", "goto", "if", "in", "local", "not", "or", "then", "until", "while"
                    };
                    var IntellisenseNoDocs = new List<string>
                    {
                        "error", "getfenv", "getmetatable", "newproxy", "next", "pairs", "pcall", "print", "rawequal", "rawget", "rawset", "select", "setfenv", "tonumber", "tostring", "type", "unpack", "xpcall", "delay", "require", "spawn", "tick", "typeof", "wait", "warn"
                    };
                    foreach (var Key in KeywordsValue)
                    {
                        AddIntellisense(Key, "Keyword", "", Key);
                    }
                    foreach (var Key in IntellisenseNoDocs)
                    {
                        AddIntellisense(Key, "Method", "", Key);
                    }
                    AddIntellisense("hookfunction", "Method", "Hooks function 'old', replacing it with the function 'hook'. The old function is returned, you must use it to call the function further.", "hookfunction");
                    AddIntellisense("getgenv", "Method", "Returns the environment that will be applied to each script ran by Synapse.", "getgenv");
                    AddIntellisense("keyrelease", "Method", "Releases 'key' on the keyboard. You can access the int key values on MSDN.", "keyrelease");
                    AddIntellisense("setclipboard", "Method", "Sets 'value' to the clipboard.", "setclipboard");
                    AddIntellisense("mouse2press", "Method", "Clicks down on the right mouse button.", "mouse2press");
                    AddIntellisense("getsenv(<LocalScript, ModuleScript> Script)", "Method", "Returns the environment of Script. Returns nil if the script is not running.", "getsenv");
                    AddIntellisense("checkcaller", "Method", "Returns true if the current thread was made by Synapse. Useful for metatable hooks.", "checkcaller");
                    AddIntellisense("bit", "Class", "Bit Library", "bit");
                    AddIntellisense("bit.bdiv", "Method", "Divides 'dividend' by 'divisor', remainder is not returned.", "bit.bdiv");
                    AddIntellisense("bit.badd", "Method", "Adds 'a' with 'b', allows overflows (unlike normal Lua).", "bit.badd");
                    AddIntellisense("bit.bsub", "Method", "Subtracts 'a' with 'b', allows overflows (unlike normal Lua).", "bit.badd");
                    AddIntellisense("bit.rshift", "Method", "Does a right shift on 'val' using 'by'.", "bit.rshift");
                    AddIntellisense("bit.band", "Method", "Does a logical AND (&) on 'val' using 'by'.", "bit.band");
                    AddIntellisense("bit.bor", "Method", "Does a logical OR (|) on 'val' using 'by'.", "bit.bor");
                    AddIntellisense("bit.bxor", "Method", "Does a logical XOR (^) on 'val' using 'by'.", "bit.bxor");
                    AddIntellisense("bit.bnot", "Method", "Does a logical NOT on 'val'.", "bit.bnot");
                    AddIntellisense("bit.bmul", "Method", "Multiplies 'val' using 'by', allows overflows (unlike normal Lua)", "bit.bmul");
                    AddIntellisense("bit.bswap", "Method", "Does a bitwise swap on 'val'.", "bit.bswap");
                    AddIntellisense("bit.tobit", "Method", "Converts 'val' into proper form for bitwise operations.", "bit.tobit");
                    AddIntellisense("bit.ror", "Method", "Rotates right 'val' using 'by'.", "bit.ror");
                    AddIntellisense("bit.lshift", "Method", "Does a left shift on 'val' using 'by'.", "bit.lshift");
                    AddIntellisense("bit.tohex", "Method", "Converts 'val' to a hex string.", "bit.tohex");
                    AddIntellisense("debug", "Class", "Debug Library", "debug");
                    AddIntellisense("debug.getconstant", "Method", "Returns the constant at index 'idx' in function 'fi' or level 'fi'.", "debug.getconstant");
                    AddIntellisense("debug.profilebegin", "Method", "Opens a microprofiler label.", "debug.profilebegin");
                    AddIntellisense("debug.profileend", "Method", "Closes the top microprofiler label.", "debug.profileend");
                    AddIntellisense("debug.traceback", "Method", "Returns a traceback of the current stack as a string.", "debug.traceback");
                    AddIntellisense("debug.getfenv", "Method", "Returns the environment of object 'o'.", "debug.getfenv");
                    AddIntellisense("debug.getupvalue", "Method", "Returns the upvalue with name 'upval' in function or level 'fi'.", "debug.getupvalue");
                    AddIntellisense("debug.getlocals", "Method", "Returns a table containing the upvalues at level 'lvl'.", "debug.getlocals");
                    AddIntellisense("debug.setmetatable", "Method", "Set the metatable of 'o' to 'mt'.", "debug.setmetatable");
                    AddIntellisense("debug.getconstants", "Method", "Retrieve the constants in function 'fi' or at level 'fi'.", "debug.getconstants");
                    AddIntellisense("debug.getupvalues", "Method", "Retrieve the upvalues in function 'fi' or at level 'fi'.", "debug.getupvalues");
                    AddIntellisense("debug.setlocal", "Method", "Set local 'localname' to value 'value' at level 'lvl'.", "debug.setlocal");
                    AddIntellisense("debug.setupvalue", "Method", "Set upvalue 'upvname' to value 'value' at level or function 'fi'.", "debug.setupvalue");
                    AddIntellisense("debug.setconstant", "Method", "Set constant 'consname' to tuple 'value' at level or function 'fi'.", "debug.setupvalue");
                    AddIntellisense("debug.getregistry", "Method", "Returns the registry", "debug.getregistry");
                    AddIntellisense("debug.getinfo", "Method", "Returns a table of info pertaining to the Lua function 'fi'.", "debug.getinfo");
                    AddIntellisense("debug.getlocal", "Method", "Returns the local with name 'localname' in level 'lvl'.", "debug.getlocal");
                    AddIntellisense("loadfile", "Method", "Loads in the contents of a file as a chunk and returns it if compilation is successful. Otherwise, if an error has occured during compilation, nil followed by the error message will be returned.", "loadfile");
                    AddIntellisense("loadstring", "Method", "Loads 'chunk' as a Lua function and returns it if compilation is succesful. Otherwise, if an error has occured during compilation, nil followed by the error message will be returned.", "loadstring");
                    AddIntellisense("writefile", "Method", "Writes 'contents' to the supplied filepath.", "writefile");
                    AddIntellisense("mousescroll", "Method", "Scrolls the mouse wheel virtually by 'px' pixels.", "mousescroll");
                    AddIntellisense("mouse2click", "Method", "Virtually presses the right mouse button.", "mouse2click");
                    AddIntellisense("islclosure", "Method", "Returns true if 'f' is an LClosure", "islclosure");
                    AddIntellisense("mouse1press", "Method", "Simulates a left mouse button press without releasing it.", "mouse1press");
                    AddIntellisense("mouse1release", "Method", "Simulates a left mouse button release.", "mouse1release");
                    AddIntellisense("keypress", "Method", "Simulates a key press for the specified keycode.", "keypress");
                    AddIntellisense("mouse2release", "Method", "Simulates a right mouse button release.", "mouse2release");
                    AddIntellisense("newcclosure", "Method", "Pushes a new c closure that invokes function 'f' upon call. Used for metatable hooks.", "newcclosure");
                    AddIntellisense("getinstances", "Method", "Returns a list of all instances within the game.", "getinstances");
                    AddIntellisense("getnilinstances", "Method", "Returns a list of all instances parented to nil within the game.", "getnilinstances");
                    AddIntellisense("readfile", "Method", "Reads the contents of the file located at 'path' and returns it. If the file does not exist, it errors.", "readfile");
                    AddIntellisense("getscripts", "Method", "Returns a list of all scripts within the game.", "getscripts");
                    AddIntellisense("getrunningscripts", "Method", "Returns a list of all scripts currently running.", "getrunningscripts");
                    AddIntellisense("appendfile", "Method", "Appends 'content' to the file contents at 'path'. If the file does not exist, it errors", "appendfile");
                    AddIntellisense("listfiles", "Method", "Returns a table of files in 'folder'.", "listfiles");
                    AddIntellisense("isfile", "Method", "Returns if 'path' is a file or not.", "isfile");
                    AddIntellisense("isfolder", "Method", "Returns if 'path' is a folder or not.", "isfolder");
                    AddIntellisense("delfolder", "Method", "Deletes 'folder' in the workspace directory.", "delfolder");
                    AddIntellisense("delfile", "Method", "Deletes 'file' from the workspace directory.", "delfile");
                    AddIntellisense("getreg", "Method", "Returns the Lua registry.", "getreg");
                    AddIntellisense("getgc", "Method", "Returns a copy of the Lua GC list.", "getgc");
                    AddIntellisense("mouse1click", "Method", "Simulates a full left mouse button press.", "mouse1click");
                    AddIntellisense("getrawmetatable", "Method", "Retrieve the metatable of value irregardless of value's metatable's __metatable field. Returns nil if it doesn't exist.", "getrawmetatable");
                    AddIntellisense("setreadonly", "Method", "Sets table's read-only value to ro", "setreadonly");
                    AddIntellisense("isreadonly", "Method", "Returns table's read-only condition.", "isreadonly");
                    AddIntellisense("getrenv", "Method", "Returns the global Roblox environment for the LocalScript state.", "getrenv");
                    AddIntellisense("decompile", "Method", "Decompiles Script and returns the decompiled script. If the decompilation fails, then the return value will be an error message.", "decompile");
                    AddIntellisense("dumpstring", "Method", "Returns the Roblox formatted bytecode for source string 'Script'.", "dumpstring");
                    AddIntellisense("getloadedmodules", "Method", "Returns all ModuleScripts loaded in the game.", "getloadedmodules");
                    AddIntellisense("isrbxactive", "Method", "Returns if the Roblox window is in focus.", "getloadedmodules");
                    AddIntellisense("getcallingscript", "Method", "Gets the script that is calling this function.", "getcallingscript");
                    AddIntellisense("setnonreplicatedproperty", "Method", "Sets the prop property of obj, not replicating to the server. Useful for anticheat bypasses.", "setnonreplicatedproperty");
                    AddIntellisense("getconnections", "Method", "Gets a list of connections to the specified signal. You can then use :Disable and :Enable on the connections to disable/enable them.", "getconnections");
                    AddIntellisense("getspecialinfo", "Method", "Gets a list of special properties for MeshParts, UnionOperations, and Terrain.", "getspecialinfo");
                    AddIntellisense("messagebox", "Method", "Makes a MessageBox with 'message', 'title', and 'options' as options.", "messagebox");
                    AddIntellisense("messageboxasync", "Method", "Makes a MessageBox with 'message', 'title', and 'options' as options.", "messageboxasync");
                    AddIntellisense("rconsolename", "Method", "Sets the currently allocated console title to 'title'.", "rconsolename");
                    AddIntellisense("rconsoleinput", "Method", "Yields until the user inputs information into ther console. Returns the input the put in.", "rconsoleinput");
                    AddIntellisense("rconsoleinputasync", "Method", "Yields until the user inputs information into ther console. Returns the input the put in.", "rconsoleinputasync");
                    AddIntellisense("rconsoleprint", "Method", "Prints 'message' into the console.", "rconsoleprint");
                    AddIntellisense("rconsoleinfo", "Method", "Prints 'message' into the console, with a info text before it.", "rconsoleinfo");
                    AddIntellisense("rconsolewarn", "Method", "Prints 'message' into the console, with a warning text before it.", "rconsolewarn");
                    AddIntellisense("rconsoleerr", "Method", "Prints 'message' into the console, with a error text before it.", "rconsoleerr");
                    AddIntellisense("fireclickdetector", "Method", "Fires click detector 'detector' with 'distance'. If a distance is not provided, it will be 0.", "fireclickdetector");
                    AddIntellisense("firetouchinterest", "Method", "Fires touch 'transmitter' with 'part'. Use 0 to toggle it being touched, 1 for it not being toggled.", "firetouchinterest");
                    AddIntellisense("saveinstance", "Method", "Saves the Roblox game into your workspace folder.", "saveinstance");
                    AddIntellisense("syn", "Class", "Synapse X Library", "syn");
                    AddIntellisense("syn.crypt.encrypt", "Method", "Encrypt's data with key.", "syn.crypt.encrypt");
                    AddIntellisense("syn.crypt.decrypt", "Method", "Decrypt's data with key.", "syn.crypt.decrypt");
                    AddIntellisense("syn.crypt.hash", "Method", "Hashes data.", "syn.crypt.decrypt");
                    AddIntellisense("syn.crypt.base64.encode", "Method", "Encodes data with bas64.", "syn.crypt.base64.encode");
                    AddIntellisense("syn.crypt.base64.decode", "Method", "Decodes data with bas64.", "syn.crypt.base64.encode");
                    AddIntellisense("syn.cache_replace", "Method", "Replace obj in the cache with t_obj.", "syn.cache_replace");
                    AddIntellisense("syn.cache_invalidate", "Method", "Invalidate obj's cache entry, forcing a recache upon the next lookup.", "syn.invalidate_cache");
                    AddIntellisense("syn.set_thread_identity", "Method", "Sets the current thread identity after a Task Scheduler cycle is performed.", "syn.set_thread_identity");
                    AddIntellisense("syn.get_thread_identity", "Method", "Returns the current thread identity.", "syn.get_thread_identity");
                    AddIntellisense("syn.is_cached", "Method", "Returns true if the instance is currently cached within the registry.", "syn.is_cached");
                    AddIntellisense("syn.write_clipboard", "Method", "Writes 'content' to the current Windows clipboard.", "syn.write_clipboard");
                    AddIntellisense("mousemoverel", "Method", "Moves the mouse cursor relatively to the current mouse position by coordinates 'x' and 'y'.", "mousemoverel");
                    AddIntellisense("syn.cache_replace", "Method", "Replace obj in the cache with t_obj.", "syn.cache_replace");
                    AddIntellisense("syn.cache_invalidate", "Method", "Invalidate obj's cache entry, forcing a recache upon the next lookup.", "syn.invalidate_cache");
                }
            };
        }
        public static void SetText(string text)
        {
            if ((Monaco != null) && (EditorIsReady))
            {
                Monaco.ExecuteScriptAsync("SetText", new object[] { text });
            }
        }
        public static string GetText()
        {
            if ((Monaco != null) && (EditorIsReady))
            {
                var result = Monaco.GetMainFrame().EvaluateScriptAsync("GetText()").Result;
                return (string)result.Result;
            }
            return "";
        }
        public static void AddIntellisense(string label, string type, string description, string insert)
        {
            if ((Monaco != null) && (EditorIsReady))
            {
                Monaco.ExecuteScriptAsync("AddIntellisense", new object[] {
                    label,
                    type,
                    description,
                    insert
                });
            }
        }
        public static ChromiumWebBrowser Monaco;
        public static bool EditorIsReady;
    }
}
