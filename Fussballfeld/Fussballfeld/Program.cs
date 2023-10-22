using System;

class Feldspieler
{
    public string Name { get; private set; }

    public Feldspieler(string name)
    {
        Name = name;
    }

    public void SchiesstAufsTor()
    {
        Console.WriteLine($"{Name} schießt aufs Tor!");
    }

    public void MachtBlutgraetsche()
    {
        Console.WriteLine($"{Name} macht eine Blutgrätsche!");
    }

    public void Dribbelt()
    {
        Console.WriteLine($"{Name} dribbelt den Gegner schwindlig!");
    }
}

class Torwart
{
    public string Name { get; private set; }

    public Torwart(string name)
    {
        Name = name;
    }

    public void HaeltSchuss()
    {
        Console.WriteLine($"{Name} hält den Schuss vom Gegner!");
    }

    public void Abstoss()
    {
        Console.WriteLine($"{Name} macht einen Abstoß!");
    }
}

class Fussballmannschaft
{
    public Feldspieler Feldspieler { get; private set; }
    public Torwart Torwart { get; private set; }

    public Fussballmannschaft(string feldspielerName, string torwartName)
    {
        Feldspieler = new Feldspieler(feldspielerName);
        Torwart = new Torwart(torwartName);
    }
}

class Spiel
{
    public Fussballmannschaft HeimMannschaft { get; private set; }
    public Fussballmannschaft GastMannschaft { get; private set; }

    public Spiel(Fussballmannschaft heim, Fussballmannschaft gast)
    {
        HeimMannschaft = heim;
        GastMannschaft = gast;
    }

    public int SpieleSpiel()
    {
        Random rand = new Random();

        int heimTore = rand.Next(8); // Heimmannschaft erzielt 0 bis 4 Tore
        int gastTore = rand.Next(8); // Gastmannschaft erzielt 0 bis 4 Tor

        return heimTore - gastTore; 
    }
}

class Resultat
{
    public Spiel DasSpiel { get; private set; }
    public int HeimMannschaftTore { get; private set; }
    public int GastMannschaftTore { get; private set; }

    public Resultat(Spiel spiel, int heimTore, int gastTore)
    {
        DasSpiel = spiel;
        HeimMannschaftTore = heimTore;
        GastMannschaftTore = gastTore;
    }

    public void Ausgeben()
    {
        Console.WriteLine($"{DasSpiel.HeimMannschaft.Feldspieler.Name} {HeimMannschaftTore} : {GastMannschaftTore} {DasSpiel.GastMannschaft.Feldspieler.Name}");
    }
}

class Program
{
    static void Main()
    {
        Fussballmannschaft heimMannschaft = new Fussballmannschaft("MannschaftA-Feldspieler", "MannschaftA-Torwart");
        Fussballmannschaft gastMannschaft = new Fussballmannschaft("MannschaftB-Feldspieler", "MannschaftB-Torwart");

        Spiel spiel = new Spiel(heimMannschaft, gastMannschaft);
        int ergebnis = spiel.SpieleSpiel();

        // Ergebnisse so anpassen, dass sie nicht negativ sind
        int ergebnisHeim = Math.Max(0, ergebnis);
        int ergebnisGast = Math.Max(0, -ergebnis);

        Resultat resultat = new Resultat(spiel, ergebnisHeim, ergebnisGast);
        resultat.Ausgeben();
    }
}
