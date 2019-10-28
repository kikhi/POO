using System;
using System.Collections.Generic;

namespace Figuras
{
    abstract class Figuras
    {
        protected int ancho, alto;
        protected int px, py;
        protected string color_relleno, color_borde;

        public Figuras(int ancho, int alto, int px, int py, string color_relleno, string color_borde){
            this.ancho = ancho;
            this.alto = alto;
            this.px = px;
            this.py = py;
            this.color_relleno = color_relleno;
            this.color_borde = color_borde;
        }
        
        public abstract void dibuja();
        
    }

     abstract class  Retangulo:Figuras
    {
        public Rectangulo(string color_relleno, int px, int py):base(string color,int px, int py){

        }
        public override void dibuja(string color_relleno, int px, int py){
            Console.WriteLine("Se dibuja un rectangulo color {0}, en X{1} y Y:{2}", color_relleno, px, py);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Figuras> figuras = new List<Figuras>();
            figuras.Add(new Rectangulo(10, 10));
            //Console.WriteLine("Hello World!");
        }
    }
}
