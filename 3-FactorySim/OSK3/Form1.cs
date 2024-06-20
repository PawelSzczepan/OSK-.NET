using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace OSK3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            wakeUp.Enabled = true;
            wakeUp.Interval = r.Next(minWakeUpTime, maxWakeUpTime);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Logout();

            label1.Text = GetProcessorTemp().ToString();
        }

        private double GetProcessorTemp()
        {
            Double temperature = 0;

            ManagementObjectSearcher searcher = new ManagementObjectSearcher
                (@"root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");

            try
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    temperature = Convert.ToDouble(obj["CurrentTemperature"].ToString());
                    // Convert the value to celsius degrees
                    temperature = (temperature - 2732) / 10.0;
                }
            }
            catch
            {

            }


            return temperature;
        }

        private void Logout()
        {
            wakeUp.Enabled = false;
            mainTime.Enabled = false;

            LoginForm login = new LoginForm(this);
            DialogResult result = login.ShowDialog();

            if (result == DialogResult.Abort)
                this.Close();

            wakeUp.Enabled = true;
            mainTime.Enabled = true;
        }


        private void wakeUp_Tick(object sender, EventArgs e) => WakeUp();


        private void ąłToolStripMenuItem_Click(object sender, EventArgs e) => WakeUp();

        private void WakeUp()
        {
            wakeUp.Enabled = false;
            mainTime.Enabled = false;

            WakeUpForm wakeForm = new WakeUpForm(this);
            DialogResult result = wakeForm.ShowDialog();

            if (result == DialogResult.Abort)
                Logout();

            wakeUp.Interval = r.Next(minWakeUpTime, maxWakeUpTime);

            wakeUp.Enabled = true;
            mainTime.Enabled = true;
        }

        private void mainTime_Tick(object sender, EventArgs e)
        {         
            int newValue = progressBar1.Value + (int)numericUpDown1.Value * productionRate;
            if (newValue > 100)
                newValue = 0;

            progressBar1.Value = newValue;

            if (r.NextDouble() <= breakChance)
                Break();

            double CPUtemp = GetProcessorTemp();

            if (numericUpDown1.Value <= 5)
                temperature -= r.NextDouble() * tempChange;
            else
            {
                temperature += r.NextDouble() * tempChange;
                if (temperature + CPUtemp > 40)
                {
                    numericUpDown1.Value = 3;
                    MessageBox.Show(this, "Temperatura silnika przekroczyła 40 stopni! Redukcja prędkości pracy do 3.",
                        "Za ciepło", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            temperature = Math.Max(temperature, 0);
            label1.Text = ((int)(CPUtemp + temperature)).ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 0)
                numericUpDown1.Value = 0;
            else if (numericUpDown1.Value > 10)
                numericUpDown1.Value = 10;
        }

        private void Break()
        {
            wakeUp.Enabled = false;
            mainTime.Enabled = false;

            MessageBox.Show(this, "Urządzenie się zepsuło! Wciśnij OK po naprawieniu usterki.",
                "Usterka", MessageBoxButtons.OK, MessageBoxIcon.Error);

            wakeUp.Enabled = true;
            mainTime.Enabled = true;
        }

        private void zepsujToolStripMenuItem_Click(object sender, EventArgs e) => Break();
    }
}
