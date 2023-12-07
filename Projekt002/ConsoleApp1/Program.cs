using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object 1#
            bool spayed = true;
            double korjenIzDva = 1.414213562;
            int myAge;
            myAge = 22;
            int dogAge;
            dogAge = 5;
            string name = "Ivan";
            string Country = "Hrvatska";
            int paranBroj = 2;
            int neparanBroj = 23;
            double weight;
            weight = 92.55;
            string breed = "Doberman";
            string dogName = "Ares";
            Console.WriteLine(paranBroj + neparanBroj);
            Console.WriteLine(neparanBroj - paranBroj);
            // Print variables to the console
            Console.WriteLine(dogName);
            Console.WriteLine(breed);
            Console.WriteLine(dogAge);
            Console.WriteLine(spayed);

            Console.WriteLine(name);
            Console.WriteLine(myAge);
            Console.WriteLine(Country);
            Console.WriteLine(weight);
            Console.WriteLine($"Fun fact is the root of two = {korjenIzDva} ");
            Console.WriteLine("Fun fact is the root of two =" + korjenIzDva);
            // In line up we see 2 ways of calling variable inside string  or text 
            Console.ReadLine();


            // Object 2 debug followng programm

            /* 
             * using System;
            namespace BugSquasher
            {
            class Program
            {
            static void Main(string[] args)
            {
                int number = 38498.3222;

                dinosaur = "Barney";

                double lock = 293.000;

                bool is.yes = true;

                string band = "The Low Anthem"

            }
            }
            }
            */
            /* Soultion
             * using System;

            namespace BugSquasher
            {
            class Program
            {
            static void Main(string[] args)
            {
            int number = 38498;

            string dinosaur = "Barney";

            double myNum = 293.000;

            bool yes = true;

            string band = "The Low Anthem";


            }
            }
            }
            */


        }
    }
}
