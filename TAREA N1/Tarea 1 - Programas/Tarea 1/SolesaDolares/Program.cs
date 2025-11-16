using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolesaDolares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARANDO VARIABLES:
            double soles, tipoCambio = 3.78, dolar;
            //INGRESANDO DATOS:
            Console.Write("Ingrese la cantidad de soles que quiere cambiar S/.");
            soles = double.Parse(Console.ReadLine());
            //PROCESANDO DATOS:
            dolar = soles / 3.78;
            //IMPRIMIENDO DATOS:
            Console.WriteLine("El tipo de cambio del día es: S/.{0} y usted obtendra ${1}",tipoCambio, dolar);

            Console.ReadKey();

        }
    }
}
