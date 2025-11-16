using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Divisiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
     //DIVIDIENDO:

            double n1 = 4.5, n2 = 4;
            double division;
            division = n1 / n2;

            Console.WriteLine("La division entre 4.5 / 4 es: {0}", division);

     //RESTO , RESIDUO O MODULO:

            double R1 = 5.9, R2 = 3.1;
            double residuo;
            residuo = R1 % R2;

            Console.WriteLine("El residuo de la division entre 5.9 y 3.1 es: {0}",residuo);

            Console.ReadKey();         

        }
    }
}
