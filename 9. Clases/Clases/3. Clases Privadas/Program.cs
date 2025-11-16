using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3.Clases_Privadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciando a la clase automovil
            Automovil automovil = new Automovil();

            //Mostrando el campo privado
            Console.WriteLine("El color es : {0}",automovil.Color);

            // Asignando valor a campo privado
            automovil.Combustible = "Diesel";

            Console.WriteLine("El combustible es : {0}",automovil.Combustible);

        }

        // [modificador de acceso] [class] [identificador]
        public class Automovil
        {
            //CAMPOS:
            private string color="Rojo", modelo, combustible;
            private byte numPuertas, año;
            private int motor;

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

        }
    }
}
