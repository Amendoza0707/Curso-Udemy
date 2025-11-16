using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Contador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador=0;
            for (int i = 0; i <= 20; i+=2)
            {
                contador++;
                Console.WriteLine("{0}, vuelta del bucle N°: {1}",i,contador);
            }

            Console.WriteLine("El N° de vueltas que dio el ciclo es de:{0}",contador);
        }
    }
}
