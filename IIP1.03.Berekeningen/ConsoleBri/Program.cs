using System;

class BRIcalculator
{
    // :pushpin: Constanten
    const double BASIS = 364.2;
    const double FACTOR = 365.5;
    const double ONDERGRENS = 3.41;
    const double BOVENGRENS = 4.44;

    static void Main()
    {
        // :dart: Multiline header met icoontje
        string header = @"
===============================
:abacus: BRI CALCULATOR
===============================
";
        Console.WriteLine(header);

        // :inbox_tray: Invoer van taille en lengte
        Console.Write("Taille (in cm): ");
        int taille = int.Parse(Console.ReadLine());

        Console.Write("Lengte (in cm): ");
        int lengte = int.Parse(Console.ReadLine());

        // :brain: Berekening van BRI
        double tailleInMeter = taille / 100.0;
        double lengteInMeter = lengte / 100.0;

        double bri = BASIS - FACTOR * Math.Sqrt(1 - Math.Pow(tailleInMeter / lengteInMeter, 2));

        // :white_check_mark: Resultaat tonen in groen met 1 cijfer na de komma
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nJe BRI bedraagt: {bri:F1}");
        Console.ResetColor();

        // :pushpin: Eindtekst met interpolatie
        Console.WriteLine($"\nEen BRI tussen {ONDERGRENS} en {BOVENGRENS} is normaal.");
    }
}