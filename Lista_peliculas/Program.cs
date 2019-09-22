using System;
using System.Collections.Generic;

namespace Lista_peliculas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pelicula> peliculas = new List<Pelicula>();

            peliculas.Add(new Pelicula ("IT"));
            peliculas.Add(new Pelicula ("Terror bajo la tierra"));
            peliculas.Add(new Pelicula ("La niebla"));
            peliculas.Add(new Pelicula ("Shrek"));
            peliculas.Add(new Pelicula ("Los increibles"));

            int count = 0;
            foreach (string element in pelicula)
            {
                count++;
                Console.WriteLine($"Element #{count}: {element}");
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
