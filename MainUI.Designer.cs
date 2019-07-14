using CefSharp;
using CefSharp.WinForms;
using System;
using System.IO;

namespace GamerUI
{
    partial class MainUI
    {
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.Execute = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Minimize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Clear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.OpenFile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ExecuteFile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Attach = new Bunifu.Framework.UI.BunifuFlatButton();
            this.KillRoblox = new Bunifu.Framework.UI.BunifuFlatButton();
            this.AlwaysOnTop = new Bunifu.Framework.UI.BunifuCheckbox();
            this.AlwaysOnTopLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ScriptHub = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Execute
            // 
            this.Execute.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Execute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Execute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Execute.BorderRadius = 0;
            this.Execute.ButtonText = "Execute";
            this.Execute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Execute.DisabledColor = System.Drawing.Color.Gray;
            this.Execute.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute.Iconcolor = System.Drawing.Color.Transparent;
            this.Execute.Iconimage = ((System.Drawing.Image)(resources.GetObject("Execute.Iconimage")));
            this.Execute.Iconimage_right = null;
            this.Execute.Iconimage_right_Selected = null;
            this.Execute.Iconimage_Selected = null;
            this.Execute.IconMarginLeft = 0;
            this.Execute.IconMarginRight = 0;
            this.Execute.IconRightVisible = false;
            this.Execute.IconRightZoom = 0D;
            this.Execute.IconVisible = false;
            this.Execute.IconZoom = 90D;
            this.Execute.IsTab = false;
            this.Execute.Location = new System.Drawing.Point(8, 355);
            this.Execute.Margin = new System.Windows.Forms.Padding(1);
            this.Execute.Name = "Execute";
            this.Execute.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Execute.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Execute.OnHoverTextColor = System.Drawing.Color.White;
            this.Execute.selected = false;
            this.Execute.Size = new System.Drawing.Size(81, 27);
            this.Execute.TabIndex = 0;
            this.Execute.Text = "Execute";
            this.Execute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Execute.Textcolor = System.Drawing.Color.White;
            this.Execute.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 30);
            this.panel1.TabIndex = 1;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 8.25F);
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusLabel.Location = new System.Drawing.Point(88, 12);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 13);
            this.StatusLabel.TabIndex = 4;
            // 
            // Minimize
            // 
            this.Minimize.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize.BorderRadius = 0;
            this.Minimize.ButtonText = "-";
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.DisabledColor = System.Drawing.Color.Gray;
            this.Minimize.Iconcolor = System.Drawing.Color.Transparent;
            this.Minimize.Iconimage = ((System.Drawing.Image)(resources.GetObject("Minimize.Iconimage")));
            this.Minimize.Iconimage_right = null;
            this.Minimize.Iconimage_right_Selected = null;
            this.Minimize.Iconimage_Selected = null;
            this.Minimize.IconMarginLeft = 0;
            this.Minimize.IconMarginRight = 0;
            this.Minimize.IconRightVisible = false;
            this.Minimize.IconRightZoom = 0D;
            this.Minimize.IconVisible = false;
            this.Minimize.IconZoom = 90D;
            this.Minimize.IsTab = false;
            this.Minimize.Location = new System.Drawing.Point(689, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Minimize.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Minimize.OnHoverTextColor = System.Drawing.Color.White;
            this.Minimize.selected = false;
            this.Minimize.Size = new System.Drawing.Size(30, 30);
            this.Minimize.TabIndex = 3;
            this.Minimize.Text = "-";
            this.Minimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Minimize.Textcolor = System.Drawing.Color.White;
            this.Minimize.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.BorderRadius = 0;
            this.Exit.ButtonText = "X";
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.DisabledColor = System.Drawing.Color.Gray;
            this.Exit.Iconcolor = System.Drawing.Color.Transparent;
            this.Exit.Iconimage = ((System.Drawing.Image)(resources.GetObject("Exit.Iconimage")));
            this.Exit.Iconimage_right = null;
            this.Exit.Iconimage_right_Selected = null;
            this.Exit.Iconimage_Selected = null;
            this.Exit.IconMarginLeft = 0;
            this.Exit.IconMarginRight = 0;
            this.Exit.IconRightVisible = false;
            this.Exit.IconRightZoom = 0D;
            this.Exit.IconVisible = false;
            this.Exit.IconZoom = 90D;
            this.Exit.IsTab = false;
            this.Exit.Location = new System.Drawing.Point(720, 0);
            this.Exit.Name = "Exit";
            this.Exit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Exit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Exit.OnHoverTextColor = System.Drawing.Color.White;
            this.Exit.selected = false;
            this.Exit.Size = new System.Drawing.Size(30, 30);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "X";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.Textcolor = System.Drawing.Color.White;
            this.Exit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Yu Gothic UI", 13F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(2, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(86, 25);
            this.Title.TabIndex = 0;
            this.Title.Text = "Gamer UI";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "a.lua"});
            this.listBox1.Location = new System.Drawing.Point(642, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(102, 312);
            this.listBox1.TabIndex = 3;
            // 
            // Clear
            // 
            this.Clear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Clear.BorderRadius = 0;
            this.Clear.ButtonText = "Clear";
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.DisabledColor = System.Drawing.Color.Gray;
            this.Clear.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Iconcolor = System.Drawing.Color.Transparent;
            this.Clear.Iconimage = ((System.Drawing.Image)(resources.GetObject("Clear.Iconimage")));
            this.Clear.Iconimage_right = null;
            this.Clear.Iconimage_right_Selected = null;
            this.Clear.Iconimage_Selected = null;
            this.Clear.IconMarginLeft = 0;
            this.Clear.IconMarginRight = 0;
            this.Clear.IconRightVisible = false;
            this.Clear.IconRightZoom = 0D;
            this.Clear.IconVisible = false;
            this.Clear.IconZoom = 90D;
            this.Clear.IsTab = false;
            this.Clear.Location = new System.Drawing.Point(91, 355);
            this.Clear.Margin = new System.Windows.Forms.Padding(1);
            this.Clear.Name = "Clear";
            this.Clear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Clear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Clear.OnHoverTextColor = System.Drawing.Color.White;
            this.Clear.selected = false;
            this.Clear.Size = new System.Drawing.Size(81, 27);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Clear.Textcolor = System.Drawing.Color.White;
            this.Clear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.OpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.OpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenFile.BorderRadius = 0;
            this.OpenFile.ButtonText = "Open File";
            this.OpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFile.DisabledColor = System.Drawing.Color.Gray;
            this.OpenFile.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFile.Iconcolor = System.Drawing.Color.Transparent;
            this.OpenFile.Iconimage = ((System.Drawing.Image)(resources.GetObject("OpenFile.Iconimage")));
            this.OpenFile.Iconimage_right = null;
            this.OpenFile.Iconimage_right_Selected = null;
            this.OpenFile.Iconimage_Selected = null;
            this.OpenFile.IconMarginLeft = 0;
            this.OpenFile.IconMarginRight = 0;
            this.OpenFile.IconRightVisible = false;
            this.OpenFile.IconRightZoom = 0D;
            this.OpenFile.IconVisible = false;
            this.OpenFile.IconZoom = 90D;
            this.OpenFile.IsTab = false;
            this.OpenFile.Location = new System.Drawing.Point(174, 355);
            this.OpenFile.Margin = new System.Windows.Forms.Padding(1);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.OpenFile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.OpenFile.OnHoverTextColor = System.Drawing.Color.White;
            this.OpenFile.selected = false;
            this.OpenFile.Size = new System.Drawing.Size(81, 27);
            this.OpenFile.TabIndex = 5;
            this.OpenFile.Text = "Open File";
            this.OpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OpenFile.Textcolor = System.Drawing.Color.White;
            this.OpenFile.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // ExecuteFile
            // 
            this.ExecuteFile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.ExecuteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ExecuteFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExecuteFile.BorderRadius = 0;
            this.ExecuteFile.ButtonText = "Execute File";
            this.ExecuteFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExecuteFile.DisabledColor = System.Drawing.Color.Gray;
            this.ExecuteFile.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteFile.Iconcolor = System.Drawing.Color.Transparent;
            this.ExecuteFile.Iconimage = ((System.Drawing.Image)(resources.GetObject("ExecuteFile.Iconimage")));
            this.ExecuteFile.Iconimage_right = null;
            this.ExecuteFile.Iconimage_right_Selected = null;
            this.ExecuteFile.Iconimage_Selected = null;
            this.ExecuteFile.IconMarginLeft = 0;
            this.ExecuteFile.IconMarginRight = 0;
            this.ExecuteFile.IconRightVisible = false;
            this.ExecuteFile.IconRightZoom = 0D;
            this.ExecuteFile.IconVisible = false;
            this.ExecuteFile.IconZoom = 90D;
            this.ExecuteFile.IsTab = false;
            this.ExecuteFile.Location = new System.Drawing.Point(257, 355);
            this.ExecuteFile.Margin = new System.Windows.Forms.Padding(1);
            this.ExecuteFile.Name = "ExecuteFile";
            this.ExecuteFile.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ExecuteFile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.ExecuteFile.OnHoverTextColor = System.Drawing.Color.White;
            this.ExecuteFile.selected = false;
            this.ExecuteFile.Size = new System.Drawing.Size(81, 27);
            this.ExecuteFile.TabIndex = 6;
            this.ExecuteFile.Text = "Execute File";
            this.ExecuteFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExecuteFile.Textcolor = System.Drawing.Color.White;
            this.ExecuteFile.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteFile.Click += new System.EventHandler(this.ExecuteFile_Click);
            // 
            // Attach
            // 
            this.Attach.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Attach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Attach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Attach.BorderRadius = 0;
            this.Attach.ButtonText = "Attach";
            this.Attach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Attach.DisabledColor = System.Drawing.Color.Gray;
            this.Attach.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attach.Iconcolor = System.Drawing.Color.Transparent;
            this.Attach.Iconimage = ((System.Drawing.Image)(resources.GetObject("Attach.Iconimage")));
            this.Attach.Iconimage_right = null;
            this.Attach.Iconimage_right_Selected = null;
            this.Attach.Iconimage_Selected = null;
            this.Attach.IconMarginLeft = 0;
            this.Attach.IconMarginRight = 0;
            this.Attach.IconRightVisible = false;
            this.Attach.IconRightZoom = 0D;
            this.Attach.IconVisible = false;
            this.Attach.IconZoom = 90D;
            this.Attach.IsTab = false;
            this.Attach.Location = new System.Drawing.Point(340, 355);
            this.Attach.Margin = new System.Windows.Forms.Padding(1);
            this.Attach.Name = "Attach";
            this.Attach.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Attach.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Attach.OnHoverTextColor = System.Drawing.Color.White;
            this.Attach.selected = false;
            this.Attach.Size = new System.Drawing.Size(81, 27);
            this.Attach.TabIndex = 8;
            this.Attach.Text = "Attach";
            this.Attach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Attach.Textcolor = System.Drawing.Color.White;
            this.Attach.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // KillRoblox
            // 
            this.KillRoblox.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.KillRoblox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.KillRoblox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KillRoblox.BorderRadius = 0;
            this.KillRoblox.ButtonText = "Kill Roblox";
            this.KillRoblox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KillRoblox.DisabledColor = System.Drawing.Color.Gray;
            this.KillRoblox.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KillRoblox.Iconcolor = System.Drawing.Color.Transparent;
            this.KillRoblox.Iconimage = ((System.Drawing.Image)(resources.GetObject("KillRoblox.Iconimage")));
            this.KillRoblox.Iconimage_right = null;
            this.KillRoblox.Iconimage_right_Selected = null;
            this.KillRoblox.Iconimage_Selected = null;
            this.KillRoblox.IconMarginLeft = 0;
            this.KillRoblox.IconMarginRight = 0;
            this.KillRoblox.IconRightVisible = false;
            this.KillRoblox.IconRightZoom = 0D;
            this.KillRoblox.IconVisible = false;
            this.KillRoblox.IconZoom = 90D;
            this.KillRoblox.IsTab = false;
            this.KillRoblox.Location = new System.Drawing.Point(663, 355);
            this.KillRoblox.Margin = new System.Windows.Forms.Padding(1);
            this.KillRoblox.Name = "KillRoblox";
            this.KillRoblox.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.KillRoblox.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.KillRoblox.OnHoverTextColor = System.Drawing.Color.White;
            this.KillRoblox.selected = false;
            this.KillRoblox.Size = new System.Drawing.Size(81, 27);
            this.KillRoblox.TabIndex = 9;
            this.KillRoblox.Text = "Kill Roblox";
            this.KillRoblox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.KillRoblox.Textcolor = System.Drawing.Color.White;
            this.KillRoblox.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // AlwaysOnTop
            // 
            this.AlwaysOnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.AlwaysOnTop.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.AlwaysOnTop.Checked = false;
            this.AlwaysOnTop.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.AlwaysOnTop.ForeColor = System.Drawing.Color.White;
            this.AlwaysOnTop.Location = new System.Drawing.Point(425, 358);
            this.AlwaysOnTop.Name = "AlwaysOnTop";
            this.AlwaysOnTop.Size = new System.Drawing.Size(20, 20);
            this.AlwaysOnTop.TabIndex = 10;
            this.AlwaysOnTop.OnChange += new System.EventHandler(this.AlwaysOnTop_OnChange);
            // 
            // AlwaysOnTopLabel
            // 
            this.AlwaysOnTopLabel.AutoSize = true;
            this.AlwaysOnTopLabel.BackColor = System.Drawing.Color.Transparent;
            this.AlwaysOnTopLabel.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlwaysOnTopLabel.ForeColor = System.Drawing.Color.White;
            this.AlwaysOnTopLabel.Location = new System.Drawing.Point(448, 361);
            this.AlwaysOnTopLabel.Name = "AlwaysOnTopLabel";
            this.AlwaysOnTopLabel.Size = new System.Drawing.Size(75, 13);
            this.AlwaysOnTopLabel.TabIndex = 4;
            this.AlwaysOnTopLabel.Text = "Always on top";
            this.AlwaysOnTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ScriptHub
            // 
            this.ScriptHub.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.ScriptHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ScriptHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScriptHub.BorderRadius = 0;
            this.ScriptHub.ButtonText = "Script Hub";
            this.ScriptHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScriptHub.DisabledColor = System.Drawing.Color.Gray;
            this.ScriptHub.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptHub.Iconcolor = System.Drawing.Color.Transparent;
            this.ScriptHub.Iconimage = ((System.Drawing.Image)(resources.GetObject("ScriptHub.Iconimage")));
            this.ScriptHub.Iconimage_right = null;
            this.ScriptHub.Iconimage_right_Selected = null;
            this.ScriptHub.Iconimage_Selected = null;
            this.ScriptHub.IconMarginLeft = 0;
            this.ScriptHub.IconMarginRight = 0;
            this.ScriptHub.IconRightVisible = false;
            this.ScriptHub.IconRightZoom = 0D;
            this.ScriptHub.IconVisible = false;
            this.ScriptHub.IconZoom = 90D;
            this.ScriptHub.IsTab = false;
            this.ScriptHub.Location = new System.Drawing.Point(585, 355);
            this.ScriptHub.Margin = new System.Windows.Forms.Padding(1);
            this.ScriptHub.Name = "ScriptHub";
            this.ScriptHub.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ScriptHub.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.ScriptHub.OnHoverTextColor = System.Drawing.Color.White;
            this.ScriptHub.selected = false;
            this.ScriptHub.Size = new System.Drawing.Size(76, 27);
            this.ScriptHub.TabIndex = 11;
            this.ScriptHub.Text = "Script Hub";
            this.ScriptHub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScriptHub.Textcolor = System.Drawing.Color.White;
            this.ScriptHub.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(750, 390);
            this.ControlBox = false;
            this.Controls.Add(this.ScriptHub);
            this.Controls.Add(this.AlwaysOnTopLabel);
            this.Controls.Add(this.AlwaysOnTop);
            this.Controls.Add(this.KillRoblox);
            this.Controls.Add(this.Attach);
            this.Controls.Add(this.ExecuteFile);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Execute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Gamer UI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Bunifu.Framework.UI.BunifuFlatButton Execute;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton Minimize;
        private Bunifu.Framework.UI.BunifuFlatButton Exit;
        private Bunifu.Framework.UI.BunifuCustomLabel Title;
        private System.Windows.Forms.ListBox listBox1;
        private Bunifu.Framework.UI.BunifuFlatButton Clear;
        private Bunifu.Framework.UI.BunifuFlatButton OpenFile;
        private Bunifu.Framework.UI.BunifuFlatButton ExecuteFile;
        private Bunifu.Framework.UI.BunifuFlatButton Attach;
        private Bunifu.Framework.UI.BunifuFlatButton KillRoblox;
        private Bunifu.Framework.UI.BunifuCheckbox AlwaysOnTop;
        private Bunifu.Framework.UI.BunifuCustomLabel AlwaysOnTopLabel;
        private Bunifu.Framework.UI.BunifuFlatButton ScriptHub;
        private Bunifu.Framework.UI.BunifuCustomLabel StatusLabel;
    }
}

