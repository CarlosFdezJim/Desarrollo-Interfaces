using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            String[,] Tablero = new String[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; i < 8; j++)
                {
                    if(j == 1 || j == 6)
                    {
                        Tablero[i, j] = "P";
                    }else if((i == 0 || i == 7) && (j == 0 || i == 7))
                    {
                        Tablero[i, j] = "T";
                    }else if((i == 1 || i == 6) && (j == 0 || i == 7))
                    {
                        Tablero[i, j] = "C";
                     }else if((i == 2 || i == 5) && (j == 0 || i == 7))
                     {
                        Tablero[i, j] = "A";
                    }else if (i == 3 && (j == 0 || i == 7))
                    {
                        Tablero[i, j] = "D";
                    }else if(i == 4 && (j == 0 || i == 7))
                    {
                        Tablero[i, j] = "R";
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0 ; j < 8; j++)
                {
                    Console.Write(Tablero[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
