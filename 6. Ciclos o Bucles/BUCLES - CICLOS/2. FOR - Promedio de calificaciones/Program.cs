using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.FOR___Promedio_de_calificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
 //PROBLEMA: SACAR EL PROMEDIO DE LA CALIFICACIÓN DE TRES ALUMNOS DE UN COLEGIO:

    //DECLARAMOS VARIABLES:
            double cali1, cali2, cali3, promedio;

    //PEDIMOS DATOS AL USUARIO:
            Console.Write("Ingresa la calificación del primer alumno: ");
            cali1 = double.Parse(Console.ReadLine());
            Console.Write("Ingresa la calificación del segundo alumno: ");
            cali2 = double.Parse(Console.ReadLine());
            Console.Write("Ingresa la calificación del tercer alumno: ");
            cali3 = double.Parse(Console.ReadLine());

    //PROCESAMOS DATOS:
            promedio = (cali1 + cali2 + cali3) / 3;

    //IMPRIMIMOS DATOS
            Console.WriteLine("El promedio es: {0}",promedio);


        }
    }
}
