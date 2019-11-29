using System;
using System.Collections.Generic;
using System.IO;

namespace Proyecto
{
    class Producto
    {
        public string codigo;
        public string descripcion;
        public double precio;
        public string departamento;
        public int likes;

        public Producto(string c, string d, double p, string m, int l){
            codigo = c; descripcion = d; precio = p; departamento = m; likes = l;
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
            productos.Add(new Producto("A54sa", "Placa Arduino", 14.23d, "Electronica", 13));
            productos.Add(new Producto("Dsda6", "Brazo metalico", 5.51d, "Mecanica", 54));
            productos.Add(new Producto("Edf51", "Laptop con pantalla LCD", 22200.23d, "Computacion", 68));
            productos.Add(new Producto("Psda9", "Multimetro", 500.36d, "Electricidad", 2));

            FileStream fs = new FileStream(@"Product.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter txtOut = new StreamWriter(fs);

            foreach(Producto p in productos){
                txtOut.Write(p.descripcion + " ");
                txtOut.Write(p.precio + " ");
                txtOut.Write(p.codigo + " ");
                txtOut.Write(p.departamento + " ");
                txtOut.WriteLine(p.likes);
            }
            txtOut.Close();
        }
    }
}
