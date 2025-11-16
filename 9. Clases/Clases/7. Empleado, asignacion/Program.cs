using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Empleado__asignacion
{
//Se contrato un empleado y se necesita registar para generar cuentas de banco, id, y mas:
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido, nip;

            Console.WriteLine("******ASIGNADO DATOS A TRABAJADOR *****");
            Console.WriteLine("Ingrese los sgtes campos: ");
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Digite su NIP para asignarlo a su tarjeta bancaria: ");
            nip = Console.ReadLine();

            //Instanciamos o llamamos a la clase empleado:
            EMPLEADO empleado = new EMPLEADO(nombre, apellido);

            empleado.Nip = nip;

            //Mostrar la informacion.
            Console.WriteLine(empleado.ToString());
        }
    }
}
