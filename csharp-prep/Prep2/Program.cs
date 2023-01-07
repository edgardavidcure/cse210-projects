using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Enter your grade percentage: ");
        string grade = Console.ReadLine();
        int gradePercentage = int.Parse(grade);
        string gradeLetter = "";
        if (gradePercentage >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradePercentage >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradePercentage >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradePercentage >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }
        Console.WriteLine($"Your grade is: {gradeLetter}");
        
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class");

        }
        else
        {
            Console.WriteLine("You did not pass the class dummy");
        }

    }
}