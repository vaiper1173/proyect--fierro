using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Practica_2_TAP
{
    public partial class Form1 : Form
    {
        bool sim = true;
        int turno = 1;
        int[,] Gato;
        int puntosJ1 = 0;
        int puntosJ2 = 0;
        string NomJ1;
        string NomJ2;
        bool hayGanador;
        int turnoContador = 0;
        int empate = 0;

        public Form1()
        {
            InitializeComponent();
            iniciojuego();
        }

        public void iniciojuego()
        {
            Gato = new int [3,3];
            int turno = 1;
            hayGanador = false;

            figurasGato.Controls.Clear();

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    var FiguraJuego = new PictureBox();
                    FiguraJuego.Image = Properties.Resources.Cuadrado;
                    FiguraJuego.Name = string.Format("{0}", i + " " + j);
                    FiguraJuego.Dock = DockStyle.Fill;
                    FiguraJuego.Cursor = Cursors.Hand;
                    FiguraJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    FiguraJuego.Click += Jugar;
                    figurasGato.Controls.Add(FiguraJuego, j, i);
                    Gato[i, j] = 0;
                }
            }

        }

        private void Jugar(object sender, EventArgs e)
        {
            var figuraSeleccionada = (PictureBox)sender;
            if (turno == 1)
            {
                figuraSeleccionada.Image = Properties.Resources.X;
            }
            else
            {
                figuraSeleccionada.Image = Properties.Resources.O;
            }
            string[] Posicion = figuraSeleccionada.Name.Split(" ".ToCharArray());
            int Fila = Convert.ToInt32(Posicion[0]);
            int Columna = Convert.ToInt32(Posicion[1]);
            Gato[Fila, Columna] = turno;
            VerificarJuego(Fila, Columna);
            turno = (turno == 1) ? 2 : 1;
        }

        public void VerificarJuego(int Fila, int Columna)
        {//Esto sirve para contar las figuras en las filas y las columnas
            int GFilas = 0;
            int GColumnas = 0;
            int DiagonalPrin = 0;
            int DiagonalInv = 0;
            int tamGato = 3;

            for (var i = 0; i < tamGato; i++)
            {
                for (var j = 0; j < tamGato; j++)
                {
                    if (i == Fila)
                    {
                        if (Gato[i, j] == turno)
                        {
                            GFilas++;

                            turnoContador++;

                        }
                    }
                    if (j == Columna)
                    {
                        if (Gato[i, j] == turno)
                        {
                            GColumnas++;
                            turnoContador++;
                        }
                    }
                    if (i == j)
                    {
                        if (Gato[i, j] == turno)
                        {
                            DiagonalPrin++;
                            turnoContador++;
                        }
                    }
                    if ((i + j) == (tamGato - 1))
                    {
                        if (Gato[i, j] == turno)
                        {
                            DiagonalInv++;
                            turnoContador++;
                        }
                    }
                }
            }

            if ((GFilas == tamGato) || (GColumnas == tamGato) || (DiagonalInv == tamGato) || (DiagonalPrin == tamGato))
            {
                hayGanador = true;
            }

            if (hayGanador)
            {
                string Ganador;
                MessageBox.Show("Hay un Ganador!");
                if (turno == 1)
                {
                    Ganador = NomJ1;
                    TextoGanador.Text = Ganador;
                    puntosJ1++;
                    ScoreJ1.Text = puntosJ1.ToString();
                }
                else if (turno == 2)
                {
                    Ganador = NomJ2;
                    TextoGanador.Text = Ganador;
                    puntosJ2++;
                    ScoreJ2.Text = puntosJ2.ToString();
                }
                else
                {
                    if (turnoContador == 9)
                    {
                        MessageBox.Show("Es un empate!");
                        empate++;
                        Empates.Text = "Es un empate!";
                    }
                }
            }
        }
        private void Reiniciar_Click(object sender, EventArgs e)
        {
            InicioJuego();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TextoGanador_Click(object sender, EventArgs e)
        {

        }

        private void EntradaNombreJ1_TextChanged(object sender, EventArgs e)
        {
            NomJ1 = EntradaNombreJ1.Text;
        }

        private void EntradaNombreJ2_TextChanged(object sender, EventArgs e)
        {
            NomJ2 = EntradaNombreJ2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InicioJuego();
        }

        private void Empates_Click(object sender, EventArgs e)
        {

        }
    }
}

        //Al chile no entendi lo que querias hacer pero lo guardare y lo usare de referencia
        /*private void boton1_clic(object sender, EventArgs pizo)
        {
            if (sim)
            {
                button1.Image = Image.FromFile("aqui va la direccion de la imagen, te encargo metas las imagenes en el repositorio :v");
                button1.Enabled = false;
            }
            else
            {
                sim = true;
                button1.Image = Image.FromFile("pues ya sabes no");
                button1.Enabled = false;
            }
        }
        
        private void tablero_click(object sender, EventArgs pizo)
        {
            if (sim)
            {
                sim = false;
                ((Button)sender).Image = Properties.Resources.O.png;
                ((Button)sender).Enabled = false;
            }
            else
            {
                sim = true;
                ((Button)sender).Image = Image.FromFile("la otra perra imagen");
                ((Button)sender).Enabled = false;
            }
        }

        private void boton_reinicio_clic(object sender, EventArgs pizo)
        {

            foreach (Control sano in Tablazo.Controls)
            {
                ((Button)sano).Image = null;
                sano.Enabled = true;
            }
            

        } */
    }
}
