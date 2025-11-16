using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Empleado__asignacion
{
    class EMPLEADO
    {
        // 1. Se crea la clase:
        // 2. Se crean los campos:
        private string nombre, apellido, id, locker, banco, nip;

        public EMPLEADO(string nombreME, string apellidoME)
        {
            nombre = nombreME;
            apellido = apellidoME;

            //Llamando a los metodos para generar numeros aleatorios:
            id = GENERARID();
            locker = GENERARLOCKER();
            banco = ASIGNARBANCO();
        }

        // 3. Creamos las propiedades:
        public string Nip
        {
            set => nip = value;
        }

        // 4. Metodos:
        private string GENERARID()
        {
            // Instanciamos a randon
            Random random = new Random();
            //Variables
            int i, numero;
            string id = "";

            for (i = 0; i < 10; i++)
            {
                numero = random.Next(10);
                id += numero.ToString();
            }

            return id;
        }
        private string GENERARLOCKER()
        {
            // Instanciamos a randon
            Random random = new Random();
            //Variables
            int i, numero;
            string locker = "";

            for (i = 0; i < 2; i++)
            {
                numero = random.Next(10);
                locker += numero.ToString();
            }

            return locker;
        }

        private string ASIGNARBANCO()
        {
            Random random = new Random();

            int asignarBanco;
            string banco = "";

            asignarBanco = random.Next(1, 5);

            switch (asignarBanco)
            {
                case 1:
                    banco = "INTERBANK";
                    break;
                case 2:
                    banco = "BCP";
                    break;
                case 3:
                    banco = "PICHINCGA";
                    break;
                case 4:
                    banco = "BBVA";
                    break;
            }
            return banco;
        }

        public override string ToString()
        {
            string mensaje = "";

            mensaje = "El empleado es: " + nombre + " " + apellido + "\nN° de empleado: " + id + "\nN° de locker: " + locker + "\nAsignacion de banco: " + banco; 

            return mensaje;
        }



    }
}
