using System;

namespace Alumnos
{
    class Alumno
    {
        protected string nombre;
        protected string num_control;
        protected string edad;
        protected string carrera;

        public Alumnos(string nombre, string num_control, string edad, string carrera){
            this.nombre = nombre;
            this.num_control;
            this.edad = edad;
            this.carrera = carrera;
        }

        public virtual void print()
        {
            Console.WriteLine("Datos del alumno");
            Console.WriteLine("Numero de control: {0}\n Numero de control: {1}\n Edad: {2}\n Carrera: {3}", nombre, num_control, edad, carrera);
        }
    }
    class Licenciatura : Alumno
    {
        protected string departamento;
        protected string especialidad;

        public Licenciatura(string nombre, string carrera, string num_control, string carrera, string departamento, string especialidad):base(nombre,num_control, edad, carrera){
            this.departamento = departamento;
            this.especialidad = especialidad;
        }

        public override void print(){
            Console.WriteLine("Datos del alumno");
            Console.WriteLine("Numero de control: {0}\n Numero de control: {1}\n Edad: {2}\n Carrera: {3} \n departamento {4}\n especalidad {5}\n", nombre, num_control, edad, carrera, departamento, especialidad);
        } 
    } 
    class Posgrado : Alumno
    {
        protected string area_investigsaion;

        public Posgrado(string nombre, string num_control, string edad, string this.area_investigsaion):base(nombre, num_control, especialidad){
            this.area_investigsaion = area_investigsaion;
        }

        public new void print(){
            Console.WriteLine("Datos del alumno");
            Console.WriteLine("Numero de control: {0}\n Numero de control: {1}\n Edad: {2}\n Carrera {3}\n investigacion:", nombre, num_control, edad, carrera, area_investigsaion);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Alumno Luis = new Alumno("Luis", "193025", "19", "Ing. sistemas");
            Licenciatura Joshua = new Licenciatura("Josha", "1954523", "20", "Ing. Sistemas", "Sistemas y Computacion", "Robotica");
            Posgrado Cesar = new Posgrado("Luis", "193025", "19", "Ing. sistemas", "Robotica y mecatronica")
            
            Luis.print();
            joshua.print();
            Cesar.print();
        }
    }
}
