using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClicker
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();

            lappingToggle.Checked = Properties.Settings.Default.isLappingEnabled;
            lappingChooser.Value = Properties.Settings.Default.lappingCount;
            delayStartChooser.Value = (decimal)Properties.Settings.Default.delayTimeStart;
            delayStopChooser.Value = (decimal)Properties.Settings.Default.delayTimeStop;
            timePrecisionChooser.Value = Properties.Settings.Default.timePrecision;
            updateThresholdChooser.Value = Properties.Settings.Default.updateThreshold;
            prepTimeChooser.Value = (decimal)Properties.Settings.Default.preparationTime;
            // "en-US" = Properties.Settings.Default.language = ;

            if (!lappingToggle.Checked)
            {
                lappingChooser.Enabled = false;
            }
        }

        public bool SaveOptions()
        {
            if (delayStartChooser.Value > delayStopChooser.Value)
            {
                MessageBox.Show("Start value of \"Delay Time\" should be smaller or equal to end value!", Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Properties.Settings.Default.isLappingEnabled = lappingToggle.Checked;
            Properties.Settings.Default.lappingCount = (int)lappingChooser.Value;
            Properties.Settings.Default.delayTimeStart = (double)delayStartChooser.Value;
            Properties.Settings.Default.delayTimeStop = (double)delayStopChooser.Value;
            Properties.Settings.Default.timePrecision = (int)timePrecisionChooser.Value;
            Properties.Settings.Default.updateThreshold = (int)updateThresholdChooser.Value;
            Properties.Settings.Default.preparationTime = (double)prepTimeChooser.Value;
            Properties.Settings.Default.language = "en-US";
            Properties.Settings.Default.Save();
            return true;
        }

        private void lappingToggle_CheckedChanged(object sender, EventArgs e)
        {
            lappingChooser.Enabled = lappingToggle.Checked;
        }

        private void defaultButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Are you sure to change ALL settings to default?\n" +
                    "Your reflected values will NOT be saved.", 
                    Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning
                ) != DialogResult.OK) return;
            lappingToggle.Checked = false;
            lappingChooser.Value = 5;
            delayStartChooser.Value = 0.5M;
            delayStopChooser.Value = 1;
            timePrecisionChooser.Value = 0;
            updateThresholdChooser.Value = 10;
            prepTimeChooser.Value = 3;
        }

        private void creditsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/rashlight");
        }

        private void supportButton_Click(object sender, EventArgs e)
        {
            string supportData =
                "OSVersion: " + Environment.OSVersion + "\n" +
                "Is64BitOS: " + Environment.Is64BitOperatingSystem + "\n" +
                "Is64BitBinary: " + Environment.Is64BitProcess + "\n" +
                "StopwatchFrequency: " + System.Diagnostics.Stopwatch.Frequency + "\n" +
                "IsStopwatchHighResolution: " + System.Diagnostics.Stopwatch.IsHighResolution + "\n" +
                "IsElevated: " + System.Security.Principal.WindowsIdentity.GetCurrent().Owner.IsWellKnown(System.Security.Principal.WellKnownSidType.BuiltinAdministratorsSid) + "\n" +
                "ProcessorCount: " + Environment.ProcessorCount + "\n" +
                "SystemPageSize: " + Environment.SystemPageSize + "\n" +
                "PriorityIndex: " + System.Threading.Thread.CurrentThread.Priority + "\n" +
                "Language: " + System.Threading.Thread.CurrentThread.CurrentCulture + "\n";

            MessageBox.Show(supportData, System.Diagnostics.Process.GetCurrentProcess().ProcessName + " ver " + System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void licenseText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gnu.org/licenses/gpl-3.0.en.html");
        }

        private void delayStartChooser_ValueChanged(object sender, EventArgs e)
        {
            if (delayStartChooser.Value > delayStopChooser.Value) delayStartChooser.Value = delayStopChooser.Value;
        }

        private void delayStopChooser_ValueChanged(object sender, EventArgs e)
        {
            if (delayStartChooser.Value > delayStopChooser.Value) delayStartChooser.Value = delayStopChooser.Value;
        }

        private void UnfocusComponent_Enter(object sender, EventArgs e)
        {
            flagBox.Focus();
        }
    }
}
