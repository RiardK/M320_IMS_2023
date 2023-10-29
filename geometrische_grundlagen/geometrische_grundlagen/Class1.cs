class Figur
{
    public float X { get; set; }
    public float Y { get; set; }

    public Figur(float x = 100.0f, float y = 100.0f)
    {
        X = x;
        Y = y;
    }

    public virtual void PrintPosition()
    {
        Console.WriteLine($"Position (obere linke Ecke): X={X}, Y={Y}");
    }

    public virtual void PrintArea()
    {
        Console.WriteLine("Fläche: Nicht definiert");
    }
}

class Kreis : Figur
{
    public float Radius { get; set; }

    public Kreis(float x = 100.0f, float y = 100.0f, float radius = 1.0f)
        : base(x, y)
    {
        Radius = radius;
    }

    public override void PrintPosition()
    {
        Console.WriteLine($"Mittelpunkt: X={X}, Y={Y}");
    }
}

class Rechteck : Figur
{
    public float Breite { get; set; }
    public float Höhe { get; set; }

    public Rechteck(float x = 100.0f, float y = 100.0f, float breite = 1.0f, float höhe = 1.0f)
        : base(x, y)
    {
        Breite = breite;
        Höhe = höhe;
    }

    public override void PrintPosition()
    {
        Console.WriteLine($"Position (obere linke Ecke): X={X}, Y={Y}");
        Console.WriteLine($"Position (untere rechte Ecke): X={X + Breite}, Y={Y + Höhe}");
    }

    public override void PrintArea()
    {
        Console.WriteLine($"Fläche: {Breite * Höhe}");
    }
}

