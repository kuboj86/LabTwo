using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"What up {name}!");

            Boolean retry = false;
            do
            {
                NumberInput(name);
                retry = Retry(name);
            } while (retry);
            Console.WriteLine($"OK {name}, see you later!");
            Console.ReadLine();
        }
        static void NumberInput(String name)
        {
            while (true)
            {
                Console.Write($"{name}... please enter a number from 1-100:   ");
                string input = Console.ReadLine();
                int num;
                bool success = int.TryParse(input, out num);
                if (!success)
                {
                    Console.WriteLine("That input is not a number.");
                    continue;
                }
                if (num % 2 == 0 && num <= 25)
                {
                    Console.WriteLine($" {num} is an even number and less than 25");
                    break;
                }
                else if (num % 2 == 0 && num >= 25 && num <= 60)
                {
                    Console.WriteLine($" {num} is an even number and is between 26 and 60");
                    break;
                }
                else if (num % 2 == 0 && num >= 60)
                {
                    Console.WriteLine($"{num} is even and greater than 60");
                    break;
                }
                else if (num % 2 == 1 && num >= 60)
                {
                    Console.WriteLine($"{num} is odd and greater than 60");
                    break;
                }
                else
                {
                    Console.WriteLine($"{num} is an odd number");
                    break;
                }
            }
        }
        static Boolean Retry(String name)
        {
            Console.WriteLine($"{name}... would you like to run this program again?   Y/N:");
            string answer = Console.ReadLine();
            return Char.ToLower(answer[0]) == 'y';
        }
    }
}
