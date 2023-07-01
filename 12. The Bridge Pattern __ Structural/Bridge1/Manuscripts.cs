namespace Bridge1;


public abstract class Manuscript
{
    protected readonly IFormatter _formatter;
    public Manuscript(IFormatter formatter)
    {
        _formatter = formatter;
    }
    public abstract void Print();
}

public class FAQ : Manuscript
{
    public FAQ(IFormatter formatter) : base(formatter)
    {

    }
    public string Title { get; set; }
    public Dictionary<string, string> Questions { get; set; } = default!;

    public override void Print()
    {
        Console.WriteLine(_formatter.Format("Title: {0}", Title));
        foreach (var question in Questions)
        {
            Console.WriteLine(_formatter.Format("Q: {0} : {1}", question.Key, question.Value));
        }
    }
}


public class Book : Manuscript
{
    public Book(IFormatter formatter) : base(formatter)
    {

    }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Text { get; set; }

    public override void Print()
    {
        Console.WriteLine(_formatter.Format("Title: {0}", Title));
        Console.WriteLine(_formatter.Format("Author: {0}", Author));
        Console.WriteLine(_formatter.Format("Text: {0}", Text));

    }
}


public class TermPaper : Manuscript
{
    public TermPaper(IFormatter formatter) : base(formatter)
    {

    }
    public string Class { get; set; }
    public string Student { get; set; }
    public string Text { get; set; }
    public string Referances { get; set; }

    public override void Print()
    {
        Console.WriteLine(_formatter.Format("Class: {0}", Class));
        Console.WriteLine(_formatter.Format("Student: {0}", Student));
        Console.WriteLine(_formatter.Format("Text: {0}", Text));
        Console.WriteLine(_formatter.Format("Referances: {0}", Referances));

    }
}
