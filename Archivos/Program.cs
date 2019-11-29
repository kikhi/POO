using System;
using System.Collections.Generic;
using System.IO;

namespace Archivos
{
    class Producto
    {
        public string codigo, descripcion;
        public double precio;

        public Producto(string c, string d, double p){
            codigo = c; descripcion = d; precio = p;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto("AQW", "Lapiz Azul w2", 12.23d));
            productos.Add(new Producto("AQW", "Lapiz Verde w2", 12.23d));
            productos.Add(new Producto("AQW", "Pluma Azul w2", 22.23d));
            productos.Add(new Producto("AQW", "Borrador ww2", 22.23d));

            FileStream fs = new FileStream(@"Product.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter txtOut = new StreamWriter(fs);

            foreach(Producto p in productos){
                txtOut.Write(p.descripcion + "");
                txtOut.WriteLine(p.precio);
            }
            txtOut.Close();

            /*Console.WriteLine("captura el arrchivo a ocultar");

            string archivos = Console.ReadLine();

            File.SetAttributes(archivos, FileAttributes.Hidden);*/
        }
    }
}
