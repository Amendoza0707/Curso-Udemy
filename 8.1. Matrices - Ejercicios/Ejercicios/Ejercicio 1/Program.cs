using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

// Crea un array de 10 posiciones, con valores puestos por ti y muestra el array.

            //CREAMOS LA MATRIZ DE 1x10 Y LE DAMOS VALORES:
            int[] numero = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //CREAMOS EL BUCLE FOR, PARA IMPRIMIR VALORES:
            for (int i = 0; i < numero.Length; i++)
            { 
                Console.WriteLine(numero[i]);
            }

        }
    }
}
