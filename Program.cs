using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_RPG_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of faces on the die: ");
            int max = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            while (true)
            {
                Console.WriteLine("Press Enter to roll the die, press Q to quit");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("You rolled: " + random.Next(1, max + 1).ToString());
                }
                else if (key.Key == ConsoleKey.Q)
                {
                    break;
                }
            }
        }
    }
}
