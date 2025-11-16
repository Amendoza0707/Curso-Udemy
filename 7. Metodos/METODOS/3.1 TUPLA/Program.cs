using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_TUPLA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
           // string NOMBRE = "ALEX";
            //int edad = 50;
            //long telefono = 2099147670;
            //int postal = 95376;

            //CONVERTIREMOS ESE GRUPO EN 1 SOLA:
            //SINTASIS: 
            //(TIPO) identificador = (valor):
            (string nombre, int edad, long telefono, int postal) Persona1 = ("Alex Mendoza", 32, 2099147670, 95376);

            var Persona2 = (nombre: "Madeleine Usnayo", edad: 40, telefono: 987169174, postal: 01);

            Console.WriteLine("Los datos de la persona 1 son: {0}", Persona1);
            Console.WriteLine(Persona2.nombre);
            Console.WriteLine(Persona2.edad);
            Console.WriteLine(Persona2.telefono);




        }
    }
}
