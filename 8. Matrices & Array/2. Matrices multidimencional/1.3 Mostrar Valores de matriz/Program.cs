using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_Mostrar_Valores_de_matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {

    //tipo [,] nombre = new tipo [fila,columna]
            double[,] ventas = new double[4, 3] { {100,120,205},
                                                  {115,196,300},
                                                  {157,172,245},
                                                  {130,180,281},
                                                };
            //Declarando variables de control:
            int x; //Externa.
            int y; //Interna.

            for (x=0; x<4; x++)
            {

                Console.WriteLine("Fila {0}: ", x+1);

                for(y=0; y<3; y++)
                {
                    
                    Console.WriteLine(ventas[x, y]);
                }
            }

        }
    }
}
