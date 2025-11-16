using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Convirtiendo_Cadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma, n1, n2;
            n1 = 1;
          
    // Solicitando el numero:
            Console.Write("Porfavor, ingrese un numero para sumarlo con 1: ");
            n2 = int.Parse(Console.ReadLine());

            suma = n1 + n2;

            Console.WriteLine("El resultado de la suma es: {0}",suma);


         //METODO 2:

            Console.ReadKey();
        }
    }
}
