public class GainWeightWorkout : Workout
{
    protected List<string> _desiredCardio = new List<string>();
    protected List<string> _desiredWeightsWorkout = new List<string>();
    protected List<string> _desiredMachineWorkout = new List<string>();

    protected List<string> _Workout = new List<string>();
    protected List<List<string>> _workoutSessions = new List<List<string>>();

    //public GainWeightWorkout(){
       //List<List<List<string>>> _Sessions = new List<List<List<string>>>();
       //_Sessions.Add(_workoutSessions);
    //}

    public void ChooseExerciseTypes(){
        int valid = 0;
        while (valid < 2){
            if (valid == 0){
                Console.WriteLine("Please select at least 2 different types of exercise");
            } else if (valid == 1){
                Console.WriteLine("Please select at least another type of exercise");
                
            }
            
            Console.WriteLine($"Exercise types available: ");
            int index = 1;
            foreach (string item in _exerciseTypes){
                Console.WriteLine($"{index}. {item}");
                index++;
            }
            Console.WriteLine("Please select one: ");
            int selection = int.Parse(Console.ReadLine()) - 1;
            Console.Clear();
            if (selection == 0){
                SetExerciseDuration(10);
                ChooseCardioExercise();
                valid++;
            } 
            else if (selection == 1){
                SetRepetitions(8);
                SetSets(6);
                SetWorkoutLenght(60);
                SetPoundsToLift(30);
                ChooseWeightLiftingExercise();
                valid++;

            }
            else if( selection == 2){
                SetRepetitions(8);
                SetSets(6);
                SetWorkoutLenght(60);
                SetPoundsToLift(30);
                ChooseMachineExercise();
                valid++;
            }
            Console.Clear();

        }
        
    }


    public void ChooseCardioExercise(){
        Console.WriteLine($"Cardio exercises available: ");
        int index = 1;
        foreach (string item in _cardioExercises){
            Console.WriteLine($"{index}. {item}");
            index++;
        }
        Console.WriteLine();
        Console.WriteLine($"Enter the Cardio exercise desired by number: ");
        int selection = int.Parse(Console.ReadLine()) - 1;
        if (selection < _cardioExercises.Count){
            _desiredCardio.Add($"{_cardioExercises[selection]} - {GetExerciseDuration()} min");
        } else{
            Console.WriteLine("Wrong selection, please try again.");
        }
        Console.Clear();

    }

    public void ChooseWeightLiftingExercise(){
        int valid = 0;
        while (valid < 4){
            Console.WriteLine($"You have selected {valid}/4 exercises");
            Console.WriteLine();
            Console.WriteLine($"Weight Lifting exercises available: ");
            int index = 1;
            foreach (string item in _weightsExercises){
                Console.WriteLine($"{index}. {item}");
                index++;
            }
            Console.WriteLine();
            Console.WriteLine($"Enter the Weight Lifting exercise desired by number: ");
            int selection = int.Parse(Console.ReadLine()) - 1;
            if (selection < _weightsExercises.Count){
                _desiredWeightsWorkout.Add($"{_weightsExercises[selection]} - {GetRepetitions()} reps/{GetSets()} sets - {GetPoundsToLift()} pounds");
            } else{
                Console.WriteLine("Wrong selection, please try again.");
            }
            Console.Clear();
            valid++;

        }

        

    }
    public void ChooseMachineExercise(){
        int valid = 0;
        while (valid < 4){
            Console.WriteLine($"You have selected {valid}/4 exercises");
            Console.WriteLine();
            Console.WriteLine($"Gym Machine exercises available: ");
            int index = 1;
            foreach (string item in _machineExercises){
                Console.WriteLine($"{index}. {item}");
                index++;
            }
            Console.WriteLine();
            Console.WriteLine($"Enter the Gym Machine exercise desired by number: ");
            int selection = int.Parse(Console.ReadLine()) - 1;
            if (selection < _machineExercises.Count){
                _desiredMachineWorkout.Add($"{_machineExercises[selection]} - {GetRepetitions()} reps/{GetSets()} sets - {GetPoundsToLift()} pounds");
            } else{
                Console.WriteLine("Wrong selection, please try again.");
            }
            Console.Clear();
            valid++;

        }

    }

    public void SaveWorkoutSession(){
    List<string> workoutSession = new List<string>();
    if (_desiredCardio.Count > 0) {
        workoutSession.Add("Cardio:");
        foreach (string session in _desiredCardio){
            workoutSession.Add($"    - {session}");
        }
        _desiredCardio.Clear();
    }
    if (_desiredWeightsWorkout.Count > 0){
        workoutSession.Add("Weight Lifting Exercises:");
        foreach (string session in _desiredWeightsWorkout){
            workoutSession.Add($"    - {session}");
        }
        _desiredWeightsWorkout.Clear();
    }
    if (_desiredMachineWorkout.Count > 0){
        workoutSession.Add("Gym Machine Exercises:");
        foreach(string session in _desiredMachineWorkout){
            workoutSession.Add($"    - {session}");
        }
        _desiredMachineWorkout.Clear();
    }
        
    _workoutSessions.Add(workoutSession);
}

    public override void DisplayWorkout(){
    for (int i = 0; i < _workoutSessions.Count; i++){
        Console.WriteLine();
        Console.WriteLine($"Workout #{i + 1}:");
        foreach (string workout in _workoutSessions[i]){
            Console.WriteLine($"    {workout}");
        }
        Console.WriteLine();
    }
}
    public override void CreateWorkout()
    {
        
        ChooseExerciseTypes();
        SaveWorkoutSession();        
    }

}