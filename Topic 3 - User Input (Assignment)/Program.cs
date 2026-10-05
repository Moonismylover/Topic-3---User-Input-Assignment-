using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_3___User_Input__Assignment_
{
    internal class Program
    {
        public static void Greetings()
        {
            Console.WriteLine("-------------------------Greetings-------------------------");
            Console.WriteLine();

            Console.WriteLine();


        }

        static void Main(string[] args)
        {
            Console.Title = "Topic 3 - User Input (Assignment)";

            Greetings();

        }
    }
}

/*

1. Greetings

Create a program that reads in a user’s name, age and the current year. Be sure to
store the values in variables of the proper type with descriptive names. The program
should generate and display a greeting message including the users name the year that
they were born (do not worry about accounting for the birth month).
• Optional Bonus: use the internet to figure out how to get the current year from
the computer instead of the user typing it in and calculate the year they were
born using that.

2. Adder

Create a program that reads in 3 integers from the user and displays their total.

3. Distance

Create a program that reads in three distances in km (may include decimals) and prints
the average. Round to 2 decimal places.

4. Hypotenuse

Create a program that will read in the two legs of a right triangle, and output the length
of the hypotenuse. You may want to use a method from the Math class to help with
finding the square root. Use the internet to help you. Round to 2 decimal places.
Here is a link to the official documentation for the Math class. This class contains a number of
methods that perform a variety of important mathematical operations. Look for the “Methods” section
in the menu at the right to find a method for square root:
https://docs.microsoft.com/en-us/dotnet/api/system.math?view=netframework-4.8

If you can’t find what you are looking for on the official API, use an internet search engine to find what
you are looking for.
*/
