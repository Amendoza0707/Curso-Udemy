using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booleanos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAMOS VARIABLES:
            int edad;
            bool licencia;
            //SOLICITAMOS DATOS DEL USUARIO:
            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.Write("Tienes licencia de conducir: ");
            licencia = bool.Parse(Console.ReadLine());
            //PROCESAMOS DATOS:
            if (edad >= 18 && licencia == true)
            {
                Console.WriteLine("PUEDES CONDUCIR");
            }
            else
            {
                Console.WriteLine("LO SIENTO NO PUEDES CONDUCIR");
            }
        }
    }
}
