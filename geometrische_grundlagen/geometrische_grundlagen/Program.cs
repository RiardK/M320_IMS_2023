using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Figur> figuren = new List<Figur>();

        
        Kreis kreis = new Kreis(150.0f, 150.0f, 5.0f);
        Rechteck rechteck = new Rechteck(200.0f, 200.0f, 8.0f, 6.0f);

        figuren.Add(kreis);
        figuren.Add(rechteck);

        
        foreach (Figur figur in figuren)
        {
            Console.WriteLine($"Figur-Typ: {figur.GetType().Name}");
            figur.PrintPosition();
            figur.PrintArea();
            Console.WriteLine();
        }
    }
}