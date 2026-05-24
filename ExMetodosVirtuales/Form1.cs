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

            this.Text = "6 formas distintas con colores en distinto tamaño y color rgb";

            this.Width =1450;
            this.Height = 350;

            pictureBox1.Width = 1350;
            pictureBox1.Height = 230;

            pictureBox1.Left = 20;
            pictureBox1.Top = 1;

           
            dibujarButton.Left = 20;
            dibujarButton.Top = 270;



            figuras = new Figura[6] 
            {
                new Circulo(20,ColorAleatorio()),
                new Rectangulo(40,60,ColorAleatorio()),
                new Cuadrado(95,ColorAleatorio()),
                new TrianguloEquilatero(120,ColorAleatorio()),
                new TrianguloIsosceles(150,130,ColorAleatorio()),
                new Rombo (180,ColorAleatorio())
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
                figuras[i].Dibujar(gr, 1 + i * 140 , 40);
            }

        }
    }
}
