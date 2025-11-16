using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Conversion_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------
            //-                                     -
            //-    CONVERSION DEL TIPO object       -
            //-                                     -
            //---------------------------------------

            object num1 = 5;
            object num2 = 20;
            object resultado;

            //resultado = num1 + num2; // NO ARROJA RESULTADO.

            // DEBEMOS HACER LA CONVERSION BOXING UNBOXING
            // 1. BOXING [tipo de valor -> object] implicita

            int a = 50;
            object obj = a; // Boxing: copia el valor de a dentro de object

            // 2. UNBOXING: Convierte --- [object -> tipo de valor] explicita

            resultado = (int)num1 + 30;


            Console.WriteLine(resultado);


        }
    }
}
