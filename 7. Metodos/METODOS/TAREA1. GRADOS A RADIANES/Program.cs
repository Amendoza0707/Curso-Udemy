using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA1.GRADOS_A_RADIANES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO:
            //Pedir el numero en grados.
            //Enviar los grados al metodo.
            //Covertir los grados a radianes, mediante la formula.
            //Devolver la conversion.
            //Mostrar el resultado
            //FIN

            //DECLARAMOS VARIABLES:
            double grados, radianes;

            //PEDIMOS LOS GRADOS:
            Console.Write("Ingresa los grados: "); 
            grados = double.Parse(Console.ReadLine());

            //INVOCAMOS METODOS
            radianes = GRADOSRADIANES(grados);

            //MOSTRAMOS RESULTADO:
            Console.WriteLine("La conversion de {0}° a radieanes es {1} radianes.",grados,radianes);

        }

        static double GRADOSRADIANES(double grados)
        {
            double radianes;
       
            radianes = (grados * Math.PI) / 180;

            return radianes;
        }
    }
}
