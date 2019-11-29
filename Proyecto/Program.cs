using System;
using System.Collections.Generic;
using System.IO;

namespace Proyecto
{
    class Producto
    {
        public string codigo;
        public string description;
        double Precio;
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
            productos.Add(new Producto("A54sa", "Placa Arduino", 14.23d));
            productos.Add(new Producto("Dsda6", "Led Verde", 5.51d));
            productos.Add(new Producto("Edf51", "Laptop con pantalla LCD", 22200.23d));
            productos.Add(new Producto("Psda9", "Multimetro", 500.36d));

            FileStream fs = new FileStream(@"Product.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter txtOut = new StreamWriter(fs);

            foreach(Producto p in productos){
                txtOut.Write(p.descripcion + "");
                txtOut.WriteLine(p.precio);
            }
            txtOut.Close();
        }
    }
}
