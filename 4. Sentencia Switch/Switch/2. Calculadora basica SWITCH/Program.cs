using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Calculadora_basica_SWITCH
{
    internal class Program
    {
        static void Main(string[] args)
        {
    //DECLARAMOS VARIABLES:
            double n1, n2, resultado;
            int opcion;
    //INGRESAMOS DATOS:
            Console.WriteLine("****MENU DE CALCULOS****");
            Console.WriteLine("________________________");
            Console.WriteLine("OPCION 1: SUMA");
            Console.WriteLine("OPCION 2: RESTA");
            Console.WriteLine("OPCION 3: MULTIPLICACION");
            Console.WriteLine("OPCION 4: DIVISION");
            Console.WriteLine("");
            Console.Write("Ingrese la opcion:  ");
            opcion = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el primer N°:  " );
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo N°: ");
            n2 = double.Parse(Console.ReadLine());
    //PROCEDAMOS DATOS
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Selecciono SUMA:");
                    resultado = n1 + n2;
                    Console.WriteLine("LA SUMA DE: {0} + {1} = {2}", n1, n2, resultado);
                break;

                case 2:
                    Console.WriteLine("Selecciono RESTA:");
                    resultado = n1 + n2;
                    Console.WriteLine("LA RESTA ES: {0} - {1} = {2}", n1, n2, resultado);
                break;

                case 3:
                    Console.WriteLine("Selecciono MULTIPLICACION:");
                    resultado = n1 + n2;
                    Console.WriteLine("LA MULTIPLICACION DE: {0} X {1} = {2}", n1, n2, resultado);
                    break;

                case 4:
                    Console.WriteLine("Selecciono DIVISION:");
                    resultado = n1 / n2;
                    if(n2 == 0)
                    {
                        Console.WriteLine("LA DIVISION NO EXISTE");
                    }

                    else
                    {
                        Console.WriteLine("LA DIVISION DE: {0} / {1} = {2}", n1, n2, resultado);
                    }
                 break;

                default:
                    Console.WriteLine("SELECCION INCORRECTA");
                break;
            }
        }
    }
}
