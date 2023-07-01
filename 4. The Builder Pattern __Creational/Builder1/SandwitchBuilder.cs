namespace Builder1;


/// <summary>
/// Builder Director
/// </summary>
public class SandwithMaker : SandwitchBuilder
{
    public Sandwitch CreateBurger()
    {
        return
          WithBreadType(BreadType.White)
         .WithMeetType(MeetType.Bufflow)
         .WithCheeseType(CheeseType.Cheddar)
         .WithMayo()
         .WithVegitables("Carrots", "Tommato")
         .Toasted()
         .Build();

    }
}
public class SandwitchBuilder
{
    private Sandwitch _sandwitch;
    public SandwitchBuilder()
    {
        _sandwitch = new Sandwitch();
    }

    public SandwitchBuilder WithMeetType(MeetType meetType)
    {
        _sandwitch.MeetType = meetType;
        return this;
    }

    public SandwitchBuilder WithBreadType(BreadType breadType)
    {
        _sandwitch.BreadType = breadType;
        return this;
    }

    public SandwitchBuilder WithCheeseType(CheeseType cheeseType)
    {
        _sandwitch.CheeseType = cheeseType;
        return this;
    }

    public SandwitchBuilder WithMayo()
    {
        _sandwitch.HasMayo = true;
        return this;
    }

    public SandwitchBuilder Toasted()
    {
        _sandwitch.IsToasted = true;
        return this;
    }

    public SandwitchBuilder NotToasted()
    {
        _sandwitch.IsToasted = false;
        return this;
    }

    public SandwitchBuilder WithoutMayo()
    {
        _sandwitch.HasMayo = false;
        return this;
    }


    public SandwitchBuilder WithVegitables(params string[] vegitables)
    {
        _sandwitch.Vegitables = vegitables.ToList();
        return this;
    }
    public Sandwitch Build()
    {
        return _sandwitch;
    }
}



public class Sandwitch
{
    public MeetType MeetType { get; set; }
    public BreadType BreadType { get; set; }
    public CheeseType CheeseType { get; set; }

    public bool HasMayo { get; set; }
    public bool HasKatchub { get; set; }
    public bool IsToasted { get; set; }
    public List<string> Vegitables { get; set; }



    public void Display()
    {
        this.GetType().GetProperties().ToList()
            .ForEach(p =>
            {
                if (p.Name != nameof(Vegitables))
                {
                    Console.WriteLine(p.Name + " : " + p.GetValue(this));
                }
                else
                {
                    var vegitables = (List<string>)p.GetValue(this)!;
                    Console.WriteLine($"Vegitables : ({string.Join(", ", vegitables)})");
                }
            });
    }

}

public enum MeetType
{
    Bufflow,
    Cow
}


public enum CheeseType
{
    Cheddar,
    Turkish
}

public enum BreadType
{
    White,
    Dark
}

