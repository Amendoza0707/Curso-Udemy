using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.sOBRECARGAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable para recibir concatenar
            string nombreCompleto;
            //Llamando al metodo:
            Nombre nombre = new Nombre();

            nombreCompleto = nombre.Concatenar("Alex", "Mendoza", "Rossi");

            //Mostrando las cadenas concatenadas:
            Console.WriteLine(nombreCompleto);
        }
    }

    class Nombre
    {
        //Metodo
        public string Concatenar(string nombre, string apellido)
        {
            string nombreCompleto;
            nombreCompleto = nombre + " " + apellido;
            return nombreCompleto;
        }

        //Sobrecarga del metodo:
        public string Concatenar (string nombre, string apellido, string apellido2)
        {
            string nombreCompleto;
            nombreCompleto = nombre + " " + apellido + " " + apellido2;
            return nombreCompleto;
        }

    }


}
