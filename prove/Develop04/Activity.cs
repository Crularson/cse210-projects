public class Activity
{
    private int _time;
    private string _welcome;
    private string _description;
    private string _endtext;

    public Activity(int time, string desc, string endtext)
    {
        _time = time;
        _description = desc;
        _endtext = endtext;
        _welcome = "Welcome to a mindfulness activity.";
    }

    protected DateTime GetEndTime()
    {
        return DateTime.Now.AddSeconds(_time); 
    }
    public string DisplayWelcome()
    {
        return _welcome;
    }
    public string DisplayDesc()
    {
        return _description;
    }
    public string DisplayEnd()
    {
        return _endtext;
    }
    protected void Welcome()
    {
        Console.WriteLine(DisplayWelcome());
        Console.WriteLine();
        Console.WriteLine(DisplayDesc());
        Console.WriteLine();
    }
    
     protected void Countdown()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        for (int placeholder = 5; placeholder > 0; placeholder--)
        {
            Console.Write(placeholder);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}