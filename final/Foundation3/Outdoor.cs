public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string desc, DateOnly date, TimeOnly time, Address address, string weather) : base(title, desc, date, time, address)
    {
        _weather = weather;
    }
    
     public override string MoreInfo()
    {
        return $@"{this.BasicInfo()}
        Event Type: Outdoor Event
        Weather Conditions: {_weather}";
    }
    public override string LessInfo()
    {
        return $@"{this.GetTitle()}
        Event Type: Outdoor Event
        Date: {this.GetDate()}";
    }
}