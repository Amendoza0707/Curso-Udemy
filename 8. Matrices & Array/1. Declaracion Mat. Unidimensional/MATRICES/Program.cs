using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATRICES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte tamaño;
            Console.Write("Ingrese el tamaño de la matriz: ");
            tamaño = byte.Parse(Console.ReadLine());

            // tipo [] nombre = new tipo [tamaño];
            //int [] numeros; ASI SE DECLARA, TRABAJAREMOS CON DOUBLE
            double [] calificaciones = new double [4];
            string [] nombre = new string [5];
            int [] numeros = new int [10];
            byte [] datos = new byte [7];

            int [] primos = new int [tamaño];



        }
    }
}
