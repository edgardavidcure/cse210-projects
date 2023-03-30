using iTextSharp.text;
using iTextSharp.text.pdf;

public class AppControl
{
    protected int _selection;
    User user = new User();
    LoseWeightDiet diet = new LoseWeightDiet();
    public void DisplayMenu(){
        while (true){
            user.DisplayHoldAnimation();
            Console.WriteLine("Menu options:");
            Console.WriteLine();
            Console.WriteLine("1. Create a new Plan");
            Console.WriteLine("2. Display your Plan");
            Console.WriteLine("3. Quit");
            Console.WriteLine();
            Console.WriteLine("What would you like to do? Enter the option number (eg. '1'):");
            _selection = int.Parse(Console.ReadLine());
            user.DisplayHoldAnimation();
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
    
    public void SaveFile(){
        Document document = new Document();
        PdfWriter.GetInstance(document, new FileStream(@"Sample.pdf", FileMode.Create));

    // Open the document
        document.Open();

    // Add some text to the document
        Paragraph para = new Paragraph($"This is a sample PDF document created using C#.");
        document.Add(para);

        // Close the document
        document.Close();
            }
        // Create a new PDF document



}