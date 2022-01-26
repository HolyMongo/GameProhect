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
            this.Start3IRad = new System.Windows.Forms.Button();
            this.StartPizzaMedKebab = new System.Windows.Forms.Button();
            this.StartSnake = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start2DPlatformer
            // 
            this.start2DPlatformer.Location = new System.Drawing.Point(39, 280);
            this.start2DPlatformer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.start2DPlatformer.Name = "start2DPlatformer";
            this.start2DPlatformer.Size = new System.Drawing.Size(117, 63);
            this.start2DPlatformer.TabIndex = 0;
            this.start2DPlatformer.Text = "2D Platformer";
            this.start2DPlatformer.UseVisualStyleBackColor = true;
            this.start2DPlatformer.MouseEnter += new System.EventHandler(this.start2DPlatformer_MouseEnter);
            this.start2DPlatformer.MouseLeave += new System.EventHandler(this.start2DPlatformer_MouseLeave);
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
            // Start3IRad
            // 
            this.Start3IRad.Location = new System.Drawing.Point(294, 280);
            this.Start3IRad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Start3IRad.Name = "Start3IRad";
            this.Start3IRad.Size = new System.Drawing.Size(117, 63);
            this.Start3IRad.TabIndex = 2;
            this.Start3IRad.Text = "3 I Rad";
            this.Start3IRad.UseVisualStyleBackColor = true;
            this.Start3IRad.MouseEnter += new System.EventHandler(this.Start3IRad_MouseEnter);
            this.Start3IRad.MouseLeave += new System.EventHandler(this.Start3IRad_MouseLeave);
            // 
            // StartPizzaMedKebab
            // 
            this.StartPizzaMedKebab.Location = new System.Drawing.Point(294, 492);
            this.StartPizzaMedKebab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartPizzaMedKebab.Name = "StartPizzaMedKebab";
            this.StartPizzaMedKebab.Size = new System.Drawing.Size(117, 63);
            this.StartPizzaMedKebab.TabIndex = 4;
            this.StartPizzaMedKebab.Text = "Nils special";
            this.StartPizzaMedKebab.UseVisualStyleBackColor = true;
            this.StartPizzaMedKebab.MouseEnter += new System.EventHandler(this.StartPizzaMedKebab_MouseEnter);
            this.StartPizzaMedKebab.MouseLeave += new System.EventHandler(this.StartPizzaMedKebab_MouseLeave);
            // 
            // StartSnake
            // 
            this.StartSnake.Location = new System.Drawing.Point(39, 492);
            this.StartSnake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartSnake.Name = "StartSnake";
            this.StartSnake.Size = new System.Drawing.Size(117, 63);
            this.StartSnake.TabIndex = 3;
            this.StartSnake.Text = "Snake";
            this.StartSnake.UseVisualStyleBackColor = true;
            this.StartSnake.MouseEnter += new System.EventHandler(this.StartSnake_MouseEnter);
            this.StartSnake.MouseLeave += new System.EventHandler(this.StartSnake_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(478, 645);
            this.Controls.Add(this.StartPizzaMedKebab);
            this.Controls.Add(this.StartSnake);
            this.Controls.Add(this.Start3IRad);
            this.Controls.Add(this.nameOfTheGame);
            this.Controls.Add(this.start2DPlatformer);
            this.Name = "Form1";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start2DPlatformer;
        private System.Windows.Forms.Label nameOfTheGame;
        private System.Windows.Forms.Button Start3IRad;
        private System.Windows.Forms.Button StartPizzaMedKebab;
        private System.Windows.Forms.Button StartSnake;
    }
}

