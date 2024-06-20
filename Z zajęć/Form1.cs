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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Tu nadaj wartości początkowe zmiennych!
            x = 1;
            this.col1 = Color.LightGray;
            this.col2 = Color.LightGray;
            this.col3 = Color.LightGray;
            tempCol = Color.LightGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // this.pictureBox2.Load("C:\\Users\\Student\\Pictures\\scoobydoo.png");
            this.pictureBox2.Load("C:/Users/Student/Pictures/scoobydoo.png");
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            try 
            {
                this.pictureBox1.Load(this.openFileDialog1.FileName);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch 
            {
                MessageBox.Show("Wystąpił nieznany błąd");
            }

            this.label1.Text = this.openFileDialog1.FileName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x == 1)
            {
                x = 2;
                this.pictureBox2.Load("C:/Users/Student/Pictures/scoobydoo.png");
            }
            else
            {
                x = 1;
                this.pictureBox2.Load("C:/Users/Student/Pictures/1.png");
            }

            label1.Text = "Wartość zmiennej statycznej xst = " + xst.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.okno = new Form2(this.score, this);
            this.okno.Show();
            //this.okno.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {                                    
            this.score++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void przycisk_click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;
            if (przycisk.Text == "p1")
            {
                this.label2.Text = "nacisnieto przycisk 1";
                this.BackColor = Color.AliceBlue;
                
            }
            else if (przycisk.Text == "p2")
            {
                this.label2.Text = "nacisnieto przycisk 2";
                this.BackColor = Color.Bisque;
            }

            else if (przycisk.Text == "p3")
            {
                this.label2.Text = "nacisnieto przycisk 3";
                this.BackColor = Color.Aquamarine;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Przycisk_klik(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;
            this.label3.Text = "Wciśnięto przycisk " + przycisk.Text;

            switch (przycisk.Text)
            {
                case "1":
                    this.but1.BackColor = Color.Red;
                    this.but2.BackColor = Color.LightGray;
                    this.but3.BackColor = Color.LightGray;
                    this.col1 = Color.Red;
                    this.col2 = Color.LightGray;
                    this.col3 = Color.LightGray;
                    break;

                case "2":
                    this.but1.BackColor = Color.LightGray;
                    this.but2.BackColor = Color.Red;
                    this.but3.BackColor = Color.LightGray;
                    this.col1 = Color.LightGray;
                    this.col2 = Color.Red;
                    this.col3 = Color.LightGray;
                    break;

                case "3":
                    this.but1.BackColor = Color.LightGray;
                    this.but2.BackColor = Color.LightGray;
                    this.but3.BackColor = Color.Red;
                    this.col1 = Color.LightGray;
                    this.col2 = Color.LightGray;
                    this.col3 = Color.Red;
                    break;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                    this.but1.PerformClick();
                    break;

                case '2':
                    this.but2.PerformClick();
                    break;

                case '3':
                    this.but3.PerformClick();
                    break;
            }
        }

        private void przycisk_MouseHover(object sender, EventArgs e) 
        {
            Button przycisk = (Button)sender;

            switch (przycisk.Text)
            {
                case "1":
                    break;

                case "2":

                    break;

                case "3":

                    break;
            }

            tempCol = przycisk.BackColor;

            przycisk.BackColor = Color.Blue;
        }

        private void przycisk_MouseLeave(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;

            switch (przycisk.Text)
            {
                case "1":

                    break;

                case "2":

                    break;

                case "3":

                    break;
            }

            przycisk.BackColor = tempCol;
        }

        private void button5_Click_1(object sender, EventArgs e) 
        {
            int x = 5;
            int y = 0;
            try 
            {
                int z = x / y;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
