using System;

namespace classes{
    public class Journal
    {
        IDictionary<string, bool> prompts = new Dictionary<string, bool>();
        public void AddKeyValuePair()
        {
            prompts.Add("How was your day?", false);
            prompts.Add("How is your family?", false);
            prompts.Add("What was the weather like today?", false);
            prompts.Add("What was fun today?", false);
            prompts.Add("How was work today?", false);

        }

        public List<string> responses = new List<string>();

        public void ShowMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("Please Select one of the following options:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            Console.WriteLine("What would you like to do?");

            
        }

        public void DisplayEntry()
        {
            
            responses.ForEach(Console.WriteLine);
        }

        public void Write()
        {
            
            
            List<string> keys = new List<string>(prompts.Keys);
            List<string> unansweredQuestion = new List<string>(keys.Where(question => this.prompts[question] == false));
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            Random rndNum = new Random();
            int listSize = unansweredQuestion.Count;
            int rndIndex = rndNum.Next(0, listSize);
            if (unansweredQuestion.Count == 0)
            {
                Console.WriteLine("No more prompts available");
                return;
            }
            string index  = rndIndex.ToString();
            string randomQuestion = (unansweredQuestion[rndIndex]);
            
            prompts[randomQuestion] = true;
            Console.WriteLine(randomQuestion);
            

            string answer = Console.ReadLine();
            responses.Add($"Date: {date} - Prompt: {randomQuestion} - {answer}");

        }

        public Journal()
        {

        }
            
        
            
                

    }  
}

