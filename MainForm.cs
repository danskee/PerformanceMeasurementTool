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

using System;
using System.IO;
using System.Media;
using Microsoft.Win32;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Performance_Measurement_Tool
{
    public partial class MainForm : Form
    {
        AboutDialog AboutDialog = new AboutDialog();
        LicenseAgreementForm LicenseAgreementForm = new LicenseAgreementForm();
        RegistryKey Settings = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\PerformanceMeasurementTool", true);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Settings.GetValue("LicenseAccepted") != null)
            {
            }
            else
            {
                Settings.SetValue("LicenseAccepted", "False");
            }

            if (Settings.GetValue("LicenseAccepted").ToString() == "False")
            {
                LicenseAgreementForm.ShowDialog(this);
            }

            if (Settings.GetValue("CaptureHotkey") != null)
            {
                TextBoxCaptureHotkey.Text = Settings.GetValue("CaptureHotkey").ToString();
            }
            else
            {
                TextBoxCaptureHotkey.Text = "F11";
            }

            if (Settings.GetValue("CaptureDelay") != null)
            {
                NumericUpDownCaptureDelay.Text = Settings.GetValue("CaptureDelay").ToString();
            }
            else
            {
                NumericUpDownCaptureDelay.Text = "0";
            }

            if (Settings.GetValue("CaptureTime") != null)
            {
                NumericUpDownCaptureTime.Text = Settings.GetValue("CaptureTime").ToString();
            }
            else
            {
                NumericUpDownCaptureTime.Text = "0";
            }

            if (Settings.GetValue("OutputFolder") != null)
            {
                TextBoxOutputFolder.Text = Settings.GetValue("OutputFolder").ToString();
            }
            else
            {
                TextBoxOutputFolder.Text = AppDomain.CurrentDomain.BaseDirectory + "Captures";
            }

            ButtonRefreshProcessList_Click(sender, e);

            if (Directory.Exists(TextBoxOutputFolder.Text))
            {
            }
            else
            {
                Directory.CreateDirectory(TextBoxOutputFolder.Text);
            }

            ButtonApplySettings_Click(sender, e);

            RegisterHotkey();
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            AboutDialog.ShowDialog(this);
        }

        private void ButtonRefreshProcessList_Click(object sender, EventArgs e)
        {
            List<string> IgnorableProcesses = new List<string>(new string[] {
            "7zFM",
            "aida64",
            "CPU-Z",
            "cpuz_x64",
            "Editor.exe",
            "notepad++",
            "InSpectre",
            "notepad",
            "CapFrameX",
            "memreduct",
            "MouseTester",
            "Retroarch",
            "Speccy",
            "UEFITool",
            "Wireshark",
            "GPU-Z",
            "lghub",
            "iCUE",
            "Editor",
            "HWiNFO64",
            "HWMonitor",
            "ILSpy",
            "dnSpy",
            "mlc",
            "regedit",
            "SSD-Z",
            "steam",
            "steamwebhelper",
            "msvsmon",
            "GalaxyClientHelper",
            "GameBar",
            "Microsoft.Notes",
            "Microsoft.Photos",
            "MicrosoftEdge",
            "Rufus",
            "WinRAR",
            "GalaxyClientHelper",
            "balenaEtcher",
            "BethesdaNetLauncher",
            "Blend",
            "BsgLauncher",
            "MSBuild",
            "PerfWatson",
			"userinit",
            "PerfWatson2",
            "procexp64",
            "ServiceHub.DataWarehouseHost",
			"WmiPrvSE",
            "ServiceHub.Host.CLR.x86",
            "System",
            "Idle",
            "VBCSCompiler",
            "wininit",
            "Services",
            "RadeonSettings",
            "RadeonSoftware",
            "RTSS",
            "PresentMon64-1.5.2",
            "PresentMon-1.6.0-x64",
            "SearchUI",
            "ShellExperienceHost",
            "Skype",
            "SkypeApp",
            "Spotify",
            "StartMenuExperienceHost",
            "Taskmgr",
            "ProcessHacker",
            "SystemSettings",
            ".Battle.Net",
            "Battle.Net",
            "3DMark",
            "AMD Ryzen Master",
            "ApplicationFrameHost",
            "Calculator",
            "CCleaner64",
            "chrome",
            "DataExchangeHost",
            "dllhost",
            "dwm",
            "EpicGamesLauncher",
            "legendary",
            "DeviceCleanup",
            "Avidemux",
            "Autoruns",
            "AsrTC",
            "DISM++",
            "Setup",
            "Teams",
            "WinStore.App",
            "XboxApp",
            "XboxPcApp",
            "Teamviewer",
            "TeamviewerDesktop",
            "TextInputHost",
            "ts3clientwin64",
            "ISLC",
            "IntelligentStandbyListCleaner",
            "Intelligent Standby List Cleaner",
            "TimerResolution",
            "MinecraftLauncher",
            "msedge",
            "NordVPN",
            "NVIDIAGeforceExperience",
            "NVIDIAShare",
            "vlc",
            "WhatsApp",
            "OverdriveNTool",
            "MSIAfterburner",
            "smss",
            "Performance Measurement Tool",
            "cmd",
            "StandardCollector.Service",
            "ServiceHub.IdentityHost",
            "ServiceHub.TestWindowStoreHost",
            "ServiceHub.ThreadedWaitDialog",
            "ServiceHub.VSDetouredHost",
            "Discord",
            "firefox",
            "Ripcord",
            "RipcordPatched",
            "foobar2000",
            "conhost",
            "audiodg",
            "devenv",
            "explorer",
            "lsass",
            "lsm",
            "services",
            "Memory Cleaner",
            "Microsoft.ServiceHub.Controller",
            "NTLite",
            "csrss",
            "svchost",
            "winlogon",
            "obs64",
            "OCAT",
            "Origin",
            "PaintDotNet",
            "Gimp",
            "RadeonMod",
            "Prime95",
            "PowerRun",
            "ServiceHub.SettingsHost",
            "ServiceHub.RoslynCodeAnalysisService"});

            ListBoxProcesses.Items.Clear();

            foreach (Process p in Process.GetProcesses())
            {
                if (IgnorableProcesses.Contains(p.ProcessName))
                {
                }
                else
                {
                    ListBoxProcesses.Items.Add(p.ProcessName);
                }
            }
        }

        private void TextBoxCaptureHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                if (e.KeyCode.ToString() == "ShiftKey")
                {
                }
                else
                {
                    if (e.KeyCode.ToString().Contains("F12"))
                    {
                        MessageBox.Show("F12 can not be used as the capture hotkey due to the reason that it is reserved for the debugger.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        UnregisterHotKey(this.Handle, 1);
                        RegisterHotKey(this.Handle, 1, (int)4, e.KeyCode.GetHashCode());
                        TextBoxCaptureHotkey.Text = "Shift + " + e.KeyCode.ToString();
                    }
                }
            }
            else if (Control.ModifierKeys == Keys.Control)
            {
                if (e.KeyCode.ToString() == "ControlKey")
                {
                }
                else
                {
                    if (e.KeyCode.ToString().Contains("F12"))
                    {
                        MessageBox.Show("F12 can not be used as the capture hotkey due to the reason that it is reserved for the debugger.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        UnregisterHotKey(this.Handle, 1);
                        RegisterHotKey(this.Handle, 1, (int)2, e.KeyCode.GetHashCode());
                        TextBoxCaptureHotkey.Text = "Control + " + e.KeyCode.ToString();
                    }
                }
            }
            else if (Control.ModifierKeys == Keys.Alt)
            {
                if (e.KeyCode.ToString() == "Menu")
                {
                }
                else
                {
                    if (e.KeyCode.ToString().Contains("F12"))
                    {
                        MessageBox.Show("F12 can not be used as the capture hotkey due to the reason that it is reserved for the debugger.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        UnregisterHotKey(this.Handle, 1);
                        RegisterHotKey(this.Handle, 1, (int)1, e.KeyCode.GetHashCode());
                        TextBoxCaptureHotkey.Text = "Alt + " + e.KeyCode.ToString();
                    }
                }
            }
            else
            {
                if (e.KeyCode.ToString().Contains("F12"))
                {
                    MessageBox.Show("F12 can not be used as the capture hotkey due to the reason that it is reserved for the debugger.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    UnregisterHotKey(this.Handle, 1);
                    RegisterHotKey(this.Handle, 1, (int)0, e.KeyCode.GetHashCode());
                    TextBoxCaptureHotkey.Text = e.KeyCode.ToString();
                }
            }
        }

        private void NumericUpDownCaptureDelay_Validated(object sender, EventArgs e)
        {
            if (NumericUpDownCaptureDelay.Text == "")
            {
                NumericUpDownCaptureDelay.Text = "0";
            }
        }

        private void NumericUpDownCaptureTime_Validated(object sender, EventArgs e)
        {
            if (NumericUpDownCaptureTime.Text == "")
            {
                NumericUpDownCaptureTime.Text = "0";
            }
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                TextBoxOutputFolder.Text = fbd.SelectedPath;
            }
        }

        private void ButtonApplySettings_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(TextBoxOutputFolder.Text))
            {
                foreach (Process p in Process.GetProcesses())
                {
                    if (p.ProcessName.Contains("PresentMon-1.6.0-x64"))
                    {
                        p.Kill();
                    }
                }

                string PresentMonArgs = "";
                PresentMonArgs = "-process_name " + ListBoxProcesses.SelectedItem + ".exe";
                PresentMonArgs = PresentMonArgs + " -output_file " + "\"" + TextBoxOutputFolder.Text + "\\" + "Capture.csv" + "\"";
                PresentMonArgs = PresentMonArgs + " -hotkey " + TextBoxCaptureHotkey.Text.Replace(" ", "").Replace("Alt", "ALT").Replace("Control", "CTRL").Replace("Shift", "SHIFT").Replace("Back", "BACKSPACE").Replace("Return", "ENTER").Replace("Capital", "CAPSLOCK").Replace("Escape", "ESC").Replace("Space", "SPACE").Replace("PageUp", "PAGEUP").Replace("Next", "PAGEDOWN").Replace("End", "END").Replace("Home", "HOME").Replace("Left", "LEFT").Replace("Up", "UP").Replace("Right", "RIGHT").Replace("Down", "DOWN").Replace("Insert", "INS").Replace("Delete", "DEL").Replace("Scroll", "SCROLLLOCK").Replace("D0", "0").Replace("D1", "1").Replace("D2", "2").Replace("D3", "3").Replace("D4", "4").Replace("D5", "5").Replace("D6", "6").Replace("D7", "7").Replace("D8", "8").Replace("D9", "9");
                PresentMonArgs = PresentMonArgs + " -stop_existing_session";

                if (NumericUpDownCaptureDelay.Value.ToString() == "0")
                {
                }
                else
                {
                    PresentMonArgs = PresentMonArgs + " -delay " + NumericUpDownCaptureDelay.Value.ToString();
                }

                if (NumericUpDownCaptureTime.Value.ToString() == "0")
                {
                }
                else
                {
                    PresentMonArgs = PresentMonArgs + " -timed " + NumericUpDownCaptureTime.Value.ToString();
                }

                try
                {
                    Process StartNewSession = new Process();
                    StartNewSession.StartInfo.FileName = "PresentMon\\PresentMon-1.6.0-x64.exe";
                    StartNewSession.StartInfo.Arguments = PresentMonArgs;
                    StartNewSession.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    StartNewSession.StartInfo.CreateNoWindow = true;
                    StartNewSession.Start();
                }
                catch
                {
                    MessageBox.Show("Please allow the execution of PresentMon.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ButtonApplySettings_Click(sender, e);
                }

                Settings.SetValue("CaptureHotkey", TextBoxCaptureHotkey.Text, RegistryValueKind.String);
                Settings.SetValue("CaptureDelay", NumericUpDownCaptureDelay.Value.ToString(), RegistryValueKind.String);
                Settings.SetValue("CaptureTime", NumericUpDownCaptureTime.Value.ToString(), RegistryValueKind.String);
                Settings.SetValue("OutputFolder", TextBoxOutputFolder.Text, RegistryValueKind.String);
            }
            else
            {
                MessageBox.Show("Specified output folder doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonResetSettings_Click(object sender, EventArgs e)
        {
            TextBoxCaptureHotkey.Text = "F11";
            NumericUpDownCaptureDelay.Text = "0";
            NumericUpDownCaptureTime.Text = "0";
            TextBoxOutputFolder.Text = AppDomain.CurrentDomain.BaseDirectory + "Captures";
            ButtonApplySettings_Click(sender, e);
        }

        private void RegisterHotkey()
        {
            Keys a;
            Enum.TryParse(TextBoxCaptureHotkey.Text.Replace("Shift + ", "").Replace("Control + ", "").Replace("Alt + ", ""), out a);

            if (TextBoxCaptureHotkey.Text.Contains("Shift"))
            {
                UnregisterHotKey(this.Handle, 1);
                RegisterHotKey(this.Handle, 1, (int)4, a.GetHashCode());
            }
            else if (TextBoxCaptureHotkey.Text.Contains("Control"))
            {
                UnregisterHotKey(this.Handle, 1);
                RegisterHotKey(this.Handle, 1, (int)2, a.GetHashCode());
            }
            else if (TextBoxCaptureHotkey.Text.Contains("Alt"))
            {
                UnregisterHotKey(this.Handle, 1);
                RegisterHotKey(this.Handle, 1, (int)1, a.GetHashCode());
            }
            else
            {
                UnregisterHotKey(this.Handle, 1);
                RegisterHotKey(this.Handle, 1, (int)0, a.GetHashCode());
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\Windows Pop-up Blocked.wav");
                simpleSound.Play();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName.Contains("PresentMon-1.6.0-x64"))
                {
                    p.Kill();
                }
            }

            UnregisterHotKey(this.Handle, 1);
        }
    }
}
