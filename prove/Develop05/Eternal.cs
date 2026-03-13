public class Eternal : Goal
{
    
    public Eternal(string name, string desc, int points) : base(name, desc, points)
    {
        
    }
    public override int CompleteGoal()
    {
        return this.GetPoints();
    }
    public override bool IsComplete()
    {
        return false;
    }

    public override string DisplayGoal()
    {
        return $"[ ] {this.GetName()}";
    }
    public override string Delimited()
    {
        return $"Eternal|{this.GetName()}|{this.GetDescription()}|{this.GetPoints()}|{this.IsComplete()}";
    }

}