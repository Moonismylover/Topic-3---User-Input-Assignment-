using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Topic_3___User_Input__Assignment_
{
    internal class Program
    {
        public static void Greetings()
        {
            Console.WriteLine("-------------------------Greetings-------------------------");
            Console.WriteLine();

            Console.Write("Name: ");
            string userName = Console.ReadLine();

            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Current Year: ");
            int currentYear = Convert.ToInt32(Console.ReadLine());

            int birthYear = currentYear - age;

            Console.WriteLine();

            Console.WriteLine($"Hello {userName}, I know when you were born. Creepy... isn't it?)");
            Console.WriteLine($"You were in {birthYear}, weren't you? Get ready to be scammed!!! WAHAHAHHAHA!");

            Console.WriteLine();

            Console.WriteLine("Try putting in a different age and see if I can still figure out when you were born. (Hint: I can AND I WILL!!!)");
            Console.Write("Second Age: ");
            int ageTwo = Convert.ToInt32(Console.ReadLine());

            birthYear = DateTime.Now.Year - ageTwo;

            Console.WriteLine();

            Console.WriteLine($"{userName.ToUpper()}, no matter how much you try to hide away from me. I will always find out. You were born in {birthYear}!");
        
            Console.WriteLine();
        }

        public static void Adder()
        {
            Console.WriteLine("-------------------------Adder-------------------------");
            Console.WriteLine();

            int integerOne, integerTwo, integerThree, total = 0;

            Console.WriteLine("Enter 3 integers to add together!");

            Console.WriteLine();

            Console.Write("Integer #1: ");

            while (!Int32.TryParse(Console.ReadLine(), out integerOne))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input!!! Please try again!");
                Console.Write("Integer #1: ");
            }

            Console.WriteLine();
            Console.Write("Integer #2: ");

            while (!Int32.TryParse(Console.ReadLine(), out integerTwo))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input!!! Please try again!");
                Console.Write("Integer #2: ");
            }

            Console.WriteLine();
            Console.Write("Integer #3: ");

            while (!Int32.TryParse(Console.ReadLine(), out integerThree))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input!!! Please try again!");
                Console.Write("Integer #3: ");
            }

            Console.WriteLine();

            total = integerOne + integerTwo + integerThree;

            Console.WriteLine($"Congrats on inputing all your numbers! Your total is {total}!");

            Console.WriteLine();

        }

        public static void Distance()
        {
            Console.WriteLine("-------------------------Distance-------------------------");
            Console.WriteLine();

            double  kmOne, kmTwo, kmThree, total = 0;

            Console.WriteLine("Enter 3 distances in km (may include decimals) to find the average!");

            Console.WriteLine();

            Console.Write("Distance #1: ");

            while (!Double.TryParse(Console.ReadLine(), out kmOne))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid output!!! Please try again!");
                Console.Write("Distance #1: ");
            }

            Console.WriteLine();
            Console.Write("Distance #2: ");

            while (!Double.TryParse(Console.ReadLine(), out kmTwo))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid output!!! Please try again!");
                Console.Write("Distance #2 ");
            }

            Console.WriteLine();
            Console.Write("Distance #3: ");

            while (!Double.TryParse(Console.ReadLine(), out kmThree))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid output!!! Please try again!");
                Console.Write("Distance #3: ");
            }

            Console.WriteLine();

            total = (kmOne + kmTwo + kmThree) / 3;

            Console.WriteLine($"Congrats on entering all your three distances!!! Must have been hard work!! Your total distance, rounded to two decimal places, is {Math.Round(total, 2)} kilometers!");

            Console.WriteLine();
        }

        public static void Hypotenuse()
        {
            Console.WriteLine("-------------------------Hypotenuse-------------------------");
            Console.WriteLine();

            double a, b, c = 0;

            Console.WriteLine("Enter the lengths of the two legs of a right triangle (a and b)!");

            Console.WriteLine();

            Console.Write("Length of leg a: ");

            while (!Double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input!!! Please try again!");
                Console.Write("Length of leg a: ");
            }

            Console.WriteLine();
            Console.Write("Length of leg b: ");

            while (!Double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input!!! Please try again!");
                Console.Write("Length of leg b: ");
            }

            Console.WriteLine();

            a = Math.Pow(a, 2);
            b = Math.Pow(b, 2);
            c = Math.Sqrt(a + b);

            Console.WriteLine($"Our calculations are complete! The length of the hypotenuse, rounded to 2 decimal places, is {Math.Round(c, 2)}!");

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Title = "Topic 3 - User Input (Assignment)";

            Greetings();
            Adder();
            Distance();
            Hypotenuse();
        }
    }
}
