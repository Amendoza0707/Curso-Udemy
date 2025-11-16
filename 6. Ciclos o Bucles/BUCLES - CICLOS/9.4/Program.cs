using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, resultado=0;
            int opcion;

            do
            {
                Console.WriteLine("****** CALCULADORA DIGITAL ******");
                Console.WriteLine("SUMA           - OPCION 1");
                Console.WriteLine("RESTA          - OPCION 2");
                Console.WriteLine("MULTIPLICACION - OPCION 3");
                Console.WriteLine("DIVISION       - OPCION 4");
                Console.WriteLine("--------------------------");
                Console.Write("Seleccione el ejercito a ejecutar: ");
                opcion = int.Parse(Console.ReadLine());
            }

            while ((opcion < 1) || (opcion >4));

            Console.Write("Dame el primer numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Dame el otro numero: ");
            n2 = double.Parse(Console.ReadLine());

            //Hacer operacion:

            switch(opcion)
            {
                case 1:
                    resultado = n1 + n2;
                    break;
                case 2:
                    resultado = n1 - n2;
                    break;
                case 3:
                    resultado = n1 * n2;
                    break;
                case 4:
                    if (n2 != 0)
                    {
                        resultado = n1 / n2;
                    }
                    else
                    {
                        Console.WriteLine("NUMERO NO VALIDO");
                    }
                    break;
            }

            Console.WriteLine("El resultado es: {0}", resultado);

        }
    }
}
