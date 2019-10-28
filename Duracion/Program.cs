using System;

namespace Duracion
{
    class Duracion
    {
        private string horas;
        private string minutos;
        private string segundos;

        public string Horas{
            get{ return horas; }
            set{ this.horas = horas; }
        }
        public string Minutos{
            get{ return minutos; }
            set{ this.minutos = minutos; }
        }
        public string Segundos{
            get{ return segundos; }
            set{ this.segundos = segundos; }
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

            Console.WriteLine("{0} : {1} : {2}", D.Segundos, D.Minutos, D.Horas);

        }
    }
}
