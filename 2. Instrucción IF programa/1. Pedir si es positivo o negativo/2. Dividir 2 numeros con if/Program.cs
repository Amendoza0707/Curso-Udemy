using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Dividir_2_numeros_con_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARO MIS VARIABLES:
            double dividendo, divisor, resultado;
            //INGRESAMOS LOS DATOS:
            Console.Write("Ingresa el dividendo: ");
            dividendo = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el divisor: ");
            divisor = double.Parse(Console.ReadLine());
            //PROCESANDO
            if (divisor != 0)
            {
                //SI EL DIVISOR ES DIFERENTE A 0 PROCEDE A:
                resultado = dividendo / divisor;
                Console.WriteLine("El resultado de la division es de: {0}",resultado);
            }

            if (divisor == 0)
            {
                Console.WriteLine("La division no se ejecutara");
            }

            Console.ReadKey(); 
        }
    }
}
