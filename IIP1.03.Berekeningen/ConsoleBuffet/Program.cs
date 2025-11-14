using System;

internal class NewBaseType
{
    const double VolwassenBuffetPrijs = 18.5;
    const double DessertBuffetPrijs = 7.95;
    const double KidsMenuPrijs = 11.0;

    static void Main()
    {
        string header = @"
===========================================
   WELKOM IN HET BUFFETRESTAURANT
   Alles is à volonté en dranken zijn inbegrepen!
   !!Promotie!! Vandaag ronden we het totaalbedrag af naar beneden!
===========================================
";
        Console.WriteLine(header);

        Console.Write("Aantal volwassenenbuffets (€18.5): ");
        int aantalVolwassen = int.Parse(Console.ReadLine());

        Console.Write("Aantal dessertenbuffets (€7.95): ");
        int aantalDesserten = int.Parse(Console.ReadLine());

        Console.Write("Aantal kids menus (€11): ");
        int aantalKids = int.Parse(Console.ReadLine());

        Console.Write("Fooi (0 indien geen): ");
        double fooi = double.Parse(Console.ReadLine());

        double totaal = (aantalVolwassen * VolwassenBuffetPrijs) +
                        (aantalDesserten * DessertBuffetPrijs) +
                        (aantalKids * KidsMenuPrijs) + fooi;

        int afgerondTotaal = (int)Math.Floor(totaal);

        Console.WriteLine($"\nTotaal te betalen: €{totaal:F2}");
        Console.WriteLine($"Afgerond naar beneden: €{afgerondTotaal}");

        Console.Write("Cash betaald: ");
        int cash = int.Parse(Console.ReadLine());

        int wisselgeld = cash - afgerondTotaal;
        Console.WriteLine($"U krijgt terug: €{wisselgeld}");

        int[] waarden = { 50, 20, 10, 5, 2, 1 };
        string[] labels = { "briefje(s) van 50", "briefje(s) van 20", "briefje(s) van 10", "briefje(s) van 5", "munt(en) van 2", "munt(en) van 1" };

        for (int i = 0; i < waarden.Length; i++)
        {
            int aantal = wisselgeld / waarden[i];
            wisselgeld %= waarden[i];
            Console.WriteLine($"{aantal} {labels[i]}");
        }

        Console.WriteLine("0 stuk(ken) van 0.5");
        Console.WriteLine("0 stuk(ken) van 0.1");
    }
}

class BuffetRestaurant : NewBaseType
{
}