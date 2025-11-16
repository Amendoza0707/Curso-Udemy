using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.DESCUENTO_VIAJES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precioUnitario = 0.0, descuento = 0.0, precioFinal, aPagar;
            char calidad, destino;
            int cantidad;

            Console.WriteLine(" ****** MENU DEL VIAJERO  ******");
            Console.WriteLine("OPCION X: LIMA - HUANUCO");
            Console.WriteLine("OPCION Y: LIMA - HUANCAYO");
            Console.Write("Ingrese su destino: ");
            destino = char.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine("----------------------------");
            Console.WriteLine("Categoria 'A' - PREMIUM");
            Console.WriteLine("Categoria 'B' - MEDIUM");
            Console.WriteLine("Categoria 'C' - BASICA");
            Console.Write("Ingrese la calidad del viaje: ");
            calidad = char.Parse(Console.ReadLine().ToUpper());

            Console.Write("Ingrese la cantidad de pasajes que comprará: ");
            cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------");

            if (destino == 'X')
            {
                switch (calidad)
                {
                    case 'A': precioUnitario = 45; break;
                    case 'B': precioUnitario = 35; break;
                    case 'C': precioUnitario = 30; break;
                    default:
                        Console.WriteLine("Calidad Errónea"); return;
                }
            }
            else if (destino == 'Y')
            {
                switch (calidad)
                {
                    case 'A': precioUnitario = 38; break;
                    case 'B': precioUnitario = 33; break;
                    case 'C': precioUnitario = 28; break;
                    default:
                        Console.WriteLine("Calidad Errónea"); return;
                }
            }
            else
            {
                Console.WriteLine("Ruta Errónea");
                return;
            }

            precioFinal = precioUnitario * cantidad;

            if (calidad == 'A' && cantidad > 4)
            {
                descuento = precioFinal * 0.05;
            }

            aPagar = precioFinal - descuento;

            Console.WriteLine("Importe de la compra: S/. {0}", precioFinal);
            Console.WriteLine("Descuento aplicado: S/. {0}", descuento);
            Console.WriteLine("Total a pagar: S/. {0}", aPagar);
        }
    }
    }

    


