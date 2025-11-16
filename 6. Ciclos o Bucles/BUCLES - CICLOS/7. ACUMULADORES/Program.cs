using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ACUMULADORES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //QUEREMOS SUMAR 5 PRECIOS DE PRODUCTOS DISTINTOS:
            int i;
            int acumulador = 0;
            int precio;

            for(i = 1; i <= 5; i+=1)
            {
                Console.Write("Ingrese el precio: S/.");
                precio = int.Parse(Console.ReadLine());

                acumulador += precio;
            }

            Console.WriteLine("El precio total es de: S/.{0}", acumulador);
        }
    }
}
