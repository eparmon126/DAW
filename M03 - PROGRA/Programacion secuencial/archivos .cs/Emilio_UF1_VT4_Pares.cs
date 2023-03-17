using System;

namespace Ejer_VT_ArrayPares
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vector = new int[10];
            int cuenta = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Escribe el valor número {i + 1}");
                vector[i] = Convert.ToInt32(Console.ReadLine());
                if (vector[i] % 2 == 0)
                {
                    cuenta++;
                    Console.Beep(1500, 200);
                    Console.Beep(3000, 500);
                }
                else
                {
                    Console.Beep(400, 600);
                }
            }

            Console.WriteLine($"Has introducido {cuenta} números pares");
                      
        
        }
    }
}
