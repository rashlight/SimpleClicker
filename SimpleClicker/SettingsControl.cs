﻿using System;
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
        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {
            lappingToggle.Checked = Properties.Settings.Default.isLappingEnabled;
            lappingChooser.Value = Properties.Settings.Default.lappingCount;
            delayStartChooser.Value = (decimal)Properties.Settings.Default.delayTimeStart;
            delayStopChooser.Value = (decimal)Properties.Settings.Default.delayTimeStop;
            timePrecisionChooser.Value = Properties.Settings.Default.timePrecision;
            updateThresholdChooser.Value = Properties.Settings.Default.updateThreshold;
            prepTimeChooser.Value = (decimal)Properties.Settings.Default.preparationTime;

            if (!lappingToggle.Checked)
            {
                lappingChooser.Enabled = false;
            }

            LocalizeUI();
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
            if (theme == MetroThemeStyle.Default)
            {
                if (DateTime.Now.Hour >= Properties.Settings.Default.sunriseTime && DateTime.Now.Hour < Properties.Settings.Default.sunsetTime)
                {
                    metroStyleManager.Theme = MetroThemeStyle.Light;
                }
                else metroStyleManager.Theme = MetroThemeStyle.Dark;
            }
            else metroStyleManager.Theme = theme;
            lappingToggle.Theme = metroStyleManager.Theme;
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

        private void lappingChooser_ValueChanged(object sender, EventArgs e)
        {
            lappingChooser_MouseUp(lappingChooser, null);
        }

        private void prepTimeChooser_ValueChanged(object sender, EventArgs e)
        {
            prepTimeChooser_MouseUp(prepTimeChooser, null);
        }

        private void delayStartChooser_ValueChanged(object sender, EventArgs e)
        {
            if (delayStartChooser.Value > delayStopChooser.Value) delayStartChooser.Value = delayStopChooser.Value;
            delayStartChooser_MouseUp(delayStartChooser, null);
        }

        private void delayStopChooser_ValueChanged(object sender, EventArgs e)
        {
            if (delayStartChooser.Value > delayStopChooser.Value) delayStartChooser.Value = delayStopChooser.Value;
            delayStopChooser_MouseUp(delayStopChooser, null);
        }

        private void timePrecisionChooser_ValueChanged(object sender, EventArgs e)
        {
            timePrecisionChooser_MouseUp(timePrecisionChooser, null);
        }

        private void updateThresholdChooser_ValueChanged(object sender, EventArgs e)
        {
            updateThresholdChooser_MouseUp(updateThresholdChooser, null);
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
