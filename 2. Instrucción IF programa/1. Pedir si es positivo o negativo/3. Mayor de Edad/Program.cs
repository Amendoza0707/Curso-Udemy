using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Mayor_de_Edad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARANDO VARIABLES:
            int edad;
            string nombre;
            //INGRESAMOS DATOS DEL USUARIO:
            Console.Write("Ingrese el nombre del estudiante: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            //PROCESAMOS DATOS:
            //Utilizamos el if: Si el valor es Verdadero imprimimos el mensaje:
            if (edad >= 18)
            {
                Console.WriteLine("El estudiante: {0} es mayor de edad",nombre);
            }

            else
            {
                Console.WriteLine("El estudiante: {0} es menor de edad",nombre);
            }

            Console.ReadKey();
        }
    }
}
