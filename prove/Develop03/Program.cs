using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
            {
            Console.Write("Enter the reference of the scripture: ");
            string reference = Console.ReadLine();

            Console.Write("Enter the text of the scripture: ");
            string text = Console.ReadLine();

            Scripture scripture = new Scripture(reference, text);
            Word game = new Word(scripture);
            game.Play();
        }

    }
}






