
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRAFOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nodo = 0;

            grafo migrafo = new grafo(7);

            migrafo.AdicionaArista(0, 1);
            migrafo.AdicionaArista(0, 2);
            migrafo.AdicionaArista(0, 3);
            migrafo.AdicionaArista(1, 3);
            migrafo.AdicionaArista(1, 4);
            migrafo.AdicionaArista(2, 5);
            migrafo.AdicionaArista(3, 2);
            migrafo.AdicionaArista(3, 5);
            migrafo.AdicionaArista(3, 6);
            migrafo.AdicionaArista(4, 3);
            migrafo.AdicionaArista(4, 6);
            migrafo.AdicionaArista(6, 5);


            migrafo.MuestraAdyacencia();
            Console.WriteLine();
            migrafo.CalcularIndegree();
            migrafo.MostrarIndegree();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            do
            {

                //Encontramos el nodo  con el ingreso 0
                nodo = migrafo.EncuentraI0();

                if( nodo != -1)
                {
                    //Imprimimos el nodo 
                    Console.Write("{0}->", nodo);

                    //Decrementamos los idegrees
                    migrafo.DecrementaIndegree(nodo);

                }

            }while(nodo != -1);
             Console.WriteLine();

        }
    }
}
