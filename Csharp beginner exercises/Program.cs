using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_beginner_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            determineImage();
            Console.Read();
        }


        public static void numberValidation()
        {
            Console.WriteLine("Enter a number between 1 and 10");
            var number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Unvalid");
            }
        }

        public static void displayMaximum()
        {
            Console.WriteLine("Enter first number:");
            var firstnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            var secondnumber = int.Parse(Console.ReadLine());

            var biggestnumber =firstnumber > secondnumber ? firstnumber : secondnumber;

            Console.WriteLine("This number is largest: " + biggestnumber);  
        }

        public static void determineImage()
        {
            Console.WriteLine("Enter height");
            var height = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter width");
            var width = int.Parse(Console.ReadLine());

            var result = height > width ? "Portrait" : "Landscape";

            Console.WriteLine("The image is a "+ result);
        }
           
    }
}
