using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace SimpleClicker
{
    public partial class SettingsControl : UserControl
    {
        public bool isDelayOverride = false;

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

            LocalizeUI();
            ChangeTheme(Properties.Settings.Default.darkModeType);
            ChangeBorder(Properties.Settings.Default.borderColorType);
        }

        private void LocalizeUI()
        {
            enableLappingText.Text = Properties.Languages.enableLappingText;
            preparationTimeText.Text = Properties.Languages.preparationTimeText;
            delayTimeText.Text = Properties.Languages.delayTimeText;
            delayToText.Text = Properties.Languages.delayToText;
            timePrecisionText.Text = Properties.Languages.timePrecisionText;
            updateThresholdText.Text = Properties.Languages.updateThresholdText;
            moreOptionsButton.Text = Properties.Languages.moreOptionsButtonText;
            aboutButton.Text = Properties.Languages.supportText;
        }

        public void ChangeTheme(MetroThemeStyle theme)
        {
            metroStyleManager.Theme = theme;
        }

        public void ChangeBorder(MetroColorStyle color)
        {
            metroStyleManager.Style = color;
        }

        private void lappingToggle_CheckedChanged(object sender, EventArgs e)
        {
            lappingChooser.Enabled = lappingToggle.Checked;
            Properties.Settings.Default.isLappingEnabled = lappingToggle.Checked;
            Properties.Settings.Default.Save();
        }

        private void creditsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/rashlight/SimpleClicker");
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
            delayToText.Focus();
        }

        private void moreOptionsButton_Click(object sender, EventArgs e)
        {
            MoreOptionsForm mof = new MoreOptionsForm();
            mof.ShowDialog();
        }

        private void delayStartChooser_MouseUp(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.delayTimeStart = (double)delayStartChooser.Value;
            Properties.Settings.Default.Save();
        }

        private void delayStopChooser_MouseUp(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.delayTimeStop = (double)delayStopChooser.Value;
            if (delayStartChooser.Value == delayStopChooser.Value)
                Properties.Settings.Default.delayTimeStart = (double)delayStartChooser.Value;
            Properties.Settings.Default.Save();
        }

        private void lappingChooser_MouseUp(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.lappingCount = (int)lappingChooser.Value;
            Properties.Settings.Default.Save();
        }

        private void prepTimeChooser_MouseUp(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.preparationTime = (double)prepTimeChooser.Value;
            Properties.Settings.Default.Save();
        }

        private void timePrecisionChooser_MouseUp(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.timePrecision = (int)timePrecisionChooser.Value;
            Properties.Settings.Default.Save();
        }

        private void updateThresholdChooser_MouseUp(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.updateThreshold = (int)updateThresholdChooser.Value;
            Properties.Settings.Default.Save();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void licenseLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gnu.org/licenses/gpl-3.0.en.html");
        }
    }
}
