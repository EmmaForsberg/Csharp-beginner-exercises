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
            numberValidation();
            Console.Read();
        }


        public static void numberValidation()
        {
            Console.WriteLine("Enter a number between 1 and 10");
            var number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <=10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Unvalid");
            }
        }
    }
}
