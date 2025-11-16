using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Cuentas_bancarias
{
    internal class BANCO
    {
        //Creamos los campos:
        string nombre, apellidos, direccion, DNI;
        double saldo;

        //Constructor
        public BANCO(string nombreME, string apellidosME, double saldoME, string direccionME, string DNIME)
        {
            nombre = nombreME;
            apellidos = apellidosME;
            saldo = saldoME;
            direccion = direccionME;
            DNI = DNIME;
        }

        public void ConsultaSaldo()
        {
            Console.WriteLine("Su saldo es: {0}",saldo);
        }

        public override string ToString()
        {
            string mensaje = "";
            mensaje = "Saludos: " + nombre + " " + apellidos + "\nN° DNI: " + DNI + "\nDireccion: " + direccion + "\nSaldo actual: S/. " + saldo;

            return mensaje;
        }

        public double Depositar(double MontoME)
        {
            saldo += MontoME;
            return saldo;
        }

        public double Retiro(double MontoME)
        {
            if (saldo >= MontoME)
            {
                saldo -= MontoME;
            }

            else
            {
                Console.WriteLine("Saldo insuficiente");
            }

            return saldo;
        }

    }
}
