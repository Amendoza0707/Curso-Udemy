using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Declaro Variables:
            string nombre, apellido;

        //Ingreso Datos:
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();

        //Mostrando datos:
            Console.WriteLine("Bienvenido al programa: {0} {1}",nombre,apellido);

            Console.ReadKey();
        }
    }
}
