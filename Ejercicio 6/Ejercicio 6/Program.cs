using System;

public class Ejercicio6
{
    public static void Main()
    {
        Console.WriteLine("Escribe un número y descubre cuantos 7 hay en él.");
        //int num = 
        Console.WriteLine("247371");
        Console.WriteLine("---------------------------------------");
        int count = 0;
        int num = 247371;

        //var number = new List <String>();
        //number.Add(num);

        //foreach --> String
        //do...while -->Int

        foreach (int x in num)
        {
            if (num.Equals(7))
            {
                count++;
                Console.WriteLine(x);
            }
            
        }

        Console.WriteLine("El número 7 se ha repetido " + count + " veces");
        //Console.ReadKey();
    }
}