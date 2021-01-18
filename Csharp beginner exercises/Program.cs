using System;

namespace Csharp_beginner_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            largestNumber();
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

            var biggestnumber = firstnumber > secondnumber ? firstnumber : secondnumber;

            Console.WriteLine("This number is largest: " + biggestnumber);
        }

        public static void determineImage()
        {
            Console.WriteLine("Enter height");
            var height = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter width");
            var width = int.Parse(Console.ReadLine());

            var result = height > width ? "Portrait" : "Landscape";

            Console.WriteLine("The image is a " + result);
        }

        public static void speedCamera()
        {
            Console.WriteLine("Enter speed limit");
            var speedlimit = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your speed?");
            var carspeed = int.Parse(Console.ReadLine());

            if (carspeed < speedlimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                var demeritpoints = (carspeed - speedlimit) / 5;

                if (demeritpoints > 12)
                {
                    Console.WriteLine("You have {0} demeritpoints. Your license is suspended.", demeritpoints);
                }
                else
                {
                    Console.WriteLine("Demeripoints is " + demeritpoints);
                }
            }

        }

        public static void countNumbers()
        {
            int count = 0;

            for (int i = 1; i <= 100; i++)
            {

                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("It is {0} numbers that are divided by 3 with no remainder.", count);
        }

        public static void enterNumberorOk()
        {
            int allnumberssum = 0;

            while (true)
            {
                Console.WriteLine("Enter a number or if you want to exit just enter ok");
                var input = Console.ReadLine();

                if (input == "ok")
                {
                    break;
                }
                else
                {
                    allnumberssum += Convert.ToInt32(input);
                }
            }
            Console.WriteLine("Sum of all number is " + allnumberssum);
        }

        public static void factorialNumber()
        {
            Console.WriteLine("Enter a number");
            var input = int.Parse(Console.ReadLine());

            var result = 1;

            for (int i = input; i > 0; i--)
            {
                result *= i;

            }
            Console.WriteLine("Factorial is {0}", result);
        }

        public static void randomNumber()
        {
            Random random = new Random();
            var randomnumber = random.Next(1, 10);

            int quesses = 0;

            while (quesses <4)
            {
                Console.WriteLine("Guess the number between 1 and 10.");
                var myguess = int.Parse(Console.ReadLine());

                if (myguess == randomnumber)
                {
                    Console.WriteLine("You quess right");
                    break;
                }

                Console.WriteLine("Wrong");
                quesses++;
            }
        }

        public static void largestNumber()
        {
            Console.WriteLine("Enter some numbers separated by a ',' ");
            var input = Console.ReadLine();

            var numberarray = input.Split(',');

            int[] newnumbarray = Array.ConvertAll(numberarray, int.Parse);

            int largestnumber = 0;

            foreach (var item in newnumbarray)
            {
                if (largestnumber < item)
                {
                    largestnumber = item;
                }       
            }
            Console.WriteLine("Largest number is " + largestnumber);
        }
    }
}
