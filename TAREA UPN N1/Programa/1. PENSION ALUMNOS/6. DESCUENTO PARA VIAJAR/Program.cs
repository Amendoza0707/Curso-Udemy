using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.DESCUENTO_PARA_VIAJAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precioUnitario=0, precioFinal, descuento=0, importeCompra, descuentoFinal;
            char destino, calidad;
            int cantidad;

            Console.WriteLine("  ****** COMPRANDO BOLETOS  ******");
            Console.WriteLine("DESTINO 1 : LIMA -  HUANUCO");
            Console.WriteLine("DESTINO 2 : LIMA - HUANCAYO");
            Console.WriteLine("...........................");
            Console.WriteLine("CALIDAD A :         PREMIUM");
            Console.WriteLine("CALIDAD B :          MEDIUM");
            Console.WriteLine("CALIDAD C :          BASICA");
            Console.WriteLine("...........................");
            Console.Write("Seleccione el destino a viajar: ");
            destino = char.Parse(Console.ReadLine().ToUpper());
            Console.Write("Seleccione la calidad de viaje: ");
            calidad = char.Parse(Console.ReadLine().ToUpper());
            Console.Write("Seleccione la cantidad de pasajes: ");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("...........................");

            switch (calidad)
            {
                case 'A':
                    switch(destino)
                    {
                        case '1': precioUnitario = 45; break;
                        case '2': precioUnitario = 38; break;
                    }
                    if (cantidad > 4)
                    {
                        descuento = 0.05;
                    }
                break;
                case 'B':
                    switch (destino)
                    {
                        case '1': precioUnitario = 35; break;
                        case '2': precioUnitario = 33; break;
                    }
                break;
                case 'c':
                    switch (destino)
                    {
                        case '1': precioUnitario = 30; break;
                        case '2': precioUnitario = 28; break;
                    }
                break;
            }

            importeCompra = precioUnitario * cantidad;
            descuentoFinal = importeCompra * descuento;
            precioFinal = importeCompra - descuentoFinal;

            Console.WriteLine("El importe de la compra es de: S/.{0}", importeCompra);
            Console.WriteLine("Tiene un descuento de: S/.{0}",descuentoFinal);
            Console.WriteLine("El precio a pagar es de: S/.{0}",precioFinal);

            Console.ReadKey();

        }
    }
}
