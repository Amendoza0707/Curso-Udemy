using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Operadores_Aritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
     //SUMANDO MANERA 1:
           //Declaramos variables.

            int n1, n2;
            double n3 = 4.6;
            double resultado;

            // Sumando 3 variables:

            n1 = 8;
            n2 = 7;
            resultado = n1 + n2 + n3;

            Console.WriteLine(resultado);
            

     //SUMANDO MANERA 2 CADENAS:

            string saludo = "Hola";
            string nombre = "Alex Mendoza";

            Console.WriteLine(saludo + " " + nombre);
           
     //RESTANDO:

            int r1, r2;
            int resta;
            r1 = 9;
            r2 = 5;
            resta = r1 - r2;

            Console.WriteLine("La resta de 9 - 5 es: {0}", resta);

     //MULTIPLICANDO

            int m1=5, m2=8;
            int producto;

            producto = m1 * m2;

            Console.WriteLine("La mulriplicación de 5x8 es: {0}", producto);

            Console.ReadKey();

        }
    }
}
