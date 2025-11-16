using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar matriz jagged:

            //Estrucutura:
            // tipo [][] nombre = new tipo[filas][];
            double[][] ventas = new double[4][];//Matriz ventas con 4 matrices

            //Declaracion de matrices internas:
            ventas[0] = new double[3] { 155, 100, 170 };
            ventas[1] = new double[2] {205,120};    
            ventas[2] = new double[4] {115,190,104,130};
            ventas[3] = new double[3] {163,218,125};

            // Tambien se puede hacer esto:
            double[][] ventas2 = new double[][]
            {
                new double[] { 125, 150, 170 },
                new double[] { 125, 150 },
                new double[] { 163, 218, 125 }
            };

            //Mostrar valores
            Console.WriteLine(ventas[2][1]);
    }
 }
}
