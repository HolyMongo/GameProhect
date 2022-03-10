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
    public partial class Form3 : Form
    {

        bool goLeft, goRight, Jumping, isGameOver;
        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;

        int horizontalSpeed = 5;
        int verticalSpeed = 3;

        int enemyOneSpeed = 5;
        int enemyTwoSpeed = 3;


        private void Form3_Load(object sender, EventArgs e)
        {
            RestartGame();
            this.Size = new Size(500, 760);
            foreach (Control x in Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "coin")
                    {
                        x.Size = new Size(28, 31);
                    }
                }
            }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @"../../Shrekophone.wav";
            player.PlayLooping();
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "score: " + score;

           
            player.Top += jumpSpeed;

            if (goLeft == true)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true)
            {
                player.Left += playerSpeed;
            }

            if (Jumping == true && force < 0)
            {
                Jumping = false;
            }

            if (Jumping == true)
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            foreach (Control x in this.Controls)
            {

                if ((string)x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;


                        if ((string)x.Name == "horizontalPlatform" && goLeft == false || (string)x.Name == "horizontalPlatform" && goRight == false)
                        {
                            player.Left -= horizontalSpeed;
                        }
                    }

                    x.BringToFront();
                }

                if ((string)x.Tag == "coin")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        score++;
                    }

                }

                if ((string)x.Tag == "enemy")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameTimer.Stop();
                        isGameOver = true;
                        txtScore.Text = "score: " + score + Environment.NewLine + "You was killed. Game over" + Environment.NewLine + "Press \"Enter\" To Restart!";

                    }
                }

            }
            // move platforms bounce from border to border
            horizontalPlatform.Left -= horizontalSpeed;
            if (horizontalPlatform.Left < 0 || horizontalPlatform.Left + horizontalPlatform.Width > this.ClientSize.Width)
            {
                horizontalSpeed = -horizontalSpeed;
            }

            //Y2 = 142  Y1 = 460
            verticalPlatform.Top += verticalSpeed;
            if (verticalPlatform.Top < 142 || verticalPlatform.Top > 460)
            {
                verticalSpeed = -verticalSpeed;
            }

            //enemy movement
            enemyOne.Left -= enemyOneSpeed;
            if (enemyOne.Left < pictureBox5.Left || enemyOne.Left + enemyOne.Width > pictureBox5.Left + pictureBox5.Width)
            {
                enemyOneSpeed = -enemyOneSpeed;
            }

            enemyTwo.Left += enemyTwoSpeed;
            if (enemyTwo.Left < pictureBox2.Left || enemyTwo.Left + enemyTwo.Width > pictureBox2.Left + pictureBox2.Width)
            {
                enemyTwoSpeed = -enemyTwoSpeed;
            }
            //player out of bounds death
            if (player.Top + player.Height > this.ClientSize.Height + 50)
            {
                GameTimer.Stop();
                isGameOver = true;
                txtScore.Text = "Score: " + score + Environment.NewLine + "You fell to your death. Game Over" + Environment.NewLine + "Press \"Enter\" To Restart!";
            } 
          
            //Player touches door and wins if they have more than 25 coins collected
            if (player.Bounds.IntersectsWith(Door.Bounds))
            {
                if (score == 25)
                {

                GameTimer.Stop();
                isGameOver = true;
                txtScore.Text = "Score: " + score + Environment.NewLine + "Your adventure is over. YOU WIN" + Environment.NewLine + "Press \"Enter\" To Restart!";
                }
            }
          

        }


        //buttons move character
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && Jumping == false)
            {
                Jumping = true;
            }
            
        }



        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (Jumping == true)
            {
                Jumping = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                RestartGame();
            }

        }
        //resets game and everything
        private void RestartGame()
        {
            Jumping = true;
            goLeft = false;
            goRight = false;
            isGameOver = false;
            score = 0;

            txtScore.Text = "Score: " + score + Environment.NewLine + "Collect all 25 coins and Open the door!";

            GameTimer.Start();
            // reset coins :)
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }

            // reset the position of player, platforms and enemies

            player.Left = 51;
            player.Top = 530;

            enemyOne.Left = 313;
            enemyTwo.Left = 414;

            horizontalPlatform.Left = 265;
            verticalPlatform.Top = 460;

            Door.Location = new Point(Door.Location.X, pictureBox8.Location.Y - Door.Height);
          

        }

    }
}

