using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukolbrezen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte první číslo");
            int cislo1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadejte druhé číslo");
            int cislo2 = Convert.ToInt32(Console.ReadLine());
            int max = Math.Max(cislo1, cislo2);
            int min = Math.Min(cislo1, cislo2);
            Console.WriteLine($"{max} > {min}");
            Console.ReadKey();
            if (cislo1 == cislo2)
            {
                Console.WriteLine("Čísla jsou shodná");
            }
        }
    }
}
