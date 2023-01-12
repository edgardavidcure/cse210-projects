using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        Result();

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");

        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your number: ");
            string numberStr = Console.ReadLine();
            int number = int.Parse(numberStr);
            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void Result()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int squaredNumber = SquareNumber(userNumber);
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        }











    }
}