public class User
{   
    protected string _userName;
    protected string _userAge;
    protected string _userDesire;
    LoseWeightPlan loseWeight = new LoseWeightPlan();
    GainWeightPlan gainWeight = new GainWeightPlan();


    public void CreateUser(){
        DisplayHoldAnimation();
        Console.WriteLine("Welcome to the healthy team! We are committed to help you achieve your goals.");
        Console.WriteLine("What is your name?");
        _userName = Console.ReadLine();
        Console.WriteLine("Enter your age (eg. '20'):");
        _userAge = Console.ReadLine();
        Console.WriteLine($"Thank you {_userName}! Now let's talk about business... Do you want to lose weight or gain weight? (Enter letter 'L' or 'G')");
        _userDesire = Console.ReadLine();
        while (true){
            DisplayHoldAnimation();

            if (_userDesire == "L" || _userDesire == "l"){
                loseWeight.MakePlan();
                break;
            }
            else if (_userDesire == "G" || _userDesire == "g"){
                gainWeight.MakePlan();
                break;
            }
            else {
                Console.WriteLine("Wrong Selection, please try again.");
            }
            Console.Clear();
        }
        
    }

    public void DisplayUser(){
        if (_userDesire == "L" || _userDesire == "l"){
            loseWeight.DisplayPlan();
                
        }
        else if (_userDesire == "G" || _userDesire == "g"){
            gainWeight.DisplayPlan();

        } else {
            Console.WriteLine("You must create a new plan first.");
        }
        Console.WriteLine();
        Console.WriteLine("Press enter to go back to the main menu");
        Console.ReadLine();
    }
    public void DisplayHoldAnimation(){
        Console.Clear();
        string[] spinner = {"-","|", "/" };
        for (int i = 0; i < 5; i++ ){
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(500);
            Console.SetCursorPosition(Console.CursorLeft -1, Console.CursorTop);
        }
    }

}