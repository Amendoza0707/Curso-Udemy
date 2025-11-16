using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PASAR_X_VALOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable local y asignamos valor:
            byte numAr;
            string saludoAr;
            int numPrimoAr;

            //INVOCAMOS AL METODO Y MANDAMOS AL ARGUMENTOS:
            PRUEBA(out numAr, out saludoAr, out numPrimoAr);

            //DESPUES DE QUE EL METODO CAMBIO EL VALOR , VOLVEMOS A MOSTRAR AL ARGUMENTO:
            Console.WriteLine(numAr);
            Console.WriteLine(saludoAr);
            Console.WriteLine(numPrimoAr);

        }

        static void PRUEBA(out byte numPa, out string saludoPa, out int numPrimoPa)
        {
            //MODIFICAMOS EL VALOR DE los PARAMETROs:
            numPa = 20;
            saludoPa = "HOLA FAMILIA";
            numPrimoPa = 7;

        }

    }
}
