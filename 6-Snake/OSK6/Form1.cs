using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSK6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            board = new Board(this);
            DoubleBuffered = true;
        }

        public class Board
        {
            const int maxX = 26, maxY = 13, cellSize = 35;

            cellState[,] prevCells = new cellState[maxX, maxY];
            cellState[,] cells = new cellState[maxX, maxY];
            direction[,] prevDirs = new direction[maxX, maxY];
            direction[,] dirs = new direction[maxX, maxY];

            int headX = 1, headY = 0;
            int tailX, tailY;
            int growing = 1;
            public int score = 0;
            int bodyIndex = 0;

            Form1 parent;

            PictureBox head = new PictureBox();
            PictureBox tail = new PictureBox();
            PictureBox fruit = new PictureBox();
            List<PictureBox> body = new List<PictureBox>();

            Random r = new Random();

            public Board(Form1 newParent)
            {
                parent = newParent;

                tailX = headX - 1;
                tailY = headY;

                cells[headX, headY] = cellState.head;
                cells[tailX, tailY] = cellState.tail;
                dirs[headX, headY] = direction.right;
                dirs[tailX, tailY] = direction.right;


                head.BackgroundImage = Properties.Resources.HeadRight;
                head.BackgroundImageLayout = ImageLayout.Stretch;
                head.Margin = new Padding(0);
                head.Size = new Size(cellSize, cellSize);
                head.BorderStyle = BorderStyle.None;
                parent.Controls.Add(head);

                fruit.BackgroundImage = Properties.Resources.Apple;
                fruit.BackgroundImageLayout = ImageLayout.Stretch;
                fruit.Margin = new Padding(0);
                fruit.Size = new Size(cellSize, cellSize);
                fruit.BorderStyle = BorderStyle.None;
                parent.Controls.Add(fruit);

                tail.BackgroundImage = Properties.Resources.TailRight;
                tail.BackgroundImageLayout = ImageLayout.Stretch;
                tail.Margin = new Padding(0);
                tail.Size = new Size(cellSize, cellSize);
                tail.BorderStyle = BorderStyle.None;
                parent.Controls.Add(tail);

                for (int x = 0; x < maxX; x++)
                {
                    for (int y = 0; y < maxY; y++)
                    {
                        prevCells[x, y] = cells[x, y];
                        prevDirs[x, y] = dirs[x, y];
                    }
                }

                SpawnFruit();
            }

            void AddBody(int x, int y, direction dir, direction newDir)
            {
                PictureBox newBody = new PictureBox();
                newBody.BackgroundImage = Properties.Resources.BodyLeftRight;
                newBody.BackgroundImageLayout = ImageLayout.Stretch;
                newBody.Margin = new Padding(0);
                newBody.Size = new Size(cellSize, cellSize);
                newBody.Location = new Point(cellSize * x, cellSize * y);
                newBody.BorderStyle = BorderStyle.None;
                body.Add(newBody);
                parent.Controls.Add(newBody);



                if ((dir == direction.left && newDir == direction.up) ||
                    (newDir == direction.right && dir == direction.down))
                    newBody.BackgroundImage = Properties.Resources.BodyLeftUp;

                else if ((dir == direction.left && newDir == direction.down) ||
                        (newDir == direction.right && dir == direction.up))
                    newBody.BackgroundImage = Properties.Resources.BodyLeftDown;

                else if ((dir == direction.right && newDir == direction.down) ||
                        (newDir == direction.left && dir == direction.up))
                    newBody.BackgroundImage = Properties.Resources.BodyRightDown;

                else if ((dir == direction.right && newDir == direction.up) ||
                        (newDir == direction.left && dir == direction.down))
                    newBody.BackgroundImage = Properties.Resources.BodyRightUp;

                else if ((dir == direction.right || dir == direction.left) &&
                        (newDir == direction.right || newDir == direction.left))
                    newBody.BackgroundImage = Properties.Resources.BodyLeftRight;

                else if ((dir == direction.down || dir == direction.up) &&
                        (newDir == direction.down || newDir == direction.up))
                    newBody.BackgroundImage = Properties.Resources.BodyUpDown;
            }

            public void ChangeDirection(direction dir)
            {                
                direction prevDir = dirs[headX, headY];
                if (!(prevDir == direction.up && dir == direction.down) &&
                    !(prevDir == direction.right && dir == direction.left) &&
                    !(prevDir == direction.down && dir == direction.up) &&
                    !(prevDir == direction.left && dir == direction.right))
                {
                    prevDirs[headX, headY] = dir;
                }
            }

            void MoveCell(int x, int y, direction dir)
            {
                int newX = x;
                int newY = y;
                switch (dir)
                {
                    case direction.up:
                        newY--;
                        break;
                    case direction.right:
                        newX++;
                        break;
                    case direction.down:
                        newY++;
                        break;
                    case direction.left:
                        newX--;
                        break;

                }
                if (newY >= 0 && newY < maxY && newX >= 0 && newX < maxX)
                {
                    cells[newX, newY] = prevCells[x, y];

                    if (prevCells[x, y] == cellState.tail)
                    {
                        if(growing <= 0)
                        {
                            cells[x, y] = cellState.empty;
                            tail.Location = new Point(cellSize * newX, cellSize * newY);
                            switch (dirs[newX, newY])
                            {
                                case direction.up:
                                    tail.BackgroundImage = Properties.Resources.TailUp;
                                    break;
                                case direction.right:
                                    tail.BackgroundImage = Properties.Resources.TailRight;
                                    break;
                                case direction.down:
                                    tail.BackgroundImage = Properties.Resources.TailDown;
                                    break;
                                case direction.left:
                                    tail.BackgroundImage = Properties.Resources.TailLeft;
                                    break;
                            }
                        }
                        else
                        {
                            cells[newX, newY] = cellState.body;
                            growing--;
                            AddBody(newX, newY, prevDirs[x, y], prevDirs[newX, newY]);
                        }
                    }
                    else if (prevCells[x, y] == cellState.head)
                    {
                        if (prevCells[newX, newY] == cellState.body || prevCells[newX, newY] == cellState.tail)
                            parent.GameOver();
                        else if (prevCells[newX, newY] == cellState.fruit)
                        {
                            score++;
                            growing++;
                            SpawnFruit();
                        }

                        switch (dir)
                        {
                            case direction.up:
                                head.BackgroundImage = Properties.Resources.HeadUp;
                                break;
                            case direction.right:
                                head.BackgroundImage = Properties.Resources.HeadRight;
                                break;
                            case direction.down:
                                head.BackgroundImage = Properties.Resources.HeadDown;
                                break;
                            case direction.left:
                                head.BackgroundImage = Properties.Resources.HeadLeft;
                                break;
                        }

                        dirs[x, y] = dir;
                        dirs[newX, newY] = dir;
                        headX = newX;
                        headY = newY;

                        head.Location = new Point(cellSize * newX, cellSize * newY);
                    }
                    else if (prevCells[x, y] == cellState.body)
                    {
                        if ((prevDirs[x, y] == direction.left && prevDirs[newX, newY] == direction.up) ||
                           (prevDirs[newX, newY] == direction.right && prevDirs[x, y] == direction.down))
                            body[bodyIndex].BackgroundImage = Properties.Resources.BodyLeftUp;

                        else if ((prevDirs[x, y] == direction.left && prevDirs[newX, newY] == direction.down) ||
                           (prevDirs[newX, newY] == direction.right && prevDirs[x, y] == direction.up))
                            body[bodyIndex].BackgroundImage = Properties.Resources.BodyLeftDown;

                        else if ((prevDirs[x, y] == direction.right && prevDirs[newX, newY] == direction.down) ||
                           (prevDirs[newX, newY] == direction.left && prevDirs[x, y] == direction.up))
                            body[bodyIndex].BackgroundImage = Properties.Resources.BodyRightDown;

                        else if ((prevDirs[x, y] == direction.right && prevDirs[newX, newY] == direction.up) ||
                           (prevDirs[newX, newY] == direction.left && prevDirs[x, y] == direction.down))
                            body[bodyIndex].BackgroundImage = Properties.Resources.BodyRightUp;

                        else if ((prevDirs[x, y] == direction.right || prevDirs[x, y] == direction.left) &&
                           (prevDirs[newX, newY] == direction.right || prevDirs[newX, newY] == direction.left))
                            body[bodyIndex].BackgroundImage = Properties.Resources.BodyLeftRight;

                        else if ((prevDirs[x, y] == direction.down || prevDirs[x, y] == direction.up) &&
                           (prevDirs[newX, newY] == direction.down || prevDirs[newX, newY] == direction.up))
                            body[bodyIndex].BackgroundImage = Properties.Resources.BodyUpDown;

                        body[bodyIndex].Location = new Point(cellSize * newX, cellSize * newY);
                        bodyIndex++;
                    }
                }
                else if (prevCells[x, y] == cellState.head)
                    parent.GameOver();
            }

            void SpawnFruit()
            {
                int x = 0;
                int y = 0;
                do
                {
                    x = r.Next(maxX);
                    y = r.Next(maxY);
                } while (cells[x, y] != cellState.empty);
                cells[x, y] = cellState.fruit;
                fruit.Location = new Point(cellSize * x, cellSize * y);
            }

            public void Update()
            {
                bodyIndex = 0;
                for (int x = 0; x <  maxX; x++)
                {
                    for (int y = 0; y < maxY; y++)
                    {
                        if(prevCells[x,y] == cellState.body || prevCells[x, y] == cellState.head || prevCells[x, y] == cellState.tail)
                        {
                            MoveCell(x, y, prevDirs[x, y]);
                        }                       
                    }
                }

                for (int x = 0; x < maxX; x++)
                {
                    for (int y = 0; y < maxY; y++)
                    {
                        prevCells[x, y] = cells[x, y];
                        prevDirs[x, y] = dirs[x, y];
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            board.Update();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            switch(e.KeyCode)
            {
                case Keys.Up:
                    board.ChangeDirection(direction.up);
                    break;
                case Keys.Right:
                    board.ChangeDirection(direction.right);
                    break;
                case Keys.Down:
                    board.ChangeDirection(direction.down);
                    break;
                case Keys.Left:
                    board.ChangeDirection(direction.left);
                    break;
            }
        }

        public void GameOver()
        {
            timer1.Enabled = false;
            DialogResult dialogResult = MessageBox.Show("Przegrałeś! Twój wynik to "+ board.score.ToString() + ". Czy chcesz kontynuować?", "GAME OVER", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }

            
    }
}
