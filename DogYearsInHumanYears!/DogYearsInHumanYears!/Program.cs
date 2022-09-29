using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogYearsInHumanYears_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declare Variables \\
            int dogAge;
            int age;

            // Enter age of the dog \\
            Console.WriteLine("Enter the age of your dog in years: ");
            dogAge = Convert.ToInt32(Console.ReadLine());

            // Calculates dog years to human years \\
            age = dogAge * 7;

            // Outputs the dogs years into human years \\
            Console.WriteLine("The dog is " + age + " in human years.");

            // Exit \\
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();


        }
    }
}
