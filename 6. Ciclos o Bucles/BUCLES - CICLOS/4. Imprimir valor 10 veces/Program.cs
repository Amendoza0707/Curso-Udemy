using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Imprimir_valor_10_veces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAMOS VARIABLES DE BUCLE:
            int i;

            //INSTRUCCION FOR PARA IMPRIMIR 10 NUMEROS:
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
