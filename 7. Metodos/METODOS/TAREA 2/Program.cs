using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TAREA_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AREA CIRCULO A = PI * R2
            //AREA CUADRADO A = B * H
            //AREA TRIANGULO A = (B * H) / 2

            //DECLARAMOS VARIABLES:
            double radio, bas, altura, lado, area;
            int opcion;

            //MOSTRAMOS MENU:
            Console.WriteLine("****ESCOGE LAS OPCIONES: ***** ");
            Console.WriteLine("1. Area del circulo");
            Console.WriteLine("2. Area del cuadrado");
            Console.WriteLine("3. Area del trinagulo");
            Console.WriteLine("**********************");
            Console.Write("Seleccione la opcion: ");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("**********************");

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el radio del circulo: ");
                    radio = double.Parse(Console.ReadLine());

                    //INVOCAMOS AL METODO:
                    area = AREACIRCULO(radio);

                    Console.WriteLine("El area es: {0}",area);

                    break;

                case 2:
                    Console.Write("Ingrese lado del cuadrado: ");
                    lado = double.Parse(Console.ReadLine());
                    
                    //INVOCAMOS EL METODO:
                    area = AREACUADRADO(lado);

                    Console.WriteLine("El area es: {0}", area);

                    break;

                case 3:
                    Console.Write("Ingrese base del triangulo: ");
                    bas = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese altura del triangulo: ");
                    altura = double.Parse(Console.ReadLine());

                    //INVOCAMOS EL METODO:
                    area = AREATRIANGULO(bas, altura);

                    Console.WriteLine("El area es: {0}", area);

                    break;

            }

        }

        //METODOS - FUERA DEL MAIN:
        //CIRCULO:
        static double AREACIRCULO(double radio)
        {
            double area;

            //CALCULA EL AREA:
            area = (radio * radio) * 3.1416;

            //REGRESAMOS EL VALOR:
            return area;
        }

        //CUADRADO:
        static double AREACUADRADO(double lado)
        {
            double area;

            //CALCULA EL AREA:
            area = lado * lado;

            //REGRESAMOS EL VALOR:
            return area;
        }

        //TRIANGULO:
        static double AREATRIANGULO(double bas, double altura)
        {
            double area;

            //CALCULA EL AREA:
            area = (bas * altura) / 2;

            //REGRESAMOS EL VALOR:
            return area;
        }
    }
}
