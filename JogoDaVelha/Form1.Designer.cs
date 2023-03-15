namespace JogoDaVelha
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.ptJ1 = new System.Windows.Forms.Label();
            this.ptJ2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(10, 57);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(62, 62);
            this.b1.TabIndex = 0;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(78, 57);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(62, 62);
            this.b2.TabIndex = 1;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(146, 57);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(62, 62);
            this.b3.TabIndex = 2;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(10, 125);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(62, 62);
            this.b4.TabIndex = 3;
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(78, 125);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(62, 62);
            this.b5.TabIndex = 4;
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(146, 125);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(62, 62);
            this.b6.TabIndex = 5;
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(10, 193);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(62, 62);
            this.b7.TabIndex = 6;
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(78, 193);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(62, 62);
            this.b8.TabIndex = 7;
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(146, 193);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(62, 62);
            this.b9.TabIndex = 8;
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // ptJ1
            // 
            this.ptJ1.AutoSize = true;
            this.ptJ1.Location = new System.Drawing.Point(7, 9);
            this.ptJ1.Name = "ptJ1";
            this.ptJ1.Size = new System.Drawing.Size(94, 13);
            this.ptJ1.TabIndex = 9;
            this.ptJ1.Text = "Pontos Jogador X:";
            // 
            // ptJ2
            // 
            this.ptJ2.AutoSize = true;
            this.ptJ2.Location = new System.Drawing.Point(7, 31);
            this.ptJ2.Name = "ptJ2";
            this.ptJ2.Size = new System.Drawing.Size(95, 13);
            this.ptJ2.TabIndex = 10;
            this.ptJ2.Text = "Pontos Jogador O:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(215, 264);
            this.Controls.Add(this.ptJ2);
            this.Controls.Add(this.ptJ1);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha - Gabriel Siriani";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Label ptJ1;
        private System.Windows.Forms.Label ptJ2;
    }
}

