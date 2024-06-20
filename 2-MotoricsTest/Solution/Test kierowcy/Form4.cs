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
    public partial class Form4 : Form
    {
        public Form4(Form1 form)
        {
            InitializeComponent();
            parent = form;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            sound1.Load();

            MessageBox.Show("W tym teście kliknij zielone lewym przycikiem myszy pole, " +
                "gdy usłyszysz dźwięk. Teraz usłyszysz testowany dźwięk");

            Console.WriteLine(sound1.IsLoadCompleted.ToString());
            sound1.Play();

            MessageBox.Show("Wykonaj teraz " + learningTests.ToString() + " testy próbne.");

            r = new Random();
            Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            canClick = true;
            start = DateTime.Now;
            sound1.Play();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left))
            {
                if (!canClick)
                    MessageBox.Show("Za szybko! Test zostanie powtórzony.");
                else
                    Results();
            }

            Reset();
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
        }
    }
}
