namespace GameProhect
{
    partial class Form1
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
            this.start2DPlatformer = new System.Windows.Forms.Button();
            this.nameOfTheGame = new System.Windows.Forms.Label();
            this.start3IRad = new System.Windows.Forms.Button();
            this.startPizzaMedKebab = new System.Windows.Forms.Button();
            this.startNotPokemon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start2DPlatformer
            // 
            this.start2DPlatformer.Location = new System.Drawing.Point(39, 280);
            this.start2DPlatformer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.start2DPlatformer.Name = "start2DPlatformer";
            this.start2DPlatformer.Size = new System.Drawing.Size(117, 62);
            this.start2DPlatformer.TabIndex = 0;
            this.start2DPlatformer.Text = "2D Platformer";
            this.start2DPlatformer.UseVisualStyleBackColor = true;
            this.start2DPlatformer.Click += new System.EventHandler(this.start2DPlatformer_Click);
            this.start2DPlatformer.MouseLeave += new System.EventHandler(this.start2DPlatformer_MouseLeave);
            this.start2DPlatformer.MouseHover += new System.EventHandler(this.start2DPlatformer_MouseHover);
            // 
            // nameOfTheGame
            // 
            this.nameOfTheGame.AutoSize = true;
            this.nameOfTheGame.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfTheGame.Location = new System.Drawing.Point(152, 25);
            this.nameOfTheGame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameOfTheGame.Name = "nameOfTheGame";
            this.nameOfTheGame.Size = new System.Drawing.Size(193, 84);
            this.nameOfTheGame.TabIndex = 1;
            this.nameOfTheGame.Text = "Start";
            // 
            // start3IRad
            // 
            this.start3IRad.Location = new System.Drawing.Point(294, 280);
            this.start3IRad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.start3IRad.Name = "start3IRad";
            this.start3IRad.Size = new System.Drawing.Size(117, 62);
            this.start3IRad.TabIndex = 2;
            this.start3IRad.Text = "3 I Rad";
            this.start3IRad.UseVisualStyleBackColor = true;
            this.start3IRad.Click += new System.EventHandler(this.start3IRad_Click);
            this.start3IRad.MouseLeave += new System.EventHandler(this.Start3IRad_MouseLeave);
            this.start3IRad.MouseHover += new System.EventHandler(this.start3IRad_MouseHover);
            // 
            // startPizzaMedKebab
            // 
            this.startPizzaMedKebab.Location = new System.Drawing.Point(294, 492);
            this.startPizzaMedKebab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startPizzaMedKebab.Name = "startPizzaMedKebab";
            this.startPizzaMedKebab.Size = new System.Drawing.Size(117, 62);
            this.startPizzaMedKebab.TabIndex = 4;
            this.startPizzaMedKebab.Text = "Nils special";
            this.startPizzaMedKebab.UseVisualStyleBackColor = true;
            this.startPizzaMedKebab.Click += new System.EventHandler(this.startPizzaMedKebab_Click);
            this.startPizzaMedKebab.MouseLeave += new System.EventHandler(this.StartPizzaMedKebab_MouseLeave);
            this.startPizzaMedKebab.MouseHover += new System.EventHandler(this.startPizzaMedKebab_MouseHover);
            // 
            // startNotPokemon
            // 
            this.startNotPokemon.Location = new System.Drawing.Point(39, 492);
            this.startNotPokemon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startNotPokemon.Name = "startNotPokemon";
            this.startNotPokemon.Size = new System.Drawing.Size(117, 62);
            this.startNotPokemon.TabIndex = 3;
            this.startNotPokemon.Text = "Not Pokémon";
            this.startNotPokemon.UseVisualStyleBackColor = true;
            this.startNotPokemon.Click += new System.EventHandler(this.startNotPokemon_Click);
            this.startNotPokemon.MouseLeave += new System.EventHandler(this.StartSnake_MouseLeave);
            this.startNotPokemon.MouseHover += new System.EventHandler(this.startNotPokemon_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(478, 645);
            this.Controls.Add(this.startPizzaMedKebab);
            this.Controls.Add(this.startNotPokemon);
            this.Controls.Add(this.start3IRad);
            this.Controls.Add(this.nameOfTheGame);
            this.Controls.Add(this.start2DPlatformer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start2DPlatformer;
        private System.Windows.Forms.Label nameOfTheGame;
        private System.Windows.Forms.Button start3IRad;
        private System.Windows.Forms.Button startPizzaMedKebab;
        private System.Windows.Forms.Button startNotPokemon;
    }
}

