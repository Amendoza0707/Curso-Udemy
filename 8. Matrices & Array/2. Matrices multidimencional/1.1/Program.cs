using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //tipo [,] nombre = new tipo [fila,columna]
            double[,] ventas = new double[4, 3] { {100,120,205},
                                                  {115,196,300},
                                                  {157,172,245},
                                                  {130,180,281}, 
                                                };


        //Declaracion e instancia de matriz 3 dimensiones:
            int[,,] matriz3d = new int[2, 2, 3] { { {1,2,3}, {4,5,6} },
                                                { {7,8,9}, {10,11,12} } };







            ////Declaracion e instancia de matriz 3 dimensiones:
            //    double[,,] ventasAño = new double[5,3,3];



        }
    }
}
