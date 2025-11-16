using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_Implicita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Matriz implicita unidimensional 
            var matriz = new[] { 1.5, 2.5, 3.8, 4 };
            //Matriz multidimensional:
            var matriz2 = new[,] { {2,3}, {4,6} };
            //Matriz escalonada, jagger
            var matriz3 = new[]
            {
                new[] {12,23},
                new[] {15,30}
            };

        }
    }
}
