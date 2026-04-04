public class Swimming : Exercise
{
    private int _laps;

    public Swimming(DateOnly date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }
    public override float GetDistance()
    {
        return _laps * 50f / 1000f * 0.62f;
    }
    public override float GetSpeed()
    {
        float distance = this.GetDistance();
        float speed = distance / this.GetLength() * 60;

        return speed;
    }

    public override float GetPace()
    {
        return this.GetLength() / this.GetDistance();
    }

    public override string Type()
    {
        return "Swimming";
    }
}