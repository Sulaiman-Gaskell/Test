// My first program

using System;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                // Asks the user for two numbers
                Console.WriteLine("Enter a number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter another number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                // Asks what the user wants to do with the numbers entered
                Console.WriteLine("\nChoose one of the following:\n");
                Console.WriteLine("1) Addition");
                Console.WriteLine("2) Subtraction");
                Console.WriteLine("3) Multiplciation");
                Console.WriteLine("4) Division\n");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("\n\nThe output of the two numbers is " + Convert.ToInt32(num1 + num2));
                        break;

                    case 2:
                        Console.WriteLine("\n\nThe output of the two numbers is " + Convert.ToInt32(num1 - num2));
                        break;

                    case 3:
                        Console.WriteLine("\n\nThe output of the two numbers is " + Convert.ToInt32(num1 * num2));
                        break;

                    case 4:
                        Console.WriteLine("\n\nThe output of the two numbers is " + Convert.ToInt32(num1 / num2));
                        break;
                }

                Console.WriteLine("\n");






            }
        }
    }
}