using System;
using System.IO;
public class PromptGenerator
{
    public static string GeneratePrompt()
    {
        string filename = "C:\\Users\\crula\\OneDrive - BYU-Idaho\\Documents\\byui\\winter2026\\cse210\\cse210-projects\\prove\\Develop02\\prompts.txt";
        string[] lines = File.ReadAllLines(filename);

        
           Random random = new Random();
           int randomIndex = random.Next(0,lines.Length);

           return lines[randomIndex];
    }
}