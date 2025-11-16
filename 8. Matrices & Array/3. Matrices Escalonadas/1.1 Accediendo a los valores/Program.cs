using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_Accediendo_a_los_valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables y matriz escalonada:
            double[][] ventas = new double[4][]
            {
                new double[] { 155, 100, 170 },
                new double[] { 205, 120 },
                new double[] { 115, 190, 104, 130 },
                new double[] { 163, 218, 125 }
            };

            int x, y;

            for(x=0; x<ventas.Length;x++)
            {
                Console.WriteLine("Elemento {0}", x);
                for(y=0; y < ventas[x].Length; y++)
                {
                    Console.WriteLine(ventas[x][y]);
                }
            }

        }
    }
}
