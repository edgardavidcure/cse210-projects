using System;

using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        int number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (number != 0)
        {
            
            Console.Write("Enter Number: ");
            string numberStr = Console.ReadLine();
            number = int.Parse(numberStr);
            if (number != 0)
            {
                numbers.Add(number);

            }
            
        }
        int sum1 = numbers.Sum();
        Console.WriteLine($"The sum is: {sum1}");
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        

    }
}