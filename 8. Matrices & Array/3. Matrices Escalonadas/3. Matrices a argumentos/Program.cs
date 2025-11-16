using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Matrices_a_argumentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matriz = new int[] {1,2,3,4,5,6,7,8,9,10};//Unidimensional
            int[,] matriz2 = new int[,] { {1,2 },
                                          {3,4 } };

            //2. Invocamos
            IMPRIMIRMATRIZ(matriz);
            IMPRIMIRMATRIZ2(matriz2);

        }

        // 1. IMPRIMIR VALORES DE MATRIZ
        static void IMPRIMIRMATRIZ(int[] matriz)
        {
            int i;
            for(i = 0; i < matriz.Length; i++)
            {
                Console.WriteLine(matriz[i]);
            }
        }

        static void IMPRIMIRMATRIZ2(int[,] matriz2)
        {
            int x, y;

            for(x = 0; x < matriz2.GetLength(0); x++)
            {
                Console.WriteLine("Fila {0}", x);
                for (y = 0; y < matriz2.GetLength(0); y++)
                {
                    Console.WriteLine(matriz2[x, y]);
                }
            }
        }

    }
}
