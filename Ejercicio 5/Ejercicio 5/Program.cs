using System;

namespace Ejercicio5
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 20);
            bool acertado = false;

            Console.WriteLine("Escribe un número aleatorio entre 0 y 20 (inclusives) ");


            for (int i = 0; i < 5 && acertado != true; i++)
            {
                int entrada = int.Parse(Console.ReadLine());

                if (num > entrada)
                {
                    Console.WriteLine("Introduzca un número MAYOR");
                }
                else if (num < entrada)
                {
                    Console.WriteLine("Introduzca un número MENOR");
                }
                else
                {
                    Console.WriteLine("!!!HAS ACERTADOO!!!");
                    acertado = true;
                }
            }

            if (acertado == false)
            {
                Console.WriteLine("El número era " + num);
            }


        }
    }
}