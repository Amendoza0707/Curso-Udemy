using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Iniciando_Sintasis
{
    internal class Program
    {
        static void Main(string[] args)
        {
    //SINTASIS: 
            int i; // OPERANDO
            i = 10;
            Console.WriteLine("Valor inicial del operando: {0}",i);

    //INCREMENTO COMO SUFIJO E IMPRIMIDOS:
            Console.WriteLine("Valor con incremento incluido: {0}", ++i);
        //YA NO INCREMENTO, SOLO IMPRIMO:
            Console.WriteLine(i);

    //DECREMENTO:
            int n = 20;
            Console.WriteLine("--------------------");
            Console.WriteLine("Valor inicial del operando: {0}", n);
            Console.WriteLine("Valor con decremento: {0}", --n);
        }
    }
}
