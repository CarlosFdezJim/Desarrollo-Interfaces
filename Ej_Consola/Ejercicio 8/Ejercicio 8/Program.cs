using System;

namespace Ejercicio_8
{
    class Program
    {

        static void Main(string[] args)
        {
            int mes;
            int years;

            Console.WriteLine("Bienvenido" + "\nPor favor, introduzca la fecha, primero el mes : ");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Ahora introduzca el año: ");
            years = int.Parse(Console.ReadLine()); 

            Console.WriteLine("El fecha introducida es " + mes + " de " + years);


            switch (mes)
            {
                case 1:
                    Console.WriteLine("El mes " + mes + "del año " + years + " tiene 31 días.");
                    break;

                case 2:
                    Console.WriteLine("El mes " + mes + "del año " + years + " tiene 28 días.");
                    break;

                case 3:
                    Console.WriteLine("El mes " + mes + "del año " + years + " tiene 31 días.");
                    break;
                case 4:
                    Console.WriteLine("El mes " + mes + "del año " + years + " tiene 30 días.");
                    break;

                case 5:
                    Console.WriteLine("El mes " + mes + "del año " + years + " tiene 31 días.");
                    break;

                case 6:
                    Console.WriteLine("El mes " + mes + "del año " + years + " tiene 30 días.");
                    break;

                case 7:
                    Console.WriteLine("El mes " + mes + "del año " + years + " tiene 31 días.");
                    break;

                case 8:
                    Console.WriteLine("El mes " + mes + "del año " + years + " tiene 31 días.");
                    break;

                case 9:
                    Console.WriteLine("El mes " + mes + "del año " + years + " tiene 30 días.");
                    break;

                case 10:
                    Console.WriteLine("El mes " + mes + "del año " + years + " tiene 31 días.");
                    break;

                case 11:
                    Console.WriteLine("El mes " + mes + "del año " + years + " tiene 30 días.");
                    break;

                case 12:
                    Console.WriteLine("El mes " + mes + "del año " + years + " tiene 31 días.");
                    break;

                default:
                    Console.WriteLine("Ese mes no exite MENTIROSO");
                    break;
            }

            if ((years % 4 == 0 && years % 100 != 0 ) || (years % 400 == 0))
            {
                Console.WriteLine("Es bisiesto {0}\n", years);
            }
            else
            {
                Console.WriteLine("no es bisiesto {0} \n", years);
            }
            //Console.ReadKey();
        }
    }
}
