using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi! Please enter an integer! ");
            long input = long.Parse(Console.ReadLine());

            Console.WriteLine("Number\t Squared\tCubed");
            Console.WriteLine("======\t =======\t=====");

            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine($"{i}\t {i*i}\t\t{i*i*i}");
            }

            Console.WriteLine("Would you like to go again? (y/n)");
            string response = Console.ReadLine();

            if (response == "y" || response == "Y" || response == "yes")
            {
                Console.Clear();
                Main(args);
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
