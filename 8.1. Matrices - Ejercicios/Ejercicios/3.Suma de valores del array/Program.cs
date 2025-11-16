using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Suma_de_valores_del_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
 //Sumar los valores de una array de 1x5 y mostrar el resultado:

            //Creamos el array 1x5 y declaramos la suma:
            double[] sumatoria = new double[5];
            double suma=0;

            Console.WriteLine("****SUMATORIA DE VALORES*****");

            //Pedimos los valores por for:
            for (int i = 0; i < sumatoria.Length; i++)
            {
                Console.Write("Ingrese el valor de la posicion {0}: ", i);
                sumatoria[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("**** MOSTRANDO RESULTADO: *****");

            //Realizamos la sumatoria por for:
            for(int i = 0;i < sumatoria.Length; i++)
            {
                suma += sumatoria[i];
            }

            //Mostramos la suma:
            Console.WriteLine(suma);

        }
    }
}
