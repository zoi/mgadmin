﻿namespace MiracleDKP
{
    partial class News
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(News));
            this.newsGroup = new System.Windows.Forms.GroupBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.newsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hírekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.woWIndításaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dKPLekérdezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this._mainTimer = new System.Windows.Forms.Timer(this.components);
            this.newsGroup.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newsGroup
            // 
            this.newsGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.newsGroup.Controls.Add(this.nextButton);
            this.newsGroup.Controls.Add(this.prevButton);
            this.newsGroup.Controls.Add(this.newsLabel);
            this.newsGroup.Location = new System.Drawing.Point(4, 5);
            this.newsGroup.Name = "newsGroup";
            this.newsGroup.Size = new System.Drawing.Size(620, 275);
            this.newsGroup.TabIndex = 4;
            this.newsGroup.TabStop = false;
            this.newsGroup.Text = "Hírek";
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Location = new System.Drawing.Point(545, 0);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Következő";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Enabled = false;
            this.prevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevButton.Location = new System.Drawing.Point(464, 0);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(75, 23);
            this.prevButton.TabIndex = 1;
            this.prevButton.Text = "Előző";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // newsLabel
            // 
            this.newsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newsLabel.Location = new System.Drawing.Point(3, 16);
            this.newsLabel.Name = "newsLabel";
            this.newsLabel.Size = new System.Drawing.Size(614, 256);
            this.newsLabel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(502, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 65);
            this.button1.TabIndex = 5;
            this.button1.Text = "WoW indítása";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this._startWow_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hírekToolStripMenuItem,
            this.woWIndításaToolStripMenuItem,
            this.dKPLekérdezésToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 92);
            // 
            // hírekToolStripMenuItem
            // 
            this.hírekToolStripMenuItem.Name = "hírekToolStripMenuItem";
            this.hírekToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.hírekToolStripMenuItem.Text = "Hírek";
            this.hírekToolStripMenuItem.Click += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // woWIndításaToolStripMenuItem
            // 
            this.woWIndításaToolStripMenuItem.Name = "woWIndításaToolStripMenuItem";
            this.woWIndításaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.woWIndításaToolStripMenuItem.Text = "WoW indítása...";
            this.woWIndításaToolStripMenuItem.Click += new System.EventHandler(this._startWow_Click);
            // 
            // dKPLekérdezésToolStripMenuItem
            // 
            this.dKPLekérdezésToolStripMenuItem.Name = "dKPLekérdezésToolStripMenuItem";
            this.dKPLekérdezésToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.dKPLekérdezésToolStripMenuItem.Text = "DKP lekérdezés";
            this.dKPLekérdezésToolStripMenuItem.Click += new System.EventHandler(this.dkpButton_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Az alkamazás továbbra is fut.";
            this.notifyIcon1.BalloonTipTitle = "MIracLE Guild System";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "MIracLE";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // _mainTimer
            // 
            this._mainTimer.Enabled = true;
            this._mainTimer.Interval = 3600000;
            this._mainTimer.Tick += new System.EventHandler(this._mainTimer_Tick);
            // 
            // News
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 368);
            this.Controls.Add(this.newsGroup);
            this.Controls.Add(this.button1);
            this.Name = "News";
            this.ShowInTaskbar = true;
            this.Text = "News";
            this.newsGroup.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox newsGroup;
        private System.Windows.Forms.Label newsLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem woWIndításaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dKPLekérdezésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer _mainTimer;
        private System.Windows.Forms.ToolStripMenuItem hírekToolStripMenuItem;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
    }
}