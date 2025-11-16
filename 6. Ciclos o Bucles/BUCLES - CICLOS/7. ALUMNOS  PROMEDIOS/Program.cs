using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ALUMNOS__PROMEDIOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, alumnos;
            double notas=0, sumaNotas=0, promedioNotas;

            Console.Write("Ingrese el Numero de alumnos a promediar: ");
            alumnos = int.Parse(Console.ReadLine());

            for (i = 1; i <= alumnos; i++)
            {
                Console.Write("Ingrese la nota del alumno: ");
                notas = double.Parse(Console.ReadLine());

                sumaNotas += notas;
            }

            promedioNotas = sumaNotas / alumnos;
            Console.WriteLine("El promedio de los {0} alumnos es de {1}", alumnos, promedioNotas);
        }
    }
}
