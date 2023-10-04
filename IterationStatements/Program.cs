

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000 - DONE!

        //Write a method that will print to the console numbers 3 through 999 by 3 each time - DONE!

        //Write a method to accept two integers as parameterss and check whether they are equal or not - DONE!

        //Write a method to check whether a given number is even or odd - Done

        //Write a method to check whether a given number is positive or negative - Done

        //Write a method to read the age of a candidate and determine whether they can vote. - Done
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10 - Done

        //Write a method to display the multiplication table(from 1 to 12) of a given integer - Done


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            ThreeByThree();
            Console.WriteLine();

            LandOf1000Numbers();
            Console.WriteLine();           

            Console.WriteLine(Twinsies(3, 8));
            Console.WriteLine();

            //Even or Odd
            Console.WriteLine("Pick a number.");
            int pick = int.Parse(Console.ReadLine());
            bool evenOrOdd = EvenOrOdd(pick);
            if (evenOrOdd)
            {
                Console.WriteLine($"{pick} is an even Steven.");
            }
            else
            {
                Console.WriteLine($"{pick} is the odd man out.");
            }
            Console.WriteLine();

            //Positive or negative
            Console.WriteLine("Pick a number");
            int number = int.Parse(Console.ReadLine());
            PositiveOrNegative(number);
            Console.WriteLine();

            //Old Enough To Vote
            Console.WriteLine("Please enter your age.");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                bool canVote = OldEnoughToVote(age);

                if (canVote)
                {
                    Console.WriteLine("You're old enough vote.");
                }
                else
                {
                    Console.WriteLine("Sorry. You're too young to vote.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            Console.WriteLine();

            //Range -10 and 10
            Console.WriteLine("Please pick a number.");
            if (int.TryParse(Console.ReadLine(), out int userNumber))
            {
                if (TenByNegTen(userNumber, -10, 10))
                {
                    Console.WriteLine("Your number is between 10 and -10.");
                }
                else
                {
                    Console.WriteLine("Your number is not between 10 and -10.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. You're PC has been cursed forever");
            }
            Console.WriteLine();

            //Multiplication Table
            Console.WriteLine("Pick a number and I will give you the multiplication table upto 12.");
            if (int.TryParse(Console.ReadLine(), out int input1))
            {
                TimesTable(input1);
            }
            else
            {
                Console.WriteLine("Invalid input. Your computer will self distruct in 3 seconds.");
            }
            Console.WriteLine();
        }
        public static void LandOf1000Numbers()
        {
            for (var i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
        /* Important.  I don't understand.  When I run the progrma in it's
         * entirety ThreeByThree gets skipped. But When I put in a break point
         * ThreeByThree functions properly*/
        public static void ThreeByThree()
        {
            for (var t = 3; t <= 999; t += 3)
            {
                Console.WriteLine(t);
            }
        }

        public static bool Twinsies(int pick1, int pick2)
        {
            var equal = (pick1 == pick2) ? true : false;
            return equal;
        }

        public static bool EvenOrOdd(int pick)
        {
            return pick % 2 == 0;
        }

        public static void PositiveOrNegative(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Your number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("Your number is negative.");
            }
            else
            {
                Console.WriteLine("Your number is neutral.");
            }
        }

        public static bool OldEnoughToVote(int age)
        {
            return age >= 18;
        }

        public static bool TenByNegTen(int number, int min, int max)
        {
            return number >= min && number <= max;
        }

        public static void TimesTable(int input1)
        {
            Console.WriteLine($"Multiplication table for {input1}:");

            for (int i = 1; i <= 12; i++)
            {
                int result = input1 * i;
                Console.WriteLine($"{input1} x {i} = {result}");
            }
        }

    }
}

