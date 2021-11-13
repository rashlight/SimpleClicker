using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClicker
{
    public partial class ExtendForm : Form
    {
        public ExtendForm()
        {
            InitializeComponent();
        }

        private void TimeExtendForm_Load(object sender, EventArgs e)
        {
            ChangeTheme(Properties.Settings.Default.darkModeType);
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

            settingsControl.ChangeTheme(metroStyleManager.Theme);
            lapsControl.ChangeTheme(metroStyleManager.Theme);
        }

        private void TimeExtendForm_MouseEnter(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
