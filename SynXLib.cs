using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using sxlib;
using sxlib.Specialized;

namespace GamerUI
{
    class SynXLib
    {
        public static void Initialize(Form form)
        {
            Syn = SxLib.InitializeWinForms(form, Properties.Settings.Default.SynapseDirectory);
            Syn.LoadEvent += LoadHandler;
            Syn.ScriptHubEvent += ScriptHubHandler;
        }
        private static void LoadHandler(SxLibBase.SynLoadEvents Status)
        {
            switch (Status)
            {
                case SxLibBase.SynLoadEvents.NOT_UPDATED:
                    SetStatus("Synapse X is not updated!");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                    break;
                case SxLibBase.SynLoadEvents.CHECKING_WL:
                    SetStatus("checking whitelist...");
                    break;
                case SxLibBase.SynLoadEvents.DOWNLOADING_DATA:
                    SetStatus("downloading data...");
                    break;
                case SxLibBase.SynLoadEvents.CHECKING_DATA:
                    SetStatus("checking data...");
                    break;
                case SxLibBase.SynLoadEvents.DOWNLOADING_DLLS:
                    SetStatus("downloading dlls...");
                    break;
                case SxLibBase.SynLoadEvents.READY:
                    SetStatus("ready!");
                    isReady = true;
                    break;
                default:
                    break;
            }
        }
        private static void ScriptHubHandler(List<SxLibBase.SynHubEntry> hubEntries)
        {
            hubScripts = hubEntries;
            SetStatus("hub loaded!");
        }

        public static Action<string> SetStatus;
        public static bool isReady = false;
        public static bool attached = false;
        public static SxLibWinForms Syn;
        public static List<SxLibBase.SynHubEntry> hubScripts;
    }
}
