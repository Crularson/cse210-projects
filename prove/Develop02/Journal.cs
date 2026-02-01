// I added a mood section to the Journal. I now display mood as well as the other entry bits. In my prompts.txt I also have 10 instead of the normal 5 prompts. I have 4 total classes rather than the minimum 3 required. 

using System.IO;
public class Journal
{
    public List<Entry> _entriesList = new List<Entry>();

    public void Write()
    {
        Entry entry = new Entry();
        Console.WriteLine("What is your mood right now?");
        string mood = Console.ReadLine();
        entry._mood = mood;
        string prompt = PromptGenerator.GeneratePrompt();
        entry._prompt = prompt;
        Console.WriteLine(entry._prompt);
        entry._date = DateTime.Now;
        entry._response = Console.ReadLine();
        _entriesList.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in _entriesList)
        {
            Console.WriteLine(entry._date);
            Console.WriteLine($"Mood: {entry._mood}");
            Console.WriteLine(entry._prompt);
            Console.WriteLine(entry._response);
            Console.WriteLine("");
            Console.WriteLine("----");
            Console.WriteLine("");

        }
    }
    public void Load(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _entriesList.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry entry = new Entry();
            entry._date = DateTime.Parse(parts[0]);
            entry._mood = parts[1];
            entry._prompt = parts[2];
            entry._response = parts[3];

            _entriesList.Add(entry);
        }
        
    }
    public void Save(string outputFileName)
    {
        
        using (StreamWriter outputFile = new StreamWriter(outputFileName))
        {
            foreach (Entry entry in _entriesList)
            {
                outputFile.WriteLine($"{entry._date} |{entry._mood}|{entry._prompt}|{entry._response}");
            }
        }
    }

    
}