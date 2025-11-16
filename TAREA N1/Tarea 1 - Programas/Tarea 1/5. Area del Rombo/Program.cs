using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Area_del_Rombo
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //DECLARO VARIABLES:
            double area, ladoMayor, ladoMenor;
        //INGRESANDO DATOS:
            Console.Write("Ingrese cuanto mide el lado mayor del rombo: ");
            ladoMayor = double.Parse(Console.ReadLine());
            Console.Write("Ingrese cuanto mide el lado menor del rombo: ");
            ladoMenor = double.Parse(Console.ReadLine());
        //PROCESANDO:
            area = (ladoMayor * ladoMenor) / 2;
        //IMPRIMIENDO DATOS:
            Console.WriteLine("El area del rombo es de: {0}",area);

            Console.ReadKey();
        }
    }
}
