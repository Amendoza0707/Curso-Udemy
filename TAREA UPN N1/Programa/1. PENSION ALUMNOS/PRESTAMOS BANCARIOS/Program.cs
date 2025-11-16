using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRESTAMOS_BANCARIOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double prestamo, interes, montoMensual, montoInteres;
            int cuotas;

            Console.WriteLine("****** SIMULADOR DE PRESTAMOS ******");
            Console.Write("Ingrese el monto que desea solicitar al banco: S/.");
            prestamo = double.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------");

            if (prestamo <= 5000)
            {
                cuotas = 2;
                interes = 0.05;
                montoInteres = (prestamo / cuotas) * interes;
                montoMensual = (prestamo / cuotas) + montoInteres;
                Console.WriteLine("El monto solicitado es de: S/.{0} y sera pagado en {1} cuotas",prestamo , cuotas);
                Console.WriteLine("Su interes mensual es de: {0}%, usted tendra que pagar al mes: S/.{1}",interes, montoMensual);
                Console.WriteLine("----------------------------------------------");
            }

            else if (prestamo >=5000 && prestamo < 10000) 
            {
                cuotas = 4;
                interes = 0.05;
                montoInteres = (prestamo / cuotas) * interes;
                montoMensual = (prestamo / cuotas) + montoInteres;
                Console.WriteLine("El monto solicitado es de: S/.{0} y sera pagado en {1} cuotas", prestamo, cuotas);
                Console.WriteLine("Su interes mensual es de: {0}%, usted tendra que pagar al mes: S/.{1}", interes, montoMensual);
                Console.WriteLine("----------------------------------------------");
            }

            else if (prestamo >= 10000 && prestamo < 15000)
            {
                cuotas = 6;
                interes = 0.03;
                montoInteres = (prestamo / cuotas) * interes;
                montoMensual = (prestamo / cuotas) + montoInteres;
                Console.WriteLine("El monto solicitado es de: S/.{0} y sera pagado en {1} cuotas", prestamo, cuotas);
                Console.WriteLine("Su interes mensual es de: {0}%, usted tendra que pagar al mes: S/.{1}", interes, montoMensual);
                Console.WriteLine("----------------------------------------------");
            }

            else 
            {
                cuotas = 10;
                interes = 0.03;
                montoInteres = (prestamo / cuotas) * interes;
                montoMensual = (prestamo / cuotas) + montoInteres;
                Console.WriteLine("El monto solicitado es de: S/.{0} y sera pagado en {1} cuotas", prestamo, cuotas);
                Console.WriteLine("Su interes mensual es de: {0}%, usted tendra que pagar al mes: S/.{1}", interes, montoMensual);
                Console.WriteLine("----------------------------------------------");
            }

            Console.ReadKey();
        }
    }
}
