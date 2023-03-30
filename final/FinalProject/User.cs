using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


public class User
{
    protected string _userName;
    protected string _userAge;
    protected string _userDesire;
    public string GetUserDesire()
    {
        return _userDesire;
    }
    LoseWeightPlan loseWeight = new LoseWeightPlan();
    GainWeightPlan gainWeight = new GainWeightPlan();


    public void CreateUser()
    {
        DisplayHoldAnimation();
        Console.WriteLine("Welcome to the healthy team! We are committed to help you achieve your goals.");
        Console.WriteLine("What is your name?");
        _userName = Console.ReadLine();
        Console.WriteLine("Enter your age (eg. '20'):");
        _userAge = Console.ReadLine();
        Console.WriteLine($"Thank you {_userName}! Now let's talk about business... Do you want to lose weight or gain weight? (Enter letter 'L' or 'G')");
        _userDesire = Console.ReadLine();
        while (true)
        {
            DisplayHoldAnimation();

            if (_userDesire == "L" || _userDesire == "l")
            {
                loseWeight.MakePlan();
                break;
            }
            else if (_userDesire == "G" || _userDesire == "g")
            {
                gainWeight.MakePlan();
                break;
            }
            else
            {
                Console.WriteLine("Wrong Selection, please try again.");
            }
            Console.Clear();
        }

    }

    public void DisplayUser()
    {
        if (_userDesire == "L" || _userDesire == "l")
        {
            loseWeight.DisplayPlan();

        }
        else if (_userDesire == "G" || _userDesire == "g")
        {
            gainWeight.DisplayPlan();


        }
        else
        {
            Console.WriteLine("You must create a new plan first.");
        }
        Console.WriteLine();
        Console.WriteLine("Press enter to go back to the main menu");
        Console.ReadLine();
    }
    public void DisplayHoldAnimation()
    {
        Console.Clear();
        string[] spinner = { "-", "|", "/" };
        for (int i = 0; i < 5; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(500);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
    }

    public void SavePlanToPdf(string planType)
    {
        List<string> meals = loseWeight.GetMealPlan();
        List<List<string>> workouts = loseWeight.GetWorkoutPlan();
        Document document = new Document();

        PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("myplan.pdf", FileMode.Create));


        document.Open();

        Paragraph title = new Paragraph("Meal and Workout Plan");
        title.Alignment = Element.ALIGN_CENTER;
        document.Add(title);

        Paragraph nameParagraph = new Paragraph($"Name: {_userName}\n\n");
        document.Add(nameParagraph);

        Paragraph ageParagraph = new Paragraph($"Age: {_userAge}\n\n");
        document.Add(ageParagraph);

        Paragraph typeParagraph = new Paragraph($"Plan Type: {planType}\n\n");
        document.Add(typeParagraph);


        // Add a table to the document to display the list of meals and workouts
        PdfPTable mtable = new PdfPTable(1);
        mtable.WidthPercentage = 100;
        mtable.SpacingBefore = 20f;
        mtable.SpacingAfter = 30f;
        mtable.AddCell(new Phrase("Meal Plan", new Font(Font.FontFamily.HELVETICA, 12f, Font.BOLD)));

        foreach (string meal in meals)
        {
            PdfPCell mealCell = new PdfPCell(new Phrase(meal));
            mtable.AddCell(mealCell);
        }
        document.Add(mtable);



        PdfPTable wtable = new PdfPTable(1);
        wtable.WidthPercentage = 100;
        wtable.SpacingBefore = 20f;
        wtable.SpacingAfter = 30f;



        for (int i = 0; i < workouts.Count; i++)
        {
            wtable.AddCell(new Phrase($"Workout #{i + 1}", new Font(Font.FontFamily.HELVETICA, 12f, Font.BOLD)));

            foreach (string workout in workouts[i])
            {
                Paragraph workoutCell = new Paragraph(new Phrase(workout));
                wtable.AddCell(workoutCell);
            }
        }
        document.Add(wtable);

        document.Close();



    }


}

