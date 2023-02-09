using System;
namespace classes

{
    class Word
    {
    private Scripture scripture;

    public Word(Scripture scripture)
    {
        this.scripture = scripture;
    }

    public void Play()
    {
        while (scripture.HiddenWordIndices.Count < scripture.WordCount)
        {
            Console.Clear();
            Console.WriteLine(scripture.Reference);
            Console.WriteLine();
            for (int i = 0; i < scripture.WordCount; i++)
            {
                if (scripture.HiddenWordIndices.Contains(i))
                {
                    Console.Write("_____ ");
                }
                else
                {
                    Console.Write(scripture.Words[i] + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Press Enter to filter, or type quit: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            else
            {
                Random random = new Random();
                int hiddenWordIndex = random.Next(scripture.WordCount);
                scripture.HiddenWordIndices.Add(hiddenWordIndex);
            }
        }
    }
}
}

