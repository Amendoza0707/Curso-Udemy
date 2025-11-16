using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Clase_Ramdom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciando a la clase ramdom
            Random random = new Random();

            Console.WriteLine(random.Next(10, 100));
        }
    }
}
