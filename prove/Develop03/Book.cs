public class Book
{
    private string _title;
    private Reference _reference;
    private bool _checkedout;

    public Book(string title)
    {
        
        _title = title;
    }
    public Book(string title, Reference reference)
    {
        _title = title;
        _reference = reference;
    }

    public void CheckOut()
    {
        _checkedout = true;
    }

    public void Checkin()
    {
        _checkedout = false;
    }

    public string GetDescription()
    {
        if(_checkedout)
        {
            return $"{_title} is checked out";
        }
        else
        {
            return $"{_title} is checked in";
        }
    }
}