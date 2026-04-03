public class Lecture : Event
{
    private string _speaker;
    private int _maxGuest;

    public Lecture(string title, string desc, DateOnly date, TimeOnly time, Address address, string speaker, int maxguest) : base(title, desc, date, time, address)
    {
        _speaker = speaker;
        _maxGuest = maxguest;
    }

    public override string MoreInfo()
    {
        return $@"{this.BasicInfo()}
        Event Type: Lecture
        Speaker: {_speaker}
        Maximum Guest Capacity: {_maxGuest}";
    }
    public override string LessInfo()
    {
        return $@"{this.GetTitle()}
        Event Type: Lecture
        Date: {this.GetDate()}";
    }
}