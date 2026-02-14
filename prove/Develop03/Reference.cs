// I have made sure the words don't hide when they are already hidden, and I set up the classes to be able to handle external scripture inputs.
// I made a lot of constructors for robustness.

public class Reference
{
    private string _book;
    private int _chapter;
    private string _verseNumber;

    public Reference()
    {
        _book = "Ether";
        _chapter = 12;
        _verseNumber = "27";
    }

    public Reference(string book)
    {
        _book = book;
    }
    public Reference(string book, int chapter)
    {
        _book = book;
        _chapter = chapter;
    }
    public Reference(string book, int chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verseNumber = verse;
    }
    public Reference(string book, int chapter, string firstverse, string lastverse)
    {
        _book = book;
        _chapter = chapter;
        _verseNumber = firstverse + "-" + lastverse;
    }

    public string GetReference()
    {
        if (_chapter != 0 && _verseNumber != null)
        {
        return $"{_book} {_chapter}:{_verseNumber}";
        }
        else if (_chapter != 0)
        {
            return $"{_book} {_chapter}";
        }
        else
        {
            return $"{_book}";
        }
    }









    // private string _id;
    // private string _location;
    // public Reference(string id)
    // {
    //     _id = id;
    //     _location = "UNKNOWN";
    // }
    // public Reference(string id, string location)
    // {
    //     _id = id;
    //     _location = location;
    // }
    // public string GetId()
    // {return _id;}
}