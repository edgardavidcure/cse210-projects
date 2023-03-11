public abstract class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalValueInPoints;
    protected bool _completed = false;
    protected int _earnedPoints;

    public Goal()
    {

    }
    public Goal(string name, string description, int goalValue, bool completed, int earnedPoints)
    {
        _goalName = name;
        _goalDescription = description;
        _goalValueInPoints = goalValue;
        _completed = completed;
        _earnedPoints = earnedPoints;

    }

    public Goal(string name, string description, bool completed)
    {
        _goalName = name;
        _goalDescription = description;
        _completed = completed;
    }
    public string GetGoalName()
    {
        return _goalName;
    }
    public void SetGoalName(string name)
    {
        _goalName = name;
    }


    public string GetDescription()
    {
        return _goalDescription;
    }
    public void SetDescription(string description)
    {
        _goalDescription = description;
    }

    public int GetDesiredPoints()
    {
        return _goalValueInPoints;
    }
    public void SetDesiredPoints(int _points)
    {
        _goalValueInPoints = _points;
    }


    public void SetCompleted(bool x)
    {
        _completed = x;
    }
    public bool GetCompleted()
    {
        return _completed;
    }



    public void SetEarnedPoints(int points)
    {
        _earnedPoints = _earnedPoints + points;
    }
    public int GetEarnedPoints()
    {
        return _earnedPoints;
    }







    public abstract void CreateGoal();

    public abstract void RecordEvent();
    public abstract string PrintIsComplete();

}