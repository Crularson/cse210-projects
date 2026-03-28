public class Comment{
    private string _commenter;
    private string _content;

    public Comment(string name, string text){
        _commenter = name;
        _content = text;
    }
    public void Display()
    {
        Console.WriteLine(_commenter);
        Console.WriteLine(_content);
    }

}