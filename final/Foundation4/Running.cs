public class Running : Exercise
{
    private float _distance;


    public Running(DateOnly date, int length, float distance) : base(date, length)
    {
        _distance = distance;
    }
    public override float GetDistance()
    {
        return _distance;
    }
    public override float GetSpeed()
    {
        return _distance / this.GetLength() * 60;
    }

    public override float GetPace()
    {
        return this.GetLength() / _distance;
    }

    public override string Type()
    {
        return "Running";
    }
}