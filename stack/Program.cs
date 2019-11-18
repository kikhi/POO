using System;

namespace stack
{
    class stack<T>
    {
        private T[] elementos;
        public int maximo;
        private int apuntador = 0;

        public Stack():this(100){}

        public Stack(int size){
            maximo = size;
            elementos = new T[maximo];
        }
        
        public void Push(T elemento){
            elementos[apuntador] = elemento;
            apuntador++;
        }    
        public T Pop(){
            apuntador--;
            return elementos[apuntador];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> nombres = new Stack<string>(4); 
            nombres.Push("Car");
            nombres.Push(" A");
            nombres.Push(" Melo");
            Console.Write(nombres.Pop());
            Console.Write(nombres.Pop());
            Console.Write(nombres.Pop());
        }
    }
}
