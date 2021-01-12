using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace SimpleClicker
{
    public partial class AboutForm : MetroForm
    {
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        public AboutForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.isAlwaysOnTop)
                SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);

            ChangeUIScaling();
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
        }

        public void ChangeBorder(MetroColorStyle color)
        {
            metroStyleManager.Style = color;
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            versionText.Text = "ver. " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            string dpiWidth = "Unknown";
            string dpiHeight = "Unknown";

            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT PixelsPerXLogicalInch, PixelsPerYLogicalInch FROM Win32_DesktopMonitor");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    dpiWidth = queryObj["PixelsPerXLogicalInch"].ToString();
                    dpiHeight = queryObj["PixelsPerYLogicalInch"].ToString();
                }
            }
            catch
            {
            }

            string supportData =
                "SimpleClicker has detected the following information:\n" +
                "  - OSVersion: " + Environment.OSVersion + "\n" +
                "  - Is64BitOS: " + Environment.Is64BitOperatingSystem + "\n" +
                "  - Is64BitBinary: " + Environment.Is64BitProcess + "\n" +
                "  - Resolution: " + Screen.PrimaryScreen.Bounds.Size.Width + "x" + Screen.PrimaryScreen.Bounds.Size.Height + "\n" +
                "  - DPI: " + dpiWidth + "x" + dpiHeight + "\n" +
                "  - StopwatchFrequency: " + System.Diagnostics.Stopwatch.Frequency + "\n" +
                "  - IsStopwatchHighResolution: " + System.Diagnostics.Stopwatch.IsHighResolution + "\n" +
                "  - IsAdministator: " + System.Security.Principal.WindowsIdentity.GetCurrent().Owner.IsWellKnown(System.Security.Principal.WellKnownSidType.BuiltinAdministratorsSid) + "\n" +
                "  - ProcessorCount: " + Environment.ProcessorCount + "\n" +
                "  - SystemPageSize: " + Environment.SystemPageSize + "\n" +
                "  - PriorityIndex: " + System.Threading.Thread.CurrentThread.Priority + "\n" +
                "  - Language: " + System.Threading.Thread.CurrentThread.CurrentCulture + "\n";

            systemInfoTextBox.Text = supportData;

            ChangeTheme(Properties.Settings.Default.darkModeType);
            ChangeBorder(Properties.Settings.Default.borderColorType);

            this.Text = Properties.Languages.supportText;
            infoTab.Text = Properties.Languages.infoTabText;
            attributionsTab.Text = Properties.Languages.attributionTabText;
            licenseTab.Text = Properties.Languages.licenseTabText;
            systemInfoTab.Text = Properties.Languages.systemInfoTabText;

            bool isDefaultInDarkMode = DateTime.Now.Hour < Properties.Settings.Default.sunriseTime || DateTime.Now.Hour >= Properties.Settings.Default.sunsetTime;
            if (Properties.Settings.Default.darkModeType == MetroThemeStyle.Dark || (Properties.Settings.Default.darkModeType == MetroThemeStyle.Default && isDefaultInDarkMode))
            {
                iconPictureBox.BackgroundImage = Properties.Resources.brown_simpleclicker;
            }
        }

        private void UnfocusComponents_Enter(object sender, EventArgs e)
        {
            iconPictureBox.Focus();
        }

        private void aboutTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}
