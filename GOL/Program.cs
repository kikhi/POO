using System;
using System.Collections.Generic;

namespace GOL
{
    enum Estado { viva, muerta };

    class Celula
    {
        public Estado estado_actual;
        public Estado estado_siguiente;
        public Tablero tablero;
        public short renglon;
        public short columna;
        

        public Celula(Estado inicial, Tablero tablero, short renglon, short columna){
            estado_actual = inicial;
            this.renglon = renglon;
            this.columna = columna;
        }

        public void imprimir(){
            if(this.estado_actual == Estado.muerta){
                Console.Write("▓");
            }
            else{
                Console.Write("▒");
            }
        }
    }

    class Tablero
    {
        private List<List<Celula>> grid;
        public Tablero(){
            grid = new List<List<Celula>>();
            grid.Add(new List<Celula>());
            grid[0].Add(new Celula(Estado.viva, this, 0,0));
            grid[0].Add(new Celula(Estado.muerta, this, 0,1));
            grid[0].Add(new Celula(Estado.viva, this, 0,2));

            grid.Add(new List<Celula>());
            grid[0].Add(new Celula(Estado.viva, this, 1,0));
            grid[0].Add(new Celula(Estado.muerta, this, 1,1));
            grid[0].Add(new Celula(Estado.viva, this, 1,2));

            grid.Add(new List<Celula>());
            grid[0].Add(new Celula(Estado.muerta, this, 2,0));
            grid[0].Add(new Celula(Estado.muerta, this, 2,1));
            grid[0].Add(new Celula(Estado.viva, this, 2,2));
        }
        public void imprimir(){
        foreach(List<Celula> renglon in grid)
            foreach(Celula c in renglon)
            c.imprimir();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Tablero GOL = new Tablero();
            GOL.imprimir();
        }
    }
}
