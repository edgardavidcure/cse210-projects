public class AppControl
{
    //DisplayPoints()
    List<Goal> goals = new List<Goal>();
    public void MainMenu()
    {
        while (true)
        {
            Console.WriteLine($"You have {CalculateTotalPoints()} points");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Event");
            Console.WriteLine("     6. Quit");
            Console.WriteLine("Please select an option:");
            int mainMenuChoice = Convert.ToInt32(Console.ReadLine());
            if (mainMenuChoice == 1)
            {
                Console.Clear();
                Console.WriteLine("The types of goal are:");
                Console.WriteLine("     1. Simple Goal");
                Console.WriteLine("     2. Eternal Goal");
                Console.WriteLine("     3. Checklist Goal");
                Console.WriteLine("Please select an option:");
                int createGoalChoice = Convert.ToInt32(Console.ReadLine());
                if (createGoalChoice == 1)
                {
                    Console.Clear();
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.CreateGoal();
                    goals.Add(simpleGoal);

                }
                else if (createGoalChoice == 2)
                {
                    Console.Clear();
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.CreateGoal();
                    goals.Add(eternalGoal);
                }
                else if (createGoalChoice == 3)
                {
                    Console.Clear();
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    checklistGoal.CreateGoal();
                    goals.Add(checklistGoal);
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }
            else if (mainMenuChoice == 2)
            {
                Console.Clear();

                foreach (Goal goal in goals)
                {
                    if (goal is ChecklistGoal)
                    {
                        ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                        Console.WriteLine($"{checklistGoal.PrintIsComplete()} {checklistGoal.GetGoalName()} ({checklistGoal.GetDescription()}) --- Currently completed: {checklistGoal.GetProgress()}/{checklistGoal.GetDesiredCompletions()} times");
                    }
                    else
                    {
                        Console.WriteLine($"{goal.PrintIsComplete()} {goal.GetGoalName()} ({goal.GetDescription()})");

                    }
                }
            }
            else if (mainMenuChoice == 3)
            {
                this.WriteFile();

            }
            else if (mainMenuChoice == 4)
            {
                this.LoadFile();
            }
            else if (mainMenuChoice == 5)
            {
                Console.Clear();

                Console.WriteLine("These are you goals:");
                int index = 1;
                foreach (Goal goal in goals)
                {
                    Console.WriteLine(index + ". " + goal.GetGoalName());
                    index++;
                }
                Console.WriteLine("What goal have you completed?");
                int completedChoice = int.Parse(Console.ReadLine());
                if (completedChoice >= 1 && completedChoice <= goals.Count)
                {
                    Goal completedGoal = goals[completedChoice - 1];
                    completedGoal.RecordEvent();
                    Console.WriteLine("Good Job!");
                }
                else
                {
                    Console.WriteLine("Invalid goal choice.");
                }
            }

            else if (mainMenuChoice == 6)
            {
                break;

            }
        }

    }

    public void WriteFile()
    {



        Console.WriteLine("What is the file name you would like to choose? Enter .txt at the end");
        string _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine(CalculateTotalPoints());
            foreach (Goal goal in goals)
            {
                if (goal is ChecklistGoal)
                {
                    ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                    outputFile.WriteLine($"{goal.GetType()}:|{checklistGoal.GetGoalName()}|{checklistGoal.GetDescription()}|{checklistGoal.GetDesiredPoints()}|{checklistGoal.GetBonus()}/{checklistGoal.GetProgress()}|{checklistGoal.GetDesiredCompletions()}|{checklistGoal.GetCompleted()}|{checklistGoal.GetEarnedPoints()}");
                }
                else
                {
                    outputFile.WriteLine($"{goal.GetType()}:|{goal.GetGoalName()}|{goal.GetDescription()}|{goal.GetDesiredPoints()}|{goal.GetCompleted()}|{goal.GetEarnedPoints()}");

                }
            }
        }
    }

    public void LoadFile()
    {
        Console.WriteLine("What is the desired filename to Load?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        lines = lines.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string name = parts[1];
            string desc = parts[2];
            int desiredPoints = int.Parse(parts[3]);
            if (parts[4].Contains("/"))
            {
                string bonus = parts[4];
                string[] checklistParts = bonus.Split("/");
                bonus = checklistParts[0];
                int progress = int.Parse(checklistParts[1]);
                int bonusInt = int.Parse(bonus);
                int desired = int.Parse(checklistParts[1]);
                bool complete = bool.Parse(parts[6]);
                int earned = int.Parse(parts[7]);
                goals.Add(new ChecklistGoal(name, desc, progress, desired, bonusInt, complete, desiredPoints, earned));

            }
            else
            {
                int earned = int.Parse(parts[5]);
                bool complete = bool.Parse(parts[4]);
                string goalType = parts[0];
                if (goalType == "SimpleGoal:")
                {
                    goals.Add(new SimpleGoal(name, desc, desiredPoints, complete, earned));

                }
                else
                {
                    goals.Add(new EternalGoal(name, desc, desiredPoints, complete, earned));

                }
            }




        }

    }




    public int CalculateTotalPoints()
    {
        int totalPoints = 0;
        foreach (Goal goal in goals)
        {
            totalPoints += goal.GetEarnedPoints();
        }
        return totalPoints;
    }



}