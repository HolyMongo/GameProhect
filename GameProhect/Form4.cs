
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
            double playerHealth = 1000, enemyHealth = 1000, playerDamage = 300, enemyDamage = 200; //instansierar viktiga variabler som vi kommer att behöva. Dessa är bas värden som kommer ändars beroende på vad användaren väljer för gubbe

            string playerAnimal, playerElement, enemyAnimal, enemyElement; //instansierar viktiga variabler för att kunna checka om attacker är effektivia eller inte

            Random r = new Random();
            int randomvar;

            public Form4()
            {
                InitializeComponent();
            }
            private void Form4_Load(object sender, EventArgs e) //Händer när man öppnar formen första gången
            {
                bringUpCharSelect(sender, e);//Kallar på en metod som tar upp en GUI för att välja gubbe
                splayer.SoundLocation = @"../../BAttlemusique.wav"; //Letar på rätt ljudfil
                splayer.PlayLooping();//spelar och loopar musiken/ljudfilen
            }

            private void bringUpCharSelect(object sender, EventArgs e) //tar fram GUI för att välja gubbe
            {
            //Om det står char följt av något annat tex charpickingbackground så betyder det characterpickingbackground
                charPickingBackground.BringToFront();
                charPickingBackground.Visible = true;
                charPickingBackground.Enabled = true;
                foreach (Control x in Controls)
                {
                    if ((string)x.Tag == "startGUI" && x is Button || x is Label && (string)x.Tag == "startGUI") //Letar på alla controller som har taggen startGUI och sedan gör så att de ligger överst
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


            //De nästa 6 metoder är knappar i charackterselection menyn som byter element och djur. De ställer även in hp och attack tex om du clickar på "turtle" så får du 1500 liv istället för 1000 och 200 attackskada istället för 300
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
                playerHealth = 1000;
                playerDamage = 300;
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
                playerDamage = 400;
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
                playerDamage = 200;
                turtle.BackColor = Color.FromArgb(100, 100, 100);
                cat.BackColor = Color.White;
                dog.BackColor = Color.White;
                attack3.Text = "Hide";
                attack4.Text = "jaw snap";
            }

        //De nästa 4 metoderna är metoder som händer när du klickar på en av de 4 attackerna. De gör skada på motståndaren och sedan kallar på en metod som använder en random attack av motståndaren och gör sedan skada på dig

            private void attack1_Click(object sender, EventArgs e)
            {


                if (playerElement == "Fire") //checkar vilket element användaren har och sedan vilket element motståndaren har för att avgöra hur mycket skada som ska göras. Det finns ingen sak som checkar samma element som användaren (tex om användaren är "Fire" så finns det ingen som checkar om motståndaren är "Fire") eftersom att den inta ska göra skada så är det onädigt att ha med den
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
                enemyattack(sender, e);//kallar på metoden som attackerar åt motståndaren och gör skada på spelaren
                EnemyHP.Text = enemyHealth.ToString(); //Den här och den under updaterar lables på skärmen så att du ser hur mycket liv både du och motståndaren har
                PlayerHP.Text = playerHealth.ToString();

            }

            private void attack2_Click(object sender, EventArgs e)
            {
                if (playerElement == "Fire")//checkar vilket element användaren har och sedan vilket element motståndaren har för att avgöra hur mycket skada som ska göras. Det finns ingen sak som checkar samma element som användaren (tex om användaren är "Fire" så finns det ingen som checkar om motståndaren är "Fire") eftersom att den inta ska göra skada så är det onädigt att ha med den
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
                enemyattack(sender, e);//kallar på metoden som attackerar åt motståndaren och gör skada på spelaren
                EnemyHP.Text = enemyHealth.ToString();//Den här och den under updaterar lables på skärmen så att du ser hur mycket liv både du och motståndaren har
                PlayerHP.Text = playerHealth.ToString();


            }

            private void attack3_Click(object sender, EventArgs e)
            {
                //Attack3 och Attack 4 är normaltyper och gör atlltid lika mycket skada vilket betyder att de inte behöver en sak som checkar typerna p åattacker och motståndaren
                enemyHealth -= playerDamage;
                enemyattack(sender, e);//kallar på metoden som attackerar åt motståndaren och gör skada på spelaren
                EnemyHP.Text = enemyHealth.ToString();//Den här och den under updaterar lables på skärmen så att du ser hur mycket liv både du och motståndaren har
                PlayerHP.Text = playerHealth.ToString();

            }

            private void attack4_Click(object sender, EventArgs e)
            {
                //Attack3 och Attack 4 är normaltyper och gör atlltid lika mycket skada vilket betyder att de inte behöver en sak som checkar typerna p åattacker och motståndaren
                enemyHealth -= playerDamage; //Gör skada
                enemyattack(sender, e); //kallar på metoden som attackerar åt motståndaren och gör skada på spelaren
                EnemyHP.Text = enemyHealth.ToString();//Den här och den under updaterar lables på skärmen så att du ser hur mycket liv både du och motståndaren har
                PlayerHP.Text = playerHealth.ToString();

            }


            private void enemyattack(object sender, EventArgs e) //Attackerar åt motståndaren
            {
                Random r = new Random();
                int randomvar = r.Next(1, 4);//tar fram ett randomnummer och sedan kollar vilken attack som ska användas med samma principer som när användaren attackerar.


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

            private void endingScreenReset_Click(object sender, EventArgs e) //skickar allt på slutskärmen längs bac bakom allt och gör det osynligt coh sedan kallar på metoden som gör att du kan välja djur och element
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
        }



            private void mainMeny_Click(object sender, EventArgs e)//Stänger ner den här formen och öppnar formet där du får välja spel
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                splayer.Stop();
                this.Close();
            }

            private void checkDeath(object sender, EventArgs e)//checkar om spelarens eller datorns liv är =< 0. Om den är det så tas slutskärmen upp där du får veta om du vann eller förlorade, om du vill köra igen och om du vill gå tillbaka till startmenyn(där du väljer alla spel)
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
                    endingScreenText.Location = new Point(this.Width / 2 - endingScreenText.Width / 2, endingScreenText.Location.Y);//sätter texten som säger att du vann i mitten av skärmen
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
                    endingScreenText.Location = new Point(this.Width / 2 - endingScreenText.Width / 2, endingScreenText.Location.Y);//sätter texten som säger att du vann i mitten av skärmen
            }
            }

            private void help_Click(object sender, EventArgs e) //Tar upp en textruta med information om spelet
            {
                helpInformation.BringToFront();
                closeInformation.BringToFront();
            }

            private void closeInformation_Click(object sender, EventArgs e)//Stänger ner rutan som talar om hur man kör spelet
            {
                helpInformation.SendToBack();
                closeInformation.SendToBack();
            }

            private void enemyChoosingCharakter(object sender, EventArgs e)//Väljer ett random djur och element till datorn/motståndaren
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


            private void Start_Click(object sender, EventArgs e) //startar själva spelet efter att spelaren har val djur och element
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


                if (playerAnimal == "Turtle" && playerElement == "Fire") //Byter Namn, bild och liv beroende på vad användaren har valt
                {
                    Player.Image = Properties.Resources.firetortor;
                    NameOfPlayer.Text = "Fire Turtle";
                    PlayerHP.Text = "HP: " + playerHealth.ToString();
                } 
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

                enemyChoosingCharakter(sender, e); //Kallar på metoden som väljer djur och element till motståndaren/datorn


            }



            private void pictureBox1_Click(object sender, EventArgs e)
            {
                //Den här gör inget men av någon anlednign får jag inte ta bort den. picturebox1 har inget click event men när jag tar bort denna så crashar formen
            }

        }
    }