using System;

//Crea un vector con 5 Jugadores de futbol, añadiendo su nombre, dorsal y pais de procedencia, luego pregunta al usuario que selección quiere mostrar.

namespace Ejercicio_10
{
    class Program
    {

        public static void Main()
        {
            Persona p = new Persona();
            p.DataBase();
            p.Menu();

        }
    }
}