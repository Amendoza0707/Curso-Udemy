using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Pedir_un_numero_x_teclaro_y_multiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicitar un numero por teclado y multiplicarlo por cada elemento del array:

            // Creamos el array 1x5 y declaramos la variable:
            double multiplicacion;
            double[] matriz = new double[5] {700, 650, 320, 420, 210};
            
            //Solicitamos el numero a multiplicar:
            Console.WriteLine("*****MULTIPLICANDO UN NUMERO POR LA MATRIZ******");

            Console.Write("Ingrese el numero a multiplicar: ");
            multiplicacion = double.Parse(Console.ReadLine());

            //Creamos el for y ejecutamos la multiplicacion:
            for (int i = 0; i < 5; i++)
            {
                

                matriz[i] = matriz[i]*multiplicacion;

                //Mostramos el resultado:
                Console.WriteLine("Los resultados son: {0}", matriz[i]);

            }

            


        }
    }
}
