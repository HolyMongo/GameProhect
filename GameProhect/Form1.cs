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



/*
 
Byt Nins special mot en kibabpizza

när man trycker på den så kommer det en kibabpizza

David kom på en bättre ide. Vi rickrollar philip med kibabpizzan istället för en kibabizza :)


 
*/


namespace GameProhect
{
    public partial class Form1 : Form
    {
      


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            nameOfTheGame.Location = new Point((this.Width / 2) - (nameOfTheGame.Width / 2), nameOfTheGame.Location.Y);
            start3IRad.Location = new Point((this.Width / 2) - (start3IRad.Width / 2) + 80, start3IRad.Location.Y);
            start2DPlatformer.Location = new Point((this.Width / 2) - (start2DPlatformer.Width / 2) - 80, start2DPlatformer.Location.Y);
            startNotPokemon.Location = new Point((this.Width / 2) - (startNotPokemon.Width / 2) + 80, startNotPokemon.Location.Y);
            startPizzaMedKebab.Location = new Point((this.Width / 2) - (startPizzaMedKebab.Width / 2) - 80, startPizzaMedKebab.Location.Y);
            nameOfTheGame.BackColor = Color.Transparent;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @"../../WiiShopMusic.wav";
            player.PlayLooping();
        }


        private void start2DPlatformer_MouseLeave(object sender, EventArgs e)
        {
            nameOfTheGame.Text = "Start";
            BackColor = Color.LightBlue;
            nameOfTheGame.Location = new Point((this.Width / 2) - (nameOfTheGame.Width / 2), nameOfTheGame.Location.Y);
        }

      
        private void Start3IRad_MouseLeave(object sender, EventArgs e)
        {
            nameOfTheGame.Text = "Start";
            BackColor = Color.LightBlue;
            nameOfTheGame.Location = new Point((this.Width / 2) - (nameOfTheGame.Width / 2), nameOfTheGame.Location.Y);
        }

        private void StartSnake_MouseLeave(object sender, EventArgs e)
        {
            nameOfTheGame.Text = "Start";
            BackColor = Color.LightBlue;
            nameOfTheGame.Location = new Point((this.Width / 2) - (nameOfTheGame.Width / 2), nameOfTheGame.Location.Y);
        }


        private void StartPizzaMedKebab_MouseLeave(object sender, EventArgs e)
        {
            nameOfTheGame.Text = "Start";
            BackColor = Color.LightBlue;
            nameOfTheGame.Location = new Point((this.Width / 2) - (nameOfTheGame.Width / 2), nameOfTheGame.Location.Y);
        }

       
        private void start2DPlatformer_MouseHover(object sender, EventArgs e)
        {
            nameOfTheGame.Text = "Bean adventure";
            BackColor = Color.FromArgb(169, 35, 94);
            nameOfTheGame.Location = new Point((this.Width / 2) - (nameOfTheGame.Width / 2), nameOfTheGame.Location.Y);
        }

        private void start3IRad_MouseHover(object sender, EventArgs e)
        {
            nameOfTheGame.Text = "3 I Rad";
            BackColor = Color.FromArgb(200, 0, 0);
            nameOfTheGame.Location = new Point((this.Width / 2) - (nameOfTheGame.Width / 2), nameOfTheGame.Location.Y);
        }

        private void startPizzaMedKebab_MouseHover(object sender, EventArgs e)
        {
            nameOfTheGame.Text = "Kebabbpizza";
            BackColor = Color.Purple;
            nameOfTheGame.Location = new Point((this.Width / 2) - (nameOfTheGame.Width / 2), nameOfTheGame.Location.Y);
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            nameOfTheGame.Text = "Start";
            BackColor = Color.LightBlue;
            nameOfTheGame.Location = new Point((this.Width / 2) - (nameOfTheGame.Width / 2), nameOfTheGame.Location.Y);
        }

        private void startNotPokemon_MouseHover(object sender, EventArgs e)
        {
            nameOfTheGame.Text = "Not Pokémon";
            BackColor = Color.FromArgb(0, 0, 200);
            nameOfTheGame.Location = new Point((this.Width / 2) - (nameOfTheGame.Width / 2), nameOfTheGame.Location.Y);
        }
        private void start2DPlatformer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
            
        }

        private void start3IRad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

       

        private void startNotPokemon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
        }


        private void startPizzaMedKebab_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
            this.Close();
        }
    }
}
