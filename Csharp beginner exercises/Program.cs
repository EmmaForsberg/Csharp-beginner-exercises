using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Csharp_beginner_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            numberOfWords();
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

            while (quesses < 4)
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

        public static void facebookLikes()
        {
            List<string> names = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter name");
                var input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }
                names.Add(input);
            }

            if (names.Count == 1)
            {
                Console.WriteLine(names[0] + " liked your post");
            }
            else if (names.Count == 2)
            {
                Console.WriteLine(names[0] + ", " + names[1] + " liked your post");
            }
            else
            {
                Console.WriteLine(names[0] + ", " + names[1] + " and " + (names.Count - 2) + " other liked your post");
            }

        }

        public static void reversedName()
        {
            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();

            char[] reversename = name.ToCharArray();
            Array.Reverse(reversename);
            string newnewname = "";

            foreach (var item in reversename)
            {
                newnewname += item;
            }

            Console.WriteLine(newnewname);
        }

        public static void uniqueFive()
        {
            List<int> mynumbers = new List<int>();

            int count = 0;

            while (count < 5)
            {
                Console.WriteLine("Enter five unique numbers");
                var input = int.Parse(Console.ReadLine());

                if (mynumbers.Contains(input))
                {
                    continue;
                }

                mynumbers.Add(input);
                count++;
            }
            mynumbers.Sort();

            foreach (var item in mynumbers)
            {
                Console.WriteLine(item);
            }
        }

        public static void numbOrQuit()
        {
            List<int> mynumbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number or type quit to exit");
                var input = Console.ReadLine();

                if (input == "exit")
                {
                    break;
                }

                var number = int.Parse(input);
                mynumbers.Add(number);
            }

            List<int> uniquenumb = mynumbers.Distinct().ToList();

            foreach (var item in uniquenumb)
            {

                Console.WriteLine(item);
            }

        }

        public static void overFiveNumbers()
        {
            while (true)
            {
                Console.WriteLine("Enter some numers separated by a , ");
                var input = Console.ReadLine();

                var numbers = input.Split(',');

                var mynumbers = Array.ConvertAll(numbers, int.Parse);

                if (mynumbers != null && mynumbers.Length >= 5)
                {
                    Array.Sort(mynumbers);

                    for (int i = 0; i <= 2; i++)
                    {
                        Console.WriteLine(mynumbers[i]);
                    }
                    break;
                }
                continue;
            }
        }

        public static void consecutiveOrNot()
        {
            Console.WriteLine("Enter some numbers separated by a - ");
            var input = Console.ReadLine();

            var removehyphen = input.Split('-');

            var mynumbers = Array.ConvertAll(removehyphen, int.Parse);

            var firstvalue = mynumbers[0];
            bool cons = true;

            for (int i = 0; i < mynumbers.Length; i++)
            {
                if (mynumbers[i] - i != firstvalue)
                {
                    cons = false;
                    break;
                }
            }
            if (cons)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }

        }

        public static void duplicateOrNot()
        {
            while (true)
            {
                Console.WriteLine("Enter some numbers separated by a - ");
                var input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }

                var removehyphen = input.Split('-');

                var tonumbers = Array.ConvertAll(removehyphen, int.Parse);

                var duplic = tonumbers.Distinct();

                if (tonumbers.Length != duplic.Distinct().Count())
                {
                    Console.WriteLine("Duplicate");
                    break;
                }
            }

            Console.ReadLine();
        }

        public static void checkTime()
        {
            try
            {
                Console.WriteLine("Enter a time value");
                var time = TimeSpan.Parse(Console.ReadLine());

                if (time == null)
                {
                    Console.WriteLine("Invalid");
                }

                Console.WriteLine("Valid");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid time");
            }
            Console.ReadLine();
        }

        public static void PascalCase()
        {
            Console.WriteLine("Enter some words separated by a space");
            var words = Console.ReadLine();

            var splitting = words.ToLower().Split(' ');

            var allwords = "";
            foreach (var item in splitting)
            {
                var toupper = char.ToUpper(item[0]) + item.Substring(1);
                allwords += toupper;

            }
            Console.WriteLine(allwords);


        }

        public static void numberOfVowels()
        {
            Console.WriteLine("Enter a word");
            var word = Console.ReadLine();

            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i' };
            int count = 0;

            foreach (var item in word)
            {
                if (vowels.Contains(item))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        public static void numberOfWords()
        {
            string path = @"C:\Users\forsb\Desktop\Customers.txt";
            var x = File.ReadAllText(path);

            var words = x.Split(' ');

            int count = 0;

            foreach (var item in words)
            {
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
