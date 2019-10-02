using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_DivisibleProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            while (true)
            {
                try
                {
                    Console.Write("Enter number 1: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter number 2: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    break;
                }
                catch
                {
                    Console.WriteLine("Please make sure you enter two integers");
                }
            }
            try
            {
                int result = num2 / num1;
                if (num2%num1 == 0)
                {
                    Console.WriteLine(num2+" is exactly divisable by "+num1+".");
                }
                else
                {
                    Console.WriteLine(num2+"/"+num1+" gives a remainder of "+(num2%num1)+".");
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by zero.");
            }
            catch
            {
                Console.WriteLine("Something went wrong.");
            }

            Console.ReadLine();
        }
    }
}
