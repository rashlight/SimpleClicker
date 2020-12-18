using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace SimpleClicker
{
    public partial class LapsControl : UserControl
    {
        public List<Tuple<bool, TimeSpan>> laps = new List<Tuple<bool, TimeSpan>>();
        public Random random = new Random();

        public LapsControl()
        {
            InitializeComponent();
        }

        public void SortLaps()
        {
            // Sorts items
            switch (Properties.Settings.Default.lapsSorting)
            {
                case LapSorting.FIRST_FOCUSED:
                    break;
                case LapSorting.LAST_FOCUSED:
                    break;
                case LapSorting.BEST_TO_WORST:
                    laps = laps.OrderBy(item => item.Item1).ThenBy(item => item.Item2.TotalSeconds).ToList();
                    break;
                case LapSorting.WORST_TO_BEST:
                    laps = laps.OrderByDescending(item => item.Item2.TotalSeconds).ToList();
                    break;
                case LapSorting.RANDOMIZE:
                    int randTime = laps.Count;
                    while (randTime > 1)
                    {
                        randTime--;
                        int randNum = random.Next(randTime + 1);
                        var value = laps[randNum];
                        laps[randNum] = laps[randTime];
                        laps[randTime] = value;
                    }
                    break;
                default:
                    break;
            }

            // Check items overflow
            if (Properties.Settings.Default.lappingCount > 0 && laps.Count > Properties.Settings.Default.lappingCount)
            {
                switch (Properties.Settings.Default.lapsSorting)
                {
                    case LapSorting.FIRST_FOCUSED:
                        laps.RemoveAt(laps.Count - 1);
                        break;
                    case LapSorting.LAST_FOCUSED:
                        laps.RemoveAt(0);
                        break;
                    case LapSorting.BEST_TO_WORST:
                        laps.RemoveAt(laps.Count - 1);
                        break;
                    case LapSorting.WORST_TO_BEST:
                        laps.RemoveAt(laps.Count - 1);
                        break;
                    case LapSorting.RANDOMIZE:
                        laps.RemoveAt(random.Next(0, laps.Count));
                        break;
                    default:
                        break;
                }
            }
        }

        public void DisplayLaps()
        {
            lapsListBox.BeginUpdate();
            lapsListBox.Items.Clear();
            for (int i = 0; i < laps.Count; i++)
            {
                string delayDisplay = laps[i].Item1 == true ? "-" : "";
                string hoursDisplay = laps[i].Item2.Hours < 10 ? "0" + laps[i].Item2.Hours : laps[i].Item2.Hours.ToString();
                string minutesDisplay = laps[i].Item2.Minutes < 10 ? "0" + laps[i].Item2.Minutes : laps[i].Item2.Minutes.ToString();
                string secondsDisplay = laps[i].Item2.Seconds < 10 ? "0" + laps[i].Item2.Seconds : laps[i].Item2.Seconds.ToString();
                string unitsDisplay = Math.Round(laps[i].Item2.TotalSeconds - Math.Truncate((double)laps[i].Item2.TotalSeconds), Properties.Settings.Default.timePrecision).ToString();
                lapsListBox.Items.Add(
                    Properties.Languages.lapIntervalText + " " + (lapsListBox.Items.Count + 1) + ": " +
                    delayDisplay + hoursDisplay + ":" + minutesDisplay + ":" + secondsDisplay +
                    ((unitsDisplay.Length > 2 ? ("." + unitsDisplay.ToString().Substring(2)) : "") + " " + Properties.Languages.timeUnitText)
                );
            }
            lapsListBox.EndUpdate();

            if (Properties.Settings.Default.lapsSorting == LapSorting.LAST_FOCUSED) lapsListBox.TopIndex = lapsListBox.Items.Count - 1;
        }

        public void AddLap(bool isDelayed, TimeSpan time)
        {
            laps.Add(new Tuple<bool, TimeSpan>(isDelayed, time));
            SortLaps();
            DisplayLaps();
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
    }
}
