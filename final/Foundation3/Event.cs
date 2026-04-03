public abstract class Event
{
    private string _title;
    private string _description;
    private DateOnly _date;
    private TimeOnly _time;
    private Address _address;
    public virtual string BasicInfo()
    {
        return $"{_title}\nDescription: {_description}\n{_date} at {_time}\n{_address.GetAddress()}";
    }
    public abstract string MoreInfo();
    public abstract string LessInfo();
    protected string GetTitle()
    {
        return _title;
    }
     protected DateOnly GetDate()
    {
        return _date;
    }

    public Event(string title, string desc, DateOnly date, TimeOnly time, Address address)
    {
        _title = title;
        _description = desc;
        _date = date;
        _time = time;
        _address = address;
    }
}