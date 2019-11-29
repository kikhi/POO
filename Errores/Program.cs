using System;

namespace Errores
{
    class Program
    {
        static void Main(string[] args)
        {
            //int valor;
            Console.WriteLine("Ingresa tu edad:");
            //string captura = Console.ReadLine();
            /*valor = int.Parse(captura);

            Console.WriteLine("En diez años tenndras {0}", valor + 10);
            Console.ReadKey();*/

            try
            {
                string captura = Console.ReadLine();
                int valor = int.Parse(captura);
                Console.WriteLine(valor);
            }
            catch(FormatException)
            {
                Console.WriteLine("Formato incorrecto");
            }

           
        }
    }
}
