// I have made sure the words don't hide when they are already hidden, and I set up the classes to be able to handle external scripture inputs.
// I made a lot of constructors for robustness.

public class Word
{
    private bool _isvisible;
    private string _text;
    private string _invisibleText;
    
    public Word(string text)
    {
        _text = text;
        _isvisible = true;
    }
    public void NotVisible()
    {
        _invisibleText = new string('_',_text.Length);
        _isvisible = false;
    }
    public string GetWord()
    {
        if (_isvisible)
        {
            return _text;
        }
        else
        {
            return _invisibleText;
        }
    }
    public bool IsVisible()
    {
        return _isvisible;
    }
}