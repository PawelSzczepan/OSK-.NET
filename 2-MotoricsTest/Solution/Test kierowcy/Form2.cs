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
    public partial class Form2 : Form
    {
        public Form2(Form1 form)
        {
            InitializeComponent();
            parent = form;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            MessageBox.Show("W tym teście kliknij kolorowe pole przycisk lewym przyciskiem myszy, gdy zmieni kolor na zielony. " +
                "Wykonaj teraz " + learningTests.ToString() + " testy próbne.");

            r = new Random();
            Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.BackColor = Color.Green;
            canClick = true;
            start = DateTime.Now;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!canClick)
            {
                MessageBox.Show("Za szybko! Test zostanie powtórzony.");
                Reset();
            }
            else
            {
                if (e.Button.HasFlag(MouseButtons.Left))
                    Results();
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
            Reset();
        }

        private void Reset()
        {
            timer1.Interval = r.Next(Form1.wait[0], Form1.wait[1]);
            timer1.Enabled = true;
            button1.BackColor = Color.Red;
            canClick = false;
        }
    }
}
