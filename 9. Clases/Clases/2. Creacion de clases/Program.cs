using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Creacion_de_clases
{
    class Program
    {
        static void Main(string[] args)
        {

            bool acelerar;
            //Instanciando a la clase automovil
            Automovil automovil = new Automovil();

            //Acceder a los campos de las clase: --- Accedes a las clases por la referencia.
            automovil.color = "rojo";
            automovil.combustible = "gasolina";

            Console.WriteLine("El tipo de combustible es: {0}",automovil.combustible);

            // Acceder a los metodos de la clase:
            acelerar = automovil.Acelerar();
            
            if(acelerar)
            {
                Console.WriteLine("Correcto");
            }

            Automovil.PRUEBA();
        }
    }

    // [modificador de acceso] [class] [identificador]
    public class Automovil
    {
        //CAMPOS:
        public string color, modelo, combustible;
        public byte numPuertas, año;
        public int motor;

        //METODOS:
        public bool Acelerar()
        {
            bool acelerar = true;
            Console.WriteLine("Acelerar");
            PRUEBA();
            return acelerar;
        }

        public bool Frenar()
        {
            bool frenar = true;
            Console.WriteLine("Frenar");
            return frenar;
        }

        public void Velocidades(ref byte velocidad)
        {
            velocidad++;
            Console.WriteLine("Se cambio la velocidad");
        }

        //METODO STATIC
        public static void PRUEBA()
        {
            Console.WriteLine("Soy un metodo statitico");
        }

    }

}
