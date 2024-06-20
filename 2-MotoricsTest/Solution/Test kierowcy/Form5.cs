using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_kierowcy
{
    public partial class Form5 : Form
    {
        public Form5(Form1 form)
        {
            InitializeComponent();
            parent = form;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            MessageBox.Show("W tym teście kliknij ruchome zielone pole lewym przyciskiem myszy.");


            MessageBox.Show("Wykonaj teraz " + learningTests.ToString() + " test(y) próbne.");

            position = new double[2];
            r = new Random();
            timer2.Interval = frameTime;
            Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            canClick = true;
            start = DateTime.Now;
            button1.Visible = true;
            button1.Enabled = true;
            position[0] = r.NextDouble() * 700;
            position[1] = r.NextDouble() * 350;
            direction = r.NextDouble() * 2 * Math.PI;
            button1.Location = new Point((int)(position[0]), (int)(position[1]));
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left))
            {
                Results();
                Reset();
            }
        }

        private void Results()
        {
            double result = (DateTime.Now - start).TotalMilliseconds;
            MessageBox.Show("Czas reakcji " + result.ToString() + "ms");


            if (testsPassed == learningTests - 1)
                MessageBox.Show("Teraz rozpocznie się faktyczny test. Wykonaj go "
                    + Form1.maxTests.ToString() + " razy.");
            else if (testsPassed >= learningTests)
                parent.AddResults(testsPassed - learningTests, result);

            if (testsPassed >= Form1.maxTests + learningTests - 1)
                this.Close();

            testsPassed++;
        }

        private void Reset()
        {
            timer1.Interval = r.Next(Form1.wait[0], Form1.wait[1]);
            timer1.Enabled = true;
            canClick = false;

            position[0] = 0;
            position[1] = 0;
            button1.Location = new Point((int)(position[0]), (int)(position[1]));
            button1.Visible = false;
            button1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(canClick)
            {                  
                if (position[1] < 0)
                {
                    position[1] = 0;
                    direction = r.NextDouble() * -Math.PI - Math.PI;
                }
                else if (position[0] < 0)
                {
                    position[0] = 0;
                    direction = r.NextDouble() * Math.PI - Math.PI / 2;
                }
                else if (position[1] > 325)
                {
                    position[1] = 325;
                    direction = r.NextDouble() * -Math.PI;
                }
                else if (position[0] > 700)
                {
                    position[0] = 700;
                    direction = r.NextDouble() * Math.PI + Math.PI / 2;
                }

                position[0] += Math.Cos(direction) * speed * frameTime / 1000;
                position[1] += Math.Sin(direction) * speed * frameTime / 1000;
                button1.Location = new Point((int)(position[0]), (int)(position[1]));
            }
        }
    }
}
