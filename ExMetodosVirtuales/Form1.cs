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
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            this.Text = "5 formas disntinas con colores en distinto tamaño y color rgb";

            this.Width = 800;
            this.Height = 300;

            pictureBox1.Width = 750;
            pictureBox1.Height = 200;

            figuras = new Figura[5] 
            {
                new Circulo(20,ColorAleatorio()),
                new Rectangulo(40,60,ColorAleatorio()),
                new Cuadrado(95,ColorAleatorio()),
                new Triangulo(120,ColorAleatorio()),
                new Rombo (150,ColorAleatorio())
            };

        }

        private Color ColorAleatorio()
            {
             return Color.FromArgb(
                 random.Next(256),
                 random.Next(256),
                 random.Next(256)

                 );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
              //cada figura crea su propio pen segund el color en su constructor
            for (int i = 0; i < figuras.Length; i++)
            {   // aumento la cordenada x para que halla mas espacio entre cada figura
                figuras[i].Dibujar(gr, 15+ i * 125, 50);
            }

        }
    }
}
