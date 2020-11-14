using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
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
        public static int stopWatchFrequency = 0;

        public bool isStart = false;
        public bool isOptionsMenuOpened = false;
        public StopWatchMode currentMode = StopWatchMode.Default;
        public TimeSpan preparedTime = new TimeSpan();
        public TimeSpan delayTime = new TimeSpan();
        public Stopwatch stopWatch = new Stopwatch();
        public ResourceManager localizationManager = new ResourceManager(typeof(Properties.Resources));

        private long tempDelayTicks = 0;
        private long trueElapsedTicks = 0;
        private long lapsLastTicks = 0;
        private Size defaultFormSize = new Size(542, 226);
        private Size expandedFormSize = new Size(542, 529);

        public MainForm()
        {
            InitializeComponent();
            preparedTime = TimeSpan.FromSeconds(Properties.Settings.Default.preparationTime);
            delayTime = TimeSpan.FromSeconds(Properties.Settings.Default.delayTimeStop - Properties.Settings.Default.delayTimeStart);
            LocalizeUI();
            ChangeModeUI(StopWatchMode.Default);
            ToggleOptionsMenuSize(defaultFormSize);
        }

        private double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        private void LocalizeUI()
        {
        }

        public void ChangeModeUI(StopWatchMode mode)
        {
            switch (mode)
            {
                case StopWatchMode.Options:
                    mainActionButton.Enabled = false;
                    secondaryActionButton.Text = "Save";
                    break;
                case StopWatchMode.Default:
                    mainActionButton.Enabled = true;
                    mainActionButton.Text = "Start";
                    secondaryActionButton.Text = "Options";
                    break;
                case StopWatchMode.Prepared:
                    mainActionButton.Enabled = false;
                    secondaryActionButton.Enabled = false;
                    mainActionButton.Text = "WAIT";
                    secondaryActionButton.Text = "Lap";
                    break;
                case StopWatchMode.Delayed:
                    secondaryActionButton.Enabled = true;
                    mainActionButton.Text = "WAIT";
                    secondaryActionButton.Text = "Lap";
                    if (!Properties.Settings.Default.isLappingEnabled || Properties.Settings.Default.lappingCount == 0) secondaryActionButton.Enabled = false;
                    break;
                case StopWatchMode.Started:
                    mainActionButton.Enabled = true;
                    mainActionButton.Text = "Stop";
                    secondaryActionButton.Text = "Lap";
                    if (!Properties.Settings.Default.isLappingEnabled) secondaryActionButton.Enabled = false;
                    else if (Properties.Settings.Default.lappingCount == 0) secondaryActionButton.Enabled = true;
                    break;
                case StopWatchMode.Paused:
                    secondaryActionButton.Enabled = true;
                    mainActionButton.Text = "Start";
                    secondaryActionButton.Text = "Reset";
                    break;
                default:
                    break;
            }
        }
        
        private void ToggleOptionsMenuSize(Size size)
        {
            this.Size = size;
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
                case StopWatchMode.Prepared:
                    if (stopWatch.Elapsed.Ticks >= preparedTime.Ticks)
                    {
                        stopWatch.Stop();
                        tempDelayTicks = stopWatch.Elapsed.Ticks - preparedTime.Ticks + delayTime.Ticks;
                        stopWatch.Reset();
                        currentMode = StopWatchMode.Delayed;
                        ChangeModeUI(currentMode);
                        stopWatch.Start();
                    }
                    break;
                case StopWatchMode.Delayed:
                    if (stopWatch.Elapsed.Ticks >= tempDelayTicks)
                    {
                        stopWatch.Stop();
                        trueElapsedTicks = stopWatch.Elapsed.Ticks - tempDelayTicks;
                        stopWatch.Reset();
                        currentMode = StopWatchMode.Started;
                        ChangeModeUI(currentMode);
                        stopWatch.Start();
                    }
                    DisplayTime(TimeSpan.FromTicks(tempDelayTicks - stopWatch.Elapsed.Ticks));
                    break;
                case StopWatchMode.Started:
                    DisplayTime(TimeSpan.FromTicks(trueElapsedTicks + stopWatch.Elapsed.Ticks));
                    break;
                case StopWatchMode.Paused:
                    break;
                default:
                    break;
            }
        }

        private void DisplayTime(TimeSpan time)
        {
            string delayDisplay = (currentMode == StopWatchMode.Delayed) ? "-" : "";
            string hoursDisplay = time.Hours < 10 ? "0" + time.Hours : time.Hours.ToString();
            string minutesDisplay = time.Minutes < 10 ? "0" + time.Minutes : time.Minutes.ToString();
            string secondsDisplay = time.Seconds < 10 ? "0" + time.Seconds : time.Seconds.ToString();
            mainTimerText.Text = delayDisplay + hoursDisplay + ":" + minutesDisplay + ":" + secondsDisplay;
            tickTimerText.Text = Math.Round(time.TotalSeconds - Math.Truncate((double)time.TotalSeconds), Properties.Settings.Default.timePrecision) + " units";
        }

        private void mainActionButton_Click(object sender, EventArgs e)
        {
            switch (currentMode)
            {
                case StopWatchMode.Options:
                    MessageBox.Show("Can't start timer when the options menu is opened!", Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case StopWatchMode.Default:
                    currentMode = StopWatchMode.Prepared;
                    stopWatch.Reset();
                    delayTime = TimeSpan.FromSeconds(GetRandomNumber(Properties.Settings.Default.delayTimeStart, Properties.Settings.Default.delayTimeStop));
                    ChangeModeUI(currentMode);
                    timer.Enabled = true;
                    stopWatch.Start();
                    break;
                case StopWatchMode.Prepared:
                    MessageBox.Show("Please wait for the signal...", Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case StopWatchMode.Delayed:
                    MessageBox.Show("Please wait for the signal...", Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    stopWatch.Start();
                    timer.Enabled = true;
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
                    if (!settingsControl.SaveOptions()) return;
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
                    MessageBox.Show("Please wait for the signal...", Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case StopWatchMode.Delayed:
                    settingsControl.Visible = false;
                    lapsControl.Visible = true;
                    Size = expandedFormSize;
                    lapsControl.AddLap(true, TimeSpan.FromTicks(Math.Abs(stopWatch.Elapsed.Ticks - tempDelayTicks)));
                    if (lapsControl.laps.Count >= Properties.Settings.Default.lappingCount) secondaryActionButton.Enabled = false;
                    break;
                case StopWatchMode.Started:
                    settingsControl.Visible = false;
                    lapsControl.Visible = true;
                    Size = expandedFormSize;
                    lapsControl.AddLap(false, TimeSpan.FromTicks(trueElapsedTicks + stopWatch.Elapsed.Ticks - lapsLastTicks));
                    lapsLastTicks = trueElapsedTicks + stopWatch.Elapsed.Ticks;
                    if (lapsControl.laps.Count >= Properties.Settings.Default.lappingCount) secondaryActionButton.Enabled = false;
                    break;
                case StopWatchMode.Paused:
                    currentMode = StopWatchMode.Default;
                    tempDelayTicks = 0;
                    trueElapsedTicks = 0;
                    preparedTime = TimeSpan.FromSeconds(Properties.Settings.Default.preparationTime);
                    lapsControl.ResetLap();
                    Size = defaultFormSize;
                    lapsControl.Visible = false;
                    settingsControl.Visible = true;
                    DisplayTime(TimeSpan.Zero);
                    tickTimerText.Text = "Ready to start.";
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
    }
}
