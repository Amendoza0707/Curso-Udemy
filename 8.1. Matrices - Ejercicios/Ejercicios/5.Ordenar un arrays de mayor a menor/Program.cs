using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Ordenar_un_arrays_de_mayor_a_menor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresa un array 1x6 por teclado y ordenalos de mayor a menor:

            //Declaramos el array unidimensionale 1x5:
            double[] numero = new double[6];

            for (int i = 0; i < numero.Length; i++)
            {
                Console.Write("Ingrese el numero: ");
                numero[i]= double.Parse(Console.ReadLine());   
            }

            double mayor=0, menor=0;
            Array.Sort(numero);



            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i] > mayor)
                {
                    mayor = numero[i];
                }

                else
                {
                    menor = numero[i];
                }


            }

            Console.Clear();

            foreach (int i in numero)
            {
                Console.WriteLine(numero[i]);
            }

            Console.WriteLine("**** MOSTRANDO VALORES: ****");

            Console.WriteLine("El numero mayor es: {0} ", mayor);
            Console.WriteLine("El numero menor es: {0} ", menor);


            Console.ReadKey();

        }
    }
}
