using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Practica_3_TAP
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool mover = false;
        Pen pincel; //Creamos la variable 
        

        public Form1()
        {
            InitializeComponent();
            g = Pizarra.CreateGraphics();
            pincel = new Pen(Color.Black, 5);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //Evita los dientes de sierra en el trazado (un Antialising
            pincel.StartCap = pincel.EndCap = System.Drawing.Drawing2D.LineCap.Round; 
        }
        private void Paleta_Click(object sender, EventArgs e)
        {   //Color de pincel
            PictureBox p = (PictureBox)sender; //Toma el color de los pictureBox y lo coloca en el pincel
            pincel.Color = p.BackColor;

        }

        private void panesiz_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pincel.Width = p.Width;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Herramientas_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
