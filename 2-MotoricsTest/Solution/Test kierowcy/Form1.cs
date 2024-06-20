using System;
using System.Media;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tests[0] = new Form2(this);
            tests[1] = new Form3(this);
            tests[2] = new Form4(this);
            tests[3] = new Form5(this);

            results = new double[testAmount, maxTests];
            currentTest = 0;
            while (currentTest < testAmount)
            {
                tests[currentTest].ShowDialog();
                currentTest++;
            }

            Form6 wykres = new Form6(results);
            wykres.ShowDialog();
        }

        public void AddResults(int resultNum, double result) => results[currentTest, resultNum] = (int)result;
    }
}
