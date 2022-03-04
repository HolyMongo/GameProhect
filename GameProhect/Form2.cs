using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProhect
{
    public partial class Form2 : Form
    {

        Random r = new Random();
        public int aiPlayer;
        int rounds = 0;
        bool isGameOver = false;
        
        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Location = new Point((this.Width / 2) - (label2.Width / 2), label2.Location.Y);
            //music
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @"../../LofiMusic.wav";
            player.Play();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void a1_Click(object sender, EventArgs e)
        {
            if (isGameOver == false)
            {

                if (a1.Text == "")
                {
                    a1.Text = "X";

                    rounds++;
                    Ai();
                }
            }
        }

        private void a2_Click(object sender, EventArgs e)
        {
            if (isGameOver == false)
            {
                if (a2.Text == "")
                {
                    a2.Text = "X";
                    rounds++;
                    Ai();
                }
            }
        }

        private void a3_Click(object sender, EventArgs e)
        {
            if (isGameOver == false)
            {
                if (a3.Text == "")
                {
                    a3.Text = "X";
                    rounds++;
                    Ai();
                }
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (isGameOver == false)
            {
                if (b1.Text == "")
                {
                    b1.Text = "X";
                    rounds++;
                    Ai();
                }
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (b2.Text == "")
            {
                b2.Text = "X";
                rounds++;
                Ai();
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (isGameOver == false)
            {
                if (b3.Text == "")
                {
                    b3.Text = "X";
                    rounds++;
                    Ai();
                }
            }
        }

        private void c1_Click(object sender, EventArgs e)
        {
            if (isGameOver == false)
            {
                if (c1.Text == "")
                {
                    c1.Text = "X";
                    rounds++;
                    Ai();
                }
            }
        }

        private void c2_Click(object sender, EventArgs e)
        {
            if (isGameOver == false)
            {
                if (c2.Text == "")
                {
                    c2.Text = "X";
                    rounds++;
                    Ai();
                }
            }
        }

        private void c3_Click(object sender, EventArgs e)
        {
            if (isGameOver == false)
            {
                if (c3.Text == "")
                {
                    c3.Text = "X";
                    rounds++;
                    Ai();
                }
            }
        }

        private void Ai()
        {
            while (true)
            {
                CheckWin();
                if (label2.Text == "You win!")
                {
                    break;
                }
                
                if (rounds <= 7)
                {

                aiPlayer = r.Next(1, 10);

                if (aiPlayer == 1)
                {
                    if (a1.Text == "")
                    {

                        a1.Text = "O";
                        rounds++;
                        break;
                    }
                }
                else if (aiPlayer == 2)
                {
                    if (a2.Text == "")
                    {

                        a2.Text = "O";
                        rounds++;
                        break;
                    }
                }
                else if (aiPlayer == 3)
                {
                    if (a3.Text == "")
                    {

                        a3.Text = "O";
                        rounds++;
                        break;
                    }
                }
                else if (aiPlayer == 4)
                {
                    if (b1.Text == "")
                    {

                        b1.Text = "O";
                        rounds++;
                        break;
                    }
                }
                else if (aiPlayer == 5)
                {
                    if (b2.Text == "")
                    {

                        b2.Text = "O";
                        rounds++;
                        break;
                    }
                }
                else if (aiPlayer == 6)
                {
                    if (b3.Text == "")
                    {

                        b3.Text = "O";
                        rounds++;
                        break;
                    }
                }
                else if (aiPlayer == 7)
                {
                    if (c1.Text == "")
                    {

                        c1.Text = "O";
                        rounds++;
                        break;
                    }
                }
                else if (aiPlayer == 8)
                {
                    if (c2.Text == "")
                    {

                        c2.Text = "O";
                        rounds++;
                        break;
                    }
                }
                else
                {
                    if (c3.Text == "")
                    {

                        c3.Text = "O";
                        rounds++;
                        break;
                    }
                }

                }
                else
                {
                    break;
                }
            }
            CheckWin();

        }


        private void CheckWin()
        {
            if (a1.Text == "X" && a2.Text == "X" && a3.Text == "X" || a1.Text == "X" && b2.Text == "X" && c3.Text == "X" || b1.Text == "X" && b2.Text == "X" && b3.Text == "X" || c1.Text == "X" && c2.Text == "X" && c3.Text == "X" || a1.Text == "X" && b1.Text == "X" && c1.Text == "X" || a2.Text == "X" && b2.Text == "X" && c2.Text == "X" || a3.Text == "X" && b3.Text == "X" && c3.Text == "X" || a3.Text == "X" && b2.Text == "X" && c1.Text == "X")
            {
                label2.Text = "You win!";
                isGameOver = true;
            }
            else if (a1.Text == "O" && a2.Text == "O" && a3.Text == "O" || a1.Text == "O" && b2.Text == "O" && c3.Text == "O" || b1.Text == "O" && b2.Text == "O" && b3.Text == "O" || c1.Text == "O" && c2.Text == "O" && c3.Text == "O" || a1.Text == "O" && b1.Text == "O" && c1.Text == "O" || a2.Text == "O" && b2.Text == "O" && c2.Text == "O" || a3.Text == "O" && b3.Text == "O" && c3.Text == "O" || a3.Text == "O" && b2.Text == "O" && c1.Text == "O")
            {
                label2.Text = "You lose!";
                isGameOver = true;
            }
            label2.Location = new Point((this.Width/2) - (label2.Width/2), label2.Location.Y);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            c1.Text = "";
            c2.Text = "";
            c3.Text = "";
            label2.Text = "pick a box where u want to place an X";
            rounds = 0;
            label2.Location = new Point((this.Width / 2) - (label2.Width / 2), label2.Location.Y);
            isGameOver = false;
        }

    }
}
