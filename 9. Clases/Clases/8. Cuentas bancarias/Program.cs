using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Cuentas_bancarias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double monto=0, saldoinicialAR;
            int opcion;
            string nombreAR, apellidosAR, direccionAR, DNIAR;

            Console.WriteLine("***** CUENTA BANCARIA *****");
            Console.ReadKey();

            Console.WriteLine("Ingrese la informacion solicitada: ");
            Console.WriteLine("");
            Console.Write("Nombre: ");
            nombreAR = Console.ReadLine();
            Console.Write("Apellidos: ");
            apellidosAR = Console.ReadLine();
            Console.Write("N° de DNI: ");
            DNIAR = Console.ReadLine();
            Console.Write("Direccion: ");
            direccionAR= Console.ReadLine();
            Console.Write("Ingrese su deposito inicial: S/.");
            saldoinicialAR = double.Parse(Console.ReadLine());

            //Instanciamos la clase:
            BANCO cliente = new BANCO(nombreAR, apellidosAR, saldoinicialAR, direccionAR, DNIAR);

            // Mensaje creacion de cuenta:
            Console.WriteLine("Su cuenta a sido creada con Exito");
            Console.ReadKey();

            //Menu
            do
            {
                Console.WriteLine("\n1.Deposito");
                Console.WriteLine("2. Retiro");
                Console.WriteLine("3. Consulta saldo");
                Console.WriteLine("4. Informacion de cuenta");
                Console.WriteLine("5. Salir");
                Console.WriteLine("");
                Console.Write("Elija una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el monto a depositar: ");
                        monto = double.Parse(Console.ReadLine());

                        cliente.Depositar(monto);
                        break;

                    case 2:
                        Console.Write("Ingrese el monto a retirar: S/.");
                        cliente.Retiro(monto);
                        break;

                    case 3:
                        cliente.ConsultaSaldo();
                        break;
                    
                    case 4:
                        Console.WriteLine(cliente.ToString());
                        break;
                }
            }
            while (opcion >=1 && opcion <=4);
        }
    }
}
