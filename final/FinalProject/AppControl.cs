
public class AppControl
{
    protected int _selection;
    User user = new User();
    public void DisplayMenu()
    {
        while (true)
        {
            user.DisplayHoldAnimation();
            Console.WriteLine("Menu options:");
            Console.WriteLine();
            Console.WriteLine("1. Create A New Plan");
            Console.WriteLine("2. Display Your Plan");
            Console.WriteLine("3. Save Plan As PDF");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.WriteLine("What would you like to do? Enter the option number (eg. '1'):");
            _selection = int.Parse(Console.ReadLine());
            user.DisplayHoldAnimation();
            if (_selection == 1)
            {
                user.CreateUser();
            }
            else if (_selection == 2)
            {
                user.DisplayUser();
            }
            else if (_selection == 3)
            {
                if (user.GetUserDesire() == "L" || user.GetUserDesire() == "l")
                {
                    user.SavePlanToPdf("Weight Loss");
                }
                else if (user.GetUserDesire() == "G" || user.GetUserDesire() == "g")
                {
                    user.SavePlanToPdf("Weight Gain");
                }
                else
                {
                    Console.WriteLine("You must create a new plan first.");
                    Console.WriteLine("Press Enter To Go Back To The Main Menu");
                    Console.ReadLine();
                }
            }
            else if (_selection == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Enter a valid option");
            }
        }

    }


}





