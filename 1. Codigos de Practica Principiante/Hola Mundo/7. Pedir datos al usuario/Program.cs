using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Pedir_datos_al_usuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Preguntas al usuario:
            string nombre;
            Console.Write("?Cual es tu nombre?: ");
            nombre = Console.ReadLine();

            //Saludamos al usuario:
            Console.WriteLine("Hola {0} , un placer trabajar contigo", nombre);

            Console.ReadKey();
        }
    }
}
