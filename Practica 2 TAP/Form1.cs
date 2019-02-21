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

        public Form1()
        {
            InitializeComponent();
        }

        private void boton1_clic(object sender, EventArgs pizo)
        {
            if (sim)
            {
                button1.Image = Image.FromFile("aqui va la direccion de la imagen, te encargo metas las imagenes en el repositorio :v");
                button1.Enabled = false;
            }
            else
            {
                sim = true;
                button1.Image = Image.FromFile("pues ya saves no");
                button1.Enabled = false;
            }
        }
        private void tablero_click(object sender, EventArgs pizo)
        {
            if (sim)
            {
                sim = false;
                ((Button)sender).Image = Image.FromFile("la otra imagen");
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

        } 
    }
}
