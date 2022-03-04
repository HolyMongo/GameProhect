
namespace GameProhect
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.NameOfPlayer = new System.Windows.Forms.Label();
            this.NameOfEnemy = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.attack2 = new System.Windows.Forms.Button();
            this.attack1 = new System.Windows.Forms.Button();
            this.attack3 = new System.Windows.Forms.Button();
            this.attack4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EnemyHP = new System.Windows.Forms.Label();
            this.PlayerHP = new System.Windows.Forms.Label();
            this.charPickingBackground = new System.Windows.Forms.PictureBox();
            this.turtle = new System.Windows.Forms.Button();
            this.cat = new System.Windows.Forms.Button();
            this.dog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.water = new System.Windows.Forms.Button();
            this.grass = new System.Windows.Forms.Button();
            this.fire = new System.Windows.Forms.Button();
            this.tank = new System.Windows.Forms.Label();
            this.dps = new System.Windows.Forms.Label();
            this.allInOne = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.help = new System.Windows.Forms.Button();
            this.helpInformation = new System.Windows.Forms.RichTextBox();
            this.closeInformation = new System.Windows.Forms.Button();
            this.endingScreen = new System.Windows.Forms.PictureBox();
            this.endingScreenText = new System.Windows.Forms.Label();
            this.endingScreenReset = new System.Windows.Forms.Button();
            this.mainMeny = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charPickingBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endingScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // Enemy
            // 
            this.Enemy.Location = new System.Drawing.Point(366, 59);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(150, 150);
            this.Enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy.TabIndex = 0;
            this.Enemy.TabStop = false;
            this.Enemy.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Player
            // 
            this.Player.Location = new System.Drawing.Point(12, 268);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(150, 150);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // NameOfPlayer
            // 
            this.NameOfPlayer.AutoSize = true;
            this.NameOfPlayer.Location = new System.Drawing.Point(12, 245);
            this.NameOfPlayer.Name = "NameOfPlayer";
            this.NameOfPlayer.Size = new System.Drawing.Size(111, 20);
            this.NameOfPlayer.TabIndex = 2;
            this.NameOfPlayer.Text = "NameOfPlayer";
            // 
            // NameOfEnemy
            // 
            this.NameOfEnemy.AutoSize = true;
            this.NameOfEnemy.Location = new System.Drawing.Point(362, 36);
            this.NameOfEnemy.Name = "NameOfEnemy";
            this.NameOfEnemy.Size = new System.Drawing.Size(117, 20);
            this.NameOfEnemy.TabIndex = 3;
            this.NameOfEnemy.Text = "NameOfEnemy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(225, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 168);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // attack2
            // 
            this.attack2.Location = new System.Drawing.Point(390, 328);
            this.attack2.Name = "attack2";
            this.attack2.Size = new System.Drawing.Size(137, 41);
            this.attack2.TabIndex = 5;
            this.attack2.Text = "button1";
            this.attack2.UseVisualStyleBackColor = true;
            this.attack2.Click += new System.EventHandler(this.attack2_Click);
            // 
            // attack1
            // 
            this.attack1.Location = new System.Drawing.Point(247, 328);
            this.attack1.Name = "attack1";
            this.attack1.Size = new System.Drawing.Size(137, 41);
            this.attack1.TabIndex = 6;
            this.attack1.Text = "button2";
            this.attack1.UseVisualStyleBackColor = true;
            this.attack1.Click += new System.EventHandler(this.attack1_Click);
            // 
            // attack3
            // 
            this.attack3.Location = new System.Drawing.Point(247, 375);
            this.attack3.Name = "attack3";
            this.attack3.Size = new System.Drawing.Size(137, 41);
            this.attack3.TabIndex = 8;
            this.attack3.Text = "button3";
            this.attack3.UseVisualStyleBackColor = true;
            this.attack3.Click += new System.EventHandler(this.attack3_Click);
            // 
            // attack4
            // 
            this.attack4.Location = new System.Drawing.Point(390, 375);
            this.attack4.Name = "attack4";
            this.attack4.Size = new System.Drawing.Size(137, 41);
            this.attack4.TabIndex = 7;
            this.attack4.Text = "button4";
            this.attack4.UseVisualStyleBackColor = true;
            this.attack4.Click += new System.EventHandler(this.attack4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "What will you do?";
            // 
            // EnemyHP
            // 
            this.EnemyHP.AutoSize = true;
            this.EnemyHP.Location = new System.Drawing.Point(362, 212);
            this.EnemyHP.Name = "EnemyHP";
            this.EnemyHP.Size = new System.Drawing.Size(164, 20);
            this.EnemyHP.TabIndex = 10;
            this.EnemyHP.Text = "HealthLeft/MaxHealth";
            // 
            // PlayerHP
            // 
            this.PlayerHP.AutoSize = true;
            this.PlayerHP.Location = new System.Drawing.Point(8, 421);
            this.PlayerHP.Name = "PlayerHP";
            this.PlayerHP.Size = new System.Drawing.Size(164, 20);
            this.PlayerHP.TabIndex = 11;
            this.PlayerHP.Text = "HealthLeft/MaxHealth";
            // 
            // charPickingBackground
            // 
            this.charPickingBackground.Location = new System.Drawing.Point(0, -2);
            this.charPickingBackground.Name = "charPickingBackground";
            this.charPickingBackground.Size = new System.Drawing.Size(542, 456);
            this.charPickingBackground.TabIndex = 12;
            this.charPickingBackground.TabStop = false;
            this.charPickingBackground.Tag = "startGUI";
            // 
            // turtle
            // 
            this.turtle.BackColor = System.Drawing.Color.White;
            this.turtle.Location = new System.Drawing.Point(47, 102);
            this.turtle.Name = "turtle";
            this.turtle.Size = new System.Drawing.Size(146, 68);
            this.turtle.TabIndex = 13;
            this.turtle.Tag = "startGUI";
            this.turtle.Text = "Turtle";
            this.turtle.UseVisualStyleBackColor = false;
            this.turtle.Click += new System.EventHandler(this.turtle_Click);
            // 
            // cat
            // 
            this.cat.BackColor = System.Drawing.Color.White;
            this.cat.Location = new System.Drawing.Point(199, 102);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(146, 68);
            this.cat.TabIndex = 14;
            this.cat.Tag = "startGUI";
            this.cat.Text = "Cat";
            this.cat.UseVisualStyleBackColor = false;
            this.cat.Click += new System.EventHandler(this.cat_Click);
            // 
            // dog
            // 
            this.dog.BackColor = System.Drawing.Color.White;
            this.dog.Location = new System.Drawing.Point(351, 102);
            this.dog.Name = "dog";
            this.dog.Size = new System.Drawing.Size(146, 68);
            this.dog.TabIndex = 15;
            this.dog.Tag = "startGUI";
            this.dog.Text = "Dog";
            this.dog.UseVisualStyleBackColor = false;
            this.dog.Click += new System.EventHandler(this.dog_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 16;
            this.label2.Tag = "startGUI";
            this.label2.Text = "Choose an animal!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 20;
            this.label3.Tag = "startGUI";
            this.label3.Text = "Pick an Element!";
            // 
            // water
            // 
            this.water.BackColor = System.Drawing.Color.White;
            this.water.Location = new System.Drawing.Point(351, 301);
            this.water.Name = "water";
            this.water.Size = new System.Drawing.Size(146, 68);
            this.water.TabIndex = 19;
            this.water.Tag = "startGUI";
            this.water.Text = "Water";
            this.water.UseVisualStyleBackColor = false;
            this.water.Click += new System.EventHandler(this.water_Click);
            // 
            // grass
            // 
            this.grass.BackColor = System.Drawing.Color.White;
            this.grass.Location = new System.Drawing.Point(199, 301);
            this.grass.Name = "grass";
            this.grass.Size = new System.Drawing.Size(146, 68);
            this.grass.TabIndex = 18;
            this.grass.Tag = "startGUI";
            this.grass.Text = "Grass";
            this.grass.UseVisualStyleBackColor = false;
            this.grass.Click += new System.EventHandler(this.grass_Click);
            // 
            // fire
            // 
            this.fire.BackColor = System.Drawing.Color.White;
            this.fire.Location = new System.Drawing.Point(47, 301);
            this.fire.Name = "fire";
            this.fire.Size = new System.Drawing.Size(146, 68);
            this.fire.TabIndex = 17;
            this.fire.Tag = "startGUI";
            this.fire.Text = "Fire";
            this.fire.UseVisualStyleBackColor = false;
            this.fire.Click += new System.EventHandler(this.fire_Click);
            // 
            // tank
            // 
            this.tank.AutoSize = true;
            this.tank.Location = new System.Drawing.Point(92, 173);
            this.tank.Name = "tank";
            this.tank.Size = new System.Drawing.Size(44, 20);
            this.tank.TabIndex = 21;
            this.tank.Tag = "startGUI";
            this.tank.Text = "Tank";
            // 
            // dps
            // 
            this.dps.AutoSize = true;
            this.dps.Location = new System.Drawing.Point(243, 173);
            this.dps.Name = "dps";
            this.dps.Size = new System.Drawing.Size(35, 20);
            this.dps.TabIndex = 22;
            this.dps.Tag = "startGUI";
            this.dps.Text = "dps";
            // 
            // allInOne
            // 
            this.allInOne.AutoSize = true;
            this.allInOne.Location = new System.Drawing.Point(399, 173);
            this.allInOne.Name = "allInOne";
            this.allInOne.Size = new System.Drawing.Size(74, 20);
            this.allInOne.TabIndex = 23;
            this.allInOne.Tag = "startGUI";
            this.allInOne.Text = "balanced";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(383, 410);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(133, 30);
            this.Start.TabIndex = 24;
            this.Start.Tag = "startGUI";
            this.Start.Text = "Ready!";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GameProhect.Properties.Resources.elementTable;
            this.pictureBox2.Location = new System.Drawing.Point(34, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(493, 12);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(34, 31);
            this.help.TabIndex = 26;
            this.help.Tag = "startGUI";
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // helpInformation
            // 
            this.helpInformation.Location = new System.Drawing.Point(0, -3);
            this.helpInformation.Name = "helpInformation";
            this.helpInformation.Size = new System.Drawing.Size(542, 456);
            this.helpInformation.TabIndex = 27;
            this.helpInformation.Tag = "startGUI";
            this.helpInformation.Text = resources.GetString("helpInformation.Text");
            // 
            // closeInformation
            // 
            this.closeInformation.Location = new System.Drawing.Point(492, 12);
            this.closeInformation.Name = "closeInformation";
            this.closeInformation.Size = new System.Drawing.Size(34, 31);
            this.closeInformation.TabIndex = 28;
            this.closeInformation.Tag = "startGUI";
            this.closeInformation.Text = "X";
            this.closeInformation.UseVisualStyleBackColor = true;
            this.closeInformation.Click += new System.EventHandler(this.closeInformation_Click);
            // 
            // endingScreen
            // 
            this.endingScreen.Location = new System.Drawing.Point(0, -2);
            this.endingScreen.Name = "endingScreen";
            this.endingScreen.Size = new System.Drawing.Size(542, 455);
            this.endingScreen.TabIndex = 29;
            this.endingScreen.TabStop = false;
            this.endingScreen.Tag = "endingGUI";
            // 
            // endingScreenText
            // 
            this.endingScreenText.AutoSize = true;
            this.endingScreenText.Location = new System.Drawing.Point(253, 60);
            this.endingScreenText.Name = "endingScreenText";
            this.endingScreenText.Size = new System.Drawing.Size(36, 20);
            this.endingScreenText.TabIndex = 30;
            this.endingScreenText.Text = "???";
            // 
            // endingScreenReset
            // 
            this.endingScreenReset.Location = new System.Drawing.Point(199, 214);
            this.endingScreenReset.Name = "endingScreenReset";
            this.endingScreenReset.Size = new System.Drawing.Size(133, 83);
            this.endingScreenReset.TabIndex = 31;
            this.endingScreenReset.Text = "Play again";
            this.endingScreenReset.UseVisualStyleBackColor = true;
            this.endingScreenReset.Click += new System.EventHandler(this.endingScreenReset_Click);
            // 
            // mainMeny
            // 
            this.mainMeny.Location = new System.Drawing.Point(366, 403);
            this.mainMeny.Name = "mainMeny";
            this.mainMeny.Size = new System.Drawing.Size(163, 35);
            this.mainMeny.TabIndex = 32;
            this.mainMeny.Text = "Back to main meny";
            this.mainMeny.UseVisualStyleBackColor = true;
            this.mainMeny.Click += new System.EventHandler(this.mainMeny_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameProhect.Properties.Resources.backdrop;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.help);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PlayerHP);
            this.Controls.Add(this.EnemyHP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attack3);
            this.Controls.Add(this.attack4);
            this.Controls.Add(this.attack1);
            this.Controls.Add(this.attack2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NameOfEnemy);
            this.Controls.Add(this.NameOfPlayer);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.allInOne);
            this.Controls.Add(this.dps);
            this.Controls.Add(this.tank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.water);
            this.Controls.Add(this.grass);
            this.Controls.Add(this.fire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dog);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.turtle);
            this.Controls.Add(this.charPickingBackground);
            this.Controls.Add(this.helpInformation);
            this.Controls.Add(this.closeInformation);
            this.Controls.Add(this.endingScreen);
            this.Controls.Add(this.endingScreenText);
            this.Controls.Add(this.endingScreenReset);
            this.Controls.Add(this.mainMeny);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charPickingBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endingScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Label NameOfPlayer;
        private System.Windows.Forms.Label NameOfEnemy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button attack2;
        private System.Windows.Forms.Button attack1;
        private System.Windows.Forms.Button attack3;
        private System.Windows.Forms.Button attack4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EnemyHP;
        private System.Windows.Forms.Label PlayerHP;
        private System.Windows.Forms.PictureBox charPickingBackground;
        private System.Windows.Forms.Button turtle;
        private System.Windows.Forms.Button cat;
        private System.Windows.Forms.Button dog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button water;
        private System.Windows.Forms.Button grass;
        private System.Windows.Forms.Button fire;
        private System.Windows.Forms.Label tank;
        private System.Windows.Forms.Label dps;
        private System.Windows.Forms.Label allInOne;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.RichTextBox helpInformation;
        private System.Windows.Forms.Button closeInformation;
        private System.Windows.Forms.PictureBox endingScreen;
        private System.Windows.Forms.Label endingScreenText;
        private System.Windows.Forms.Button endingScreenReset;
        private System.Windows.Forms.Button mainMeny;
    }
}