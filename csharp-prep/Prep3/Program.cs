using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        
        int guessNumber = -1;
            while (guessNumber != magicNumber)
            {
                Console.Write("What is your guess number? ");
                guessNumber = int.Parse(Console.ReadLine());

                if (guessNumber < magicNumber) 
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

    
        
    }
}