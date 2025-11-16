using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2.FORMULARIO_REGISTRO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contraseña1, contraseña2="";
            int intentos=0;

            Console.Write("Ingrese su Contraseña: ");
            contraseña1 = Console.ReadLine();

            while(contraseña1 != contraseña2)
            {
                Console.Write("Confirma tu contraseña: ");
                contraseña2 = Console.ReadLine();
                intentos++;//Acumulador . cuenta las veces de vueltas al bucle.
            }

            Console.WriteLine("CONTRASEÑA GUARDADA");
            Console.WriteLine("Numero de intentos: {0}", intentos);
        }
    }
}
