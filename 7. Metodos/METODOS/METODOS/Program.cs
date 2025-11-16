using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METODOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TRABAJANDO CON METODOS SIN PARAMETROS , NI TIPO:
            //DECLARANDO VARIABLES:
            int opcion;
            int r; //DEVOLVERA RESULTADO DE RESTA
            int num1AR, num2AR;

            //DECLARAMOS UNA TUPLA:
            (int num1, int num2, int resultado) NUMEROS;

            //DO:
            do
            {
                Console.WriteLine("1. SUMA");
                Console.WriteLine("2. RESTA");
                Console.WriteLine("3. MULTIPLICACIÓN");
                Console.WriteLine("4. DIVISION");

                //PEDIMOS LA OPCION:
                Console.Write("Seleccione la opcion:");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("***********************");
            }

            while ((opcion < 1) || (opcion > 4));

            switch(opcion)
            {
                case 1:
                    SUMAR();
                    break;

                case 2:
                    NUMEROS = RESTAR();//Asignamos a la tupla NUMEROS el valor por return;
                    Console.WriteLine("El resultado de la resta es: {0}",NUMEROS.resultado);
                    break;

                case 3:
                    Console.Write("Ingrese el primer numero: ");
                    num1AR = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo numero: ");
                    num2AR = int.Parse(Console.ReadLine());

                    //INVOCAMOS AL METODO:
                    MULTIPLICAR(num1AR, num2AR);
                    break;

                case 4:
                    Console.Write("Ingrese el primer numero: ");
                    num1AR = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo numero: ");
                    num2AR = int.Parse(Console.ReadLine());

                    r = DIVIDIR(num1AR, num2AR);

                    Console.WriteLine("El resultado de la division es: {0}", r);
                    break;
            }

        }//CIERRE DEL METODO MAIN
        //ABRIENDO METODOS: 
        //[MODIFICADOR] [TIPO] [IDENTIFICADOR] [PARAMETROS]
        static void SUMAR()
        {
            int num1, num2, resultado;//VARIABLES DEL METODO SUMAR

            //PEDIMOS EL VALOR DE NUMEROS:
            Console.Write("Ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            //OPERACION:
            resultado = num1 + num2;

            //RESULTADOS: 
            Console.WriteLine("LA SUMA DE: {0} + {1} = {2}",num1,num2,resultado);
        }

        //METODO QUE DEVUELVE UN TIPO:
        //[MODIFICADOR] [TIPO] [IDENTIFICADOR] [PARAMETROS]
        static (int, int, int) RESTAR()
        {
            int num1, num2, resultado;
            //PEDIMOS EL VALOR DE NUMEROS:
            Console.Write("Ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            //OPERACION:
            resultado = num1 - num2;

            //RESULTADOS, DEVOLVEMOS A UN TIPO QUE LO SOLICITO
            return (num1, num2, resultado);
        }

        //METODO CON PARAMETROS:
        //[MODIFICADOR] [TIPO] [IDENTIFICADOR] [PARAMETROS]
        static void MULTIPLICAR(int num1PA, int num2PA)
        {
            int resultado; //MULTIPLICACION CON LOS VALORES DE LOS ARGUMENTOS.

            resultado = num1PA * num2PA;

            Console.WriteLine("La multiplicacion es: {0}", resultado);
        }

        //METODO CON PARAMETROS QUE DEVUELVEN UM TIPO:
        //[MODIFICADOR] [TIPO] [IDENTIFICADOR] [PARAMETROS]
        static int DIVIDIR(int num1PA, int num2PA)
        {
            int resultado;

            if (num2PA == 0)
            {
                Console.WriteLine("DIVISOR NO VALIDO");
                resultado = 0;
            }
            else
            {
                resultado = num1PA / num2PA;
            }

            return resultado;
        }

    }
}
