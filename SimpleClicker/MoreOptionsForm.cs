using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
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
        public const string ENABLE_RANDOMIZE = "randomlist";
        public const string TOGGLE_TIMECONTROL = "togglebiostime";
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

            ChangeUIScaling();
        }

        private void MoreOptionsForm_Load(object sender, EventArgs e)
        {
            LocalizeUI();
            ChangeColorTooltip();
            LoadSavedData();
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private void ChangeUIScaling()
        {
            if (!MainForm.isScalable)
            {
                // WMI is disabled, rather having it blur than to make mess-up UI
                this.Name += " (Compatibility Mode)";
                this.AutoScaleMode = AutoScaleMode.None;
                this.PerformAutoScale();
                return;
            }
        }

        private void LocalizeUI()
        {
            this.Text = Properties.Languages.moreOptionsFormText;

            lapsTab.Text = Properties.Languages.lapsTabText;
            interfacesTab.Text = Properties.Languages.interfaceTabText;
            themesTab.Text = Properties.Languages.themeTabText;
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

            darkModeText.Text = Properties.Languages.darkModeText;
            // ComboBox Items adding
            darkModeComboBox.Items.Add(Properties.Languages.darkModeOption1);
            darkModeComboBox.Items.Add(Properties.Languages.darkModeOption2);
            darkModeComboBox.Items.Add(Properties.Languages.darkModeOption3);
            toolTip.SetToolTip(darkModeHelp, Properties.Languages.darkModeHelpText);

            borderColorText.Text = Properties.Languages.borderColorText;
            foreach (var item in Enum.GetNames(typeof(MetroFramework.MetroColorStyle)))
            {
                borderColorComboBox.Items.Add(item);
            }
            // Clear the "Default" option, since it has a negative index and unusable in many array context.
            borderColorComboBox.Items.RemoveAt(borderColorComboBox.Items.Count - 1);
            toolTip.SetToolTip(borderColorHelp, Properties.Languages.borderColorHelpText);

            sunriseLabel.Text = Properties.Languages.sunriseText;
            toolTip.SetToolTip(sunriseHelp, Properties.Languages.sunriseHelpText);

            sunsetLabel.Text = Properties.Languages.sunsetText;
            toolTip.SetToolTip(sunsetHelp, Properties.Languages.sunsetHelpText);

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
            switch (Properties.Settings.Default.lapsAllowancesType)
            {
                case LapAllowances.ALL_DURATIONS:
                    lapAllowancesComboBox.SelectedIndex = 0;
                    break;
                case LapAllowances.AFTER_DELAYS:
                    lapAllowancesComboBox.SelectedIndex = 1;
                    break;
                case LapAllowances.DELAYS_ONLY:
                    lapAllowancesComboBox.SelectedIndex = 2;
                    break;
                default:
                    MessageBox.Show("The settings might be corrupted!\nYou will need to reset all (Extras) or edit the file manually.", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            switch (Properties.Settings.Default.lapsSortingType)
            {
                case LapSorting.FIRST_FOCUSED:
                    lapSortingComboBox.SelectedIndex = 0;
                    break;
                case LapSorting.LAST_FOCUSED:
                    lapSortingComboBox.SelectedIndex = 1;
                    break;
                case LapSorting.BEST_TO_WORST:
                    lapSortingComboBox.SelectedIndex = 2;
                    break;
                case LapSorting.WORST_TO_BEST:
                    lapSortingComboBox.SelectedIndex = 3;
                    break;
                case LapSorting.RANDOMIZE: // Randomizer
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
                case LapDisplayType.TIME_PER_LAPS:
                    lapDisplayComboBox.SelectedIndex = 0;
                    break;
                case LapDisplayType.REAL_TIME:
                    lapDisplayComboBox.SelectedIndex = 1;
                    break;
                default:
                    MessageBox.Show("The settings might be corrupted!\nYou will need to reset all (Extras) or edit the file manually.", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            switch (Properties.Settings.Default.darkModeType)
            {
                case MetroThemeStyle.Default: // System
                    darkModeComboBox.SelectedIndex = 0;
                    break;
                case MetroThemeStyle.Light: // Off
                    darkModeComboBox.SelectedIndex = 1;
                    break;
                case MetroThemeStyle.Dark: // On
                    darkModeComboBox.SelectedIndex = 2;
                    break;
                default:
                    MessageBox.Show("The settings might be corrupted!\nYou will need to reset all (Extras) or edit the file manually.", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            borderColorComboBox.SelectedIndex = (int)Properties.Settings.Default.borderColorType;

            // Notice: Will trigger SelectedIndexChanged!
            switch (Properties.Settings.Default.language)
            {
                case "en-US": // English
                    languageComboBox.SelectedIndex = 0;
                    break;
                case "fr-FR": // French
                    languageComboBox.SelectedIndex = 1;
                    break;
                case "vi-VN": // Vietnamese
                    languageComboBox.SelectedIndex = 2;
                    break;
                default:
                    MessageBox.Show("The settings might be corrupted!\nYou will need to reset all (Extras) or edit the file manually.", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            sunriseChooser.Value = Properties.Settings.Default.sunriseTime;
            sunsetChooser.Value = Properties.Settings.Default.sunsetTime;

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

        public void ChangeTheme(MetroThemeStyle theme)
        {
            if (theme == MetroThemeStyle.Default)
            {
                if (DateTime.Now.Hour >= Properties.Settings.Default.sunriseTime && DateTime.Now.Hour < Properties.Settings.Default.sunsetTime)
                {
                    metroStyleManager.Theme = MetroThemeStyle.Light;
                }            
                else metroStyleManager.Theme = MetroThemeStyle.Dark;
                
                InvokeThemeOtherForm(metroStyleManager.Theme, typeof(MainForm));
            }
            else metroStyleManager.Theme = theme;

            foreach (MetroFramework.Controls.MetroTabPage tab in new[] { lapsTab, interfacesTab, themesTab, extrasTab })
            {
                foreach (PictureBox helpImage in tab.Controls.OfType<PictureBox>().ToList())
                {
                    if (helpImage.Name != flagPictureBox.Name && !helpImage.Name.Contains("ColorBox"))
                    {
                        if (metroStyleManager.Theme == MetroThemeStyle.Dark)
                        {
                            helpImage.BackgroundImage = Properties.Resources.help_icon_dark;
                        }
                        else helpImage.BackgroundImage = Properties.Resources.help_icon_light;
                    }
                }
            }

            foreach (PictureBox helpImage in defaultDarkModePanel.Controls.OfType<PictureBox>().ToList())
            {
                if (metroStyleManager.Theme == MetroThemeStyle.Dark)
                {
                    helpImage.BackgroundImage = Properties.Resources.help_icon_dark;
                }
                else helpImage.BackgroundImage = Properties.Resources.help_icon_light;
            }
        }

        public void ChangeBorder(MetroColorStyle color)
        {
            metroStyleManager.Style = color;
        }

        private void InvokeThemeOtherForm(MetroThemeStyle theme, Type formType)
        {
            // Using delegate instead of reflection to improve performance
            MethodInfo methodInfo = formType.GetMethod("ChangeTheme", new Type[] { typeof(MetroThemeStyle) });
            int invokeIndex = 0;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].GetType() == formType)
                {
                    invokeIndex = i;
                    break;
                }
            }
            Action<MetroThemeStyle> action = (Action<MetroThemeStyle>)Delegate.CreateDelegate(typeof(Action<MetroThemeStyle>), Application.OpenForms[invokeIndex], methodInfo, true);
            action.Invoke(theme);
        }

        private void InvokeBorderOtherForm(MetroColorStyle color, Type formType)
        {
            // Using delegate instead of reflection to improve performance
            MethodInfo methodInfo = formType.GetMethod("ChangeBorder", new Type[] { typeof(MetroColorStyle) });
            int invokeIndex = 0;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].GetType() == formType)
                {
                    invokeIndex = i;
                    break;
                }
            }
            Action<MetroColorStyle> action = (Action<MetroColorStyle>)Delegate.CreateDelegate(typeof(Action<MetroColorStyle>), Application.OpenForms[invokeIndex], methodInfo);
            action.Invoke(color);
        }

        private void lapAllowancesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lapAllowancesComboBox.SelectedIndex)
            {
                case 0: // All durations
                    Properties.Settings.Default.lapsAllowancesType = LapAllowances.ALL_DURATIONS;
                    break;
                case 1: // After delays
                    Properties.Settings.Default.lapsAllowancesType = LapAllowances.AFTER_DELAYS;
                    break;
                case 2: // Delays only
                    Properties.Settings.Default.lapsAllowancesType = LapAllowances.DELAYS_ONLY;
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
                    Properties.Settings.Default.lapsSortingType = LapSorting.FIRST_FOCUSED;
                    break;
                case 1: // Last focused
                    Properties.Settings.Default.lapsSortingType = LapSorting.LAST_FOCUSED;
                    break;
                case 2: // Best to worst
                    Properties.Settings.Default.lapsSortingType = LapSorting.BEST_TO_WORST;
                    break;
                case 3: // Worst to best
                    Properties.Settings.Default.lapsSortingType = LapSorting.WORST_TO_BEST;
                    break;
                case 4: // Randomize
                    Properties.Settings.Default.lapsSortingType = LapSorting.RANDOMIZE;
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
                foreach (Form form in Application.OpenForms)
                {
                    SetWindowPos(form.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
                }
            }
            else 
            {
                foreach (Form form in Application.OpenForms)
                {
                    SetWindowPos(form.Handle, HWND_NOTOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
                }
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
            // Laps tab
            Properties.Settings.Default.lapsAllowancesType = LapAllowances.ALL_DURATIONS;
            Properties.Settings.Default.lapsSortingType = LapSorting.LAST_FOCUSED;
            Properties.Settings.Default.lapsDisplayType = LapDisplayType.REAL_TIME;
            // Interfaces tab
            Properties.Settings.Default.isDelayTimeShows = true;
            Properties.Settings.Default.isAlwaysOnTop = false;
            Properties.Settings.Default.preparationTimeColor = Color.Silver;
            Properties.Settings.Default.delayTimeColor = Color.FromArgb(255, 128, 0); // Orange-ish
            Properties.Settings.Default.startTimeColor = Color.Green;
            Properties.Settings.Default.pauseTimeColor = Color.FromArgb(0, 128, 255); // Blue-ish
            // Themes tab
            Properties.Settings.Default.darkModeType = MetroThemeStyle.Default;
            Properties.Settings.Default.borderColorType = MetroColorStyle.Blue;
            Properties.Settings.Default.sunriseTime = 7;
            Properties.Settings.Default.sunsetTime = 19;
            // Extra tab
            Properties.Settings.Default.language = "en-US";
            Properties.Settings.Default.Save();
            MessageBox.Show(Properties.Languages.infoResetCompleted, Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
            Environment.Exit(0);
        }

        private void resetAllButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Languages.warningResetAllOptions, Name, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            // Settings tab
            Properties.Settings.Default.isLappingEnabled = true;
            Properties.Settings.Default.preparationTime = 3;
            Properties.Settings.Default.lappingCount = -1;
            Properties.Settings.Default.delayTimeStart = 0.5;
            Properties.Settings.Default.delayTimeStop = 3;
            Properties.Settings.Default.timePrecision = 4;
            Properties.Settings.Default.updateThreshold = 10;
            // Laps tab
            Properties.Settings.Default.lapsAllowancesType = LapAllowances.ALL_DURATIONS;
            Properties.Settings.Default.lapsSortingType = LapSorting.LAST_FOCUSED;
            Properties.Settings.Default.lapsDisplayType = LapDisplayType.REAL_TIME;
            // Interfaces tab
            Properties.Settings.Default.isDelayTimeShows = true;
            Properties.Settings.Default.isAlwaysOnTop = false;
            Properties.Settings.Default.preparationTimeColor = Color.Silver;
            Properties.Settings.Default.delayTimeColor = Color.FromArgb(255, 128, 0); // Orange-ish
            Properties.Settings.Default.startTimeColor = Color.Green;
            Properties.Settings.Default.pauseTimeColor = Color.FromArgb(0, 128, 255); // Blue-ish
            // Themes tab
            Properties.Settings.Default.darkModeType = MetroThemeStyle.Default;
            Properties.Settings.Default.borderColorType = MetroColorStyle.Blue;
            Properties.Settings.Default.sunriseTime = 7;
            Properties.Settings.Default.sunsetTime = 19;
            // Extra tab
            Properties.Settings.Default.language = "en-US";
            Properties.Settings.Default.Save();
            MessageBox.Show(Properties.Languages.infoResetCompleted, Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
        }

        private void secretButton_Click(object sender, EventArgs e)
        {
            metroStyleExtender.SetApplyMetroTheme(lapAllowanceLabel, true);
            metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            switch (secretBox.Text)
            {
                case Secrets.ENABLE_RANDOMIZE:
                    if (lapSortingComboBox.Items.Count <= LapSorting.DEFAULT_ITEM_COUNT)
                    {
                        lapSortingComboBox.Items.Add("Randomizer");
                        // Preserving for multiple secrets
                        lapSortingComboBox.SelectedIndex = lapSortingComboBox.Items.Count - 1;
                    }
                    MessageBox.Show("Random list is enabled.", "Secrets!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Secrets.TOGGLE_TIMECONTROL:
                    DialogResult dg = MessageBox.Show("Do you want to display current time on idle?", "Secrets!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dg == DialogResult.Yes)
                    {
                        Properties.Settings.Default.isBiosTimeEnabled = true;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.isBiosTimeEnabled = false;
                        Properties.Settings.Default.Save();
                        MessageBox.Show("Random list is enabled.", "Secrets!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    MessageBox.Show("Is BIOS time enabled: " + dg.ToString() + "\nEnter this secret again to toggle!",
                        "Secrets!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    break;
                default:
                    break;
            }
        }

        private void secretBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                secretButton_Click(secretBox, new EventArgs());
            }
        }

        private void secretHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Languages.secretListText, "SimpleClicker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (languageComboBox.SelectedIndex)
            {
                case 0:
                    Properties.Settings.Default.language = "en-US";
                    flagPictureBox.BackgroundImage = Properties.Resources.us_uk;
                    break;
                case 1:
                    Properties.Settings.Default.language = "fr-FR";
                    flagPictureBox.BackgroundImage = Properties.Resources._1280px_Flag_of_France_svg;
                    break;
                case 2:
                    Properties.Settings.Default.language = "vi-VN";
                    flagPictureBox.BackgroundImage = Properties.Resources._1280px_Flag_of_Vietnam_svg;
                    break;
                default:
                    break;
            }

            Properties.Settings.Default.Save();
            if (isRequestLanguageChange) ChangeLanguage(Properties.Settings.Default.language);
        }

        private void moreOptionsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.moreOptionsLastSelTab = moreOptionsTabControl.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void darkModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            defaultDarkModePanel.Visible = false;
            switch (darkModeComboBox.SelectedIndex)
            {
                case 0:
                    ChangeTheme(MetroThemeStyle.Default);
                    Properties.Settings.Default.darkModeType = MetroThemeStyle.Default;
                    defaultDarkModePanel.Visible = true;
                    break;
                case 1:
                    ChangeTheme(MetroThemeStyle.Light);
                    Properties.Settings.Default.darkModeType = MetroThemeStyle.Light;
                    break;
                case 2:
                    ChangeTheme(MetroThemeStyle.Dark);
                    Properties.Settings.Default.darkModeType = MetroThemeStyle.Dark;
                    break;
                default:
                    break;
            }
            InvokeThemeOtherForm(metroStyleManager.Theme, typeof(MainForm)); 
            Properties.Settings.Default.Save();
        }

        private void borderColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeBorder((MetroColorStyle)Enum.Parse(typeof(MetroColorStyle), borderColorComboBox.SelectedItem.ToString()));
            InvokeBorderOtherForm(metroStyleManager.Style, typeof(MainForm));
            Properties.Settings.Default.borderColorType = metroStyleManager.Style;
            Properties.Settings.Default.Save();
        }

        private void sunriseChooser_MouseUp(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.sunriseTime = (int)sunriseChooser.Value;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.darkModeType == MetroThemeStyle.Default)
            {
                ChangeTheme(MetroThemeStyle.Default);
            }
        }

        private void sunsetChooser_MouseUp(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.sunsetTime = (int)sunsetChooser.Value;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.darkModeType == MetroThemeStyle.Default)
            {
                ChangeTheme(MetroThemeStyle.Default);
            }
        }
    }
}
