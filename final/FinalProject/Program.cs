
namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {

            AppControl app = new AppControl();
            Console.Clear();
            Console.WriteLine("Welcome to the Healthy Lifestyle Program!");
            Console.WriteLine("In this program you will be able to create plans that will help you improve your lifestyle.");
            Console.WriteLine();
            Console.WriteLine("Please press enter to continue");
            Console.ReadLine();
            app.DisplayMenu();
            // Create a new PDF document
        }
    }
}





