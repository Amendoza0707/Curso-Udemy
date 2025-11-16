using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4.Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
 //PEDIREMOS LAS CALIFICACIONES DE VARIOS SALONES DE CLASES EN UNA MATRIZ MULTIDIMEMENSIONALS:
 //LAS FILAS SERAN LOS SALONES Y LAS COLUMNAS EL NUMERO DE ALUMNOS. 

            // 1. Declaramos variables:
            byte salones, numAlumnos, x, y;
            double promedio, sumaNotas=0, notaMin=20, notaMax=0;

            // 2. Pedimos datos por teclado:
            Console.WriteLine("*****SOLICITANDO NOTAS******");
            Console.Write("Ingrese el N° de salones: ");
            salones = byte.Parse(Console.ReadLine());
            Console.Write("Ingrese el N° de alumnos por salon: ");
            numAlumnos = byte.Parse(Console.ReadLine());
            Console.WriteLine("******************************");

            // 3. Creamos la matriz multidimensional:
            double[,] notas = new double[salones,numAlumnos];

            // 4. Pedimos las notas
            for(x = 0; x < salones; x++)
            {

                Console.WriteLine("Salon {0}", x);

                for (y = 0; y < numAlumnos; y++)
                {
                    Console.Write("Ingrese la nota del alumno: ");
                    notas[x,y] = double.Parse(Console.ReadLine());
                }

                // 5. Acumulamos la notas:
                sumaNotas += notas[x,y];
            }

            // 6. Calculamos el promedio.
            promedio = sumaNotas / (numAlumnos*salones);

            // 7. Obtenemos la nota minima:
            for (x = 0; x < salones; x++)
            {
                for (y = 0; y < numAlumnos; y++)
                {
                    if (notas[x,y] < notaMin)
                    {
                        notaMin = notas[x,y];
                    }
                }
            }

            // 8. Obtiene la nota maxima:
            for (x = 0; x < salones; x++)
            {
                for (y = 0; y < numAlumnos; y++)
                {
                    if (notas[x, y] > notaMax)
                    {
                        notaMax = notas[x, y];
                    }
                }
            }

            // 9. Mostramos resultados:
            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("El nota minima es: {0}", notaMin);
            Console.WriteLine("El nota maxima es: {0}", notaMax);

        }
    }
    }

