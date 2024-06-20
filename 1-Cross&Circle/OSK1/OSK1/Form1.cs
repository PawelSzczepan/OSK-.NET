using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace OSK1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            chosenCross = zwykłeToolStripMenuItem1;
            chosenCircle = toolStripMenuItem2;
            circleTurn = false;
            grid = new cellState[3, 3];
            focus = new int[] { 0, 0 };
            turns = 0;

            Reset();
        }


        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy chcesz zamknąć grę?", "Jesteś pewien?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Close();
        }

        private void Reset()
        {
            circleTurn = false;
            infoPicture.BackgroundImage = chosenCross.Image;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    grid[x, y] = cellState.empty;
                    PictureBox img = (PictureBox)tableLayoutPanel1.GetControlFromPosition(x, y);
                    img.BackgroundImage = null;
                }
            }
            turns = 0;
        }

        private void tile_Click(object sender, EventArgs e)
        {
            PictureBox img = (PictureBox)sender;
            TableLayoutPanelCellPosition pos = tableLayoutPanel1.GetPositionFromControl(img);

            if (grid[pos.Column, pos.Row] != cellState.empty)
                return;

            turns += 1;
            circleTurn = !circleTurn;
            if (circleTurn)
                infoPicture.BackgroundImage = chosenCircle.Image;
            else
                infoPicture.BackgroundImage = chosenCross.Image;

            if (circleTurn)
            {
                img.BackgroundImage = chosenCross.Image;
                grid[pos.Column, pos.Row] = cellState.cross;
                CheckWin(pos.Column, pos.Row, cellState.cross);
            }
            else
            {

                img.BackgroundImage = chosenCircle.Image;
                grid[pos.Column, pos.Row] = cellState.circle;
                CheckWin(pos.Column, pos.Row, cellState.circle);
            }

            if (turns == 9)
            {
                DialogResult result = MessageBox.Show("Remis!");
                Reset();
            }
        }

        private void CheckWin(int x, int y, cellState state)
        {
            //Sprawdzamy linię poziomą
            bool win = true;
            for (int i = 0; i < 3; i++)
            {
                if (grid[x, i] != state)
                    win = false;
            }
            if (win)
                Win();

            //Sprawdzamy linię pionową
            win = true;
            for (int i = 0; i < 3; i++)
            {
                if (grid[i, y] != state)
                    win = false;
            }
            if (win)
                Win();

            //Sprawdzamy po skosie
            if ((x + y) % 2 != 0)
                return;

            win = true;
            for (int i = 0; i < 3; i++)
            {
                if (grid[i, i] != state)
                    win = false;
            }
            if (win)
                Win();

            win = true;
            for (int i = 0; i < 3; i++)
            {
                if (grid[2 - i, i] != state)
                    win = false;
            }
            if (win)
                Win();
        }

        private void Win()
        {
            string playerName;
            if (circleTurn)
                playerName = "Krzyżyki";
            else
                playerName = "Kółka";

            DialogResult result = MessageBox.Show(playerName + " wygrały!");
            Reset();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            chosenCross.Checked = false;
            chosenCross = (ToolStripMenuItem)sender;
            chosenCross.Checked = true;

            if (!circleTurn)
                infoPicture.BackgroundImage = chosenCross.Image;

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (grid[x, y] == cellState.cross)
                    {
                        PictureBox img = (PictureBox)tableLayoutPanel1.GetControlFromPosition(x, y);
                        img.BackgroundImage = chosenCross.Image;
                    }
                }
            }
        }

        private void circle_Click(object sender, EventArgs e)
        {
            chosenCircle.Checked = false;
            chosenCircle = (ToolStripMenuItem)sender;
            chosenCircle.Checked = true;

            if (circleTurn)
                infoPicture.BackgroundImage = chosenCircle.Image;

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (grid[x, y] == cellState.circle)
                    {
                        PictureBox img = (PictureBox)tableLayoutPanel1.GetControlFromPosition(x, y);
                        img.BackgroundImage = chosenCircle.Image;
                    }
                }
            }
        }

        private void resetujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy chcesz zresetować grę?", "Jesteś pewien?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Reset();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            PictureBox img = (PictureBox)tableLayoutPanel1.GetControlFromPosition(focus[0], focus[1]);
            img.BorderStyle = BorderStyle.FixedSingle;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    focus[0] = Math.Abs((focus[0] + 3 - 1)) % 3;
                    break;

                case Keys.Right:
                    focus[0] = Math.Abs((focus[0] + 3 + 1)) % 3;
                    break;

                case Keys.Down:
                    focus[1] = Math.Abs((focus[1] + 3 + 1)) % 3;
                    break;

                case Keys.Up:
                    focus[1] = Math.Abs((focus[1] + 3 - 1)) % 3;
                    break;

                case Keys.Enter:
                    tile_Click(img, EventArgs.Empty);
                    break;
            }

            img = (PictureBox)tableLayoutPanel1.GetControlFromPosition(focus[0], focus[1]);
            img.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
