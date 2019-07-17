using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamerUI
{
    /// <summary>
    /// Main GamerUI form
    /// </summary>
    public partial class MainUI : Form
    {
        public MainUI()
        {
            if (!File.Exists(Path.Combine(Properties.Settings.Default.SynapseDirectory, "Synapse X.exe")))
            {
                using (FolderBrowserDialog dlg = new FolderBrowserDialog())
                {
                    dlg.Description = "Select your Synapse X directory.";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        Properties.Settings.Default.SynapseDirectory = dlg.SelectedPath;
                        Properties.Settings.Default.Save();
                    }
                }
            }
            InitializeComponent(); // initialize the main form
            SynXLib.SetStatus = (Action<string, bool>)Delegate.Combine(SynXLib.SetStatus, new Action<string, bool>(SetStatus)); // connect SetStatus() to synxlib
            form = this;
            panel1.MouseDown += GUI_MouseDown; //
            panel1.MouseMove += GUI_MouseMove; // connect topbar drags
            panel1.MouseUp += GUI_MouseUp; //
            foreach (string path in Directory.GetFiles(Path.Combine(Properties.Settings.Default.SynapseDirectory, "scripts")))
            {
                string fileName = Path.GetFileName(path);
                string a = fileName.Substring(fileName.Length - 3, 3).ToLower();
                bool flag = a == "lua" || a == "txt";
                if (flag)
                {
                    ScriptsList.Items.Add(fileName);
                }
            }
            ScriptsList.SelectedValueChanged += ScriptsList_ValueChanged;
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                SynXLib.Initialize(this); // initialize synapse
            }).Start();
            Editor.InitializeChromium(); // initialize the editor
            WebSocket.StartSocket(); // start websocket service
        }
        public static Form form;
        public static void Wait(int seconds)
        {
            int ms = seconds * 1000;
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < ms)
            {
                Application.DoEvents();
            }
        }
        private void ScriptsList_ValueChanged(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.Combine(Properties.Settings.Default.SynapseDirectory, "scripts"), ScriptsList.SelectedItem.ToString());
            Editor.SetText(File.ReadAllText(path));
            ScriptsList.ClearSelected();
        }
        public void SetStatus(string status, bool erase)
        {
            StatusLabel.Text = status;
            if (erase) {
                Wait(2);
                StatusLabel.Text = "";
            }
        }

        private bool mouseDown;
        private Point lastLocation;

        private void GUI_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void GUI_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }
        private void GUI_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Editor.SetText("");
        }


        private void OpenFile_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.CheckFileExists = true;
                openFileDialog.Title = "Open File";
                openFileDialog.Filter = "Script Files (*.txt, *.lua)|*.txt;*.lua|All Files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;
                bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
                if (flag)
                {
                    Editor.SetText(File.ReadAllText(openFileDialog.FileName));
                }
            }
        }

        private void ExecuteFile_Click(object sender, EventArgs e)
        {
            if (SynXLib.attached)
            {
                this.ActiveControl = null;
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.CheckFileExists = true;
                    openFileDialog.Title = "Open File";
                    openFileDialog.Filter = "Script Files (*.txt, *.lua)|*.txt;*.lua|All Files (*.*)|*.*";
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        SynXLib.ExecuteScript(File.ReadAllText(openFileDialog.FileName));
                    }
                }
            } else
            {
                SetStatus("not attached!", true);
            }
        }
        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScriptsList.Items.Clear();
            foreach (string path2 in Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scripts")))
            {
                string fileName = Path.GetFileName(path2);
                string a = fileName.Substring(fileName.Length - 3, 3).ToLower();
                bool flag = a == "lua" || a == "txt";
                if (flag)
                {
                    ScriptsList.Items.Add(fileName);
                }
            }
        }
        private readonly string onImage = "https://i.vgy.me/nSqaF2.png";
        private readonly string offImage = "https://i.vgy.me/yRBaFs.png";
        private bool Checked_;
        private bool Checked
        {
            get { return Checked_; }
            set
            {
                Checked_ = value;
                TopMost = value;
                try
                {
                    ScriptHub.form.TopMost = value;
                }
                catch { }
            }
        }
        private void CheckBox_Click(object sender, EventArgs e)
        {
            Checked = !Checked;
            if (Checked)
            {
                CheckBox.ImageLocation = onImage;
            }
            else
            {
                CheckBox.ImageLocation = offImage;
            }
        }
        private void KillRoblox_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("RobloxPlayerBeta").Length < 1)
            {
                SetStatus("failed to find Roblox!", true);
            }
            else
            {
                Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
                foreach (Process process in processesByName)
                {
                    try
                    {
                        process.Kill();
                    }
                    catch (Exception ex)
                    {
                        SetStatus("error while closing Roblox: " + ex.Message, true);
                    }
                }
            }
        }
        private void Execute_Click(object sender, EventArgs e)
        {
            SynXLib.ExecuteScript(Editor.GetText());
        }
        private void Attach_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                SynXLib.Syn.Attach();
            }).Start(); // dunno if this does anything, seems to help the button glitch go away :thinking:
        }

        private void ScriptHub_Click(object sender, EventArgs e)
        {
            if (SynXLib.hubLoaded)
            {
                ScriptHub.form.Visible = true;
            } else
            {
                SetStatus("hub not loaded!", true);
            }
        }
    }
}
