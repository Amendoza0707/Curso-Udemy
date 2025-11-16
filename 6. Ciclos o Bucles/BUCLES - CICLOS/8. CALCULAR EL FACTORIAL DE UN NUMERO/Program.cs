using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.CALCULAR_EL_FACTORIAL_DE_UN_NUMERO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong i, numero, factorial = 1;

            Console.Write("Ingrese el numero que desea el factorial: ");
            numero = ulong.Parse(Console.ReadLine());

            for(i = numero; i >= 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine("El factorial de: {0} es de: {1}",numero,factorial);

        }
    }
}
