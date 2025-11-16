using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.IF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAMOS LA VARIABLES:
            double suma, resta, division, multiplicacion, n1, n2;
            int opcion;
            //PRIMERO CREAREMOS UN MENU PARA EL USUARIO
            Console.WriteLine("**************MENU*****************");
            Console.WriteLine("*** OPCION 1: SUMA ***********");
            Console.WriteLine("*** OPCION 2: RESTA **********");
            Console.WriteLine("*** OPCION 3: MULTIPLICACION *");
            Console.WriteLine("*** OPCION 4: DIVISION *******");
            Console.WriteLine("");
            //INGRESANDO LA OPCION
            Console.Write("Seleccione la opcion: ");
            opcion = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el primer numero : ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            n2 = double.Parse(Console.ReadLine());
            //PROCESANDO DATOS: 
            if (opcion == 1)
            {
                suma = n1 + n2;
                Console.WriteLine("");
                Console.WriteLine("Usted selecciono la opcion suma");
                Console.WriteLine("La suma de {0} + {1} = {2}", n1, n2, suma);
            }

            else if (opcion == 2)
            {
                resta = n1 - n2;
                Console.WriteLine("");
                Console.WriteLine("Usted selecciono la opcion resta");
                Console.WriteLine("La suma de {0} - {1} = {2}", n1, n2, resta);
            }

            else if (opcion == 3)
            {
                multiplicacion = n1 * n2;
                Console.WriteLine("");
                Console.WriteLine("Usted selecciono la opcion multiplicacion");
                Console.WriteLine("La suma de {0} X {1} = {2}", n1, n2, multiplicacion);
            }

            else if (opcion == 4)
            {
                if (n2 > 0)
                {
                    division = n1 / n2;
                    Console.WriteLine("");
                    Console.WriteLine("Usted selecciono la opcion division");
                    Console.WriteLine("La suma de {0} / {1} = {2}", n1, n2, division);
                }
                else
                {
                    Console.WriteLine("La division no se puede realizar");
                }
            }
            else if (opcion > 4)
            {
                Console.WriteLine("SELECCION INCORRECTA");
            }

        }
    }
}
