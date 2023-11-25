using System;

namespace GettingInput
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Koliko imate godina");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Ne ispravan unos, molim vas unesite vase godine!");
                // Ne ispravan unos
            }
            else
                Console.WriteLine($"Imate{input}godina");
        }
    }
}
