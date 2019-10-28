using System;

namespace Duracion
{
    class Duracion
    {
        private string horas;
        private string minutos;
        private string segundos;

        public string horas{
            get{ return horas; }
            set{ this.horas = horas; }
        }
        public string minutos{
            get{ return minutos; }
            set{ this.minutos = minutos; }
        }
        public string segundos{
            get{ return segundos; }
            set{ this.segundos = segundos; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
