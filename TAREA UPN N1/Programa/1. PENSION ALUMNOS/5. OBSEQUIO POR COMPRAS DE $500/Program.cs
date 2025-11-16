using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.OBSEQUIO_POR_COMPRAS_DE__500
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero=0;

            Console.WriteLine("******  SORTEO POR COMPRAS  ******");
            Console.Write("Ingrese el importe de su comprar en nuestra tienda: S/.");
            double precio = double.Parse(Console.ReadLine());

            if (precio < 250)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Usted no califica para el sorteo");
            }
            else if(precio >=250)
            {
                Console.WriteLine("----------------------");
                Console.Write("Usted ingreso al sorteo - Seleccione un numero del 1 al 50: ");
                numero = int.Parse(Console.ReadLine());
            } 


            switch (numero)
            {
                case 10:
                    Console.WriteLine("USTED GANO UNA AGENDA");
                    break;
                case 20:
                    Console.WriteLine("USTED GANO UN RELOJ");
                    break;
                case 30:
                    Console.WriteLine("USTED GANO UN USB");
                    break;
                case 40:
                    Console.WriteLine("USTED GANO UN PERFUME");
                    break;
                case 50:
                    Console.WriteLine("USTED GANO UNA RADIO");
                    break;
                default:
                    Console.WriteLine("USTED GANO UNA PELOTA");
                    break;

            }
        }
    }
}
