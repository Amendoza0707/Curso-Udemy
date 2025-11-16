using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Num_PAR_o_IMPAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
    //DECLARAMOS VARIABLES:
            int num;
            int resultado;
    //PEDIMOS INFORMACIÓN AL USUARIO:
            Console.WriteLine("Seleccione un número para determinar si es PAR o IMPAR: ");
            num = int.Parse(Console.ReadLine());
    //PROCESAMOS LA INFORMACIÓN:
            resultado = (num % 2);
            switch (resultado)
            {
                case (0):
                    Console.WriteLine("EL NÚMERO ES PAR");
                    break;
                default:
                    Console.WriteLine("EL NÚMERO ES IMPAR");
                    break;
            }


        }
    }
}
