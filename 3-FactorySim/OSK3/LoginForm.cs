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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            logined = false;
        }

        public LoginForm(Form1 par)
        {
            InitializeComponent();

            parent = par;
            logined = false;
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            input = textBox1.Text;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (input == password)
                {
                    logined = true;
                    this.Close();
                }
                else
                {
                    label1.Text = "Nieprawidłowe hasło";
                    label1.ForeColor = Color.Red;
                }
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!logined)
                this.DialogResult = DialogResult.Abort;
        }
    }
}
