using System;
using System.Collections.Generic;

namespace FaceColon
{
    abstract class Publicacion
    {
        protected string fecha;
        protected string reaccion;
        protected string comentarios;

        public Publicacion(string fecha, string comentarios, string reaccion){
            this.fecha = fecha;
            this.reaccion = reaccion;
            this.comentarios = comentarios;
        }
        public abstract void imprime();
    }

    class Link : Publicacion
    {
        public Link(string fecha, string comentarios, string reaccion):base(fecha, comentarios, reaccion){
            
        }
        public override void imprime(){
            Console.WriteLine("Fecha: {0} Comentario: {1} Reaccion: {2}", fecha, comentarios, reaccion);
        }
    }

    class foto : Publicacion
    {
        public foto(string fecha, string comentarios, string reaccion):base(fecha, comentarios, reaccion){
        }
        public override void imprime(){
            Console.WriteLine("Fecha: {0} Cometario: {1} Reaccion: {2}", fecha, comentarios, reaccion);
        }
        
    }
    
    class Estado : Publicacion
    {
        public Estado(string fecha, string comentarios, string reaccion):base(fecha, comentarios, reaccion){
        }
        public override void imprime(){
            Console.WriteLine("La fecha de publicacion: {0} El cometario es: {1} La reaccion es: {2}", fecha, comentarios, reaccion);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            foto f = new foto("12/10/14","Que bueno que esten bien","Me divierte");
            Estado e = new Estado("21/03/19","Que cool foto","Me divierte");
            Link l = new Link("31/10/19","Buena","Me divierte");

            List<Publicacion> o = new List<Publicacion>();
            o.Add(f);
            o.Add(e);
            o.Add(l);

            foreach(Publicacion pu in o)
            {
                pu.imprime();
            }
        }
    }
}
