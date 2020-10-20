using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            


            try
            {
                Console.WriteLine("Introduzca dos números para dividirlos.");
                Console.WriteLine("Introduzca un número");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca otro número");
                num2 = int.Parse(Console.ReadLine());
                int result = num1 / num2;
            }
            catch ( DivideByZeroException )
            {
                Console.WriteLine("No se puede realizar una división entre 0");
            }
            catch (FormatException f)
            {
                Console.WriteLine("El valor debe de ser un valor entero.");
            }
            catch (OverflowException )
            {
                Console.WriteLine("El número es demasiado grande");
            }
        }
    }
}
