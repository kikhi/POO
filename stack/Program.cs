using System;

namespace stack
{
    class stack<T>
    {
        private T[] elementos;
        readonly int maximo;
        private int apuntador = 0;

        public Stack():this(100){}

         public Stack(int size)
        {
            maximo = size;
            elementos = new T[maximo];
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
