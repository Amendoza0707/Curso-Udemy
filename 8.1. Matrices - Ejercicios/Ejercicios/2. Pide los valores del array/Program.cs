using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Pide_los_valores_del_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
//CREA UN ARRAY DE 10 POSICIONES , PIDE LOS VALORES Y MUESTRA EL ARRAY.

            //CREAMOS EL ARRAY DE 1x10
            int[] numeros = new int[10];

            //PEDIMOS LOS VALORES:
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese el valor de la posicion {0}: ", i);
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MOSTRAMOS VALORES OBTENIDOS");

            //MOSTRAMOS LOS DATOS EN PANTALLA:
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }


        }
    }
}
