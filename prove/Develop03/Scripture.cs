// I have made sure the words don't hide when they are already hidden, and I set up the classes to be able to handle external scripture inputs.
// I made a lot of constructors for robustness.

public class Scripture
{
    private Reference _reference;
    private List<Word> _verse = new List<Word>();

public Scripture()
    {
        _reference = new Reference();
        string verse = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.";
        string [] parts = verse.Split(' ');
        foreach (string word in parts)
        {
            Word newword = new Word(word);
            _verse.Add(newword);
        }
    }

public Scripture(string book, string verseText)
    {
        _reference = new Reference(book);
        string verse = verseText;
        string [] parts = verse.Split(' ');
        foreach (string word in parts)
        {
            Word newword = new Word(word);
            _verse.Add(newword);
        }
        
    }
public Scripture(string book, int chap, string verseText)
    {
        _reference = new Reference(book, chap);
        string verse = verseText;
        string [] parts = verse.Split(' ');
        foreach (string word in parts)
        {
            Word newword = new Word(word);
            _verse.Add(newword);
        }
        
    }
public Scripture(string book, int chap, string versenum, string verseText)
    {
        _reference = new Reference(book, chap, versenum);
        string verse = verseText;
        string [] parts = verse.Split(' ');
        foreach (string word in parts)
        {
            Word newword = new Word(word);
            _verse.Add(newword);
        }
        
    }
public Scripture(string book, int chap, string firstverse, string lastverse, string verseText)
    {
        _reference = new Reference(book, chap, firstverse, lastverse);
        string verse = verseText;
        string [] parts = verse.Split(' ');
        foreach (string word in parts)
        {
            Word newword = new Word(word);
            _verse.Add(newword);
        }
        
    }
    private static Random _random = new Random();
    
    public void Randomizer()
    {
        // Random random = new Random();
        int randInt = _random.Next(0,_verse.Count);
        if (Allhidden())
        {
            return;       
        }
        else
        {
            while (!_verse[randInt].IsVisible())
            {
                randInt = _random.Next(0,_verse.Count);
            }
                _verse[randInt].NotVisible();
        }
    }
   
   public string DisplayScripture()
    {
        string result = _reference.GetReference() + " ";
        foreach (Word word in _verse)
        {
            result += word.GetWord() + " ";
        }

        return result.Trim();
    }

    public bool Allhidden()
    {
        foreach (Word word in _verse)
        {
            if (word.IsVisible())
            {
                return false;
            }
        }
        return true;
    }
}