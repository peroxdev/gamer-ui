namespace GamerUI
{
    partial class ScriptHub
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptHub));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.Exit = new Syncfusion.WinForms.Controls.SfButton();
            this.Minimize = new Syncfusion.WinForms.Controls.SfButton();
            this.Execute = new Syncfusion.WinForms.Controls.SfButton();
            this.CloseHub = new Syncfusion.WinForms.Controls.SfButton();
            this.ScriptsList = new System.Windows.Forms.ListBox();
            this.Description = new System.Windows.Forms.Label();
            this.Thumbnail = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 30);
            this.panel1.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Title.Font = new System.Drawing.Font("Yu Gothic UI", 13F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(2, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(96, 25);
            this.Title.TabIndex = 22;
            this.Title.Text = "Script Hub";
            // 
            // Exit
            // 
            this.Exit.AccessibleName = "Button";
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(364, 0);
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
            this.Exit.TabIndex = 24;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Minimize
            // 
            this.Minimize.AccessibleName = "Button";
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Minimize.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(333, 0);
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
            this.Minimize.TabIndex = 23;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Execute
            // 
            this.Execute.AccessibleName = "Button";
            this.Execute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Execute.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.Execute.ForeColor = System.Drawing.Color.White;
            this.Execute.Location = new System.Drawing.Point(197, 324);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(94, 30);
            this.Execute.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Execute.Style.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Execute.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Execute.Style.FocusedForeColor = System.Drawing.Color.White;
            this.Execute.Style.ForeColor = System.Drawing.Color.White;
            this.Execute.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Execute.Style.HoverForeColor = System.Drawing.Color.White;
            this.Execute.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Execute.Style.PressedForeColor = System.Drawing.Color.White;
            this.Execute.TabIndex = 12;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = false;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // CloseHub
            // 
            this.CloseHub.AccessibleName = "Button";
            this.CloseHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CloseHub.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.CloseHub.ForeColor = System.Drawing.Color.White;
            this.CloseHub.Location = new System.Drawing.Point(295, 324);
            this.CloseHub.Name = "CloseHub";
            this.CloseHub.Size = new System.Drawing.Size(94, 30);
            this.CloseHub.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CloseHub.Style.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CloseHub.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CloseHub.Style.FocusedForeColor = System.Drawing.Color.White;
            this.CloseHub.Style.ForeColor = System.Drawing.Color.White;
            this.CloseHub.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.CloseHub.Style.HoverForeColor = System.Drawing.Color.White;
            this.CloseHub.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CloseHub.Style.PressedForeColor = System.Drawing.Color.White;
            this.CloseHub.TabIndex = 13;
            this.CloseHub.Text = "Close";
            this.CloseHub.UseVisualStyleBackColor = false;
            this.CloseHub.Click += new System.EventHandler(this.CloseHub_Click);
            // 
            // ScriptsList
            // 
            this.ScriptsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ScriptsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScriptsList.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptsList.ForeColor = System.Drawing.Color.White;
            this.ScriptsList.FormattingEnabled = true;
            this.ScriptsList.Location = new System.Drawing.Point(7, 36);
            this.ScriptsList.Name = "ScriptsList";
            this.ScriptsList.Size = new System.Drawing.Size(102, 286);
            this.ScriptsList.TabIndex = 14;
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Description.Font = new System.Drawing.Font("Yu Gothic UI", 8.5F);
            this.Description.ForeColor = System.Drawing.Color.White;
            this.Description.Location = new System.Drawing.Point(114, 215);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(275, 107);
            this.Description.TabIndex = 25;
            // 
            // Thumbnail
            // 
            this.Thumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Thumbnail.Cursor = System.Windows.Forms.Cursors.Default;
            this.Thumbnail.ImageLocation = "";
            this.Thumbnail.Location = new System.Drawing.Point(114, 36);
            this.Thumbnail.Name = "Thumbnail";
            this.Thumbnail.Size = new System.Drawing.Size(275, 176);
            this.Thumbnail.TabIndex = 26;
            this.Thumbnail.TabStop = false;
            this.Thumbnail.WaitOnLoad = true;
            // 
            // ScriptHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(394, 359);
            this.Controls.Add(this.Thumbnail);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.ScriptsList);
            this.Controls.Add(this.CloseHub);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScriptHub";
            this.Text = "Script Hub";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private Syncfusion.WinForms.Controls.SfButton Exit;
        private Syncfusion.WinForms.Controls.SfButton Minimize;
        private Syncfusion.WinForms.Controls.SfButton Execute;
        private Syncfusion.WinForms.Controls.SfButton CloseHub;
        private System.Windows.Forms.ListBox ScriptsList;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.PictureBox Thumbnail;
    }
}