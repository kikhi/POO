using System;

namespace Pase_parametros
{
    class Robot_poliarticulado
    {
        public movimiento_horizontal(ref int m){
            m = m * 10;
        }
    }
    class Nave_espacial
    {
        public posicion(in int p){}
    }
    
    class Program
    {
        static void Carro(int d,int t,out int km){
            km = d*t;
        }
        static int Carro(int n1,int n2){
            return d*t;
        }

        static void Main(string[] args)
        {
            Robot_poliarticulado x = new Robot_poliarticulado();
            int z = 2;
            m.movimiento_horizontal(ref z);
            Console.WriteLine(z);

            Nave_espacial pos = new Nave_espacial();
            int p = 10;
            p = p * 1000;
            res.re(in p);
            Console.WriteLine(p);

            int km;
            Carro(d,t,out km);
            Console.WriteLine(Carro(d,t));
        }
    }
}
