using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMatematico
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //DECLARO VARIABLES:
            int n1, n2, resultado;
        //INGRESANDO DATOS:
            Console.Write("Ingrese el valor del primer número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del segundo número ");
            n2 = int.Parse(Console.ReadLine());
        //PROCESO DE DATOS:
            resultado = (n1+n2) * (n1-n2);
        //MOSTRANDO DATOS:
            Console.WriteLine("El ejercicio: (n1+n2) * (n1-n2) da como resultado: {0}",resultado);

            Console.ReadKey();
        }
    }
}
