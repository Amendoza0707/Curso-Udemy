using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Cobrar_parqueo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARACION DE VARIABLES:
            int tiempo, opcion;
            //INGRESANDO DATOS:
            Console.WriteLine("Buenas Tardes; por favor ingrese la información solicitada:");
            Console.Write("Ingrese la cantidad de horas que estuvo estacionado: ");
            tiempo = int.Parse(Console.ReadLine());
            //PROCESAMOS DATOS:
            if (tiempo < 2)
            {
                opcion = 1;
            }
            else if (tiempo == 2)
            {
                opcion = 2;
            }
            else
            {  
                opcion = 3;
            }

            switch (opcion) 
            {
                case 1:
                    Console.WriteLine("SU PAGO SERA: S/.5.00");
                    break;

                case 2:
                    Console.WriteLine("SU PAGO SERA: S/.15.00");
                    break;

                case 3:
                    Console.WriteLine("SU PAGO SERA: S/.40.00");
                    break;

                default:
                    Console.WriteLine("USTED NO PAGARA NADA");
                    break;
            }

        }
    }
}
