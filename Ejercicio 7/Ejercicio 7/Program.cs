using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if((i + j) % 2 == 0)
                    {
                        Console.Write(" B ");
                    }else
                    {
                        Console.Write(" N ");
                    }
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
