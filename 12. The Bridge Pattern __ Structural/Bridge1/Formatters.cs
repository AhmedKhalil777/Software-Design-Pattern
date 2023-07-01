using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge1;

public class OriginalFormatter : IFormatter
{
    public string Format(string text, params string[] args)
    {
        return string.Format(text, args);
    }
}


public class ReversableFormatter : IFormatter
{
    public string Format(string text, params string[] args)
    {
        var res = string.Format(text, args);
        return new String(res.Reverse().ToArray());
    }
}


public class FancyFormatter : IFormatter
{
    public string Format(string text, params string[] args)
    {
        var sb = new StringBuilder();
        sb.AppendLine("================= I am fancy 😁 =================== ");
        sb.AppendLine(string.Format(text, args));
        sb.AppendLine("================= How Crazy I am  😎  =================== ");
        return sb.ToString();
    }
}



public interface IFormatter
{
    string Format(string text, params string[] args);
}
