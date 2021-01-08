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
using Microsoft.Win32;
using System.Windows.Forms;

namespace Performance_Measurement_Tool
{
    public partial class LicenseAgreementForm : Form
    {
        RegistryKey Settings = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\PerformanceMeasurementTool", true);

        public LicenseAgreementForm()
        {
            InitializeComponent();
        }

        private void ButtonAgree_Click(object sender, EventArgs e)
        {
            Settings.SetValue("LicenseAccepted", "True");
            this.Close();
        }

        private void ButtonDecline_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
