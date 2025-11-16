using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Ejemplo_Sin_Genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables locales:
            Alumno valorElementos;

            //Instanciamos la clase:
            GuardaObjetos<Alumno> objetos1 = new GuardaObjetos<Alumno>(3);

            //Agregar objetos
           /* objetos1.AgregarElementos("Alex");
            objetos1.AgregarElementos("Madeleine");
            objetos1.AgregarElementos("Mariana");*/

            Alumno alumno1 = new Alumno(8.4);
            Alumno alumno2 = new Alumno(9.8);
            Alumno alumno3 = new Alumno(6);

            objetos1.AgregarElementos(alumno1);
            objetos1.AgregarElementos(alumno2);
            objetos1.AgregarElementos(alumno3);

            //Obtener Elementos:
            valorElementos = (Alumno)objetos1.ObtenerElemento(0);
            Console.WriteLine(valorElementos.Nota);

        }

        class GuardaObjetos<T>
        {
           //Campo
           private int i = 0;
           private T[] matrizElementos;

            //Constructor
            public GuardaObjetos(int elementosPA)
            {
                matrizElementos = new T[elementosPA];
            }

            //Metodos
            public void AgregarElementos(T elementoPA)
            {
                matrizElementos[i] = elementoPA;
                i++;
            }

            public T ObtenerElemento(int elementoPA)
            {
                return matrizElementos[elementoPA];
            }

        }
    }
}
