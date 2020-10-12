using System;

public class Ejercicio6
{
    public static void Main()
    {
        Console.WriteLine("Escribe un número y descubre cuantos 7 hay en él.");
        Console.WriteLine("247371");
        Console.WriteLine("---------------------------------------");

        int count = 0;
        String numero = "247371";
        String encontrar = "7";

        //foreach --> String

         foreach (int encontar in numero)
         {
             if (numero.Equals(encontrar))
             {
                 count++;
             }
            Console.WriteLine("No entra");
         }


        Console.WriteLine("El número 7 se ha repetido " + count + " veces");
        //Console.ReadKey();
        //do...while -->Int


        do
        {



        } while ()
}