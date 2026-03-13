using System.Formats.Asn1;

public class Saver
{
    public void SaveFile(string fileName, List<Goal> goals, int pointTotal)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(pointTotal);
        
        foreach( Goal g in goals)
        {
            writer.WriteLine(g.Delimited());
        }
        }
    }
    public List<Goal> Load(string fileName)
    {
        List<Goal> goalList = new List<Goal>();
        using (StreamReader reader = new StreamReader(fileName))
        {
            Program.SetPointTotal(int.Parse(reader.ReadLine()));
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split("|");
                line = reader.ReadLine();
                if (fields[0] == "Simple")
                {
                    Simple simple = new Simple(fields[1],fields[2],int.Parse(fields[3]));
                    bool complete = bool.Parse(fields[4]);
                    if (complete)
                    {
                        simple.markComplete();
                    }
                    goalList.Add(simple);

                }
                else if (fields[0] == "Eternal")
                {
                    Eternal eternal = new Eternal(fields[1],fields[2],int.Parse(fields[3]));
                    goalList.Add(eternal);
                    
                }
                else if (fields[0] == "Checklist")
                {
                    Checklist checklist = new Checklist(fields[1],fields[2],int.Parse(fields[3]), int.Parse(fields[5]));
                    bool complete = bool.Parse(fields[6]);
                    if (complete)
                    {
                        checklist.markComplete();
                    }
                    else
                    {
                        checklist.SetCompletionNumber(int.Parse(fields[4]));
                    }
                    
                    goalList.Add(checklist);
                }
                
            }
            return goalList;
        }
    }
}