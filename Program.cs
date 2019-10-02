using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_GradeBoundaries
{
    class Program
    {
        /*
		<2	U
		2	1
		4	2
		13	3
		22	4
		31	5
		41	6
		54	7
		67	8
		80	9

         */
        static void Main(string[] args)
        {
            Console.Write("Enter your mark: ");
            int score = Convert.ToInt32(Console.ReadLine());
            if(score < 2)
            {
                int missed = 2 - score;
                Console.WriteLine("You achieved a grade U. "+missed.ToString()+" off a 1.");
            } else if (score < 4)
            {
                int missed = 4 - score;
                Console.WriteLine("You achieved a grade 1. " + missed.ToString() + " off a 2.");
            } else if(score < 13)
            {
                int missed = 13 - score;
                Console.WriteLine("You achieved a grade 2. " + missed + " off a 3.");
            }
            else if (score < 22)
            {
                int missed = 22 - score;
                Console.WriteLine("You achieved a grade 3. " + missed.ToString() + " off a 4.");
            }
            else if (score < 31)
            {
                int missed = 31 - score;
                Console.WriteLine("You achieved a grade 4. " + missed + " off a 5.");
            }
            else if (score < 41)
            {
                int missed = 41 - score;
                Console.WriteLine("You achieved a grade 5. " + missed.ToString() + " off a 6.");
            }
            else if (score < 54)
            {
                int missed = 54 - score;
                Console.WriteLine("You achieved a grade 6. " + missed + " off a 7.");
            }
            else if (score < 67)
            {
                int missed = 67 - score;
                Console.WriteLine("You achieved a grade 7. " + missed.ToString() + " off a 8.");
            }
            else if (score < 80)
            {
                int missed = 80 - score;
                Console.WriteLine("You achieved a grade 8. " + missed + " off a 9.");
            }
            else
            {
                Console.WriteLine("You achieved a 9. Good job!");
            }Console.ReadLine();
        }
    }
}
