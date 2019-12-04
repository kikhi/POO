using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
        public Producto()
        {
        }
        
    }
    class productoDB
    {
        //Escribir producto
        public static void EscribeProductosTXT(string archivo, List<Producto> productos)
        {

            FileStream fs = new FileStream(archivo , FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter txtOut = new StreamWriter(fs);

            foreach(Producto p in productos)
            {
                txtOut.WriteLine(p.descripcion);
                txtOut.WriteLine(p.precio);
                txtOut.WriteLine(p.codigo);
                txtOut.WriteLine(p.departamento);
                txtOut.WriteLine(p.likes);
            }
            txtOut.Close();
        }
        //Leer producto
        public static List<Producto> LeeProductosTXT(string archivo)
        {
        List<Producto> productos = new List<Producto>();        
        using( StreamReader txtOut = new StreamReader(archivo))
        {
            foreach(Producto pb in productos)
            {
                txtOut.Write(pb.Codigo);
                txtOut.Write(pb.Descripcion);
                txtOut.Write(pb.Precio);
                txtOut.Write(pb.Departamento);
                txtOut.Write(pb.Likes);
            }

        }
        return productos;
        }
        
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

            productoDB.EscribeProductosTXT(@"productos.txt", productos);
                       

        }
    }
}
