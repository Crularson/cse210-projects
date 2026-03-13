public abstract class Goal
{
    private string _name;
    private string _description;
    private int _pointValue;
    protected bool _isComplete = false;

protected Goal(string name, string desc, int points)
    {
        _name = name;
        _description = desc;
        _pointValue = points;
    }

    
    public abstract string DisplayGoal();
    public abstract string Delimited();
    public abstract bool IsComplete();
    public abstract int CompleteGoal();
    protected string GetName()
    {
        return _name;
    }
    protected string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _pointValue;
    }
    public void markComplete()
    {
        _isComplete = true;
    }

}