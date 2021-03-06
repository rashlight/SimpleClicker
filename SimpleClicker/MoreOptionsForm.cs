﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SimpleClicker
{
    public struct LapAllowances
    {
        public const int DEFAULT_ITEM_COUNT = 3;
        public const string ALL_DURATIONS = "all-durations";
        public const string AFTER_DELAYS = "after-delays";
        public const string DELAYS_ONLY = "delays-only";
    }

    public struct LapSorting
    {
        public const int DEFAULT_ITEM_COUNT = 4;
        public const string FIRST_FOCUSED = "first-focused";
        public const string LAST_FOCUSED = "last-focused";
        public const string BEST_TO_WORST = "best-to-worst";
        public const string WORST_TO_BEST = "worst-to-best";
        public const string RANDOMIZE = "randomize";
    }

    public struct LapDisplayType
    {
        public const int DEFAULT_ITEM_COUNT = 2;
        public const string TIME_PER_LAPS = "time-per-laps";
        public const string REAL_TIME = "real-time";
    }

    /// <summary>
    /// It's very sus.
    /// </summary>
    public struct Secrets
    {
        public const string ENABLE_RANDOMIZE = "\u0069\u006c\u006f\u0076\u0065\u0072\u0061\u006e\u0064\u006f\u006d";
    }

    public partial class MoreOptionsForm : MetroForm
    {
        private bool isRequestLanguageChange = false;
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        public MoreOptionsForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.isAlwaysOnTop)
                SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);

            LocalizeUI();
            ChangeColorTooltip();
            LoadSavedData();
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private void LocalizeUI()
        {
            this.Text = Properties.Languages.moreOptionsFormText;

            lapsTab.Text = Properties.Languages.lapsTabText;
            interfacesTab.Text = Properties.Languages.interfaceTabText;
            extrasTab.Text = Properties.Languages.extrasTabText;

            lapAllowanceLabel.Text = Properties.Languages.lapAllowanceText;
            // ComboBox Items adding
            lapAllowancesComboBox.Items.Add(Properties.Languages.lapAllowanceOption0);
            lapAllowancesComboBox.Items.Add(Properties.Languages.lapAllowanceOption1);
            lapAllowancesComboBox.Items.Add(Properties.Languages.lapAllowanceOption2);
            toolTip.SetToolTip(lapsAllowanceHelp, Properties.Languages.lapsAllowanceHelpText);

            lapSortingLabel.Text = Properties.Languages.lapSortingText;
            // ComboBox Items adding
            lapSortingComboBox.Items.Add(Properties.Languages.lapSortingOption0);
            lapSortingComboBox.Items.Add(Properties.Languages.lapSortingOption1);
            lapSortingComboBox.Items.Add(Properties.Languages.lapSortingOption2);
            lapSortingComboBox.Items.Add(Properties.Languages.lapSortingOption3);
            toolTip.SetToolTip(lapsSortingHelp, Properties.Languages.lapsSortingHelpText);

            lapDisplayTypeLabel.Text = Properties.Languages.lapDisplayTypeText;
            // ComboBox Items adding
            lapDisplayComboBox.Items.Add(Properties.Languages.lapDisplayTypeOption0);
            lapDisplayComboBox.Items.Add(Properties.Languages.lapDisplayTypeOption1);
            toolTip.SetToolTip(lapDisplayHelp, Properties.Languages.lapDisplayHelpText);

            delayTimeShowsLabel.Text = Properties.Languages.delayTimeShowsText;
            toolTip.SetToolTip(delayTimeShowsHelp, Properties.Languages.delayTimeShowsHelpText);

            alwaysOnTopLabel.Text = Properties.Languages.alwaysOnTopText;
            toolTip.SetToolTip(alwaysOnTopHelp, Properties.Languages.alwaysOnTopHelpText);

            preparationColorLabel.Text = Properties.Languages.preparationTimeColorText;
            preparationColorPicker.Text = Properties.Languages.changeOptionText;
            toolTip.SetToolTip(preparationColorHelp, Properties.Languages.preparationColorHelpText);

            delayColorLabel.Text = Properties.Languages.delayTimeColorText;
            delayColorPicker.Text = Properties.Languages.changeOptionText;
            toolTip.SetToolTip(delayColorHelp, Properties.Languages.delayColorHelpText);

            startColorLabel.Text = Properties.Languages.startTimeColorText;
            startColorPicker.Text = Properties.Languages.changeOptionText;
            toolTip.SetToolTip(startColorHelp, Properties.Languages.startColorHelpText);

            pauseColorLabel.Text = Properties.Languages.pauseTimeColorText;
            pauseColorPicker.Text = Properties.Languages.changeOptionText;
            toolTip.SetToolTip(pauseColorHelp, Properties.Languages.pauseColorHelpText);

            languageLabel.Text = Properties.Languages.languageText;
            toolTip.SetToolTip(languageHelp, Properties.Languages.languageHelpText);

            secretLabel.Text = Properties.Languages.secretText;
            secretButton.Text = Properties.Languages.secretButtonIdleText;
            toolTip.SetToolTip(secretHelp, Properties.Languages.secretHelpText);

            resetTimeButton.Text = Properties.Languages.resetTimeText;
            resetExtraButton.Text = Properties.Languages.resetExtraText;
            resetAllButton.Text = Properties.Languages.resetAllText;

            this.Refresh();
        }

        private void ChangeLanguage(string lang)
        {
            // TODO: Real-time translation
            DialogResult dg = MessageBox.Show(
                "Language changed to: " + new CultureInfo(Properties.Settings.Default.language).EnglishName + "\n" +
                "Restart now to apply changes?", Name, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dg == DialogResult.Yes) Application.Restart();
        }

        private void LoadSavedData()
        {
            switch (Properties.Settings.Default.lapsAllowances)
            {
                case LapAllowances.ALL_DURATIONS: // All durations
                    lapAllowancesComboBox.SelectedIndex = 0;
                    break;
                case LapAllowances.AFTER_DELAYS: // After delays
                    lapAllowancesComboBox.SelectedIndex = 1;
                    break;
                case LapAllowances.DELAYS_ONLY: // Delays only
                    lapAllowancesComboBox.SelectedIndex = 2;
                    break;
                default:
                    MessageBox.Show("The settings might be corrupted!\nYou will need to reset all (Extras) or edit the file manually.", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            switch (Properties.Settings.Default.lapsSorting)
            {
                case LapSorting.FIRST_FOCUSED: // First focused
                    lapSortingComboBox.SelectedIndex = 0;
                    break;
                case LapSorting.LAST_FOCUSED: // Last focused
                    lapSortingComboBox.SelectedIndex = 1;
                    break;
                case LapSorting.BEST_TO_WORST: // Best to worst
                    lapSortingComboBox.SelectedIndex = 2;
                    break;
                case LapSorting.WORST_TO_BEST: // Worst to best
                    lapSortingComboBox.SelectedIndex = 3;
                    break;
                case LapSorting.RANDOMIZE: // Randomize
                    if (lapSortingComboBox.Items.Count <= LapSorting.DEFAULT_ITEM_COUNT)
                    {
                        lapSortingComboBox.Items.Add("Randomizer");
                        // Preserving for multiple secrets
                        lapSortingComboBox.SelectedIndex = lapSortingComboBox.Items.Count - 1;
                    }
                    break;
                default:
                    MessageBox.Show("The settings might be corrupted!\nYou will need to reset all (Extras) or edit the file manually.", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            switch (Properties.Settings.Default.lapsDisplayType)
            {
                case LapDisplayType.TIME_PER_LAPS: // Time per laps
                    lapDisplayComboBox.SelectedIndex = 0;
                    break;
                case LapDisplayType.REAL_TIME: // Real-time
                    lapDisplayComboBox.SelectedIndex = 1;
                    break;
                default:
                    MessageBox.Show("The settings might be corrupted!\nYou will need to reset all (Extras) or edit the file manually.", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            // Will trigger SelectedIndexChanged
            switch (Properties.Settings.Default.language)
            {
                case "en-US":
                    languageComboBox.SelectedIndex = 0;
                    break;
                case "fr-FR":
                    languageComboBox.SelectedIndex = 1;
                    break;
                case "vi-VN":
                    languageComboBox.SelectedIndex = 2;
                    break;
                default:
                    MessageBox.Show("The settings might be corrupted!\nYou will need to reset all (Extras) or edit the file manually.", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            // Request message goes on afterwards
            isRequestLanguageChange = true;

            isDelayTimeToggle.Checked = Properties.Settings.Default.isDelayTimeShows;
            alwaysOnTopToggle.Checked = Properties.Settings.Default.isAlwaysOnTop;

            preparationColorBox.BackColor = Properties.Settings.Default.preparationTimeColor;
            delayColorBox.BackColor = Properties.Settings.Default.delayTimeColor;
            startColorBox.BackColor = Properties.Settings.Default.startTimeColor;
            pauseColorBox.BackColor = Properties.Settings.Default.pauseTimeColor;
        }

        private void ChangeColorTooltip()
        {
            Color preparationColor = Properties.Settings.Default.preparationTimeColor;
            Color delayColor = Properties.Settings.Default.delayTimeColor;
            Color startColor = Properties.Settings.Default.startTimeColor;
            Color pauseColor = Properties.Settings.Default.pauseTimeColor;

            toolTip.SetToolTip(preparationColorBox, preparationColor.Name + " (" + preparationColor.R + ", " + preparationColor.G + ", " + preparationColor.B + ")");
            toolTip.SetToolTip(delayColorBox, delayColor.Name + " (" + delayColor.R + ", " + delayColor.G + ", " + delayColor.B + ")");
            toolTip.SetToolTip(startColorBox, startColor.Name + " (" + startColor.R + ", " + startColor.G + ", " + startColor.B + ")");
            toolTip.SetToolTip(pauseColorBox, pauseColor.Name + " (" + pauseColor.R + ", " + pauseColor.G + ", " + pauseColor.B + ")");
        }

        private void lapAllowancesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lapAllowancesComboBox.SelectedIndex)
            {
                case 0: // All durations
                    Properties.Settings.Default.lapsAllowances = LapAllowances.ALL_DURATIONS;
                    break;
                case 1: // After delays
                    Properties.Settings.Default.lapsAllowances = LapAllowances.AFTER_DELAYS;
                    break;
                case 2: // Delays only
                    Properties.Settings.Default.lapsAllowances = LapAllowances.DELAYS_ONLY;
                    break;
                default: 
                    throw new IndexOutOfRangeException("Index " + lapAllowancesComboBox.SelectedIndex + "was not in range!");
            }
            Properties.Settings.Default.Save();
        }

        private void lapSortingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lapSortingComboBox.SelectedIndex)
            {
                case 0: // First focused
                    Properties.Settings.Default.lapsSorting = LapSorting.FIRST_FOCUSED;
                    break;
                case 1: // Last focused
                    Properties.Settings.Default.lapsSorting = LapSorting.LAST_FOCUSED;
                    break;
                case 2: // Best to worst
                    Properties.Settings.Default.lapsSorting = LapSorting.BEST_TO_WORST;
                    break;
                case 3: // Worst to best
                    Properties.Settings.Default.lapsSorting = LapSorting.WORST_TO_BEST;
                    break;
                case 4: // Randomize
                    Properties.Settings.Default.lapsSorting = LapSorting.RANDOMIZE;
                    break;
                default:
                    throw new IndexOutOfRangeException("Index " + lapAllowancesComboBox.SelectedIndex + "was not in range!");
            }
            Properties.Settings.Default.Save();
        }

        private void lapDisplayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lapDisplayComboBox.SelectedIndex)
            {
                case 0: // Time per laps
                    Properties.Settings.Default.lapsDisplayType = LapDisplayType.TIME_PER_LAPS;
                    break;
                case 1: // Real-time
                    Properties.Settings.Default.lapsDisplayType = LapDisplayType.REAL_TIME;
                    break;
                default:
                    throw new IndexOutOfRangeException("Index " + lapAllowancesComboBox.SelectedIndex + "was not in range!");
            }
            Properties.Settings.Default.Save();
        }

        private void isDelayTimeToggle_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isDelayTimeShows = isDelayTimeToggle.Checked;
            Properties.Settings.Default.Save();
        }

        private void alwaysOnTopToggle_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isAlwaysOnTop = alwaysOnTopToggle.Checked;

            if (alwaysOnTopToggle.Checked)
            {
                SetWindowPos(Application.OpenForms[0].Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
                SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            }
            else 
            {
                SetWindowPos(Application.OpenForms[0].Handle, HWND_NOTOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
                SetWindowPos(this.Handle, HWND_NOTOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            }
            
            Properties.Settings.Default.Save();
        }

        private void preparationColorPicker_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Properties.Settings.Default.preparationTimeColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.preparationTimeColor = colorDialog.Color;
                Properties.Settings.Default.Save();
                preparationColorBox.BackColor = Properties.Settings.Default.preparationTimeColor;
                ChangeColorTooltip();
            }
        }

        private void delayColorPicker_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Properties.Settings.Default.delayTimeColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.delayTimeColor = colorDialog.Color;
                Properties.Settings.Default.Save();
                delayColorBox.BackColor = Properties.Settings.Default.delayTimeColor;
                ChangeColorTooltip();
            }
        }

        private void startColorPicker_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Properties.Settings.Default.startTimeColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.startTimeColor = colorDialog.Color;
                Properties.Settings.Default.Save();
                startColorBox.BackColor = Properties.Settings.Default.startTimeColor;
                ChangeColorTooltip();
            }
        }

        private void pauseColorPicker_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Properties.Settings.Default.pauseTimeColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.pauseTimeColor = colorDialog.Color;
                Properties.Settings.Default.Save();
                pauseColorBox.BackColor = Properties.Settings.Default.pauseTimeColor;
                ChangeColorTooltip();
            }
        }

        private void resetTimeButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Languages.warningResetTimeOptions, Name, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            Properties.Settings.Default.isLappingEnabled = true;
            Properties.Settings.Default.preparationTime = 3;
            Properties.Settings.Default.lappingCount = -1;
            Properties.Settings.Default.delayTimeStart = 0.5;
            Properties.Settings.Default.delayTimeStop = 3;
            Properties.Settings.Default.timePrecision = 4;
            Properties.Settings.Default.updateThreshold = 10;
            Properties.Settings.Default.Save();
            MessageBox.Show(Properties.Languages.infoResetCompleted, Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
            Environment.Exit(0);
        }

        private void resetExtraButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Languages.warningResetExtraOptions, Name, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            Properties.Settings.Default.language = "en-US";
            Properties.Settings.Default.lapsAllowances = LapAllowances.ALL_DURATIONS;
            Properties.Settings.Default.lapsSorting = LapSorting.LAST_FOCUSED;
            Properties.Settings.Default.lapsDisplayType = LapDisplayType.REAL_TIME;
            Properties.Settings.Default.isDelayTimeShows = true;
            Properties.Settings.Default.isAlwaysOnTop = false;
            Properties.Settings.Default.preparationTimeColor = Color.Black;
            Properties.Settings.Default.delayTimeColor = Color.Black;
            Properties.Settings.Default.startTimeColor = Color.Black;
            Properties.Settings.Default.pauseTimeColor = Color.Black;
            Properties.Settings.Default.Save();
            MessageBox.Show(Properties.Languages.infoResetCompleted, Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
            Environment.Exit(0);
        }

        private void resetAllButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Languages.warningResetAllOptions, Name, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            Properties.Settings.Default.isLappingEnabled = true;
            Properties.Settings.Default.preparationTime = 3;
            Properties.Settings.Default.lappingCount = -1;
            Properties.Settings.Default.delayTimeStart = 0.5;
            Properties.Settings.Default.delayTimeStop = 3;
            Properties.Settings.Default.timePrecision = 4;
            Properties.Settings.Default.updateThreshold = 10;
            Properties.Settings.Default.language = "en-US";
            Properties.Settings.Default.lapsAllowances = LapAllowances.ALL_DURATIONS;
            Properties.Settings.Default.lapsSorting = LapSorting.LAST_FOCUSED;
            Properties.Settings.Default.lapsDisplayType = LapDisplayType.REAL_TIME;
            Properties.Settings.Default.isDelayTimeShows = true;
            Properties.Settings.Default.isAlwaysOnTop = false;
            Properties.Settings.Default.preparationTimeColor = Color.Black;
            Properties.Settings.Default.delayTimeColor = Color.Black;
            Properties.Settings.Default.startTimeColor = Color.Black;
            Properties.Settings.Default.pauseTimeColor = Color.Black;
            Properties.Settings.Default.Save();
            MessageBox.Show(Properties.Languages.infoResetCompleted, Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
            Environment.Exit(0);
        }

        private void secretButton_Click(object sender, EventArgs e)
        {
            switch (secretBox.Text)
            {
                case Secrets.ENABLE_RANDOMIZE:
                    secretButton.Enabled = false;
                    secretButton.Text = Properties.Languages.secretButtonSuccessText;
                    if (lapSortingComboBox.Items.Count <= LapSorting.DEFAULT_ITEM_COUNT)
                    {
                        lapSortingComboBox.Items.Add("Randomizer");
                        // Preserving for multiple secrets
                        lapSortingComboBox.SelectedIndex = lapSortingComboBox.Items.Count - 1;
                    }
                    break;
                default:
                    break;
            }
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (languageComboBox.SelectedIndex)
            {
                case 0:
                    Properties.Settings.Default.language = "en-US";
                    flagPictureBox.Image = Properties.Resources.us_uk;
                    break;
                case 1:
                    Properties.Settings.Default.language = "fr-FR";
                    flagPictureBox.Image = Properties.Resources._1280px_Flag_of_France_svg;
                    break;
                case 2:
                    Properties.Settings.Default.language = "vi-VN";
                    flagPictureBox.Image = Properties.Resources._1280px_Flag_of_Vietnam_svg;
                    break;
                default:
                    break;
            }

            if (isRequestLanguageChange) ChangeLanguage(Properties.Settings.Default.language);
            Properties.Settings.Default.Save();
        }
    }
}
