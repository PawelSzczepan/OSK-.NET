using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.xp = 0;
            this.label1.Text = "Kliknąłeś przyciks " + this.xp.ToString() + " razy";

            this.oknoRodzic = null;
        }

        public Form2(int xi)
        {
            InitializeComponent();

            this.xp = xi;
            this.label1.Text = "Kliknąłeś przyciks " + this.xp.ToString() + " razy";

            this.oknoRodzic = null;
        }

        public Form2(int xi, Form1 rodzic)
        {
            InitializeComponent();

            this.xp = xi;
            this.label1.Text = "Kliknąłeś przyciks " + this.xp.ToString() + " razy";

            this.oknoRodzic = rodzic;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.xst++;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.oknoRodzic != null)
            {
                this.oknoRodzic.label2.Text = "Nowy tekst " + this.xp.ToString();
            }
        }
    }
}
