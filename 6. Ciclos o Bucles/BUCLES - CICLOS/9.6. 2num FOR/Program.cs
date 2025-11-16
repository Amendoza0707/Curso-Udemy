using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._6._2num_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
           
            Console.WriteLine("****SUMA DE N° MENOR HASTA EL MAYOR****");
            Console.Write("Ingrese el primer N°:  ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo N°: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 != num2)
            {
                int menor = (num1 < num2) ? num1 : num2;
                int mayor = (num1 > num2) ? num1 : num2;

                Console.WriteLine("Los numeros entre {0} y {1} son: ",menor,mayor);
                for (int i = menor + 1; i < mayor; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("LOS NUMEROS SON IGUALES");
            }


        }
    }
}
