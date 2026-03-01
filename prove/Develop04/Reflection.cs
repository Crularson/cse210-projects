public class Reflection : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _followup = new List<string>();
    private int _gapTime;
    private Randomizer _randomizer = new Randomizer();
    

    public Reflection(int time) : base(time, "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", $"You have completed another {time} seconds of the Reflecting activity.")
    {
        _prompts = 
        ["Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        ];
        _followup = 
        ["Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
        ];
        _gapTime = 5;
    }
    private string DisplayPrompt()
    {
        int randomIndex = _randomizer.Randomint(0,_prompts.Count());
        return _prompts[randomIndex];
    }
    private string DisplayFollowup()
    {
         int randomIndex = _randomizer.Randomint(0,_followup.Count());
        return _followup[randomIndex];
    }
private void Spinner(DateTime animationEndTime)
    {
        List<string> animationStrings = new List<string>();
        animationStrings = ["|","/","—","\\"];
        int i = 0;
        while(DateTime.Now < animationEndTime)
            {
                string s = animationStrings[i];
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
                i++;
                if(i >= animationStrings.Count)
                    {
                        i = 0;
                    }
            }
    }

    public void Run()
    {
        Welcome();
        Countdown();
        Console.WriteLine(DisplayPrompt());
        DateTime endTime = GetEndTime();

        while (DateTime.Now < endTime)
        {
            DateTime animationEndTime = DateTime.Now.AddSeconds(_gapTime);
            Spinner(animationEndTime);
            

            Console.WriteLine(DisplayFollowup());

        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(DisplayEnd());
        Console.WriteLine();
        Console.WriteLine();
        Thread.Sleep(6000);
        Console.Clear();
    }

}