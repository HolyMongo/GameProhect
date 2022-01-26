using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/*
 
Byt Nins special mot en kibabpizza

när man trycker på den så kommer det en kibabpizza


 
 */


namespace GameProhect
{
    public partial class Form1 : Form
    {

        int[] gameSelector = new int[3] {0, 1, 2};
        int gamePage;
        public Form1()
        {
            InitializeComponent();
            

        }

		private void Background_Click(object sender, EventArgs e)
		{

		}

        private void positiveSlide_Click(object sender, EventArgs e)
        {

        }

        private void start2DPlatformer_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(0, 200, 0);
            nameOfTheGame.Text = "2D Platformer";
            nameOfTheGame.Location = new Point(nameOfTheGame.Location.X - 86, nameOfTheGame.Location.Y);
        }

        private void start2DPlatformer_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
            nameOfTheGame.Text = "Start";
            nameOfTheGame.Location = new Point(nameOfTheGame.Location.X + 86, nameOfTheGame.Location.Y);
        }

        private void Start3IRad_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(200, 0, 0);
            nameOfTheGame.Text = "3 I Rad";
            nameOfTheGame.Location = new Point(nameOfTheGame.Location.X - 20, nameOfTheGame.Location.Y);
        }

        private void Start3IRad_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
            nameOfTheGame.Text = "Start";
            nameOfTheGame.Location = new Point(nameOfTheGame.Location.X + 20, nameOfTheGame.Location.Y);
        }

        private void StartSnake_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(0, 0, 200);
            nameOfTheGame.Text = "Snake";
        }

        private void StartSnake_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
            nameOfTheGame.Text = "Start";
        }

        private void StartPizzaMedKebab_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Purple;
            nameOfTheGame.Text = "Kebabbpizza";
            nameOfTheGame.Location = new Point(nameOfTheGame.Location.X - 65, nameOfTheGame.Location.Y);
        }

        private void StartPizzaMedKebab_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
            nameOfTheGame.Text = "Start";
            nameOfTheGame.Location = new Point(nameOfTheGame.Location.X + 65, nameOfTheGame.Location.Y);
        }
    }
}
