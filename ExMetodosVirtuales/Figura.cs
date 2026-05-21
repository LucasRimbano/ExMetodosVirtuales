using System;
using System.Drawing;

namespace Figuras
{
    public class Figura
    {
        protected Color color;
        
        public Figura(Color color)
         { this.color = color; }

        public virtual void Dibujar(Graphics graphics, int x, int y)
        { 
            
        }
        protected Pen CrearPen()
        {
            return new Pen(color,3);
        }
    }


    public class Rectangulo : Figura
    {
        protected int alto;
        protected int ancho;

        // heredo de figura el color con : que seria similar a inherits en wollok
        public Rectangulo(int ancho, int alto,Color color) : base(color) 
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        public override void Dibujar(Graphics graphics, int x, int y)
        {
            Pen pen = CrearPen();

            Point[] points = new Point[4]
            { 
                new Point(x,y), 
                new Point(x+ancho,y), 
                new Point(x+ancho,y+alto), 
                new Point(x,y+alto) 
            };
            // DrawPolygon dibuja un poligono dado un conjunto de puntos y un lapiz
            graphics.DrawPolygon(pen, points);
        }
    }

    public class Cuadrado : Rectangulo
    {
        // Constructor. Un cuadrado es un rectangulo con ancho = alto
        public Cuadrado(int lado,Color color) : base(lado,lado,color)
        {
        }
    }


    public class Circulo : Figura
    {
        private int radio;

        // Constructor
        public Circulo(int radio,Color color) :base(color)
        {
            this.radio= radio;
        }

        public override void Dibujar(Graphics graphics, int x, int y)
        {   Pen pen = CrearPen();
            graphics.DrawEllipse(pen,x,y, radio, radio);
        }
    }
}
