public class Breathing : Activity
{
    private int _inhale;
    private int _exhale;
    private int _breathCount;

    public Breathing(int time) : base(time, "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",$"You have completed another {time} seconds of the Breathing activity.")
    {
        
        _inhale = 4;
        _exhale = 8;
        _breathCount = 0;
    }
    public void BreatheTimer()
    {
        Console.WriteLine();
        Console.Write("Breathe in for ");
        for (int i = _inhale; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Breathe out for ");
         for (int i = _exhale; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        _breathCount ++;
    }

    public string DisplayBreath()
    {
        return $"Good job, hopefully you're nice and relaxed after breathing in and out {_breathCount} time(s)";
    }

    public void Run()
    {
        DateTime endTime = GetEndTime();
        Welcome();

        Countdown();
        
        while (DateTime.Now < endTime)
        {
            BreatheTimer();
        }
        Console.WriteLine();
        Console.WriteLine(DisplayEnd());
        Console.WriteLine();
        Console.WriteLine();
        Thread.Sleep(6000);
    }

}