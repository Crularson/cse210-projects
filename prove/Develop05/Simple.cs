public class Simple : Goal
{
    public Simple(string name, string desc, int points) : base(name, desc, points)
    {

    }

    public override string DisplayGoal()
    {
        if (this.IsComplete())
        {   
        return $"[X] {this.GetName()}";
        }
        else
        {
            return $"[ ] {this.GetName()}";
        }
    }

    public override int CompleteGoal()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return this.GetPoints();
        }
        else
        {
            return 0;
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string Delimited()
    {
        return $"Simple|{this.GetName()}|{this.GetDescription()}|{this.GetPoints()}|{this.IsComplete()}";
    }

}