using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Object___Metodo_to_string
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando a la clase automovil
            Automovil automovil = new Automovil();

            // Asignando valor a campo privado
            automovil.Combustible = "Diesel";

            Console.WriteLine(automovil.ToString()); //Convierte un objeto en una cadena
        }
        // [modificador de acceso] [class] [identificador]
        public class Automovil
        {
            //CAMPOS:
            private string color = "Rojo", modelo="civic", combustible="electrico";
            private string numPuertas="4", año="2022";
            private int motor=1500;

            //Ejemplos para campos que usaremos en el constructor:
            private string asientos, tablero;
            private bool camara;

            //Constructor:
            public Automovil()
            {
                asientos = "Cuero rojo";
                tablero = "Cafe";
                camara = true;
            }

            //PROPIEDADES: NOS PERMITE INGRESAR A LAS CLASES PRIVADAS:
            //[acceso]  [tipo]  [Nombre]
            public string Color
            {
                //Descriptor de acceso get:OBTENER
                get => color;

            }

            public string Combustible
            {
                //Descriptor de acceso get:OBTENER
                get { return combustible; }
                //DDescriptor de acceso set:COLOCAR
                set => combustible = value; //{ combustible = value; }
            }

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

            //Invalidando el metodo toString():
            public override string ToString()
            {
                string mensaje;
                mensaje = "El color es: " + color + "\nmodelo es: " + modelo + "\naño: " + año + "\nel motor es: " +motor + "\nasientos: " + asientos + "\n tablero: " + tablero + "\ncamara: " + camara;
                return mensaje;
            }

        }
    }
}
