// See https://aka.ms/new-console-template for more information

using Bridge1;

var manuscripts = new List<Manuscript>();
var oFormatter = new OriginalFormatter();
var rFormatter = new ReversableFormatter();
var fFormatter = new FancyFormatter();


var faq = new FAQ(fFormatter)
{
    Questions = new Dictionary<string, string>{
        ["Who Is The Author ?"] = "Joe Lie",
        ["Whate Is Last Book for Him ?"] = "A Book",
    },
    Title = "Authors"
};
manuscripts.Add(faq);
var book = new Book(oFormatter)
{
    Text = "The Book Text",
    Title = "A Book",
    Author = "Joe Lie"
};
manuscripts.Add(book);
// Here we bridge the type of formatter
var paper = new TermPaper(rFormatter)
{
    Class = "A2",
    Student = "John Smith",
    Referances = "A Book, A Book",
    Text = "A Book Text"
};
manuscripts.Add(paper);

manuscripts.ForEach(m => { m.Print(); });



Console.ReadKey();


