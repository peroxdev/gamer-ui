using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamerUI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent(); // create the main form
            MainUI.form = this;
            panel1.MouseDown += GUI_MouseDown; // connect topbar drags
            panel1.MouseMove += GUI_MouseMove;
            panel1.MouseUp += GUI_MouseUp;
            Editor.InitializeChromium(); // initialize the editor
            WebSocket.StartSocket(); // start websocket service
        }

        public void Wait(int seconds)
        {
            int ms = seconds * 1000;
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < ms)
                Application.DoEvents();
        }

        public void SetStatus(string status)
        {
            StatusLabel.Text = status;
            Wait(2);
            StatusLabel.Text = "";
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
        public static Form form;

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Editor.SetText("");
        }

        private void AlwaysOnTop_OnChange(object sender, EventArgs e)
        {
            TopMost = AlwaysOnTop.Checked;
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
            if (SynX.attached)
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
                        //SynX.Execute(File.ReadAllText(openFileDialog.FileName));
                    }
                }
            } else
            {
                SetStatus("not attached!");
            }
        }
    }
}
