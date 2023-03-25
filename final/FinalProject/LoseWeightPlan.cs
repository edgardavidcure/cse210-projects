public class LoseWeightPlan : Plan{
    
    LoseWeightDiet diet = new LoseWeightDiet();
    LoseWeightWorkout workout = new LoseWeightWorkout();
    public override void MakePlan()
    {
        SetPlanName("Weight loss Plan");
        SetPlanDescription("A plan that consists of a healthy diet and workout exercises to help you lose weight.");
        Console.WriteLine();
        Console.WriteLine($"I am glad to help you creating a {GetPlanName()}.");
        Console.WriteLine($"{GetPlanDescription()}");
        Console.WriteLine("How many days would you like to follow this plan? (enter the number of days, eg. '3')");
        SetDaysDesired(int.Parse(Console.ReadLine()));
        Console.WriteLine("Perfect! Let's get you started...");
        Console.WriteLine("First, let's start with a diet plan. You will need to create a meal for each day you want to follow this plan.");
        for (int i = 0; i < GetDaysDesired(); i++){
            Console.WriteLine($"Meal number {i + 1}:");
            Console.WriteLine();
            diet.MakeMeal();
            Console.Clear();
        }
        Console.WriteLine("Perfect! Now that your meals are ready, let's focus on creating some workout routines for the days you specified.");
        for (int i = 0; i < GetDaysDesired(); i++){
            Console.WriteLine($"Workout number {i + 1}:");
            Console.WriteLine();
            workout.CreateWorkout();
            Console.Clear();
        }
        Console.WriteLine("This is great! You will notice big differences by following this plan.");
    }
    public override void DisplayPlan(){
        Console.WriteLine("This is the plan:");
        Console.WriteLine("Diet:");
        diet.DisplayMeal();
        Console.WriteLine("Workout:");
        workout.DisplayWorkout();
    }
    
}