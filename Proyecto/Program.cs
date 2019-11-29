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
        
        public static void EscribeProductosTXT(string archivo,List<Producto> productos)
        {
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Write);
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

        public static void EscribeProductosBIN(string archivo, List<Producto> productos)
        {
            FileStream fs=new FileStream(archivo,FileMode.OpenOrCreate,FileAccess.Write);
            BinaryWriter binOut = new BinaryWriter(fs);
            foreach(Producto p in productos)
            {
                binOut.Write(p.descripcion + " ");
                binOut.Write(p.precio + " ");
                binOut.Write(p.codigo + " ");
                binOut.Write(p.departamento + " ");
                binOut.Write(p.likes);
            }
            binOut.Close();

            /*FileStream xd = new FileStream(archivo, FileMode.Open, FileAccess.Read);

            using(StreamReader sd = new StreamReader(archivo))
            {
                string s;
                do{
                    s = sd.ReadLine();
                    Console.WriteLine(s);

                }while(s != null);
            }*/
        
        }
    

        public static string GetDepartamento(string archivo, string departamento)
        {
            
            List<Producto> productos =new List<Producto>();
            FileStream fs = new FileStream(archivo,FileMode.Open,FileAccess.Read);

            using(StreamReader sr = new StreamReader(archivo))
            {
                string s;
                do{
                    s = sr.ReadLine();
                    Console.WriteLine(s);

                }while(s != null);
            
                if (departamento == "Computacion"){
                    Console.WriteLine("Edf51, Laptop con pantalla LCD, 22200.23d, Computacion, 68");
                }
            
                return archivo;
            }    
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
            productoDB.EscribeProductosBIN(@"productos.bin", productos);
            productoDB.GetDepartamento(@"productos.bin", "Computacion");
            
            

        }
    }
}
