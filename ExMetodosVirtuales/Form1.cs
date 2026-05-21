using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Figuras
{
    public partial class Form1 : Form
    {
        Figura[] figuras;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Colores distintos";

            figuras = new Figura[3] 
            {
                new Circulo(60,Color.Red),
                new Rectangulo(30,50,Color.Blue),
                new Cuadrado(45,Color.Green),
            };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
              //cada figura crea su propio pen segund el color en su constructor
            for (int i = 0; i < figuras.Length; i++)
            {
                figuras[i].Dibujar(gr,i * 100, 50);
            }

        }
    }
}
