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
        

        //Escribir producto TXT
        public static void EscribeProductosTXT(string archivo, List<Producto> productos)
        {
            try
            {
            FileStream fs = new FileStream(archivo , FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter txtOut = new StreamWriter(fs);

            foreach(Producto p in productos)
            {
                txtOut.WriteLine("{0} {1} {2} {3} {4}", p.descripcion, p.precio, p.codigo, p.departamento, p.likes);
                Console.WriteLine("{0} {1} {2} {3} {4}", p.descripcion, p.precio, p.codigo, p.departamento, p.likes);
            }
            txtOut.Close();
            }catch(Exception e){
                Console.WriteLine("Hubo un error");
                Console.WriteLine(e.Message);
            }
        }

        
        //Leer producto TXT
        public void LeerProductosTXT(string archivo, List<Producto> productos){
			try
			{			
				FileStream fs1=new FileStream(archivo,FileMode.Open,FileAccess.Read);//crea
				using(StreamReader txtOut=new StreamReader(fs1)){//transcribe
					string line;				
					while((line = txtOut.ReadLine()) != null){//para que valla checando renglon x renglon
						string[] columnas = line.Split("|");//para dividir el constructor
						productos.Add(new Producto(columnas[0], columnas[1], double.Parse(columnas[2]), columnas[3], int.Parse(columnas[4])));
					}
				}
			}
			catch( Exception e){
                Console.WriteLine("Hubo un error");
                Console.WriteLine(e.Message);
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

            //Metodos de escritura
            productoDB.EscribeProductosTXT("productos.txt", productos);
            
            productoDB.EscribeProductosTXT("productos.txt", productos);


           
        }
    }
}
