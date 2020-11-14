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
    public partial class LapsControl : UserControl
    {
        public List<Tuple<bool, TimeSpan>> laps = new List<Tuple<bool, TimeSpan>>();

        public LapsControl()
        {
            InitializeComponent();
        }

        public void DisplayLaps()
        {
            lapsListBox.Items.Clear();
            for (int i = 0; i < laps.Count; i++)
            {
                string delayDisplay = laps[i].Item1 == true ? "-" : "";
                string hoursDisplay = laps[i].Item2.Hours < 10 ? "0" + laps[i].Item2.Hours : laps[i].Item2.Hours.ToString();
                string minutesDisplay = laps[i].Item2.Minutes < 10 ? "0" + laps[i].Item2.Minutes : laps[i].Item2.Minutes.ToString();
                string secondsDisplay = laps[i].Item2.Seconds < 10 ? "0" + laps[i].Item2.Seconds : laps[i].Item2.Seconds.ToString();
                lapsListBox.Items.Add(
                    "Lap " + (lapsListBox.Items.Count + 1) + ": " +
                    delayDisplay + hoursDisplay + ":" + minutesDisplay + ":" + secondsDisplay + "." +
                    (Math.Round(laps[i].Item2.TotalSeconds - Math.Truncate((double)laps[i].Item2.TotalSeconds), Properties.Settings.Default.timePrecision) + " units").Substring(2)
                );
            }
        }

        public void AddLap(bool isDelayed, TimeSpan time)
        {
            laps.Add(new Tuple<bool, TimeSpan>(isDelayed, time));

            if (Properties.Settings.Default.lappingCount > 0)
            {
                // Ascending
                if (laps.Count > Properties.Settings.Default.lappingCount) return;

                /* -- Decending, TODO
                bool isModified = false;
                while (laps.Count >= Properties.Settings.Default.lappingCount)
                {
                    isModified = true;
                    laps.RemoveAt(0);
                }
                if (isModified) DisplayLaps();
                */
            }

            string delayDisplay = (isDelayed) ? "-" : "";
            string hoursDisplay = time.Hours < 10 ? "0" + time.Hours : time.Hours.ToString();
            string minutesDisplay = time.Minutes < 10 ? "0" + time.Minutes : time.Minutes.ToString();
            string secondsDisplay = time.Seconds < 10 ? "0" + time.Seconds : time.Seconds.ToString();
            lapsListBox.Items.Add(
                "Lap " + (lapsListBox.Items.Count + 1) + ": " +
                delayDisplay + hoursDisplay + ":" + minutesDisplay + ":" + secondsDisplay + "." +
                (Math.Round(time.TotalSeconds - Math.Truncate((double)time.TotalSeconds), Properties.Settings.Default.timePrecision) + " units").Substring(2)
            );
            lapsListBox.TopIndex = lapsListBox.Items.Count - 1;
        }

        public void RemoveLap(int index)
        {
            laps.RemoveAt(index);
        }

        public void ResetLap()
        {
            laps.Clear();
            lapsListBox.Items.Clear();
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
