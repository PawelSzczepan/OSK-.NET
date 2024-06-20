using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSK5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();

            Register[] regs = 
            {
                new Register('a', ahBox, alBox),
                new Register('b', bhBox, blBox),
                new Register('c', chBox, clBox),
                new Register('d', dhBox, dlBox)
            };

            registers = new Registers(regs);
        }

        private class Registers
        {
            Register[] regs;

            public Registers(Register[] newRegs)
            {
                regs = newRegs;
            }

            public Register Get(char n)
            {
                foreach (Register r in regs)
                    if (r.name == n)
                        return r;
                return null;
            }

            public void Reset()
            {
                foreach (Register r in regs)
                    r.MovX(0);
            }
        }

        private class Register
        {
            public readonly char name;
            private byte H, L;
            private TextBox hBox, lBox;

            public Register(char newName, TextBox newHBox, TextBox newLBox)
            {
                name = newName;
                hBox = newHBox;
                lBox = newLBox;
            }

            public void MovX(UInt16 num)
            {
                MovH((byte)(num / 256));
                MovL((byte)(num % 256));
            }

            public void MovH(byte num)
            {
                H = num;

                string bits = "";
                for (int i = 0; i < 8; i++)
                {
                    bits += (num % 2).ToString();
                    num = (byte)(num / 2);
                }
                char[] temp = bits.ToCharArray();
                Array.Reverse(temp);
                hBox.Text = new string(temp);
            }

            public void MovL(byte num)
            {
                L = num;

                string bits = "";
                for (int i = 0; i < 8; i++)
                {
                    bits += (num % 2).ToString();
                    num = (byte)(num / 2);
                }
                char[] temp = bits.ToCharArray();
                Array.Reverse(temp);
                lBox.Text = new string(temp);
            }

            public UInt16 GetX() => (UInt16)((UInt16)(H) * (UInt16)(byte.MaxValue) + (UInt16)(L));

            public byte GetH() => H;

            public byte GetL() => L;
        }

        private class Order
        {
            public enum actions { MOV, ADD, SUB};
            public actions act;

            public char reg1Name, reg2Name;

            public enum regType { X, H, L};
            public regType type1, type2;

            public enum modes { register, instant};
            public modes mode;

            public int instantValue;

            Registers regs;

            public Order(Registers newRegs)
            {
                regs = newRegs;
            }

            public void Perform()
            {
                int old = 0, extra = 0, newValue = 0;

                switch(type1)
                {
                    case regType.X:
                        old = regs.Get(reg1Name).GetX();
                        break;
                    case regType.H:
                        old = regs.Get(reg1Name).GetH();
                        break;
                    case regType.L:
                        old = regs.Get(reg1Name).GetL();
                        break;
                }

                switch(mode)
                {
                    case modes.instant:
                        extra = instantValue;
                        break;

                    case modes.register:
                        switch (type2)
                        {
                            case regType.X:
                                extra = regs.Get(reg2Name).GetX();
                                break;
                            case regType.H:
                                extra = regs.Get(reg2Name).GetH();
                                break;
                            case regType.L:
                                extra = regs.Get(reg2Name).GetL();
                                break;
                        }
                        break;
                }

                switch(act)
                {
                    case actions.MOV:
                        newValue = extra;
                        break;
                    case actions.ADD:
                        newValue = old + extra;
                        break;
                    case actions.SUB:
                        newValue = old - extra;
                        break;
                }

                switch (type1)
                {
                    case regType.X:
                        regs.Get(reg1Name).MovX((UInt16)newValue);
                        break;
                    case regType.H:
                        regs.Get(reg1Name).MovH((byte)newValue);
                        break;
                    case regType.L:
                        regs.Get(reg1Name).MovL((byte)newValue);
                        break;
                }

            }

        }

        private void run_Click(object sender, EventArgs e) => PerformCode(false);

        private void step_Click(object sender, EventArgs e) => PerformCode(true);

        private void save_Click(object sender, EventArgs e)
        {
            Stream myStream;

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    string dataasstring = codeBox.Text; //your data
                    byte[] info = new UTF8Encoding(true).GetBytes(dataasstring);
                    myStream.Write(info, 0, info.Length);

                    // writing data in bytes already
                    byte[] data = new byte[] { 0x0 };
                    myStream.Write(data, 0, data.Length);

                    myStream.Close();
                }
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            Stream myStream;

            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string tempCode = "";
                    byte[] b = new byte[1024];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    int readLen;
                    while ((readLen = myStream.Read(b, 0, b.Length)) > 0)
                    {
                        tempCode += temp.GetString(b, 0, readLen);
                    }

                    codeBox.Text = tempCode;

                    myStream.Close();
                }
            }
        }

        private void PerformCode(bool step)
        {
            if (code.Count == 0)
            {
                registers.Reset();

                foreach (char c in (codeBox.Text.ToLower() + " "))
                    code.Enqueue(c);

                if (step)
                    return;
            }

            int orderPart = 0;
            string word = "";
            char newChar;
            Order order = new Order(registers);

            while (code.Count() > 0)
            {
                newChar = code.Dequeue();

                if (newChar == ' ' || newChar == '\n')
                {
                    if (word != "")
                    {
                        switch (orderPart)
                        {
                            case 0:
                                switch (word)
                                {
                                    case "mov":
                                        order.act = Order.actions.MOV;
                                        break;
                                    case "add":
                                        order.act = Order.actions.ADD;
                                        break;
                                    case "sub":
                                        order.act = Order.actions.SUB;
                                        break;
                                    default:
                                        MessageBox.Show("Nie rozpoznano rozkazu " + word, "Błąd kodu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        code.Clear();
                                        return;
                                        break;
                                }
                                break;

                            case 1:
                                if (word[0] == 'a' || word[0] == 'b' || word[0] == 'c' || word[0] == 'd')
                                {
                                    order.reg1Name = word[0];
                                    switch (word[1])
                                    {
                                        case 'x':
                                            order.type1 = Order.regType.X;
                                            break;
                                        case 'h':
                                            order.type1 = Order.regType.H;
                                            break;
                                        case 'l':
                                            order.type1 = Order.regType.L;
                                            break;
                                        default:
                                            MessageBox.Show("Nie rozpoznano rejestru " + word, "Błąd kodu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            code.Clear();
                                            return;
                                            break;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Nie rozpoznano rejestru " + word, "Błąd kodu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    code.Clear();
                                    return;
                                }

                                break;

                            case 2:

                                if (word[0] == 'a' || word[0] == 'b' || word[0] == 'c' || word[0] == 'd')
                                {
                                    order.mode = Order.modes.register;
                                    order.reg2Name = word[0];
                                    switch (word[1])
                                    {
                                        case 'x':
                                            order.type2 = Order.regType.X;
                                            break;
                                        case 'h':
                                            order.type2 = Order.regType.H;
                                            break;
                                        case 'l':
                                            order.type2 = Order.regType.L;
                                            break;
                                        default:
                                            MessageBox.Show("Nie rozpoznano rejestru " + word, "Błąd kodu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            code.Clear();
                                            return;
                                            break;
                                    }
                                }
                                else
                                {
                                    order.mode = Order.modes.instant;
                                    try 
                                    {
                                        order.instantValue = Convert.ToInt32(word);
                                    }
                                    catch 
                                    {
                                        MessageBox.Show("Nie rozpoznano wartości " + word, "Błąd kodu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        code.Clear();
                                        return;
                                        ;
                                    }

                                }

                                order.Perform();
                                if (step)
                                    return;
                                break;
                        }

                        orderPart = (orderPart + 1) % 3;
                        word = "";
                    }

                }
                else
                    word += newChar;
            }
        }
    }
}
