using System;
using System.Collections.Generic;

// The Main function process
var infoSrc = new InformationSrc();
infoSrc.GetInformation();

public class InformationSrc
{
    /// <summary>
    /// The Data
    /// </summary>
    private Dictionary<string, string> DataSrc = new Dictionary<string, string>
    {
        ["Ahmed"] = "Student",
        ["Mohammad"] = "Doctor",
        ["Ibrahim"] = "Player"
    };


    /// <summary>
    /// The Caller function
    /// </summary>
    public void GetInformation()
    {
        var doer = new Doer();
        doer.PrintInfo(DataSrc);
    }

}


/// <summary>
/// The Doer Class
/// </summary>
public class Doer
{
    public void PrintInfo(Dictionary<string, string> data)
    {
        foreach (var item in data)
        {
            Console.WriteLine(item.Key + " is " + item.Value);
        }
    }
}


