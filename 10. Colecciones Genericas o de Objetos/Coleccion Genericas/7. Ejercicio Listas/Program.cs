internal class Program
{
    private static void Main(string[] args)
    {
        //Variables:
        int opcion, indice;
        string alumno;

        //Instanciando la lista:
        List<string> Alumnos = new List<string>();

        do
        {
            Console.Clear();
            Console.WriteLine("1. Agregar Estudiante");
            Console.WriteLine("2. Eliminar Estudiante");
            Console.WriteLine("3. Mostrar Estudiante");
            Console.WriteLine("4. Buscar por nombre");

            //Escoger opcion:
            Console.WriteLine("Seleccione una opcion:");
            opcion=int.Parse(Console.ReadLine());
            Console.Clear();

            shitch(opcion){
                case 1:
                    Console.Write("Ingresa el nombre del alumno: ");
                    Alumnos.Add(alumno);
                    break;
                case 2:
                    Console.Write("Ingresa el numero del estudiante que quieres eliminar: ");
                    indice = int.Parse(Console.ReadLine());
                    indice--; //El usuario no sabe que el indice empieza en 0.
                    if(indice >= Alumnos.Count() || indice < 0)
                    {
                        Console.WriteLine("ALUMNO NO EXISTE");
                    }
                    else
                    {
                        string alumnoEliminado = Alumnos[indice];
                        Alumnos.RemoveAt(indice);
                        Console.WriteLine("ALUMNO ELIMINADO: ", alumnoEliminado);
                    }
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 3:
                    int i = 1;

                    foreach(string estudiante in Alumnos)
                    {
                        Console.WriteLine("{0}. {1}", i++, estudiante);
                    }
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 4:
                    string encontrarAlumno; int j;
                    Console.Write("Ingresa el nombre del alumno a buscar: ");
                    alumno = Console.ReadLine();
                    //Verificar si alumno esta en la lista:
                    if(Alumnos.IndexOf(alumno) >= 0)
                    {
                        encontrarAlumno = Alumnos[Alumnos.IndexOf(alumno)];
                        j = Alumnos.IndexOf(alumno) + 1;
                        Console.WriteLine("El estudiante {0} se encuentra en el numero {1} de la lista", encontrarAlumno, j);
                    }
                    else
                    {
                        Console.WriteLine("El estudiante {0} no se encuentra en la lista", encontrarAlumno);
                    }
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    Console.ReadKey();
                    break;
                }

        } while (opcion >= 1 && opcion <= 4);

    }
}