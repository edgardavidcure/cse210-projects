
using FinalProject;
public abstract class Diet
{
    protected List<string> _vegetables = new List<string>{
        "Cucumber",
        "Bell Pepper",
        "Spinach",
        "Broccoli",
        "Cauliflower",
        "Avocado",
        "Cabbage",
        "Zucchini"
    };

    protected List<string> _fruits = new List<string>{
        "Grapefruit",
        "Passion Fruit",
        "Apple",
        "Kiwi",
        "Melon",
        "Berry",
        "Orange",
        "Banana"
    };

    protected List<string> _proteins = new List<string>{
        "Chicken Breast",
        "Beef",
        "Salmon",
        "Tuna",
        "Turkey",
        "White Fish",
        "Pork Loin",
        "Lamb"
    };

    protected List<string> _carbs = new List<string>{
        "Quinoa",
        "Potato",
        "Rice",
        "Bread",
        "Corn",
        "Oat",
        "Pasta",
        "Plantain"
    };

    protected List<string> _loseWeightMeals = new List<string>();

    public List<string> GetLoseWeightMeal()
    {
        return _loseWeightMeals;
    }
    public void SetLoseWeightMeal(string meal)
    {
        _loseWeightMeals.Add(meal);
    }



    protected List<string> _gainWeightMeals = new List<string>();
    public List<string> GetGainWeightMeal()
    {
        return _gainWeightMeals;
    }
    public void SetGainWeightMeal(string meal)
    {
        _gainWeightMeals.Add(meal);
    }



    public abstract void MakeMeal();

    public abstract void SaveMeal();

    public abstract void DisplayMeal();

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

}