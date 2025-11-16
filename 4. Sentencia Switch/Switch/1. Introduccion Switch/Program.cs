using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Introduccion_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //DECLARAMOS VARIABLES:
            char color;
            //INGRESANDO DATOS: 
            Console.WriteLine("********MENU********");
            Console.WriteLine("OPCION R:  ROJO");
            Console.WriteLine("OPCION G: VERDE");
            Console.WriteLine("OPCION B:  AZUL");
            Console.WriteLine("");
            color = char.Parse(Console.ReadLine());

            switch(color)
            {
                case 'R':
                case 'r':
                    Console.WriteLine("El codigo RGB para {0} es: 255, 0, 0",color);
                    break;

                case 'G':
                case 'g':
                    Console.WriteLine("El codigo RGB para {0} es: 0, 255, 0", color);
                    break;

                case 'B':
                case 'b':
                    Console.WriteLine("El codigo RGB para {0} es: 0, 0, 255", color);
                    break;

                default:
                    Console.WriteLine("SELECCION INVALIDA");
                    break;
            }
        }
    }
}
