using System;
using System.IO;

// I have made sure the words don't hide when they are already hidden, and I set up the classes to be able to handle external scripture inputs.
// I made a lot of constructors for robustness.
class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        string input = null;
        do
        {

            Console.Clear();
            Console.WriteLine("Type 'quit' if you want to end the program. ");
            Console.WriteLine(scripture.DisplayScripture());
            scripture.Randomizer();
            scripture.Randomizer();
            scripture.Randomizer();
            input = Console.ReadLine();


        } while (!scripture.Allhidden() && input != "quit");
        Console.Clear();
        Console.WriteLine(scripture.DisplayScripture());






        // This is code from in class

        // Library library = new Library();

        // Reference ref1 = new Reference("1");
        // Book book1 = new Book("The Way of Kings", ref1);
        // library.AddBook(book1);

        // Reference ref2 = new Reference("1");
        // Book book2 = new Book("Words of Radiance", ref2);
        // library.AddBook(book2);



    }
}