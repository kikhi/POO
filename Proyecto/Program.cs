using System;
using System.IO;

namespace Proyecto
{
    class Producto
    {
        public string codigo;
        public string description;
        Decimal Precio = new Decimal();
        int departamento;
        int likes;

        public Producto(string c, string d, double p){
            codigo = c; descripcion = d; precio = p;
        }
    }
    class productoDB
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>();

            FileStream fs = new FileStream();
        }
    }
}
