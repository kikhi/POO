using System;

namespace Duracion
{
    class Duracion
    {
        public string horas;
        public string minutos;
        public string segundos;

        public string Horas{
            get{ return horas; }
            set{ horas = horas; }
        }
        public string Minutos{
            get{ return minutos; }
            set{ minutos = minutos; }
        }
        public string Segundos{
            get{ return segundos; }
            set{ segundos = segundos; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Duracion D = new Duracion();
            D.Horas = "3";
            D.Minutos = "26";
            D.Segundos = "4";

            Console.WriteLine("La duracion es: {0} : {1} : {2}", D.Segundos, D.Minutos, D.Horas);

        }
    }
}
