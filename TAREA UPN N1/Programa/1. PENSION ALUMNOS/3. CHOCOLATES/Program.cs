using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CHOCOLATES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad, obsequio;
            double precioUnidad, descuento, precioFinal, precio;
            
            Console.WriteLine("******  SELECCIONA EL CHOCOLATE DE TU PREFERENCIA  ******");
            Console.WriteLine("OPCIÓN A: Primor   - uni. S/ 8.50");
            Console.WriteLine("OPCIÓN B: Dulzura  - uni. S/10.00");
            Console.WriteLine("OPCIÓN C: Tentación- uni. S/ 7.00");
            Console.WriteLine("OPCIÓN D: Exploción- uni. S/12.50");
            Console.WriteLine("---------------------------------------");
            Console.Write("Seleccione el tipo de chocolate: ");
            char tipo = char.Parse(Console.ReadLine().ToUpper());
            Console.Write("Ingrese la cantidad que desea comprar: ");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------BOLETA DE VENTAS--------------------");

            if (tipo == 'A')
            {
                precioUnidad = 8.50;
            }
            else if (tipo == 'B')
            {
                precioUnidad = 10.00;
            }
            else if (tipo == 'C')
            {
                precioUnidad = 7.00;
            }
            else
            {
                precioUnidad = 12.50;
            }

            precio = precioUnidad * cantidad;

            if (cantidad < 5)
            {
                descuento = 0.04;
            }
            else if (cantidad >= 5 && cantidad < 10)
            {
                descuento = 0.065;
            }
            else if (cantidad >= 10 && cantidad < 15)
            {
                descuento = 0.09;
            }
            else
            {
                descuento = 0.115;
            }

            precioFinal = precio - descuento;

            if (precioFinal >= 250)
            {
                obsequio = cantidad * 3;
            }

            else
            {
                obsequio = cantidad * 3;
            }

            Console.WriteLine("El precio sin descuento es de: S/.{0} ", precio);
            Console.WriteLine("Usted obtuvo un descuento de:  %{0} ", descuento);
            Console.WriteLine("El precio con descuento es de: S/.{0} y recibira de obsequio {1} caramelos por San Valentin", precioFinal, obsequio);

            Console.ReadKey();

        }
    }
}
