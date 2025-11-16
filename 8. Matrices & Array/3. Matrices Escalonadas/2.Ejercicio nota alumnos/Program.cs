using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Ejercicio_nota_alumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte salones, alumnos, x, y;
            double sumaAlumnos=0, sumaNotas=0, promedio, notaMin=20, notaMax=0;

            Console.WriteLine("*****Registrando Notas*****");
            Console.Write("Ingrese el numero de salones: ");
            salones = byte.Parse(Console.ReadLine());
            

            double[][] notas = new double[salones][];

            //Pedimos el numero de alumnos x salon.
            for(x = 0; x < salones; x++)
            {
                Console.WriteLine("Ingrese el numero de alumnos x salon{0}: ",x);
                alumnos = byte.Parse(Console.ReadLine());
                sumaAlumnos += alumnos;

                notas[x] = new double[alumnos];
            }

            for (x = 0; x < salones; x++)
            {
                Console.WriteLine("Salon {0}", x);

                for (y = 0; y < notas[x].Length; y++)
                {
                    Console.WriteLine("Ingresa la calificacicon del alumno {0}:", y);
                    notas[x][y] = double.Parse(Console.ReadLine());

                    sumaNotas += notas[x][y];
                }
            }

            promedio = sumaNotas / sumaAlumnos;

            for(x = 0;x < salones; x++)
            {
                for(y=0; y<notas[x].Length; y++)
                {
                    if (notas[x][y]<notaMin)
                    {
                        notaMin = notas[x][y];
                    }
                    if (notas[x][y] > notaMax)
                    {
                        notaMax = notas[x][y];
                    }
                }
            }
            for (x = 0; x < salones; x++)
            {
                Console.WriteLine("Salon {0}", x);

                for (y = 0; y < notas[x].Length; y++)
                {
                    Console.WriteLine("El alumno {0}, tiene {1} de calificacion", y, notas[x][y]);
                }
            }

            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("El nota minima es: {0}",notaMin);
            Console.WriteLine("El nota maxima es: {0}", notaMax);
        }
    }
}
