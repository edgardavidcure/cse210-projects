public class LoseWeightDiet : Diet 
{
    protected string _desiredFruit;
    protected string _desiredProtein;
    protected string _desiredCarb;
    protected string _desiredVegetable;

    public void ChooseItem(string type, List<string> listOfItems, ref string desiredItem ){
        Console.WriteLine($"Please select a {type}: ");
        int index = 1;
        foreach (string item in listOfItems){
            Console.WriteLine($"{index}. {item}");
            index++;
        }
        Console.WriteLine();
        Console.WriteLine($"Enter the {type} number: ");
        int selection = int.Parse(Console.ReadLine());
        if (selection < listOfItems.Count){
            desiredItem = listOfItems[selection - 1];
        } else{
            Console.WriteLine("Wrong selection, please try again.");
        }
        Console.Clear();

    }
    public override void MakeMeal(){
        Console.WriteLine();
        Console.WriteLine("A meal to lose weight consists of a fruit of your choice, a protein, a whole grain food, and a vegetable.");
        ChooseItem("fruit", _fruits, ref _desiredFruit);
        ChooseItem("Carb", _carbs, ref _desiredCarb);
        ChooseItem("Protein", _proteins, ref _desiredProtein);
        ChooseItem("Vegetable", _vegetables, ref _desiredVegetable);
        SaveMeal();
    }

    public override void SaveMeal(){
        SetLoseWeightMeal($"Meal: {_desiredProtein} with {_desiredCarb} and {_desiredVegetable}, optional dessert: {_desiredFruit} ");
    }


    public override void DisplayMeal(){
        int index = 1;
        Console.WriteLine("Here is a list of your meals to lose weight: ");
        foreach (string meal in _loseWeightMeals){
            Console.WriteLine($"{index}. {meal}");
            index++;
        }
    }
    
}