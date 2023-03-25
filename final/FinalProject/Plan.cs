public abstract class Plan
{
    protected string _planName;
    public void SetPlanName(string planName){
        _planName = planName;
    }
    public string GetPlanName(){
        return _planName;
    }



    protected string _planDescription;
    public void SetPlanDescription(string description){
        _planDescription = description;
    }
    public string GetPlanDescription(){
        return _planDescription;
    }



    protected int _daysDesired;
    public void SetDaysDesired(int days){
        _daysDesired = days;
    }
    public int GetDaysDesired(){
        return _daysDesired;
    }



    public abstract void MakePlan();
    public abstract void DisplayPlan();
}