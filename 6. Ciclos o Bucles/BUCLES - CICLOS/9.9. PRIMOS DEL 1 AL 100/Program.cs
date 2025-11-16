using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._9.PRIMOS_DEL_1_AL_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
 //VARIABLES: Numeros primos del 1 al 100
        //DECLARAMOS VARIABLES:
            int numero, divisor, numeroDivisor = 0;

        //LOS NUMEROS PRIMOS SE CUENTAN A PARTIR DEL 2:
        //BUCLE EXTERIOR:
            for (numero = 2; numero <= 100; numero++)
            {
                //BUCLE ANINADO, SE ENCARGA DE VERIFICAR EL N° DE DIVISORES:
                for (divisor = 1; divisor <= numero; divisor++)
                {
                    if (numero % divisor == 0)
                    {
                        numeroDivisor++; //CONTEO
                    }                
                }

                //VERIFICAR N° DIVISORES = 2:
                if(numeroDivisor <=2)
                {
                    Console.WriteLine(numero);
                }

                //REINICIO LOS NUMEROS DE DIVISORES:
                numeroDivisor = 0;

            }

            Console.ReadKey();
        }
    }
}
