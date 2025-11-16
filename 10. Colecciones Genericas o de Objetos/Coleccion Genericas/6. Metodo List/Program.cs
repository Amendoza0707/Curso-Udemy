//---------------------------------------
//-                                     -
//-         clase LIST <t>              -
//-                                     -
//---------------------------------------

internal class Program
{
    private static int i;

    private static void Main(string[] args)
    {
        //Variables Necesarias:
        string elemento;
        int opcion;

        //Sintaxis basica:

        List<string> personas = new List<string>();

        // Para agregar elementos se usa el metodo "add"

            //personas.Add("Alex");
            //personas.Add("Madeleine");
            //personas.Add("Mariana");
            //personas.Add("Elvira");

        do
        {
            Console.WriteLine("1. Agregar elemento");
            Console.WriteLine("2. Salir");
            opcion = int.Parse(Console.ReadLine());

            if(opcion == 1)
            {
                Console.WriteLine("Ingrese el elemento a agregar en la lista");
                elemento = Console.ReadLine();

                personas.Add(elemento);
            }
            Console.WriteLine("");
        }
        while (opcion == 1);

        //Mostramos los elementos de la lista:
        //for (int i = 0; i < personas.Count(); i++) ;
       // {
            //Console.WriteLine(personas[i]);
        //}

        //utilizandi foreach
         foreach(string elementos in personas)
        {
            Console.WriteLine(elementos);
        }
    }
}