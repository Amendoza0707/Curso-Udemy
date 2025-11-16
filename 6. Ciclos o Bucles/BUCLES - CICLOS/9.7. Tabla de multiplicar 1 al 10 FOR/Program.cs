using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._7.Tabla_de_multiplicar_1_al_10_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
    //TABLAS DE MULTIPLICACIÓN DEL 1 AL 10 
        //DECLARAMOS VARIABLES:
            int i, j, resultado;

            Console.WriteLine("*****TABLAS DE MULTIPLICAR****");

            //BUCLE EXTERIOR
            for (i = 1; i <= 10; i++) 
            {
                Console.WriteLine("Ingrese la tabla de multiplicar del N°:{0} ", i); //MUESTRA LA TABLA DEL

                for (j = 1; j <= 10; j++)
                {
                    resultado = i * j;
                    Console.WriteLine("{0} * {1} = {2}",i,j,resultado);
                }

            }
        }
    }
}
