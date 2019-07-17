using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sxlib.Specialized;

namespace GamerUI
{
    /// <summary>
    /// Synapse X script hub form
    /// </summary>
    public partial class ScriptHub : Form
    {
        public ScriptHub() // only create after the hub has loaded
        {
            InitializeComponent();
            ScriptHub.form = this;
            Visible = false;
            panel1.MouseDown += ScriptHub_MouseDown; //
            panel1.MouseMove += ScriptHub_MouseMove; // topbar drag
            panel1.MouseUp += ScriptHub_MouseUp; // 
            FormClosing += ScriptHub_FormClosing; // prevent close
            ScriptsList.SelectedValueChanged += ValueChanged; // change selected script
            foreach (SxLibBase.SynHubEntry synHubEntry in SynXLib.hubScripts) // add scripts from the hub
            {
                ScriptsList.Items.Add(synHubEntry.Name);
            }
        }
        private bool mouseDown;
        private Point lastLocation;
        public static Form form;
        private void ScriptHub_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void ScriptHub_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point((Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }
        private void ScriptHub_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void ScriptHub_FormClosing(object sender, FormClosingEventArgs e) // prevent the form from actually being closed
        {
            e.Cancel = true;
            Visible = false;
        }
        private void ValueChanged(object sender, EventArgs e)
        {
            SxLibBase.SynHubEntry selected = SynXLib.GetHubEntryByName(ScriptsList.SelectedItem.ToString());
            Description.Text = selected.Description;
            Thumbnail.ImageLocation = selected.Picture;
        }
        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void CloseHub_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
        private void Execute_Click(object sender, EventArgs e)
        {
            SxLibBase.SynHubEntry selected = SynXLib.GetHubEntryByName(ScriptsList.SelectedItem.ToString());
            selected.Execute();
        }
    }
}
