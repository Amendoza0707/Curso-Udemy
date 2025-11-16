using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_Aceder_a_la_matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tipo [,] nombre = new tipo [fila,columna]
            double[,] ventas = new double[4, 3];
            ventas[1, 2] = 450;

            Console.WriteLine(ventas[1, 2]);
        }
    }
}
