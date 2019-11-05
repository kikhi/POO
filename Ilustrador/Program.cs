using System;

namespace Ilustrador
{
    abstract class Figura 
    {
        protected int x;
        protected int y;
        protected string color;

        /*public Figura(int x, int y, string c){
            this.x = x; this.y = y; color = c;
        }*/

        public int X 
        {
            get {return x;}
            set {this.x = x;}
        }
        public int Y
        {
            get {return y;}
            set {this.y = y;}
        }
        public string Color 
        {
            get {return color;}
            set {this.color = color;}
        }
    }

        public void dibuja()
        {
            Console.WriteLine("Se dibuja una figura color {0}", color);
        }

        public void printColor() {
            Console.WriteLine(color);
        }
    }

    class Circulo : Figura {
        public Circulo(int x, int y, string c):base(x , y, c){
        }

        public new void dibuja(){
            Console.WriteLine("Se dibuja un circulo {0}", color);
        }
    }

     abstract class Rect : Figura {
        public Rect(int x, int y, string c):base(x , y, c){
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo(12,13,"verde")) ;
            figuras.Add(new Rect(12,13,"azul")) ;
            figuras.Add(new Rect(12,13,"rojo")) ;
            figuras.Add(new Circulo(12,13,"rojo")) ;
            foreach (var item in figuras){
                item.dibuja();
            }    
            Circulo r = new Circulo(10,10,"rojo");   
            r.dibuja();
            }
        }
    

