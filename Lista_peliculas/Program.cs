using System;
using System.Collections.Generic;

namespace Lista_peliculas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona ("Luis"));
            personas.Add(new Persona ("Enrique"));
            personas.Add(new Persona ("Juan"));

            //Console.WriteLine("Hello World!");
        }
    }
}
