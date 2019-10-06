using System;

namespace Ejemplo
{
    class Contador
    {

	    public void incrementa(int n) { 

	    }

	    public void incrementa(Contador c) { 

	    }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
        Contador c = new Contador();

        c.incrementa(1);
        int x = 2;

        c.incrementa(x);

        Contador c2 = new Contador();
        c2.incrementa(c);

        Console.WriteLine(c);
        }
    }
}
