using System;
using System.Collections.Generic;

namespace Lista_peliculas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> peliculas =new List<string>();
                peliculas.Add("IT");
                peliculas.Add("Titanic");
                peliculas.Add("Los increibles");
                peliculas.Add("La niebla");
                peliculas.Add("Red social");

            foreach(string Pelicula in peliculas)
            {
                Console.WriteLine(Pelicula);
            }
        }
    }
}
