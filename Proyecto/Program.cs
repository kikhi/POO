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
        List<Producto> productos = new List<Producto>();

        //Escribir producto TXT
        public static void EscribeProductosTXT(string archivo, List<Producto> productos)
        {
            FileStream fs = new FileStream(archivo , FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter txtOut = new StreamWriter(fs);

            foreach(Producto p in productos)
            {
                txtOut.WriteLine("{0} {1} {2} {3} {4}", p.descripcion, p.precio, p.codigo, p.departamento, p.likes);
            }
            txtOut.Close();
        }

        
        //Leer producto TXT
        public static List<Producto> LeeProductosTXT(string archivo, List<Producto> productos)
        {
            //List<Producto> productos = new List<Producto>();        
            using( StreamReader sr = new StreamReader(archivo))
            {
                string line = "";
                while( (line =  sr.ReadLine()) != null ) // No lleguemos al final del archivo
                {
                string[] columnas = line.Split('|');            
                productos.Add( new Producto(columnas[0], columnas[1], Double.Parse(columnas[2]), columnas[3], int.Parse(columnas[4])) );
                }
            }
        return productos;
        }
        
        
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            productoDB p = new productoDB();
            
            productos.Add(new Producto("A54sa", "Placa Arduino", 14.23d, "Electronica", 13));
            productos.Add(new Producto("Dsda6", "Brazo metalico", 5.51d, "Mecanica", 54));
            productos.Add(new Producto("Edf51", "Laptop con pantalla LCD", 22200.23d, "Computacion", 68));
            productos.Add(new Producto("Psda9", "Multimetro", 500.36d, "Electricidad", 2));

            //Metodos de escritura
            productoDB.EscribeProductosTXT("productos.txt", productos);
            


            //Metodos de lectura
            List<Producto> productos_leidos = productoDB.LeeProductosTXT("productos.txt", productos);
                foreach(Producto p in productos_leidos)
                {    
                    Console.WriteLine("{0} {1} {2} {3} {4}", p.descripcion, p.precio, p.codigo, p.departamento, p.likes);
                }
        }
    }
}
