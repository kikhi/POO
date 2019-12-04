using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Proyecto
{
    class Producto
    {
        public string codigo{set; get;}
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
        //Escribir producto TXT
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
        //Leer producto TXT
        public static List<Producto> LeeProductosTXT(string archivo)
        {
        List<Producto> productos = new List<Producto>();     
        FileStream fs = new FileStream(archivo , FileMode.Open, FileAccess.Read);   

        using( StreamReader txtIn = new StreamReader(fs))
        {
            while( txtIn.Read() != -1 )
            {
                Producto producto = new Producto();
                producto.codigo = txtIn.ReadLine();
                producto.descripcion = txtIn.ReadLine();
                producto.precio = txtIn.Read();
                producto.departamento = txtIn.ReadLine();
                producto.likes = txtIn.Read();
                productos.Add(producto);
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
            //productoDB.LeeProductosTXT(@"productos.txt");

            //Imprecion de lectura TXT
            List<Producto> productos_leidos = productoDB.LeeProductosTXT("productos.txt");

                foreach(Producto p in productos_leidos)
                {    
                    Console.WriteLine(p.codigo);
                    Console.WriteLine(p.descripcion);
                    Console.WriteLine(p.precio);
                    Console.WriteLine(p.departamento);
                    Console.WriteLine(p.likes);
                }



        }
    }
}
