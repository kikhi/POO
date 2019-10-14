using System;

namespace Herencia
{
    class Persona
    {
        protected string nombre;
        public string Nombre{get {return nombre;}}
        public Persona(string n){
            nombre = n;
            }
        public void print(){
            Console.WriteLine("Mi nombre es {0}", nombre);
            }
    }
    class Alumno : Persona
    {
        protected string num_control;
        public Alumno(string nombre, string num_control): base(nombre)
        {
            this.num_control = num_control;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persona tom = new Persona("Tom");
            Persona Jim = new Persona("Jim");

            tom.print();
            Jim.print();

            Alumno luis = new Alumno("Luis", "1621555");
            luis.print();
        }
    }
}
