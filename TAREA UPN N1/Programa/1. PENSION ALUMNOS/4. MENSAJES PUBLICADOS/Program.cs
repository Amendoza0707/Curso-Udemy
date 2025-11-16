using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MENSAJES_PUBLICADOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******  CLASIFICACIÓN DE USUARIO  ******");
            Console.Write("Inserte la cantidad de mensajes que tiene en la web: ");
            int cantidad = int.Parse(Console.ReadLine());

            if (cantidad <= 49)
            {
                Console.WriteLine("USTED ES UN USUARIO DESCONOCIDO");
            }
            else if (cantidad >= 50 && cantidad <= 99)
            {
                Console.WriteLine("USTED ES UN USUARIO HUMANO");
            }
            else if (cantidad >= 100 && cantidad <= 249)
            {
                Console.WriteLine("USTED ES UN USUARIO INICIAL");
            }
            else if (cantidad >= 250 && cantidad <= 499)
            {
                Console.WriteLine("USTED ES UN USUARIO NOVATO");
            }
            else if (cantidad >= 500 && cantidad <= 999)
            {
                Console.WriteLine("USTED ES UN USUARIO EXPERIMENTADO");
            }
            else if (cantidad >= 1000 && cantidad <= 1999)
            {
                Console.WriteLine("USTED ES UN USUARIO ELITE");
            }
            else if (cantidad >= 2000 && cantidad <= 4999)
            {
                Console.WriteLine("USTED ES UN USUARIO DEFINITIVO");
            }
            else
            {
                Console.WriteLine("USTED ES UN USUARIO LEGENDARIO");
            }

        }
    }
}
