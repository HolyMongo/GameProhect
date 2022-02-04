
namespace GameProhect
{
    partial class Form2
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
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(76, 155);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(120, 120);
            this.a1.TabIndex = 0;
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.a1_Click);
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(202, 155);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(120, 120);
            this.a2.TabIndex = 1;
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.a2_Click);
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(328, 155);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(120, 120);
            this.a3.TabIndex = 2;
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.a3_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(328, 281);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(120, 120);
            this.b3.TabIndex = 5;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(202, 281);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(120, 120);
            this.b2.TabIndex = 4;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(76, 281);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(120, 120);
            this.b1.TabIndex = 3;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(328, 407);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(120, 120);
            this.c3.TabIndex = 8;
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.c3_Click);
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(202, 407);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(120, 120);
            this.c2.TabIndex = 7;
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.c2_Click);
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(76, 407);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(120, 120);
            this.c1.TabIndex = 6;
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.c1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tic tac toe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "pick a box where u want to place an X";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(328, 547);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(120, 38);
            this.reset.TabIndex = 11;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(538, 597);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reset;
    }
}