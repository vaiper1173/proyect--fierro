namespace TicTacToe
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
            this.figurasGato = new System.Windows.Forms.TableLayoutPanel();
            this.jugador1Imagen = new System.Windows.Forms.PictureBox();
            this.jugador2Imagen = new System.Windows.Forms.PictureBox();
            this.ScoreJ1 = new System.Windows.Forms.Label();
            this.ScoreJ2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EntradaNombreJ1 = new System.Windows.Forms.TextBox();
            this.EntradaNombreJ2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextoGanador = new System.Windows.Forms.Label();
            this.Reiniciar = new System.Windows.Forms.Button();
            this.Empates = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jugador1Imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugador2Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // figurasGato
            // 
            this.figurasGato.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.figurasGato.ColumnCount = 3;
            this.figurasGato.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.figurasGato.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.figurasGato.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.figurasGato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.figurasGato.Location = new System.Drawing.Point(381, 48);
            this.figurasGato.Name = "figurasGato";
            this.figurasGato.RowCount = 3;
            this.figurasGato.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.figurasGato.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.figurasGato.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.figurasGato.Size = new System.Drawing.Size(357, 326);
            this.figurasGato.TabIndex = 0;
            // 
            // jugador1Imagen
            // 
            this.jugador1Imagen.BackgroundImage = global::TicTacToe.Properties.Resources.X;
            this.jugador1Imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jugador1Imagen.Location = new System.Drawing.Point(154, 107);
            this.jugador1Imagen.Name = "jugador1Imagen";
            this.jugador1Imagen.Size = new System.Drawing.Size(131, 134);
            this.jugador1Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jugador1Imagen.TabIndex = 1;
            this.jugador1Imagen.TabStop = false;
            // 
            // jugador2Imagen
            // 
            this.jugador2Imagen.BackgroundImage = global::TicTacToe.Properties.Resources.O;
            this.jugador2Imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jugador2Imagen.Location = new System.Drawing.Point(905, 107);
            this.jugador2Imagen.Name = "jugador2Imagen";
            this.jugador2Imagen.Size = new System.Drawing.Size(125, 134);
            this.jugador2Imagen.TabIndex = 2;
            this.jugador2Imagen.TabStop = false;
            // 
            // ScoreJ1
            // 
            this.ScoreJ1.AutoSize = true;
            this.ScoreJ1.BackColor = System.Drawing.Color.Transparent;
            this.ScoreJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreJ1.ForeColor = System.Drawing.Color.Coral;
            this.ScoreJ1.Location = new System.Drawing.Point(201, 283);
            this.ScoreJ1.Name = "ScoreJ1";
            this.ScoreJ1.Size = new System.Drawing.Size(84, 91);
            this.ScoreJ1.TabIndex = 5;
            this.ScoreJ1.Text = "0";
            this.ScoreJ1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ScoreJ2
            // 
            this.ScoreJ2.AutoSize = true;
            this.ScoreJ2.BackColor = System.Drawing.Color.Transparent;
            this.ScoreJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreJ2.ForeColor = System.Drawing.Color.Cyan;
            this.ScoreJ2.Location = new System.Drawing.Point(946, 283);
            this.ScoreJ2.Name = "ScoreJ2";
            this.ScoreJ2.Size = new System.Drawing.Size(84, 91);
            this.ScoreJ2.TabIndex = 6;
            this.ScoreJ2.Text = "0";
            this.ScoreJ2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(492, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 46);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ganador";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // EntradaNombreJ1
            // 
            this.EntradaNombreJ1.Location = new System.Drawing.Point(154, 428);
            this.EntradaNombreJ1.Name = "EntradaNombreJ1";
            this.EntradaNombreJ1.Size = new System.Drawing.Size(151, 22);
            this.EntradaNombreJ1.TabIndex = 8;
            this.EntradaNombreJ1.TextChanged += new System.EventHandler(this.EntradaNombreJ1_TextChanged);
            // 
            // EntradaNombreJ2
            // 
            this.EntradaNombreJ2.Location = new System.Drawing.Point(855, 428);
            this.EntradaNombreJ2.Name = "EntradaNombreJ2";
            this.EntradaNombreJ2.Size = new System.Drawing.Size(175, 22);
            this.EntradaNombreJ2.TabIndex = 9;
            this.EntradaNombreJ2.TextChanged += new System.EventHandler(this.EntradaNombreJ2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(44, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 38);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre Jugador";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(768, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre Jugador";
            // 
            // TextoGanador
            // 
            this.TextoGanador.AutoSize = true;
            this.TextoGanador.BackColor = System.Drawing.Color.Transparent;
            this.TextoGanador.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoGanador.ForeColor = System.Drawing.Color.Cyan;
            this.TextoGanador.Location = new System.Drawing.Point(526, 450);
            this.TextoGanador.Name = "TextoGanador";
            this.TextoGanador.Size = new System.Drawing.Size(84, 91);
            this.TextoGanador.TabIndex = 12;
            this.TextoGanador.Text = "_";
            this.TextoGanador.Click += new System.EventHandler(this.TextoGanador_Click);
            // 
            // Reiniciar
            // 
            this.Reiniciar.BackgroundImage = global::TicTacToe.Properties.Resources.CirculoFondo;
            this.Reiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reiniciar.ForeColor = System.Drawing.Color.Cyan;
            this.Reiniciar.Location = new System.Drawing.Point(381, 555);
            this.Reiniciar.Name = "Reiniciar";
            this.Reiniciar.Size = new System.Drawing.Size(177, 66);
            this.Reiniciar.TabIndex = 13;
            this.Reiniciar.Text = "Nuevo Juego";
            this.Reiniciar.UseVisualStyleBackColor = true;
            this.Reiniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Empates
            // 
            this.Empates.BackgroundImage = global::TicTacToe.Properties.Resources.CirculoFondo;
            this.Empates.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Empates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empates.ForeColor = System.Drawing.Color.Cyan;
            this.Empates.Location = new System.Drawing.Point(564, 555);
            this.Empates.Name = "Empates";
            this.Empates.Size = new System.Drawing.Size(174, 66);
            this.Empates.TabIndex = 14;
            this.Empates.Text = "Empates";
            this.Empates.UseVisualStyleBackColor = true;
            this.Empates.Click += new System.EventHandler(this.Empates_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.Landscape;
            this.ClientSize = new System.Drawing.Size(1111, 633);
            this.Controls.Add(this.Empates);
            this.Controls.Add(this.Reiniciar);
            this.Controls.Add(this.TextoGanador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EntradaNombreJ2);
            this.Controls.Add(this.EntradaNombreJ1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ScoreJ2);
            this.Controls.Add(this.ScoreJ1);
            this.Controls.Add(this.jugador2Imagen);
            this.Controls.Add(this.jugador1Imagen);
            this.Controls.Add(this.figurasGato);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gato";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jugador1Imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugador2Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel figurasGato;
        private System.Windows.Forms.PictureBox jugador1Imagen;
        private System.Windows.Forms.PictureBox jugador2Imagen;
        private System.Windows.Forms.Label ScoreJ1;
        private System.Windows.Forms.Label ScoreJ2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EntradaNombreJ1;
        private System.Windows.Forms.TextBox EntradaNombreJ2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TextoGanador;
        private System.Windows.Forms.Button Reiniciar;
        private System.Windows.Forms.Button Empates;
    }
}

