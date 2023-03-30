public class GainWeightDiet : Diet
{
    protected string _desiredFruit1;
    protected string _desiredFruit2;

    protected string _desiredProtein1;
    protected string _desiredProtein2;

    protected string _desiredCarb1;
    protected string _desiredCarb2;

    protected string _desiredVegetable1;
    protected string _desiredVegetable2;


    public void ChooseItem(string type, List<string> listOfItems, ref string desiredItem, int mealNumber)
    {
        Console.WriteLine($"Please select your {type} #{mealNumber}: ");
        int index = 1;
        foreach (string item in listOfItems)
        {
            Console.WriteLine($"{index}. {item}");
            index++;
        }
        Console.WriteLine();
        Console.WriteLine($"Enter the {type} number: ");
        int selection = int.Parse(Console.ReadLine()) - 1;
        if (selection < listOfItems.Count)
        {
            desiredItem = listOfItems[selection];
        }
        else
        {
            Console.WriteLine("Wrong selection, please try again.");
        }
        Console.Clear();

    }
    public override void MakeMeal()
    {
        Console.WriteLine();
        Console.WriteLine("A meal to lose weight consists of 2 fruits of your choice, 2 proteins, 2 whole grain foods, and 2 vegetables.");
        ChooseItem("fruit", _fruits, ref _desiredFruit1, 1);
        ChooseItem("fruit", _fruits, ref _desiredFruit2, 2);

        ChooseItem("Carb", _carbs, ref _desiredCarb1, 1);
        ChooseItem("Carb", _carbs, ref _desiredCarb2, 2);

        ChooseItem("Protein", _proteins, ref _desiredProtein1, 1);
        ChooseItem("Protein", _proteins, ref _desiredProtein2, 2);

        ChooseItem("Vegetable", _vegetables, ref _desiredVegetable1, 1);
        ChooseItem("Vegetable", _vegetables, ref _desiredVegetable2, 2);
        SaveMeal();
    }

    public override void SaveMeal()
    {
        SetGainWeightMeal($"{_desiredProtein1} and {_desiredProtein2}, with {_desiredCarb1} and {_desiredCarb2}, with {_desiredVegetable1} and {_desiredVegetable2}. Optional dessert: 1 {_desiredFruit1} and 1 {_desiredFruit2}");
    }

    public override void DisplayMeal()
    {
        int index = 1;
        foreach (string meal in _gainWeightMeals)
        {
            Console.WriteLine($"{index}. {meal}");
            index++;
        }
        Console.WriteLine();
        Console.WriteLine();

    }



}