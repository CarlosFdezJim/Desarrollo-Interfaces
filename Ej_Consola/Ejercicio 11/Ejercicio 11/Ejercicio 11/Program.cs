using System;
using System.Collections;

//Almacenar 5 personas en un vector y ordenarlas alfabéticamente sobre el mismo vector

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.DataBase();
            
            Console.WriteLine("");
            Console.WriteLine("Pulsa ENTER para ver la lista ordenada");
            Console.ReadKey();
            Console.Clear();

            p.OrdenarDB();

            Console.ReadKey();
        }
    }
}
