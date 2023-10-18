using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRAFOS
{
    internal class grafo
    {
        //Matriz de adyacencia de tipo entero 
        int[,] mAdyacencia;
        /*Arreglo de indegree que es un arreglo
        que nos guardara el indegree de cada uno de los nodos*/
        int[] indegree;
        //Un entero "nodos", que nos dice la cantidad de nodos que tiene ese grafo
        int nodos;


        //En este constructor resivimos la cantidad de nodos que queremos para ese grafo 
        public grafo(int pNodos)
        {
            // Lo asignamos a la variable interna 
            nodos = pNodos;

            //Instanciamos la matriz de ayacencia(la matriz de adyacencia es cuadrada)
            mAdyacencia = new int[nodos, nodos];

            //Instanciones el arreglo de indigree
            indegree = new int[nodos];
        }


        public void AdicionaArista(int pNodoInicio, int pNodoFinal)
        {
            mAdyacencia[pNodoInicio, pNodoFinal] = 1;
        }

        public void MuestraAdyacencia()
        {
            int n = 0;
            int m = 0;

            Console.ForegroundColor = ConsoleColor.Green;

            for (n = 0; n < nodos; n++)
                Console.Write("\t{0}", n);

            Console.WriteLine();

            for (n = 0; n < nodos; n++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(n);
                for (m = 0; m < nodos; m++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.Write("\t{0}", mAdyacencia[n, m]);
                }
                Console.WriteLine();
            }
        }

        public void CalcularIndegree()
        {
            int n = 0, m = 0;

            for (n=0;n<nodos;n++)
            {
                for (m = 0; m < nodos; m++)
                {
                    if (mAdyacencia[m, n] == 1)
                        indegree[n]++;
                }
            }
        }

        public void  MostrarIndegree()
        {
            int n = 0;
            Console.ForegroundColor= ConsoleColor.White;
            for (n = 0; n < nodos; n++)
                Console.WriteLine("Nodo: {0},{1}", n, indegree[n]);
        }

        public int EncuentraI0()
        {
            bool encontrado = false;
            int n = 0;

            for(n=0; n<nodos;n++)
            {
                if (indegree[n]==0)
                {
                   encontrado = true;
                    break;
                }
            }
            if (encontrado)
                return n;
            else
                return -1; //Codigo que indica que no se ha encontrado
        }

        public void DecrementaIndegree(int pNodo)
        {
            indegree[pNodo] = -1;

            int n = 0;

            for (n = 0; n < nodos; n++)
            {
                if (mAdyacencia[pNodo,n] == 1)
                    indegree[n]--;
            }
        }

    }
    
}
