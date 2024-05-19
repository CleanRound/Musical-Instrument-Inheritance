public class MusicalInstrument
{
    public string Name { get; protected set; }
    public string Characteristics { get; protected set; }
    public string HistoryText { get; protected set; }

    public MusicalInstrument(string name, string characteristics, string history)
    {
        Name = name;
        Characteristics = characteristics;
        HistoryText = history;
    }

    public void Sound()
    {
        Console.WriteLine($"The {Name} makes a sound.");
    }

    public void Show()
    {
        Console.WriteLine($"Instrument: {Name}");
    }

    public void Desc()
    {
        Console.WriteLine($"Description: {Characteristics}");
    }

    public void History()
    {
        Console.WriteLine($"History: {HistoryText}");
    }
}

public class Violin : MusicalInstrument
{
    public Violin() : base("Violin", "A string instrument typically played with a bow.",
        "The violin has origins tracing back to the 16th century in Italy.")
    {
    }

    public new void Sound()
    {
        Console.WriteLine("The Violin produces a rich, melodious sound.");
    }
}

public class Trombone : MusicalInstrument
{
    public Trombone() : base("Trombone", "A brass instrument characterized by its telescopic slide.",
        "The trombone dates back to the 15th century, evolving from the early sackbut.")
    {
    }

    public new void Sound()
    {
        Console.WriteLine("The Trombone emits a powerful, brassy tone.");
    }
}

public class Ukulele : MusicalInstrument
{
    public Ukulele() : base("Ukulele", "A small, four-stringed instrument originating from Hawaii.",
        "The ukulele was developed in the 1880s, influenced by Portuguese instruments.")
    {
    }

    public new void Sound()
    {
        Console.WriteLine("The Ukulele produces a light, cheerful sound.");
    }
}

public class Cello : MusicalInstrument
{
    public Cello() : base("Cello", "A large string instrument played with a bow, known for its deep tones.",
        "The cello evolved in the 16th century as a member of the violin family.")
    {
    }

    public new void Sound()
    {
        Console.WriteLine("The Cello emits a deep, resonant sound.");
    }
}

class Program
{
    static void Main()
    {
        Violin violin = new Violin();
        violin.Show();
        violin.Desc();
        violin.Sound();
        violin.History();

        Console.WriteLine();

        Trombone trombone = new Trombone();
        trombone.Show();
        trombone.Desc();
        trombone.Sound();
        trombone.History();

        Console.WriteLine();

        Ukulele ukulele = new Ukulele();
        ukulele.Show();
        ukulele.Desc();
        ukulele.Sound();
        ukulele.History();

        Console.WriteLine();

        Cello cello = new Cello();
        cello.Show();
        cello.Desc();
        cello.Sound();
        cello.History();
    }
}
