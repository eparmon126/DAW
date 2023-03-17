using System;

namespace Ejer_VT_Dias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el número de días");
            int ini_dias = int.Parse(Console.ReadLine());

            int años = ini_dias / 365;
            int meses = (ini_dias % 365) / 30;
            int semanas = (((ini_dias % 365) % 30)/7);
            int dias = (semanas % 7);

            Console.WriteLine($"{ini_dias} son {años}, {meses}, {semanas}, {dias}");

        }
    }
}
