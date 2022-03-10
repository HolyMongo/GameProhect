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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Size = pictureBox1.Size;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @"../../Holymusic.wav";
            player.PlayLooping();
        }
    }
}
