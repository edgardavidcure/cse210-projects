public class AppControl
{
    protected int _selection;
    User user = new User();

    public void DisplayMenu(){
        while (true){
            Console.WriteLine("Here is the menu:");
            Console.WriteLine("1. Create a new Plan");
            Console.WriteLine("2. Display your Plan");
            Console.WriteLine("3. Quit");
            Console.WriteLine("Please select an option:");
            _selection = int.Parse(Console.ReadLine());
            if (_selection == 1){
                user.CreateUser();
            }
            else if (_selection == 2){
                user.DisplayUser();
            }
            else if (_selection == 3){
                break;
            }
            else {
                Console.WriteLine("Enter a valid option");
            }
            }
    
    }

}