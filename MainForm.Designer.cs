/*
   Performance Measurement Tool

   Copyright (C) 2020 Danske

   This file is part of Performance Measurement Tool

   Performance Measurement Tool is free software: you can redistribute it and/or modify
   it under the terms of the GNU General Public License as published by
   the Free Software Foundation, either version 3 of the License, or
   (at your option) any later version.

   Performance Measurement Tool is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   GNU General Public License for more details.

   You should have received a copy of the GNU General Public License
   along with Performance Measurement Tool. If not, see <https://www.gnu.org/licenses/>.
*/

namespace Performance_Measurement_Tool
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ListBoxProcesses = new System.Windows.Forms.ListBox();
            this.ButtonRefreshProcessList = new System.Windows.Forms.Button();
            this.LabelTheProcessToCapture = new System.Windows.Forms.Label();
            this.ButtonApplySettings = new System.Windows.Forms.Button();
            this.LabelOutputFolder = new System.Windows.Forms.Label();
            this.TextBoxOutputFolder = new System.Windows.Forms.TextBox();
            this.ButtonBrowse = new System.Windows.Forms.Button();
            this.LabelCaptureHotkey = new System.Windows.Forms.Label();
            this.TextBoxCaptureHotkey = new System.Windows.Forms.TextBox();
            this.LabelCaptureDelay = new System.Windows.Forms.Label();
            this.NumericUpDownCaptureDelay = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownCaptureTime = new System.Windows.Forms.NumericUpDown();
            this.LabelCaptureTime = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.MenuItemFile = new System.Windows.Forms.MenuItem();
            this.MenuItemExit = new System.Windows.Forms.MenuItem();
            this.MenuItemHelp = new System.Windows.Forms.MenuItem();
            this.MenuItemAbout = new System.Windows.Forms.MenuItem();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonResetSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownCaptureDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownCaptureTime)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxProcesses
            // 
            this.ListBoxProcesses.FormattingEnabled = true;
            this.ListBoxProcesses.Location = new System.Drawing.Point(13, 25);
            this.ListBoxProcesses.Name = "ListBoxProcesses";
            this.ListBoxProcesses.Size = new System.Drawing.Size(196, 69);
            this.ListBoxProcesses.TabIndex = 0;
            // 
            // ButtonRefreshProcessList
            // 
            this.ButtonRefreshProcessList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonRefreshProcessList.Location = new System.Drawing.Point(12, 100);
            this.ButtonRefreshProcessList.Name = "ButtonRefreshProcessList";
            this.ButtonRefreshProcessList.Size = new System.Drawing.Size(196, 23);
            this.ButtonRefreshProcessList.TabIndex = 1;
            this.ButtonRefreshProcessList.Text = "Refresh process list";
            this.ToolTip.SetToolTip(this.ButtonRefreshProcessList, "Refreshes the process list.");
            this.ButtonRefreshProcessList.UseVisualStyleBackColor = true;
            this.ButtonRefreshProcessList.Click += new System.EventHandler(this.ButtonRefreshProcessList_Click);
            // 
            // LabelTheProcessToCapture
            // 
            this.LabelTheProcessToCapture.AutoSize = true;
            this.LabelTheProcessToCapture.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelTheProcessToCapture.Location = new System.Drawing.Point(10, 9);
            this.LabelTheProcessToCapture.Name = "LabelTheProcessToCapture";
            this.LabelTheProcessToCapture.Size = new System.Drawing.Size(120, 13);
            this.LabelTheProcessToCapture.TabIndex = 2;
            this.LabelTheProcessToCapture.Text = "The process to capture:";
            this.ToolTip.SetToolTip(this.LabelTheProcessToCapture, "The name of the process that you want to capture.");
            // 
            // ButtonApplySettings
            // 
            this.ButtonApplySettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonApplySettings.Location = new System.Drawing.Point(220, 99);
            this.ButtonApplySettings.Name = "ButtonApplySettings";
            this.ButtonApplySettings.Size = new System.Drawing.Size(172, 23);
            this.ButtonApplySettings.TabIndex = 3;
            this.ButtonApplySettings.Text = "Apply settings";
            this.ToolTip.SetToolTip(this.ButtonApplySettings, "Apply settings and restart PresentMon.");
            this.ButtonApplySettings.UseVisualStyleBackColor = true;
            this.ButtonApplySettings.Click += new System.EventHandler(this.ButtonApplySettings_Click);
            // 
            // LabelOutputFolder
            // 
            this.LabelOutputFolder.AutoSize = true;
            this.LabelOutputFolder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelOutputFolder.Location = new System.Drawing.Point(217, 58);
            this.LabelOutputFolder.Name = "LabelOutputFolder";
            this.LabelOutputFolder.Size = new System.Drawing.Size(71, 13);
            this.LabelOutputFolder.TabIndex = 4;
            this.LabelOutputFolder.Text = "Output folder:";
            this.ToolTip.SetToolTip(this.LabelOutputFolder, "The output folder of the CSV.");
            // 
            // TextBoxOutputFolder
            // 
            this.TextBoxOutputFolder.Location = new System.Drawing.Point(220, 74);
            this.TextBoxOutputFolder.Name = "TextBoxOutputFolder";
            this.TextBoxOutputFolder.Size = new System.Drawing.Size(274, 20);
            this.TextBoxOutputFolder.TabIndex = 5;
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonBrowse.Location = new System.Drawing.Point(500, 74);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(71, 20);
            this.ButtonBrowse.TabIndex = 6;
            this.ButtonBrowse.Text = "Browse..";
            this.ToolTip.SetToolTip(this.ButtonBrowse, "Browse for the output folder.");
            this.ButtonBrowse.UseVisualStyleBackColor = true;
            this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // LabelCaptureHotkey
            // 
            this.LabelCaptureHotkey.AutoSize = true;
            this.LabelCaptureHotkey.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelCaptureHotkey.Location = new System.Drawing.Point(217, 9);
            this.LabelCaptureHotkey.Name = "LabelCaptureHotkey";
            this.LabelCaptureHotkey.Size = new System.Drawing.Size(82, 13);
            this.LabelCaptureHotkey.TabIndex = 7;
            this.LabelCaptureHotkey.Text = "Capture hotkey:";
            this.ToolTip.SetToolTip(this.LabelCaptureHotkey, "Hotkey to start and stop recording. Compatible with Alt, Shift and Control.");
            // 
            // TextBoxCaptureHotkey
            // 
            this.TextBoxCaptureHotkey.Location = new System.Drawing.Point(220, 24);
            this.TextBoxCaptureHotkey.Name = "TextBoxCaptureHotkey";
            this.TextBoxCaptureHotkey.ReadOnly = true;
            this.TextBoxCaptureHotkey.Size = new System.Drawing.Size(113, 20);
            this.TextBoxCaptureHotkey.TabIndex = 8;
            this.TextBoxCaptureHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxCaptureHotkey_KeyDown);
            // 
            // LabelCaptureDelay
            // 
            this.LabelCaptureDelay.AutoSize = true;
            this.LabelCaptureDelay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelCaptureDelay.Location = new System.Drawing.Point(336, 9);
            this.LabelCaptureDelay.Name = "LabelCaptureDelay";
            this.LabelCaptureDelay.Size = new System.Drawing.Size(89, 13);
            this.LabelCaptureDelay.TabIndex = 9;
            this.LabelCaptureDelay.Text = "Capture delay (s):";
            this.ToolTip.SetToolTip(this.LabelCaptureDelay, "Wait for provided time before starting to record in seconds.");
            // 
            // NumericUpDownCaptureDelay
            // 
            this.NumericUpDownCaptureDelay.Location = new System.Drawing.Point(339, 25);
            this.NumericUpDownCaptureDelay.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.NumericUpDownCaptureDelay.Name = "NumericUpDownCaptureDelay";
            this.NumericUpDownCaptureDelay.Size = new System.Drawing.Size(113, 20);
            this.NumericUpDownCaptureDelay.TabIndex = 11;
            this.NumericUpDownCaptureDelay.Validated += new System.EventHandler(this.NumericUpDownCaptureDelay_Validated);
            // 
            // NumericUpDownCaptureTime
            // 
            this.NumericUpDownCaptureTime.Location = new System.Drawing.Point(458, 25);
            this.NumericUpDownCaptureTime.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.NumericUpDownCaptureTime.Name = "NumericUpDownCaptureTime";
            this.NumericUpDownCaptureTime.Size = new System.Drawing.Size(113, 20);
            this.NumericUpDownCaptureTime.TabIndex = 13;
            this.NumericUpDownCaptureTime.Validated += new System.EventHandler(this.NumericUpDownCaptureTime_Validated);
            // 
            // LabelCaptureTime
            // 
            this.LabelCaptureTime.AutoSize = true;
            this.LabelCaptureTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelCaptureTime.Location = new System.Drawing.Point(455, 9);
            this.LabelCaptureTime.Name = "LabelCaptureTime";
            this.LabelCaptureTime.Size = new System.Drawing.Size(83, 13);
            this.LabelCaptureTime.TabIndex = 12;
            this.LabelCaptureTime.Text = "Capture time (s):";
            this.ToolTip.SetToolTip(this.LabelCaptureTime, "Stop recording after the provided amount of time in seconds.");
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItemFile,
            this.MenuItemHelp});
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.Index = 0;
            this.MenuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItemExit});
            this.MenuItemFile.Text = "File";
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Index = 0;
            this.MenuItemExit.Text = "Exit";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.Index = 1;
            this.MenuItemHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItemAbout});
            this.MenuItemHelp.Text = "Help";
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.Index = 0;
            this.MenuItemAbout.Text = "About";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // ButtonResetSettings
            // 
            this.ButtonResetSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonResetSettings.Location = new System.Drawing.Point(399, 100);
            this.ButtonResetSettings.Name = "ButtonResetSettings";
            this.ButtonResetSettings.Size = new System.Drawing.Size(172, 23);
            this.ButtonResetSettings.TabIndex = 14;
            this.ButtonResetSettings.Text = "Reset settings";
            this.ToolTip.SetToolTip(this.ButtonResetSettings, "Reset settings and restart PresentMon.");
            this.ButtonResetSettings.UseVisualStyleBackColor = true;
            this.ButtonResetSettings.Click += new System.EventHandler(this.ButtonResetSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 134);
            this.Controls.Add(this.ButtonResetSettings);
            this.Controls.Add(this.NumericUpDownCaptureTime);
            this.Controls.Add(this.LabelCaptureTime);
            this.Controls.Add(this.NumericUpDownCaptureDelay);
            this.Controls.Add(this.LabelCaptureDelay);
            this.Controls.Add(this.TextBoxCaptureHotkey);
            this.Controls.Add(this.LabelCaptureHotkey);
            this.Controls.Add(this.ButtonBrowse);
            this.Controls.Add(this.TextBoxOutputFolder);
            this.Controls.Add(this.LabelOutputFolder);
            this.Controls.Add(this.ButtonApplySettings);
            this.Controls.Add(this.LabelTheProcessToCapture);
            this.Controls.Add(this.ButtonRefreshProcessList);
            this.Controls.Add(this.ListBoxProcesses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Menu = this.MainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performance Measurement Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownCaptureDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownCaptureTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxProcesses;
        private System.Windows.Forms.Button ButtonRefreshProcessList;
        private System.Windows.Forms.Label LabelTheProcessToCapture;
        private System.Windows.Forms.Button ButtonApplySettings;
        private System.Windows.Forms.Label LabelOutputFolder;
        private System.Windows.Forms.TextBox TextBoxOutputFolder;
        private System.Windows.Forms.Button ButtonBrowse;
        private System.Windows.Forms.Label LabelCaptureHotkey;
        private System.Windows.Forms.TextBox TextBoxCaptureHotkey;
        private System.Windows.Forms.Label LabelCaptureDelay;
        private System.Windows.Forms.NumericUpDown NumericUpDownCaptureDelay;
        private System.Windows.Forms.NumericUpDown NumericUpDownCaptureTime;
        private System.Windows.Forms.Label LabelCaptureTime;
        private System.Windows.Forms.MainMenu MainMenu;
        private System.Windows.Forms.MenuItem MenuItemFile;
        private System.Windows.Forms.MenuItem MenuItemExit;
        private System.Windows.Forms.MenuItem MenuItemHelp;
        private System.Windows.Forms.MenuItem MenuItemAbout;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button ButtonResetSettings;
    }
}

