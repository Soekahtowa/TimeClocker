using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace TimeClocker
{
    public partial class formTimeClocker : Form
    {
        private static string filePath = "Hours Worked.txt";
        private List<DateTime> clocks = new List<DateTime>();
        private List<string> outputLines = new List<String>();
        private TimeSpan hoursWorked = TimeSpan.Zero;
        private string colorOn = "YellowGreen";
        private string colorOff = "Crimson";
        public formTimeClocker()
        {
            InitializeComponent();
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");

            timerUpdate.Interval = 1000; //1second
            timerUpdate.Tick += timerUpdate_Tick;
            timerUpdate.Start();

            //Check if file exists, creates in if not
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            //Removes empty lines
            while (outputLines.Count > 0 && string.IsNullOrWhiteSpace(outputLines[outputLines.Count - 1]))
            {
                outputLines.RemoveAt(outputLines.Count - 1);
            }

            //Reads in what is in the text file, then converts from string to DateTime to add into clocks list.
            string[] inputLines = File.ReadAllLines(filePath);
            foreach (string line in inputLines)
            {
                if (DateTime.TryParse(line, out DateTime dt))
                {
                    clocks.Add(dt);
                    if (CheckEven(clocks.Count))
                    {
                        CalcHoursWorked(clocks.Count);
                        MakinMoney(false);
                    }
                    else
                    {
                        MakinMoney(true);
                    }
                }
            }
        }

        //Helper Methods
        private bool CheckEven(int integer)
        {
            if (integer % 2 == 0)
            {  return true; }
            else return false;
        }
        private TimeSpan CalcHoursWorked(int length)
        {
            hoursWorked += clocks[length - 1] - clocks[length - 2];

            if (hoursWorked.TotalHours > 80)
            {
                lblOt.Visible = true;
                double overtimeHours = hoursWorked.TotalHours - 80;
                lblOt.Text = "Overtime: " + overtimeHours.ToString("0.00");
            }
            return hoursWorked;
        }
        private void MakinMoney(bool weAre)
        {
            if (weAre)
            {
                btnMoney.BackColor = Color.FromName(colorOn);
                PlaySound("TimeClocker.peonWorkWork.wav");
            }
            else
            {
                btnMoney.BackColor = Color.FromName(colorOff);
                PlaySound("TimeClocker.peasantJobsDone.wav");
            }
        }
        private void PlaySound(string soundName)
        {
            var assembly = Assembly.GetExecutingAssembly();

            using (Stream stream = assembly.GetManifestResourceStream(soundName))
            {
                if (stream != null)
                {
                    new SoundPlayer(stream).Play();
                }
            }
        }
        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
            lblHours.Text = "Hours: " + hoursWorked.TotalHours.ToString("0.00");
        }
        private void btnMoney_Click(object sender, EventArgs e)
        {
            try
            {
                string time = DateTime.Now.ToString();
                clocks.Add(DateTime.Now);
                if (CheckEven(clocks.Count))
                {
                    CalcHoursWorked(clocks.Count);
                    MakinMoney(false);
                }
                else { MakinMoney(true); }
                    System.IO.File.AppendAllText(filePath, time + "\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Error");
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(filePath, "");
            hoursWorked = TimeSpan.Zero;
            outputLines.Clear();
            clocks.Clear();
            MakinMoney(false);
            PlaySound("TimeClocker.pluh.wav");
            lblOt.Visible = false;
            lblOt.Text = "";
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (CheckEven(clocks.Count) && clocks.Count > 0)
            {
                outputLines.Clear();
                outputLines.Add(clocks[0].Date.ToString("MM/dd"));

                for (int i = 1; i < clocks.Count; i++)
                {
                    if (clocks[i].Date != clocks[i - 1].Date)
                    {
                        outputLines.Add(clocks[i].Date.ToString("\nMM/dd"));
                    }
                    if (i % 2 != 0)
                    {
                        outputLines.Add((clocks[i-1].ToString("hh:mm")) + " " + clocks[i].ToString("hh:mm"));
                    }
                }
                PlaySound("TimeClocker.peonWorkComplete.wav");
                System.IO.File.WriteAllLines(filePath, outputLines.ToArray());
            }
            else
            {
                MessageBox.Show("Please clock out first.");
            }
        }

    }
}
