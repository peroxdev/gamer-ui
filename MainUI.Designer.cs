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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Minimize = new Syncfusion.WinForms.Controls.SfButton();
            this.Exit = new Syncfusion.WinForms.Controls.SfButton();
            this.ScriptsList = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Execute = new Syncfusion.WinForms.Controls.SfButton();
            this.Clear = new Syncfusion.WinForms.Controls.SfButton();
            this.OpenFile = new Syncfusion.WinForms.Controls.SfButton();
            this.ExecuteFile = new Syncfusion.WinForms.Controls.SfButton();
            this.Attach = new Syncfusion.WinForms.Controls.SfButton();
            this.KillRoblox = new Syncfusion.WinForms.Controls.SfButton();
            this.CheckBox = new System.Windows.Forms.PictureBox();
            this.AlwaysOnTop = new System.Windows.Forms.Label();
            this.LaunchScriptHub = new Syncfusion.WinForms.Controls.SfButton();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 30);
            this.panel1.TabIndex = 1;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Location = new System.Drawing.Point(84, 12);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 13);
            this.StatusLabel.TabIndex = 22;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Title.Font = new System.Drawing.Font("Yu Gothic UI", 13F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(2, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(86, 25);
            this.Title.TabIndex = 21;
            this.Title.Text = "Gamer UI";
            // 
            // Minimize
            // 
            this.Minimize.AccessibleName = "Button";
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Minimize.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(689, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(30, 30);
            this.Minimize.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Minimize.Style.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Minimize.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Minimize.Style.FocusedForeColor = System.Drawing.Color.White;
            this.Minimize.Style.ForeColor = System.Drawing.Color.White;
            this.Minimize.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Minimize.Style.HoverForeColor = System.Drawing.Color.White;
            this.Minimize.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Minimize.Style.PressedForeColor = System.Drawing.Color.White;
            this.Minimize.TabIndex = 18;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.AccessibleName = "Button";
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(720, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(30, 30);
            this.Exit.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Exit.Style.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Exit.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Exit.Style.FocusedForeColor = System.Drawing.Color.White;
            this.Exit.Style.ForeColor = System.Drawing.Color.White;
            this.Exit.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Exit.Style.HoverForeColor = System.Drawing.Color.White;
            this.Exit.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Exit.Style.PressedForeColor = System.Drawing.Color.White;
            this.Exit.TabIndex = 19;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ScriptsList
            // 
            this.ScriptsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ScriptsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScriptsList.ContextMenuStrip = this.contextMenuStrip1;
            this.ScriptsList.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptsList.ForeColor = System.Drawing.Color.White;
            this.ScriptsList.FormattingEnabled = true;
            this.ScriptsList.Location = new System.Drawing.Point(642, 36);
            this.ScriptsList.Name = "ScriptsList";
            this.ScriptsList.Size = new System.Drawing.Size(102, 312);
            this.ScriptsList.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 26);
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.RefreshToolStripMenuItem.Text = "Refresh";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // Execute
            // 
            this.Execute.AccessibleName = "Button";
            this.Execute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Execute.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.Execute.ForeColor = System.Drawing.Color.White;
            this.Execute.Location = new System.Drawing.Point(7, 355);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(79, 27);
            this.Execute.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Execute.Style.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Execute.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Execute.Style.FocusedForeColor = System.Drawing.Color.White;
            this.Execute.Style.ForeColor = System.Drawing.Color.White;
            this.Execute.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Execute.Style.HoverForeColor = System.Drawing.Color.White;
            this.Execute.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Execute.Style.PressedForeColor = System.Drawing.Color.White;
            this.Execute.TabIndex = 11;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = false;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Clear
            // 
            this.Clear.AccessibleName = "Button";
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Clear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(91, 355);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(79, 27);
            this.Clear.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Clear.Style.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Clear.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Clear.Style.FocusedForeColor = System.Drawing.Color.White;
            this.Clear.Style.ForeColor = System.Drawing.Color.White;
            this.Clear.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Clear.Style.HoverForeColor = System.Drawing.Color.White;
            this.Clear.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Clear.Style.PressedForeColor = System.Drawing.Color.White;
            this.Clear.TabIndex = 12;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.AccessibleName = "Button";
            this.OpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.OpenFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.OpenFile.ForeColor = System.Drawing.Color.White;
            this.OpenFile.Location = new System.Drawing.Point(174, 355);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(81, 27);
            this.OpenFile.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.OpenFile.Style.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.OpenFile.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.OpenFile.Style.FocusedForeColor = System.Drawing.Color.White;
            this.OpenFile.Style.ForeColor = System.Drawing.Color.White;
            this.OpenFile.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.OpenFile.Style.HoverForeColor = System.Drawing.Color.White;
            this.OpenFile.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.OpenFile.Style.PressedForeColor = System.Drawing.Color.White;
            this.OpenFile.TabIndex = 13;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = false;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // ExecuteFile
            // 
            this.ExecuteFile.AccessibleName = "Button";
            this.ExecuteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ExecuteFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.ExecuteFile.ForeColor = System.Drawing.Color.White;
            this.ExecuteFile.Location = new System.Drawing.Point(257, 355);
            this.ExecuteFile.Name = "ExecuteFile";
            this.ExecuteFile.Size = new System.Drawing.Size(81, 27);
            this.ExecuteFile.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ExecuteFile.Style.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ExecuteFile.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ExecuteFile.Style.FocusedForeColor = System.Drawing.Color.White;
            this.ExecuteFile.Style.ForeColor = System.Drawing.Color.White;
            this.ExecuteFile.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.ExecuteFile.Style.HoverForeColor = System.Drawing.Color.White;
            this.ExecuteFile.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ExecuteFile.Style.PressedForeColor = System.Drawing.Color.White;
            this.ExecuteFile.TabIndex = 14;
            this.ExecuteFile.Text = "Execute File";
            this.ExecuteFile.UseVisualStyleBackColor = false;
            this.ExecuteFile.Click += new System.EventHandler(this.ExecuteFile_Click);
            // 
            // Attach
            // 
            this.Attach.AccessibleName = "Button";
            this.Attach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Attach.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.Attach.ForeColor = System.Drawing.Color.White;
            this.Attach.Location = new System.Drawing.Point(340, 355);
            this.Attach.Name = "Attach";
            this.Attach.Size = new System.Drawing.Size(81, 27);
            this.Attach.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Attach.Style.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Attach.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Attach.Style.FocusedForeColor = System.Drawing.Color.White;
            this.Attach.Style.ForeColor = System.Drawing.Color.White;
            this.Attach.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Attach.Style.HoverForeColor = System.Drawing.Color.White;
            this.Attach.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Attach.Style.PressedForeColor = System.Drawing.Color.White;
            this.Attach.TabIndex = 15;
            this.Attach.Text = "Attach";
            this.Attach.UseVisualStyleBackColor = false;
            this.Attach.Click += new System.EventHandler(this.Attach_Click);
            // 
            // KillRoblox
            // 
            this.KillRoblox.AccessibleName = "Button";
            this.KillRoblox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.KillRoblox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.KillRoblox.ForeColor = System.Drawing.Color.White;
            this.KillRoblox.Location = new System.Drawing.Point(663, 355);
            this.KillRoblox.Name = "KillRoblox";
            this.KillRoblox.Size = new System.Drawing.Size(81, 27);
            this.KillRoblox.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.KillRoblox.Style.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.KillRoblox.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.KillRoblox.Style.FocusedForeColor = System.Drawing.Color.White;
            this.KillRoblox.Style.ForeColor = System.Drawing.Color.White;
            this.KillRoblox.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.KillRoblox.Style.HoverForeColor = System.Drawing.Color.White;
            this.KillRoblox.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.KillRoblox.Style.PressedForeColor = System.Drawing.Color.White;
            this.KillRoblox.TabIndex = 16;
            this.KillRoblox.Text = "Kill Roblox";
            this.KillRoblox.UseVisualStyleBackColor = false;
            this.KillRoblox.Click += new System.EventHandler(this.KillRoblox_Click);
            // 
            // CheckBox
            // 
            this.CheckBox.ImageLocation = "https://i.vgy.me/yRBaFs.png";
            this.CheckBox.Location = new System.Drawing.Point(425, 358);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(20, 20);
            this.CheckBox.TabIndex = 17;
            this.CheckBox.TabStop = false;
            this.CheckBox.WaitOnLoad = true;
            this.CheckBox.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // AlwaysOnTop
            // 
            this.AlwaysOnTop.AutoSize = true;
            this.AlwaysOnTop.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.AlwaysOnTop.ForeColor = System.Drawing.Color.White;
            this.AlwaysOnTop.Location = new System.Drawing.Point(448, 361);
            this.AlwaysOnTop.Name = "AlwaysOnTop";
            this.AlwaysOnTop.Size = new System.Drawing.Size(75, 13);
            this.AlwaysOnTop.TabIndex = 20;
            this.AlwaysOnTop.Text = "Always on top";
            this.AlwaysOnTop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LaunchScriptHub
            // 
            this.LaunchScriptHub.AccessibleName = "Button";
            this.LaunchScriptHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.LaunchScriptHub.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.LaunchScriptHub.ForeColor = System.Drawing.Color.White;
            this.LaunchScriptHub.Location = new System.Drawing.Point(579, 355);
            this.LaunchScriptHub.Name = "LaunchScriptHub";
            this.LaunchScriptHub.Size = new System.Drawing.Size(81, 27);
            this.LaunchScriptHub.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.LaunchScriptHub.Style.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.LaunchScriptHub.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.LaunchScriptHub.Style.FocusedForeColor = System.Drawing.Color.White;
            this.LaunchScriptHub.Style.ForeColor = System.Drawing.Color.White;
            this.LaunchScriptHub.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.LaunchScriptHub.Style.HoverForeColor = System.Drawing.Color.White;
            this.LaunchScriptHub.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.LaunchScriptHub.Style.PressedForeColor = System.Drawing.Color.White;
            this.LaunchScriptHub.TabIndex = 23;
            this.LaunchScriptHub.Text = "Script Hub";
            this.LaunchScriptHub.UseVisualStyleBackColor = false;
            this.LaunchScriptHub.Click += new System.EventHandler(this.ScriptHub_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(750, 390);
            this.ControlBox = false;
            this.Controls.Add(this.LaunchScriptHub);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.AlwaysOnTop);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.KillRoblox);
            this.Controls.Add(this.Attach);
            this.Controls.Add(this.ExecuteFile);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ScriptsList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Gamer UI";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CheckBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ScriptsList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        private Syncfusion.WinForms.Controls.SfButton Execute;
        private Syncfusion.WinForms.Controls.SfButton Clear;
        private Syncfusion.WinForms.Controls.SfButton OpenFile;
        private Syncfusion.WinForms.Controls.SfButton ExecuteFile;
        private Syncfusion.WinForms.Controls.SfButton Attach;
        private Syncfusion.WinForms.Controls.SfButton KillRoblox;
        private System.Windows.Forms.PictureBox CheckBox;
        private Syncfusion.WinForms.Controls.SfButton Minimize;
        private Syncfusion.WinForms.Controls.SfButton Exit;
        private System.Windows.Forms.Label AlwaysOnTop;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label StatusLabel;
        private Syncfusion.WinForms.Controls.SfButton LaunchScriptHub;
    }
}

