using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Would you like to use this calculator? [Y/N]");
            string input = Console.ReadLine();

            while (input == "y")
            {
                int num1 = 0;
                int num2 = 0;

                bool isValidNum = false;

                while (!isValidNum)
                {
                    Console.Write("Enter your number: ");
                    input = Console.ReadLine();

                    isValidNum = Int32.TryParse(input, out num1);

                    if (!isValidNum)
                    {
                        Console.WriteLine("That is not a Number!");
                    }
                }
                while (!isValidNum)
                {
                    Console.Write("Enter your number: ");
                    input = Console.ReadLine();

                    isValidNum = Int32.TryParse(input, out num2);

                    if (!isValidNum)
                    {
                        Console.WriteLine("That is not a Number!");
                    }
                }

                Console.WriteLine(num1 + num2);

                Console.ReadKey(true);
                
            }

        }
    }
}
