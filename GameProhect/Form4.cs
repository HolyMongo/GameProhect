
using System;
            using System.Collections.Generic;
            using System.ComponentModel;
            using System.Data;
            using System.Drawing;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;
            using System.Threading;
            using System.Windows.Forms;

namespace GameProhect
    {
        public partial class Form4 : Form
        {

            System.Media.SoundPlayer splayer = new System.Media.SoundPlayer();
            double playerHealth = 1000, enemyHealth = 1000, playerDamage = 300, enemyDamage = 200;

            string playerAnimal, playerElement, enemyAnimal, enemyElement;

            Random r = new Random();
            int randomvar;

            public Form4()
            {
                InitializeComponent();
            }
            private void Form4_Load(object sender, EventArgs e)
            {
                bringUpCharSelect(sender, e);
                splayer.SoundLocation = @"../../BAttlemusique.wav";
                splayer.PlayLooping();
            }

            private void bringUpCharSelect(object sender, EventArgs e)
            {
                charPickingBackground.BringToFront();
                charPickingBackground.Visible = true;
                charPickingBackground.Enabled = true;
                foreach (Control x in Controls)
                {
                    if ((string)x.Tag == "startGUI" && x is Button || x is Label && (string)x.Tag == "startGUI")
                    {
                        x.BringToFront();
                        x.Visible = true;
                        x.Enabled = true;
                    }
                }
                closeInformation.SendToBack();
            endingScreenText.Visible = false;
            endingScreenReset.Visible = false;
            endingScreenReset.Enabled = false;
        }


            private void fire_Click(object sender, EventArgs e)
            {
                playerElement = "Fire";
                fire.BackColor = Color.FromArgb(100, 100, 100);
                water.BackColor = Color.White;
                grass.BackColor = Color.White;
                attack1.Text = "Fire sneeze";
                attack2.Text = "Flame punch";
            }

            private void grass_Click(object sender, EventArgs e)
            {
                playerElement = "Grass";
                grass.BackColor = Color.FromArgb(100, 100, 100);
                fire.BackColor = Color.White;
                water.BackColor = Color.White;
                attack1.Text = "Grass sneeze";
                attack2.Text = "Plant punch";
            }

            private void water_Click(object sender, EventArgs e)
            {
                playerElement = "Water";
                water.BackColor = Color.FromArgb(100, 100, 100);
                fire.BackColor = Color.White;
                grass.BackColor = Color.White;
                attack1.Text = "Water sneeze";
                attack2.Text = "Aqua punch";
            }

            private void dog_Click(object sender, EventArgs e)
            {
                playerAnimal = "Dog";
                dog.BackColor = Color.FromArgb(100, 100, 100);
                cat.BackColor = Color.White;
                turtle.BackColor = Color.White;
                attack3.Text = "kick";
                attack4.Text = "gouge";
            }


            private void cat_Click(object sender, EventArgs e)
            {
                playerAnimal = "Cat";
                playerHealth = 750;
                cat.BackColor = Color.FromArgb(100, 100, 100);
                dog.BackColor = Color.White;
                turtle.BackColor = Color.White;
                attack3.Text = "scratch";
                attack4.Text = "bite";
            }

            private void turtle_Click(object sender, EventArgs e)
            {
                playerAnimal = "Turtle";
                playerHealth = 1500;
                turtle.BackColor = Color.FromArgb(100, 100, 100);
                cat.BackColor = Color.White;
                dog.BackColor = Color.White;
                attack3.Text = "Hide";
                attack4.Text = "jaw snap";
            }

            private void attack1_Click(object sender, EventArgs e)
            {


                if (playerElement == "Fire")
                {
                    if (enemyElement == "Grass")
                    {
                        enemyHealth -= (playerDamage * 1.5);
                    }
                    else if (enemyElement == "Water")
                    {
                        enemyHealth -= (playerDamage * 0.75);
                    }
                }
                else if (playerElement == "Water")
                {
                    if (enemyElement == "Grass")
                    {
                        enemyHealth -= (playerDamage * 1.5);
                    }
                    else if (enemyElement == "Fire")
                    {
                        enemyHealth -= (playerDamage * 0.75);
                    }
                }
                else if (playerElement == "Grass")
                {
                    if (enemyElement == "Water")
                    {
                        enemyHealth -= (playerDamage * 1.5);
                    }
                    else if (enemyElement == "Fire")
                    {
                        enemyHealth -= (playerDamage * 0.75);
                    }
                }
                enemyattack(sender, e);
                EnemyHP.Text = enemyHealth.ToString();
                PlayerHP.Text = playerHealth.ToString();

            }

            private void attack2_Click(object sender, EventArgs e)
            {
                if (playerElement == "Fire")
                {
                    if (enemyElement == "Grass")
                    {
                        enemyHealth -= (playerDamage * 1.5);
                    }
                    else if (enemyElement == "Water")
                    {
                        enemyHealth -= (playerDamage * 0.75);
                    }
                }
                else if (playerElement == "Water")
                {
                    if (enemyElement == "Grass")
                    {
                        enemyHealth -= (playerDamage * 1.5);
                    }
                    else if (enemyElement == "Fire")
                    {
                        enemyHealth -= (playerDamage * 0.75);
                    }
                }
                else if (playerElement == "Grass")
                {
                    if (enemyElement == "Water")
                    {
                        enemyHealth -= (playerDamage * 1.5);
                    }
                    else if (enemyElement == "Fire")
                    {
                        enemyHealth -= (playerDamage * 0.75);
                    }
                }
                enemyattack(sender, e);
                EnemyHP.Text = enemyHealth.ToString();
                PlayerHP.Text = playerHealth.ToString();


            }

            private void attack3_Click(object sender, EventArgs e)
            {

                enemyHealth -= playerDamage;
                enemyattack(sender, e);
                EnemyHP.Text = enemyHealth.ToString();
                PlayerHP.Text = playerHealth.ToString();

            }

            private void attack4_Click(object sender, EventArgs e)
            {

                enemyHealth -= playerDamage;
                enemyattack(sender, e);
                EnemyHP.Text = enemyHealth.ToString();
                PlayerHP.Text = playerHealth.ToString();

            }


            private void enemyattack(object sender, EventArgs e)
            {
                Random r = new Random();
                int randomvar = r.Next(1, 4);


                if (randomvar == 1 || randomvar == 2)
                {
                    if (enemyElement == "Fire")
                    {
                        if (playerElement == "Grass")
                        {
                            playerHealth -= (enemyDamage * 1.5);
                        }
                        else if (playerElement == "Water")
                        {
                            playerHealth -= (enemyDamage * 0.75);
                        }
                    }
                    else if (enemyElement == "Water")
                    {
                        if (playerElement == "Grass")
                        {
                            playerHealth -= (enemyDamage * 1.5);
                        }
                        else if (playerElement == "Fire")
                        {
                            playerHealth -= (enemyDamage * 0.75);
                        }
                    }
                    else if (enemyElement == "Grass")
                    {
                        if (playerElement == "Water")
                        {
                            playerHealth -= (enemyDamage * 1.5);
                        }
                        else if (playerElement == "Fire")
                        {
                            playerHealth -= (enemyDamage * 0.75);
                        }
                    }

                }
                else if (randomvar == 3 || randomvar == 4)
                {
                    playerHealth -= enemyDamage;
                }
                checkDeath(sender, e);

            }

            private void endingScreenReset_Click(object sender, EventArgs e)
            {
                endingScreen.SendToBack();
                endingScreenReset.SendToBack();
                endingScreenText.SendToBack();
                endingScreenText.Visible = false;
                endingScreenReset.Visible = false;
                endingScreenReset.Enabled = false;
                mainMeny.SendToBack();
                bringUpCharSelect(sender, e);
                playerAnimal = null;
                playerElement = null;
                cat.BackColor = Color.White;
                dog.BackColor = Color.White;
                turtle.BackColor = Color.White;
                fire.BackColor = Color.White;
                grass.BackColor = Color.White;
                water.BackColor = Color.White;

            //this.Hide();
            //Form4 f4 = new Form4();
            //f4.ShowDialog();
            //this.Close();
        }



            private void mainMeny_Click(object sender, EventArgs e)
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                splayer.Stop();
                this.Close();
            }

            private void checkDeath(object sender, EventArgs e)
            {
                if (enemyHealth <= 0)
                {
                    endingScreen.BringToFront();
                    endingScreenText.BringToFront();
                    endingScreenReset.BringToFront();
                    endingScreenReset.Enabled = true;
                    endingScreenReset.Visible = true;
                    endingScreenText.Visible = true;
                    mainMeny.BringToFront();
                    endingScreenText.Text = "You Win!!";
                    endingScreen.Visible = true;
                    endingScreenText.Location = new Point(this.Width / 2 - endingScreenText.Width / 2, endingScreenText.Location.Y);
                }
                else if (playerHealth <= 0)
                {
                    endingScreen.BringToFront();
                    endingScreenText.BringToFront();
                    endingScreenReset.BringToFront();
                    endingScreenReset.Enabled = true;
                    endingScreenReset.Visible = true;
                    endingScreenText.Visible = true;
                    mainMeny.BringToFront();
                    endingScreenText.Text = "You Lose!!";
                    endingScreen.Visible = true;
                    endingScreenText.Location = new Point(this.Width / 2 - endingScreenText.Width / 2, endingScreenText.Location.Y);
                }
            }

            private void help_Click(object sender, EventArgs e)
            {
                helpInformation.BringToFront();
                closeInformation.BringToFront();
            }

            private void closeInformation_Click(object sender, EventArgs e)
            {
                helpInformation.SendToBack();
                closeInformation.SendToBack();
            }

            private void enemyChoosingCharakter(object sender, EventArgs e)
            {
                randomvar = r.Next(1, 10);
                switch (randomvar)
                {
                    case 1:
                        Enemy.Image = Properties.Resources.firetortor;
                        NameOfEnemy.Text = "Fire Turtle";
                        enemyHealth = 1500;
                        EnemyHP.Text = "HP: " + enemyHealth.ToString();
                        enemyAnimal = "Turtle";
                        enemyElement = "Fire";
                        break;
                    case 2:
                        Enemy.Image = Properties.Resources.aguatortor;
                        NameOfEnemy.Text = "Water Turtle";
                        enemyHealth = 1500;
                        EnemyHP.Text = "HP: " + enemyHealth.ToString();
                        enemyAnimal = "Turtle";
                        enemyElement = "Water";
                        break;
                    case 3:
                        Enemy.Image = Properties.Resources.plonttortor;
                        NameOfEnemy.Text = "Grass Turtle";
                        enemyHealth = 1500;
                        EnemyHP.Text = "HP: " + enemyHealth.ToString();
                        enemyAnimal = "Turtle";
                        enemyElement = "Grass";
                        break;
                    case 4:
                        Enemy.Image = Properties.Resources.fayakat;
                        NameOfEnemy.Text = "Fire Cat";
                        enemyHealth = 750;
                        EnemyHP.Text = "HP: " + enemyHealth.ToString();
                        enemyAnimal = "Cat";
                        enemyElement = "Fire";
                        break;
                    case 5:
                        Enemy.Image = Properties.Resources.aguakat;
                        NameOfEnemy.Text = "Water Cat";
                        enemyHealth = 750;
                        EnemyHP.Text = "HP: " + enemyHealth.ToString();
                        enemyAnimal = "Cat";
                        enemyElement = "Water";
                        break;
                    case 6:
                        Enemy.Image = Properties.Resources.plontkat;
                        NameOfEnemy.Text = "Grass Cat";
                        enemyHealth = 750;
                        EnemyHP.Text = "HP: " + enemyHealth.ToString();
                        enemyAnimal = "Cat";
                        enemyElement = "Grass";
                        break;
                    case 7:
                        Enemy.Image = Properties.Resources.fayaDawge;
                        NameOfEnemy.Text = "Fire Dog";
                        enemyHealth = 1000;
                        EnemyHP.Text = "HP: " + enemyHealth.ToString();
                        enemyAnimal = "Dog";
                        enemyElement = "Fire";
                        break;
                    case 8:
                        Enemy.Image = Properties.Resources.aguaDawge;
                        NameOfEnemy.Text = "Water Dog";
                        enemyHealth = 1000;
                        EnemyHP.Text = "HP: " + enemyHealth.ToString();
                        enemyAnimal = "Dog";
                        enemyElement = "Water";
                        break;
                    default:
                        Enemy.Image = Properties.Resources.plontDawge;
                        NameOfEnemy.Text = "Grass Dog";
                        enemyHealth = 1000;
                        EnemyHP.Text = "HP: " + enemyHealth.ToString();
                        enemyAnimal = "Dog";
                        enemyElement = "Grass";
                        break;
                } //väljer ett random djur och ett random element till datorn och ger sedan den ett namn, en bild, liv, en typ och ett djur   
            }


            private void Start_Click(object sender, EventArgs e)
            {
                if (playerAnimal != null && playerElement != null) // checkar om spelaren har valt ett djur och ett element
                {
                    foreach (Control x in Controls)
                    {
                        if ((string)x.Tag == "startGUI")
                        {
                            x.Visible = false;
                            x.Enabled = false;
                        }
                    }
                    endingScreen.Visible = false;
                }


                if (playerAnimal == "Turtle" && playerElement == "Fire")
                {
                    Player.Image = Properties.Resources.firetortor;
                    NameOfPlayer.Text = "Fire Turtle";
                    PlayerHP.Text = "HP: " + playerHealth.ToString();
                } //Kollar vad användaren har valt och ger sedan användaren en bild, liv och ett namn
                else if (playerAnimal == "Turtle" && playerElement == "Water")
                {
                    Player.Image = Properties.Resources.aguatortor;
                    NameOfPlayer.Text = "Water Turtle";
                    PlayerHP.Text = "HP: " + playerHealth.ToString();
                }
                else if (playerAnimal == "Turtle" && playerElement == "Grass")
                {
                    Player.Image = Properties.Resources.plonttortor;
                    NameOfPlayer.Text = "Grass Turtle";
                    PlayerHP.Text = "HP: " + playerHealth.ToString();
                }
                else if (playerAnimal == "Cat" && playerElement == "Fire")
                {
                    Player.Image = Properties.Resources.fayakat;
                    NameOfPlayer.Text = "Fire Cat";
                    PlayerHP.Text = "HP: " + playerHealth.ToString();
                }
                else if (playerAnimal == "Cat" && playerElement == "Water")
                {
                    Player.Image = Properties.Resources.aguakat;
                    NameOfPlayer.Text = "Water Cat";
                    PlayerHP.Text = "HP: " + playerHealth.ToString();
                }
                else if (playerAnimal == "Cat" && playerElement == "Grass")
                {
                    Player.Image = Properties.Resources.plontkat;
                    NameOfPlayer.Text = "Grass Cat";
                    PlayerHP.Text = "HP: " + playerHealth.ToString();
                }
                else if (playerAnimal == "Dog" && playerElement == "Fire")
                {
                    Player.Image = Properties.Resources.fayaDawge;
                    NameOfPlayer.Text = "Fire Dog";
                    PlayerHP.Text = "HP: " + playerHealth.ToString();
                }
                else if (playerAnimal == "Dog" && playerElement == "Water")
                {
                    Player.Image = Properties.Resources.aguaDawge;
                    NameOfPlayer.Text = "Water Dog";
                    PlayerHP.Text = "HP: " + playerHealth.ToString();
                }
                else
                {
                    Player.Image = Properties.Resources.plontDawge;
                    NameOfPlayer.Text = "Grass Dog";
                    PlayerHP.Text = "HP: " + playerHealth.ToString();
                }

                enemyChoosingCharakter(sender, e);


            }



            private void pictureBox1_Click(object sender, EventArgs e)
            {
                //Den här gör inget men av någon anlednign får jag inte ta bort den. picturebox1 har inget click event men när jag tar bort denna så crashar formet
            }

        }
    }