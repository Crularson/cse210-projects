public abstract class Exercise
{
    private DateOnly _date;
    private int _length;

    public Exercise(DateOnly date, int length)
    {
        _date = date;
        _length = length;
    }
    protected int GetLength()
    {
        return _length;
    }
    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
    public abstract string Type();
    
    public string Summary()
    {
        return $"{_date} {this.Type()} ({_length} min) - Distance {this.GetDistance()} miles, Speed {this.GetSpeed()} mph, Pace {this.GetPace()} min per mile";
    }
}