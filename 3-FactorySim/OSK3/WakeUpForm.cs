using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSK3
{
    public partial class WakeUpForm : Form
    {
        public WakeUpForm()
        {
            InitializeComponent();
        }

        public WakeUpForm(Form1 par)
        {
            InitializeComponent();
            parent = par;
        }

        private void WakeUpForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                correctKey = true;
                this.Close();
            }
        }

        private void WakeUpForm_Load(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play();
            this.CenterToScreen();
            timer1.Enabled = true;
            timer1.Interval = wait;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WakeUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!correctKey)
                this.DialogResult = DialogResult.Abort;
        }
    }
}
