using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Programacipin_Estructurada
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //PROBLEMA 1: HALLAR EL AREA Y PERIMETRO DE UN RECTANGULO.

        // Paso 1: Declarar Variables:
            double ancho, alto, area, perimetro;

        // Paso 2: Solicito datos al usuario:
            Console.Write("Ingrese el ancho del rectangulo: ");
            ancho=Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la altura del rectangulo: ");
            alto=Convert.ToDouble(Console.ReadLine());

        // Paso 3: Se realiza los procesos:
            area = ancho * alto;
            perimetro = 2 * (ancho + alto);

         //Mostramos resultados:
            Console.WriteLine("El area del perimetro es de: {0} m2 y el perimetro es de {1}", area, perimetro);
            Console.ReadKey();
        }
    }
}
