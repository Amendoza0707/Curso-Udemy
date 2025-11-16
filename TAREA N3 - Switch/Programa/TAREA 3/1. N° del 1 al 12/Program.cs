using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.N__del_1_al_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
     //DECLARAMOS VARIABLES:
            int mes;
            //INGRESAMOS DATOS:
            Console.WriteLine("Seleccione un número del 1 al 12 para seleccionar el mes");
            Console.Write("Ingrese el mes con el que desea trabajar: ");
            mes = int.Parse(Console.ReadLine());
     //PROCESAMOS DATOS:
            switch(mes)
            {
                case 1:
                    Console.WriteLine("ENERO");
                    break;
                case 2:
                    Console.WriteLine("FEBREO");
                    break; 
                case 3:
                    Console.WriteLine("MARZO");
                    break;
                case 4:
                    Console.WriteLine("ABRIL");
                break;
                case 5:
                    Console.WriteLine("MAYO");
                    break;
                case 6:
                    Console.WriteLine("JUNIO");
                    break;
                case 7:
                    Console.WriteLine("JULIO");
                    break;
                case 8:
                    Console.WriteLine("AGOSTO");
                    break;
                case 9:
                    Console.WriteLine("SETIEMBRE");
                    break;
                case 10:
                    Console.WriteLine("OCTUBRE");
                    break;
                case 11:
                    Console.WriteLine("NOVIEMBRE");
                    break;
                case 12:
                    Console.WriteLine("DICIEMBRE");
                    break;
                default:
                    Console.WriteLine("SELECCIONO UN MES INCORRECTO");
                    break;

            }

        }
    }
}
