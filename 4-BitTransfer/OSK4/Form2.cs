using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSK4
{
    public partial class Form2 : Form
    {
        public Form2(Form1 parent)
        {
            InitializeComponent();

            target = parent;
            forbiddenWords = target.forbiddenWords;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            byte[] bytes = ascii.GetBytes(textBox1.Text);
            int length = bytes.Length;

            bits = new bool[length * 10];
            bool parity;

            for (int i = 0; i < length; i++)
            {
                parity = true;

                for (int j = 0; j < 7; j++)
                {
                    if (bytes[i] % 2 != 0)
                    {
                        bits[i * 10 + j + 1] = true;
                        parity = !parity;
                    }

                    bytes[i] /= 2;

                }

                if (!parity)
                    bits[i * 10 + 8] = true;
                bits[i * 10 + 9] = true;

            }

            string output = "";
            foreach (bool b in bits)
            {
                if (b)
                    output += '1';
                else
                    output += '0';
            }

            textBox2.Text = output;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            target.Read(bits);
        }


        public void Read(bool[] message)
        {
            string output = "";
            int cha, wordLenght = 0; ;
            bool parity;

            for (int i = 0; i < message.Length - 9; i++)
            {
                cha = 0;
                parity = true;

                if (!message[i] && message[i + 9])
                {
                    wordLenght++;
                    for (int j = 1; j < 9; j++)
                    {
                        if (message[i + j])
                            parity = !parity;
                    }
                    if (!parity)
                        cha = 63;
                    else
                    {
                        for (int j = 1; j < 8; j++)
                        {
                            if (message[i + j])
                                cha += (int)Math.Pow(2, j - 1);
                        }
                    }

                    if (cha >= 32 && cha <= 64)
                    {
                        output = Censor(output, wordLenght - 1);
                        wordLenght = 0;
                    }

                    output += Convert.ToChar(cha);
                    i += 9;
                }
            }
            output = Censor(output, wordLenght);

            textBox3.Text = output;
        }

        private string Censor(string input, int wordLength)
        {
            string test = input.Substring(input.Length - wordLength);
            bool forbidden = false;

            if (forbiddenWords.Contains(test, StringComparer.OrdinalIgnoreCase))
            {
                forbidden = true;
            }

            if (forbidden)
            {
                input = input.Remove(input.Length - wordLength, wordLength);
                for (int i = 0; i < wordLength; i++)
                    input += '*';

            }

            return input;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != '0' &&
                e.KeyChar != '1' &&
                !char.IsControl(e.KeyChar);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            int i = 0;
            bits = new bool[textBox2.Text.Length];
            foreach (char c in textBox2.Text)
            {
                if (c != '0')
                    bits[i] = true;
                i++;

            }

        }
    }
}
