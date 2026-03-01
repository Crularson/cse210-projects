public class Randomizer
{
    private Random _rand = new Random();

    public int Randomint(int min, int max)
    {
        int randint = _rand.Next(min,max);
        return randint;
    }
}