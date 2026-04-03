public class Reception : Event
{
    private bool _rsvp;


    public Reception(string title, string desc, DateOnly date, TimeOnly time, Address address) : base(title, desc, date, time, address)
    {
        _rsvp = false;
    }
     public override string MoreInfo()
    {
        return $@"{this.BasicInfo()}
        Event Type: Reception
        Email for RSVP: realemail@email.com";
    }
    public override string LessInfo()
    {
        return $@"{this.GetTitle()}
        Event Type: Reception
        Date: {this.GetDate()}";
    }
    public void RSVP()
    {
        if (!_rsvp)
        {
            _rsvp = true;
        }
        
    }
}