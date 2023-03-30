public class GainWeightPlan : Plan
{

    GainWeightDiet diet = new GainWeightDiet();
    GainWeightWorkout workout = new GainWeightWorkout();
    public override void MakePlan()
    {
        SetPlanName("Weight Gain Plan");
        SetPlanDescription("This plan consists of a healthy diet and workout exercises to help you gain weight.");
        Console.WriteLine();
        Console.WriteLine($"I am glad to help you creating a {GetPlanName()}.");
        Console.WriteLine($"{GetPlanDescription()}");
        Console.WriteLine("How many days would you like to follow this plan? (enter the number of days, eg. '3')");
        SetDaysDesired(int.Parse(Console.ReadLine()));
        Console.WriteLine("Perfect! Let's get you started...");
        DisplayHoldAnimation();
        Console.WriteLine("First, let's start with a diet plan. You will need to create a meal for each day you want to follow this plan.");
        Console.WriteLine();
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
        for (int i = 0; i < GetDaysDesired(); i++)
        {
            DisplayHoldAnimation();
            Console.WriteLine($"Meal number {i + 1}:");
            Console.WriteLine();
            diet.MakeMeal();
            Console.Clear();
        }
        Console.WriteLine("Perfect! Now that your meals are ready, let's focus on creating some workout routines for the days you specified.");
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
        DisplayHoldAnimation();
        for (int i = 0; i < GetDaysDesired(); i++)
        {
            Console.WriteLine($"Workout number {i + 1}:");
            Console.WriteLine();
            workout.CreateWorkout();
            Console.Clear();
        }
    }
    public override void DisplayPlan()
    {
        Console.WriteLine("Your plan:");
        Console.WriteLine();
        Console.WriteLine("             -----Diet Plan-----");
        Console.WriteLine();
        diet.DisplayMeal();
        Console.WriteLine("             -----Workout Plan-----");
        workout.DisplayWorkout();
    }

    public List<string> GetMealPlan()
    {
        return diet.GetGainWeightMeal();
    }

    public List<List<string>> GetWorkoutPlan()
    {
        return workout.GetGainWeightWorkouts();
    }

}