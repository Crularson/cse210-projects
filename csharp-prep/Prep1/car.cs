public class Car
{
    public string _make;
    public string _model;
    public int _year;

    public string Getdescription()
    {
        return $"Car: {_year} {_make} {_model}";
    }
}