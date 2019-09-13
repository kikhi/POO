using System;
using System.Collections.Generic;

namespace Programa_basico_peliculas
{
    class Pelicula
    {
        private string titulo;
        //private int16 año;
        private string pais;
        private string director;

        public void SetTitulo(string titulo)
        {
            this.Titulo = titulo;
        }

        public String GetTitulo()
        {
            return this.Titulo;
        }

        public void SetAño(Int16 año)
        {
            this.Año = año;
        }

        public Int16 GetAño()
        {
            return this.Año;
        }

        public void SetDirector(string director)
        {
            this.Director = director;
        }

        public String GetDirector()
        {
            return this.Director;
        }

        public void SetPais(string pais)
        {
            this.Pais = pais;
        }

        public String GetPais()
        {
            return this.Pais;
        }
        
		public GetPeli(string titulo, Int16 año, string director, string pais) 
        {
			this.Titulo = titulo;
			this.Año = año;
            this.Director = director;
            this.Pais = pais;
		}

        public void print()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}\n", this.Titulo, this.Año, this.Director, this.Pais);
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
            p1.SetTitulo("Birdman");
            p1.SetAño(2016); 
            Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());

            Pelicula p2 = new Pelicula();
            p2.SetTitulo("Roma");
            p2.SetAño(2016); 
            Console.WriteLine("{0}({1})", p2.GetTitulo(), p2.GetAño());


        }
    }
}
