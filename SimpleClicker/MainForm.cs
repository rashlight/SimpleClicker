using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SimpleClicker
{
    public enum StopWatchMode
    {
        Options = -1,
        Default = 0,
        Prepared = 1,
        Delayed = 2,
        Started = 3,
        Paused = 4,
    }

    public partial class MainForm : MetroForm
    {
        public static int stopWatchFrequency = 0; // Used for SettingControl

        public bool isStart = false;
        public bool isOptionsMenuOpened = false;
        public bool isDelayTimeShows = true;
        public bool isDelayLapAllowed = true;
        public bool isStartLapAllowed = true;
        public string displayType = LapDisplayType.REAL_TIME;
        public StopWatchMode currentMode = StopWatchMode.Default;
        public TimeSpan preparedTime = new TimeSpan();
        public TimeSpan delayTime = new TimeSpan();
        public TimeSpan lastLap = new TimeSpan();
        public Stopwatch stopWatch = new Stopwatch();
        public ResourceManager localizationManager = new ResourceManager(typeof(Properties.Resources));

        private Size defaultFormSize = new Size(542, 226);
        private Size expandedFormSize = new Size(542, 529);
        private Color defaultBackColor = Color.White;
        private Color defaultForeColor = Color.Black;

        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        public MainForm()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.language);
            InitializeComponent();
            if (Properties.Settings.Default.isAlwaysOnTop) 
                SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);

            preparedTime = TimeSpan.FromSeconds(Properties.Settings.Default.preparationTime);
            delayTime = TimeSpan.FromSeconds(Properties.Settings.Default.delayTimeStop - Properties.Settings.Default.delayTimeStart);
            ChangeModeUI(StopWatchMode.Default);
            ToggleOptionsMenuSize(defaultFormSize);
        }

        private double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return (random.NextDouble() * (maximum - minimum)) + minimum;
        }

        private void DisplayTime(TimeSpan time)
        {
            string delayDisplay = (currentMode == StopWatchMode.Delayed) ? "-" : "";
            string hoursDisplay = time.Hours < 10 ? "0" + time.Hours : time.Hours.ToString();
            string minutesDisplay = time.Minutes < 10 ? "0" + time.Minutes : time.Minutes.ToString();
            string secondsDisplay = time.Seconds < 10 ? "0" + time.Seconds : time.Seconds.ToString();
            string tickDisplay = Math.Round(time.TotalSeconds - Math.Truncate((double)time.TotalSeconds), Properties.Settings.Default.timePrecision).ToString();
            if (tickDisplay[0] == '1') tickDisplay = "0";
            mainTimerText.Text = delayDisplay + hoursDisplay + ":" + minutesDisplay + ":" + secondsDisplay;
            tickTimerText.Text = tickDisplay + " " + Properties.Languages.timeUnitText;
        }

        public void ChangeModeUI(StopWatchMode mode)
        {
            switch (mode)
            {
                case StopWatchMode.Options:
                    mainActionButton.Enabled = false;
                    secondaryActionButton.Text = Properties.Languages.backButtonText;
                    break;
                case StopWatchMode.Default:
                    mainActionButton.Enabled = true;
                    mainActionButton.Text = Properties.Languages.startButtonText;
                    secondaryActionButton.Text = Properties.Languages.optionsButtonText;
                    tickTimerText.Text = Properties.Languages.tickIdleText;
                    mainTimerText.ForeColor = defaultForeColor;
                    break;
                case StopWatchMode.Prepared:
                    mainActionButton.Enabled = false;
                    secondaryActionButton.Enabled = false;
                    mainActionButton.Text = Properties.Languages.waitButtonText;
                    secondaryActionButton.Text = Properties.Languages.lapButtonText;
                    mainTimerText.ForeColor = Properties.Settings.Default.preparationTimeColor;
                    break;
                case StopWatchMode.Delayed:
                    if (isDelayLapAllowed) secondaryActionButton.Enabled = true;
                    mainActionButton.Text = Properties.Languages.waitButtonText;
                    secondaryActionButton.Text = Properties.Languages.lapButtonText;
                    if (!Properties.Settings.Default.isLappingEnabled || Properties.Settings.Default.lappingCount == 0) secondaryActionButton.Enabled = false;
                    mainTimerText.ForeColor = Properties.Settings.Default.delayTimeColor;
                    break;
                case StopWatchMode.Started:
                    mainActionButton.Enabled = true;
                    if (isStartLapAllowed) secondaryActionButton.Enabled = true;
                    else secondaryActionButton.Enabled = false;
                    mainActionButton.Text = Properties.Languages.stopButtonText;
                    secondaryActionButton.Text = Properties.Languages.lapButtonText;
                    if (!Properties.Settings.Default.isLappingEnabled  || (lapsControl.laps.Count >= Properties.Settings.Default.lappingCount && Properties.Settings.Default.lappingCount >= 0)) secondaryActionButton.Enabled = false;
                    mainTimerText.ForeColor = Properties.Settings.Default.startTimeColor;
                    break;
                case StopWatchMode.Paused:
                    secondaryActionButton.Enabled = true;
                    mainActionButton.Text = Properties.Languages.startButtonText;
                    secondaryActionButton.Text = Properties.Languages.resetButtonText;
                    mainTimerText.ForeColor = Properties.Settings.Default.pauseTimeColor;
                    break;
                default:
                    break;
            }
        }
        
        private void ToggleOptionsMenuSize(Size size)
        {
            this.Size = size;
        }

        private void AddDelayLap()
        {
            lapsControl.AddLap(true, delayTime + preparedTime - stopWatch.Elapsed);
        }

        private void AddStartLap()
        {
            switch (displayType)
            {
                case LapDisplayType.TIME_PER_LAPS:
                    lapsControl.AddLap(false, stopWatch.Elapsed - lastLap);
                    lastLap = stopWatch.Elapsed;
                    break;
                case LapDisplayType.REAL_TIME:
                    lapsControl.AddLap(false, stopWatch.Elapsed - delayTime - preparedTime);
                    break;
                default:
                    break;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            switch (currentMode)
            {
                case StopWatchMode.Options:
                    stopWatch.Reset();
                    timer.Enabled = false;
                    break;
                case StopWatchMode.Default:
                    stopWatch.Reset();
                    timer.Enabled = false;
                    break;
                case StopWatchMode.Paused:
                    break;
                default:
                    if (stopWatch.Elapsed > (delayTime + preparedTime))
                    {
                        if (currentMode != StopWatchMode.Started)
                        {
                            currentMode = StopWatchMode.Started;
                            ChangeModeUI(currentMode);
                        }
                        DisplayTime(stopWatch.Elapsed - delayTime - preparedTime);
                    }
                    else if (stopWatch.Elapsed > preparedTime)
                    {
                        if (currentMode != StopWatchMode.Delayed)
                        {
                            currentMode = StopWatchMode.Delayed;
                            ChangeModeUI(currentMode);
                        }

                        if (isDelayTimeShows)
                        {
                            // Needs positive time, since ChangeModeUI() already toggles negative mode
                            DisplayTime(delayTime + preparedTime - stopWatch.Elapsed);
                        }
                    }
                    else if (currentMode != StopWatchMode.Prepared)
                    {
                        currentMode = StopWatchMode.Prepared;
                        ChangeModeUI(currentMode);
                    }
                    break;
            }
        }

        private void mainActionButton_Click(object sender, EventArgs e)
        {
            switch (currentMode)
            {
                case StopWatchMode.Options:
                    MessageBox.Show(Properties.Languages.warningNoStartTimer, Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case StopWatchMode.Default:
                    bool isLapCounted = Properties.Settings.Default.isLappingEnabled;     
                    if (isLapCounted && Properties.Settings.Default.lappingCount == 0)
                    {
                        bool isInfoAccepted = MessageBox.Show(Properties.Languages.infoNoLapRecord, Name, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes;
                        if (!isInfoAccepted) return;
                    }
                    currentMode = StopWatchMode.Prepared;
                    stopWatch.Reset();
                    delayTime = TimeSpan.FromSeconds(GetRandomNumber(Properties.Settings.Default.delayTimeStart, Properties.Settings.Default.delayTimeStop));
                    lastLap = delayTime + preparedTime;
                    isDelayTimeShows = Properties.Settings.Default.isDelayTimeShows;
                    isDelayLapAllowed = new[] { LapAllowances.DELAYS_ONLY, LapAllowances.ALL_DURATIONS }.Contains(Properties.Settings.Default.lapsAllowances);
                    isStartLapAllowed = new[] { LapAllowances.AFTER_DELAYS, LapAllowances.ALL_DURATIONS }.Contains(Properties.Settings.Default.lapsAllowances);
                    displayType = Properties.Settings.Default.lapsDisplayType;
                    ChangeModeUI(currentMode);
                    timer.Enabled = true;
                    stopWatch.Start();
                    break;
                case StopWatchMode.Prepared:
                    break;
                case StopWatchMode.Delayed:
                    break;
                case StopWatchMode.Started:
                    stopWatch.Stop();
                    currentMode = StopWatchMode.Paused;
                    timer_Tick(this, null);
                    timer.Enabled = false;
                    ChangeModeUI(currentMode);
                    break;
                case StopWatchMode.Paused:
                    currentMode = StopWatchMode.Started;
                    ChangeModeUI(currentMode);
                    timer.Enabled = true;
                    stopWatch.Start();
                    break;
                default:
                    break;
            }
        }

        private void secondaryActionButton_Click(object sender, EventArgs e)
        {
            switch (currentMode)
            {
                case StopWatchMode.Options:
                    timer.Interval = Properties.Settings.Default.updateThreshold;
                    preparedTime = TimeSpan.FromSeconds(Properties.Settings.Default.preparationTime);
                    currentMode = StopWatchMode.Default;
                    ChangeModeUI(currentMode);
                    ToggleOptionsMenuSize(defaultFormSize);
                    break;
                case StopWatchMode.Default:
                    // Options button
                    currentMode = StopWatchMode.Options;
                    ChangeModeUI(currentMode);
                    ToggleOptionsMenuSize(expandedFormSize);
                    currentMode = StopWatchMode.Options;
                    break;
                case StopWatchMode.Prepared:
                    MessageBox.Show(Properties.Languages.infoWaitForSignal, Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case StopWatchMode.Delayed:
                    settingsControl.Visible = false;
                    lapsControl.Visible = true;
                    this.Size = expandedFormSize;
                    AddDelayLap();
                    if (lapsControl.laps.Count >= Properties.Settings.Default.lappingCount && Properties.Settings.Default.lappingCount >= 0) secondaryActionButton.Enabled = false;
                    break;
                case StopWatchMode.Started:
                    settingsControl.Visible = false;
                    lapsControl.Visible = true;
                    this.Size = expandedFormSize;
                    AddStartLap();
                    if (lapsControl.laps.Count >= Properties.Settings.Default.lappingCount && Properties.Settings.Default.lappingCount >= 0) secondaryActionButton.Enabled = false;
                    break;
                case StopWatchMode.Paused:
                    currentMode = StopWatchMode.Default;
                    preparedTime = TimeSpan.FromSeconds(Properties.Settings.Default.preparationTime);
                    lapsControl.ResetLap();
                    this.Size = defaultFormSize;
                    lapsControl.Visible = false;
                    settingsControl.Visible = true;
                    DisplayTime(TimeSpan.Zero);
                    ChangeModeUI(currentMode);
                    break;
                default:
                    break;
            }
        }

        private void mainTimerText_Enter(object sender, EventArgs e)
        {
            elementsPanel.Focus();
        }

        private void tickTimerText_Enter(object sender, EventArgs e)
        {
            elementsPanel.Focus();
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
    }
}
