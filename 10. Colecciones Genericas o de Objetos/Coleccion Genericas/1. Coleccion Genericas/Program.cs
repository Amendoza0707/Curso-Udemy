using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Coleccion_Genericas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //El tipo object: Admite enteros , cadenas, decimales.

            object numeroEntero = 16;
            object cadena = "HOLA";
            object flotante = 3.1416;

            object[] numero = new object[2];
            numero[0] = 1;
            numero[1] = "Alex";

            object objeto;
            objeto = "Madeleine";
            objeto = 07;

            //---------------------------------------
            //-                                     -
            //-    CONVERSION DEL TIPO              -
            //-                                     -
            //---------------------------------------

            byte numPequeño = 125;
            int numGrande = numPequeño; // El int puede almacenar al byte.

            // Pasar int a byte : (T)E

            int grande = 500;
            byte pequeño = (byte)grande;
            

        }
    }
}
