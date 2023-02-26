public class BreathingActivity : Activity{
    private int _breathInSeconds;
    private int _breatheOutSeconds;

    public BreathingActivity(int _duration, string _description, string _activityName, int _initialPauseDuration, int _finalPauseDuration, string _endingMessage, int breathIn, int breathOut) : base(_duration, _description, _activityName, _initialPauseDuration, _finalPauseDuration, _endingMessage)
    {
        _breatheOutSeconds = breathOut;
        _breathInSeconds = breathIn;
    }

    public void StartBreathingActivity(){
        StartActivity(_activityName, _description);

        int breathCount = _duration / (_breathInSeconds + _breatheOutSeconds);
        Console.Clear();
        Console.WriteLine("Get ready to start!");
        InitialPause();
        for (int i = 0; i < breathCount; i++){
            Console.WriteLine("Breath in...");
            Countdown(_breathInSeconds);
            Console.WriteLine("Breath out...");
            Countdown(_breatheOutSeconds);

        }
        DisplayEndingMessage(_activityName);

    }
    public void Countdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i + "...");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}