public abstract class Plan
{
    protected string _planName;
    public void SetPlanName(string planName)
    {
        _planName = planName;
    }
    public string GetPlanName()
    {
        return _planName;
    }



    protected string _planDescription;
    public void SetPlanDescription(string description)
    {
        _planDescription = description;
    }
    public string GetPlanDescription()
    {
        return _planDescription;
    }



    protected int _daysDesired;
    public void SetDaysDesired(int days)
    {
        _daysDesired = days;
    }
    public int GetDaysDesired()
    {
        return _daysDesired;
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


    public abstract void MakePlan();
    public abstract void DisplayPlan();
}