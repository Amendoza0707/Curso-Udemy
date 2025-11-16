using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._5.Suma_de_numeros_acumulados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            int suma=0;

            Console.WriteLine("***SUMA DE NUMEROS NATURALES***");
            Console.Write("Cuantos N° Sumaras: ");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i <= cantidad; i++)
            {
                suma += i;
            }

            Console.WriteLine("La sumatoria del 1 al {0} es de:  {1}",cantidad, suma);

        }
    }
}
