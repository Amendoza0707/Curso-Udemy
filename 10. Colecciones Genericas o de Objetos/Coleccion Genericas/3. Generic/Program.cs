using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generic<string> generico = new Generic<string>(); // Intanciar
            Generic<int> generico2 = new Generic<int>();
        }
    }

    class Generic <T>
    {

    }


}
