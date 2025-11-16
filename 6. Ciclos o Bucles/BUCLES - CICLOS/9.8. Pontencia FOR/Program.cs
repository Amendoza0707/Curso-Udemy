using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._8.Pontencia_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
    //HACER UN PROGRAMA DE UN NUMERO , YA SEA NEGATIVA O POSITIVA. INGRESAMOS LA BASE Y EL EXPONENTE:

        //DECLARAMOS VARIABLES:
            int   numeroBase,         exponente;
            double resultado=1, resultadoNegativo;

            Console.WriteLine("****** MENU DE POTENCIACIÓN *****");

        //PEDIMOS LOS DATOS DEL USUARIO:

            Console.Write("Ingrese la base: ");
            numeroBase = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el exponente: ");
            exponente = int.Parse(Console.ReadLine());

            //INTRUCCION IF: SI ES POSITIVO O NEGATIVO
            if (exponente < 0)
            {
            //CONVERTIR EL EXPONENTE A POSITIVO:
                exponente *= -1;

                for (int i = 1; i <= exponente; i++)
                {
                    resultado *= numeroBase;
                }

            //ASIGNAMOS RESULTADO NEGATIVO:
                resultadoNegativo = (1 / resultado);

            //MOSTRAMOS EL RESULTADO:
                Console.WriteLine("{0} {1} = {2}", numeroBase, exponente, resultadoNegativo);
            }

            else
            {
                for (int i = 1; i <= exponente; i++)
                {
                    resultado *= numeroBase;
                }

            //MOSTRAMOS EL RESULTADO:
                Console.WriteLine("{0} {1} = {2}", numeroBase, exponente, resultado);
            }

        }
    }
}
