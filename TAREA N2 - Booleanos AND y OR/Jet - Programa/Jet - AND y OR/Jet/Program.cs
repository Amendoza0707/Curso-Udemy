using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jet
{
    internal class Program
    {
        static void Main(string[] args)
        {
    //DECLARO MIS VARIABLES:
            double combustible;
            bool derecho, izquierdo;
    //INGRESAMOS DATOS:
            Console.Write("A qué nivel de com bustible se encuentra el tanque: ");
            combustible = double.Parse(Console.ReadLine());
            Console.Write("El propulsor derecho se encuentra operativo(true) o (false): ");
            derecho = bool.Parse(Console.ReadLine());
            Console.Write("El propulsor izquierdo se encuentra operativo(true) o (false): ");
            izquierdo = bool.Parse(Console.ReadLine());
    //PROCESAMOS DATOS:
            if (((izquierdo && derecho == true) && combustible >= 75) || ((izquierdo || derecho == true) && combustible == 100))
            {
                Console.WriteLine("EL PILOTO PUEDE DESPEGAR");
            }

            else
            {
                Console.WriteLine("EL PILOTO NO DESPEGARA");
            }

        }
    }
}
