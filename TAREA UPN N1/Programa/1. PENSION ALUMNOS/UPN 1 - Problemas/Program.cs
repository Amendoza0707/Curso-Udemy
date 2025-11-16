using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPN_1___Problemas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAMOS LAS VARIABLES
            char categoria;
            double pensionActual, descuento, promedioNota, nuevaPension;
            

            //SOLICITAMOS DATOS AL USUARIO:
            Console.WriteLine("******  TABLA DE DESCUENTO PENSIONAL  ******");
            Console.WriteLine("Categoria de pensiones universitarias:");
            Console.WriteLine("A - S/.550");
            Console.WriteLine("B - S/.500");
            Console.WriteLine("C - S/.460");
            Console.WriteLine("D - S/.400");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Alumno, Seleccione su categoria: ");
            categoria = char.Parse(Console.ReadLine().ToUpper());
            Console.Write("Ingrese su promedio final del ciclo: ");
            promedioNota = double.Parse(Console.ReadLine());
            

            switch (categoria)
            {
                case 'A':

                    pensionActual = 550;
                    if (promedioNota < 14)
                    {
                        Console.WriteLine("USTED NO APRUEBA PARA UN DESCUENTO, SU PENSION ACTUAL ES: S/{0} ", pensionActual);
                    }
                    else
                    {
                        if (promedioNota >= 14 && promedioNota < 16)
                        {
                            descuento = 550 * 0.10;
                            nuevaPension = 550 - descuento;
                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine("USTED APRUEBA PARA UN DESCUENTO DE: S/.{0}", descuento);
                            Console.WriteLine("SU NUEVA PENSION PARA ESTE CICLO ES DE: S/.{0}", nuevaPension);
                        }

                        else
                        {
                            if (promedioNota >= 16 && promedioNota < 18)
                            {
                                descuento = 550 * 0.12;
                                nuevaPension = 550 - descuento;
                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("USTED APRUEBA PARA UN DESCUENTO DE: S/.{0}", descuento);
                                Console.WriteLine("SU NUEVA PENSION PARA ESTE CICLO ES DE: S/.{0}", nuevaPension);
                            }

                            else 
                            {
                                descuento = 550 * 0.15;
                                nuevaPension = 550 - descuento;
                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("USTED APRUEBA PARA UN DESCUENTO DE: S/.{0}", descuento);
                                Console.WriteLine("SU NUEVA PENSION PARA ESTE CICLO ES DE: S/.{0}", nuevaPension);
                            }
                        }
                    }

                break;

                case 'B':

                    pensionActual = 500;
                    if (promedioNota < 14)
                    {
                        Console.WriteLine("USTED NO APRUEBA PARA UN DESCUENTO, SU PENSION ACTUAL ES: S/{0} ", pensionActual);
                    }
                    else
                    {
                        if (promedioNota >= 14 && promedioNota < 16)
                        {
                            descuento = pensionActual * 0.10;
                            nuevaPension = pensionActual - descuento;
                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine("USTED APRUEBA PARA UN DESCUENTO DE: S/.{0}", descuento);
                            Console.WriteLine("SU NUEVA PENSION PARA ESTE CICLO ES DE: S/.{0}", nuevaPension);
                        }

                        else
                        {
                            if (promedioNota >= 16 && promedioNota < 18)
                            {
                                descuento = pensionActual * 0.12;
                                nuevaPension = pensionActual - descuento;
                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("USTED APRUEBA PARA UN DESCUENTO DE: S/.{0}", descuento);
                                Console.WriteLine("SU NUEVA PENSION PARA ESTE CICLO ES DE: S/.{0}", nuevaPension);
                            }

                            else
                            {
                                descuento = pensionActual * 0.15;
                                nuevaPension = pensionActual - descuento;
                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("USTED APRUEBA PARA UN DESCUENTO DE: S/.{0}", descuento);
                                Console.WriteLine("SU NUEVA PENSION PARA ESTE CICLO ES DE: S/.{0}", nuevaPension);
                            }
                        }
                    }

                break;

                case 'C':

                    pensionActual = 460;
                    if (promedioNota < 14)
                    {
                        Console.WriteLine("USTED NO APRUEBA PARA UN DESCUENTO, SU PENSION ACTUAL ES: S/{0} ", pensionActual);
                    }
                    else
                    {
                        if (promedioNota >= 14 && promedioNota < 16)
                        {
                            descuento = pensionActual * 0.10;
                            nuevaPension = pensionActual - descuento;
                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine("USTED APRUEBA PARA UN DESCUENTO DE: S/.{0}", descuento);
                            Console.WriteLine("SU NUEVA PENSION PARA ESTE CICLO ES DE: S/.{0}", nuevaPension);
                        }

                        else
                        {
                            if (promedioNota >= 16 && promedioNota < 18)
                            {
                                descuento = pensionActual * 0.12;
                                nuevaPension = pensionActual - descuento;
                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("USTED APRUEBA PARA UN DESCUENTO DE: S/.{0}", descuento);
                                Console.WriteLine("SU NUEVA PENSION PARA ESTE CICLO ES DE: S/.{0}", nuevaPension);
                            }

                            else
                            {
                                descuento = pensionActual * 0.15;
                                nuevaPension = pensionActual - descuento;
                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("USTED APRUEBA PARA UN DESCUENTO DE: S/.{0}", descuento);
                                Console.WriteLine("SU NUEVA PENSION PARA ESTE CICLO ES DE: S/.{0}", nuevaPension);
                            }
                        }
                    }

                break;

                case 'D':

                    pensionActual = 400;
                    if (promedioNota < 14)
                    {
                        Console.WriteLine("USTED NO APRUEBA PARA UN DESCUENTO, SU PENSION ACTUAL ES: S/{0} ", pensionActual);
                    }
                    else
                    {
                        if (promedioNota >= 14 && promedioNota < 16)
                        {
                            descuento = pensionActual * 0.10;
                            nuevaPension = pensionActual - descuento;
                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine("USTED APRUEBA PARA UN DESCUENTO DE: S/.{0}", descuento);
                            Console.WriteLine("SU NUEVA PENSION PARA ESTE CICLO ES DE: S/.{0}", nuevaPension);
                        }

                        else
                        {
                            if (promedioNota >= 16 && promedioNota < 18)
                            {
                                descuento = pensionActual * 0.12;
                                nuevaPension = pensionActual - descuento;
                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("USTED APRUEBA PARA UN DESCUENTO DE: S/.{0}", descuento);
                                Console.WriteLine("SU NUEVA PENSION PARA ESTE CICLO ES DE: S/.{0}", nuevaPension);
                            }

                            else
                            {
                                descuento = pensionActual * 0.15;
                                nuevaPension = pensionActual - descuento;
                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("USTED APRUEBA PARA UN DESCUENTO DE: S/.{0}", descuento);
                                Console.WriteLine("SU NUEVA PENSION PARA ESTE CICLO ES DE: S/.{0}", nuevaPension);
                            }
                        }
                    }

                 break;

                default:
                    Console.WriteLine("SELECCIONO UNA CATEGORIA QUE NO TENEMOS - VUELVE A INTENTAR");
                break;

            }

            Console.ReadKey();
        }
    }
}
