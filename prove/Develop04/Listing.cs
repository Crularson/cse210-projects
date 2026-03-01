public class Listing : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _itemsWritten = new List<string>();
     private Randomizer _randomizer = new Randomizer();

    public Listing(int time) : base(time,"This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",$"You have completed another {time} seconds of the Listing activity.")
    {
        _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
        ];
        _itemsWritten = [];
    }
    public string DisplayPrompt()
    {
        int randomIndex = _randomizer.Randomint(0,_prompts.Count());
        return _prompts[randomIndex];
    }
    
    public string DisplayItemsWritten()
    {
        return $"Good job, you listed {_itemsWritten.Count()} items.";
    }
    public void Run()
    {
        Welcome();
        
        DateTime endTime = GetEndTime();

        Console.WriteLine(DisplayPrompt());
         while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            _itemsWritten.Add(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine(DisplayItemsWritten());
        Console.WriteLine();
        Console.WriteLine(DisplayEnd());
        Console.WriteLine();
        Console.WriteLine();
        Thread.Sleep(6000);
        Console.Clear();
    }

}