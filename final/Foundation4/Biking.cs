public class Biking : Exercise
{
    private float _speed;

    public Biking(DateOnly date, int length, float speed) : base(date, length)
    {
        _speed = speed;
    }
    public override float GetDistance()
    {
       float distance = _speed * this.GetLength() / 60;
       return distance;
    }
    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetPace()
    {
        float pace = 60 / _speed;
        
        return pace;
    }

    public override string Type()
    {
        return "Biking";
    }
}