using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_Descuento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARANDO VARIABLES:
            double precio, descuento, precioFinal;
            //SOLICITAR DATOS:
            Console.Write("Ingrese el precio del producto: S/.");
            precio=Convert.ToDouble(Console.ReadLine());
            //PROCESANDO DATOS:
            descuento = precio * 0.60;
            precioFinal = precio - descuento;
            //MOSTRANDO DATOS:
            Console.WriteLine("El descuento del producto es: S/.{0}", descuento);
            Console.WriteLine("El precio a pagar con descuento de 60% es de S/.{0}",precioFinal);

            Console.ReadKey();
        }
    }
}
