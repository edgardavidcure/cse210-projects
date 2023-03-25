public abstract class Workout
{
    protected int _workoutLenght;
    public int GetWorkoutLenght(){
        return _workoutLenght;
    }
    public void SetWorkoutLenght(int lenght){
        _workoutLenght = lenght;
    }


    protected int _exerciseDuration;

    public int GetExerciseDuration(){
        return _exerciseDuration;
    }
    public void SetExerciseDuration(int duration){
        _exerciseDuration = duration;
    }


    protected int _sets;

    public int GetSets(){
        return _sets;
    }
    public void SetSets(int sets){
        _sets = sets;
    }
    

    protected int _repetitions;
    public int GetRepetitions(){
        return _repetitions;
    }
    public void SetRepetitions(int repetitions){
        _repetitions = repetitions;
    }


    protected int _poundsToLift;
    public int GetPoundsToLift(){
        return _poundsToLift;
    }
    public void SetPoundsToLift(int pounds){
        _poundsToLift = pounds;
    }


    protected List<string> _exerciseTypes = new List<string>{
        "Cardio",
        "Weight Lifting",
        "Gym Machine"
    }

    ;
    protected List<string> _cardioExercises = new List<string>{
        "Running",
        "Swimming",
        "Cycling",
        "Aerobics",
        "Jogging",
        "Burpees"
    };
    protected List<string> _weightsExercises = new List<string>{
        "Squat",
        "Chest Fly",
        "Dead Lift",
        "Biceps Curl",
        "Chest Pushup",
        "Shoulders Lateral Raise"

    };
    protected List<string> _machineExercises = new List<string>{
        "Leg Press",
        "Leg Curl",
        "Chest Bench Press",
        "Back Pulldown",
        "Shoulder Press",
        "Triceps Pushdown"
    };

    protected List <string> _loseWeightWorkouts = new List<string>();
    public List<string> GetLoseWeightWorkouts(){
        return _loseWeightWorkouts;
    }
    public void SetLoseWeightWorkouts(List<string> loseWeightWorkout){
        _loseWeightWorkouts = loseWeightWorkout;
    }



    protected List <string> _gainWeightWorkouts = new List<string>();
    public List<string> GetGainWeightWorkouts(){
        return _gainWeightWorkouts;
    }
    public void SetGainWeightWorkouts(List<string> gainWeightWorkout){
        _gainWeightWorkouts = gainWeightWorkout;
    }

    

    public abstract void CreateWorkout();
    public abstract void DisplayWorkout();
}