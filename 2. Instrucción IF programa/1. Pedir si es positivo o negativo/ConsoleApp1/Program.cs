using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //DECLARO VARIABLES:
            double numero;
         //SOLICITO DATOS AL USUARIO:
            Console.Write("Ingrese un numero: ");
            numero = double.Parse(Console.ReadLine());
         //PROCESANDO DATOS:
            if (numero > 0) 
            {
                Console.WriteLine("El numero {0} es positivo", numero);
            }
            if (numero < 0)
            {
                Console.WriteLine("El numero {0} es negativo",numero);
            }

            Console.ReadKey();
        }
    }
}
