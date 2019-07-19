using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using sxlib;
using sxlib.Specialized;

namespace GamerUI
{
    /// <summary>
    /// Main class for interfacing with SxLib
    /// </summary>
    class SynXLib
    {
        public static void Initialize(Form form)
        {
            Syn = SxLib.InitializeWinForms(form, Properties.Settings.Default.SynapseDirectory);
            Syn.LoadEvent += LoadHandler;
            Syn.AttachEvent += AttachHandler;
            Syn.ScriptHubEvent += ScriptHubHandler;
            Syn.Load();
        }
        private static void LoadHandler(SxLibBase.SynLoadEvents Status, object Param)
        {
            switch (Status)
            {
                case SxLibBase.SynLoadEvents.NOT_UPDATED:
                    SetStatus("Synapse X is not updated!", false);
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                    break;
                case SxLibBase.SynLoadEvents.CHECKING_WL:
                    SetStatus("checking whitelist...", false);
                    break;
                case SxLibBase.SynLoadEvents.DOWNLOADING_DATA:
                    SetStatus("downloading data...", false);
                    break;
                case SxLibBase.SynLoadEvents.CHECKING_DATA:
                    SetStatus("checking data...", false);
                    break;
                case SxLibBase.SynLoadEvents.DOWNLOADING_DLLS:
                    SetStatus("downloading dlls...", false);
                    break;
                case SxLibBase.SynLoadEvents.READY:
                    SetStatus("SxLib ready!", true);
                    isReady = true;
                    Syn.ScriptHub();
                    break;
            }
        }
        private static void AttachHandler(SxLibBase.SynAttachEvents Status, object Param)
        {
            switch (Status)
            {
                case SxLibBase.SynAttachEvents.PROC_DELETION:
                    attached = false;
                    break;
                case SxLibBase.SynAttachEvents.ALREADY_INJECTED:
                    SetStatus("already injected!", true);
                    break;
                case SxLibBase.SynAttachEvents.CHECKING:
                    SetStatus("checking...", false);
                    break;
                case SxLibBase.SynAttachEvents.INJECTING:
                    SetStatus("injecting...", false);
                    break;
                case SxLibBase.SynAttachEvents.CHECKING_WHITELIST:
                    SetStatus("checking whitelist...", false);
                    break;
                case SxLibBase.SynAttachEvents.SCANNING:
                    SetStatus("scanning...", false);
                    break;
                case SxLibBase.SynAttachEvents.READY:
                    SetStatus("ready!", true);
                    attached = true;
                    // execute the init script
                    var assembly = Assembly.GetExecutingAssembly();
                    string resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith("InitScript.lua"));
                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        Syn.Execute(reader.ReadToEnd());
                    }
                    break;
                case SxLibBase.SynAttachEvents.FAILED_TO_FIND:
                    SetStatus("failed to find Roblox!", true);
                    break;
                case SxLibBase.SynAttachEvents.FAILED_TO_ATTACH:
                    SetStatus("failed to attach!", true);
                    break;
                case SxLibBase.SynAttachEvents.NOT_INJECTED:
                    SetStatus("not injected!", true);
                    break;
                // autoupdate events
                case SxLibBase.SynAttachEvents.NOT_RUNNING_LATEST_VER_UPDATING:
                    SetStatus("updating...", false);
                    MessageBox.Show("Gamer UI is auto updating Synapse X.", "Gamer UI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case SxLibBase.SynAttachEvents.UPDATING_DLLS:
                    SetStatus("updating dlls...", false);
                    break;
                case SxLibBase.SynAttachEvents.NOT_UPDATED:
                    SetStatus("Synapse X is not updated!", false);
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                    break;
                case SxLibBase.SynAttachEvents.FAILED_TO_UPDATE:
                    SetStatus("failed to update!", true);
                    MessageBox.Show("Gamer UI has failed to update. Please restart the application to update manually.", "Gamer UI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case SxLibBase.SynAttachEvents.REINJECTING:
                    SetStatus("update complete!",true);
                    break;
            }
        }
        private static void ScriptHubHandler(List<SxLibBase.SynHubEntry> hubEntries)
        {
            hubScripts = hubEntries;
            SetStatus("hub loaded!", true);
            new ScriptHub();
            hubLoaded = true;
        }

        public static SxLibBase.SynHubEntry GetHubEntryByName(string name)
        {
            if (hubLoaded)
            {
                foreach(SxLibBase.SynHubEntry script in hubScripts)
                {
                    if (script.Name == name)
                    {
                        return script;
                    }
                }
                return null;
            } else
            {
                return null;
            }
        }

        public static void ExecuteScript(string script)
        {
            if (isReady)
            {
                if (attached)
                {
                    Syn.Execute(script);
                } else
                {
                    SetStatus("not attached!", true);
                }
            } else
            {
                SetStatus("not ready!", true);
            }
        }

        public static Action<string, bool> SetStatus;
        public static bool isReady;
        public static bool attached;
        public static bool hubLoaded;
        public static SxLibWinForms Syn;
        public static List<SxLibBase.SynHubEntry> hubScripts;
    }
}
