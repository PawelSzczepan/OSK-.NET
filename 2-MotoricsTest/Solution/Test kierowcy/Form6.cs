using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Test_kierowcy
{
    public partial class Form6 : Form
    {
        public Form6(double[,] data)
        {
            InitializeComponent();

            x = new double[Form1.maxTests];
            form2 = new double[Form1.maxTests];
            form3 = new double[Form1.maxTests];
            form4 = new double[Form1.maxTests];
            form5 = new double[Form1.maxTests];
            average = new double[4];
            
            for (int i = 0; i < Form1.maxTests; i++)
            {
                x[i] = i + 1;
                form2[i] = data[0, i];
                form3[i] = data[1, i];
                form4[i] = data[2, i];
                form5[i] = data[3, i];

                average[0] += data[0, i];
                average[1] += data[1, i];
                average[2] += data[2, i];
                average[3] += data[3, i];
            }

            for (int i = 0; i < 4; i++)
            {
                average[i] /= Form1.maxTests;
                average[i] = (int)average[i];
            }
            
            string[] avTitles = new string[4];
            avTitles[0] = "Zmiana koloru";
            avTitles[1] = "Zmiana koloru złożone";
            avTitles[2] = "Dźwięki";
            avTitles[3] = "Ruchomy obiekt";


            chart1.Series.ElementAt(0).Points.DataBindXY(x, form2);
            chart1.Series.ElementAt(1).Points.DataBindXY(x, form3);
            chart1.Series.ElementAt(2).Points.DataBindXY(x, form4);
            chart1.Series.ElementAt(3).Points.DataBindXY(x, form5);
            chart1.Series.ElementAt(4).Points.DataBindXY(avTitles, average);
        }
    }
}
