using System;
using System.Collections.Generic;

namespace Musico
{
    class Musico
    {
        protected string nombre;

        public Musico(string n){
            nombre = n;
        }
        public virtual void Afina(){
            Console.WriteLine("{0} Afinando su instrumento", nombre);
        }
        /* public void Saluda(){
            Console.WriteLine("Hola soy {0}", nombre);
        } */
        /* public string Saluda(){
            return String.Format("Hola soy {0}", nombre);
        }*/
        public override string Saluda(){
            return base.Saluda() + "soy basjista";
        }
    }
    class Bajista : Musico
    {
        private string bajo;
        
        public Bajista(string no, string b):base(no){
            bajo = b;
        }
        public override void Afina(){
            Console.WriteLine("{0} afinando su {1}", nombre, bajo);
        }
    }
    class Guitarrista : Musico
    {
        private string guitarra;

        public Guitarrista(string na, string e):base(na){
            guitarra = e;
        }

        public override void Afina(){
            Console.WriteLine("{0} afinando su {1}", nombre, guitarra);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Musico tom = new Musico("tom");
            Bajista flea = new Bajista("flea", "gibson");
            Guitarrista car = new Guitarrista("car", "yamaha");
            tom.Saluda();
            tom.Afina();
            flea.Saluda();
            flea.Afina();
            car.Saluda();
            car.Afina();

            List <Musico> grupo = new List<Musico>();
            grupo.Add(tom);
            grupo.Add(flea);
            grupo.Add(car);
            /* foreach(Musico m in grupo)
            {
                m.Saluda();
                m.Afina();
            }*/
            foreach(Musico m in grupo)
            {
                Console.WriteLine(m.Saluda());
                m.Afina();
            }
        }
    }
}
