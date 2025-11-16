using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_ACCEDE_MATRIZ_USANDO_ITERACION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i; //Variable de control del ciclo.

            // tipo [] nombre = new tipo [tamaño];
            string[] nombres = new string[3];
                        
            for(i = 0; i <= 2; i++)
            {
                Console.Write("Ingrese el valor para el indice {0}: ", i);
                nombres[i] = Console.ReadLine();
            }

            //Mostramos los valores:
            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine(nombres[i]);
            }

        }
    }
}
