using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 0;


            try
            {
                int result = num1 / num2;
            }
            catch ( Exception e)
            {
                Console.WriteLine("No se puede realizar una división entre 0");
            }
        }
    }
}
