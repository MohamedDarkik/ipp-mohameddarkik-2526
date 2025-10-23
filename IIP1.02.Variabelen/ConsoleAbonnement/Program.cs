using System;
using System.Globalization;

namespace BestelGegevens
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("nl-BE");

            Console.WriteLine("Bestelgegevens");
            Console.WriteLine("==============");

            Console.Write("- naam klant: ");
            string naam = Console.ReadLine();

            Console.Write("- aantal toegangsbeurten: ");
            int aantalBeurten = int.Parse(Console.ReadLine());

            Console.Write("- prijs (b.v. 122,5): ");
            double prijs = double.Parse(Console.ReadLine());

            Console.Write("- badkleedij inbegrepen (typ true of false): ");
            bool badkleedij = bool.Parse(Console.ReadLine());

            Console.Write("- geslacht (druk 'm' of 'v'): ");
            char geslacht = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Random rnd = new Random();
            string kaartNummer = $"{rnd.Next(100, 1000)}-{rnd.Next(1000, 10000)}-{rnd.Next(10, 100)}";

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($@"
Samenvatting
============
- houder: {naam}
- geslacht: {geslacht}
- prijs: {prijs:C}
- aantal beurten: {aantalBeurten}
- incl. badkleedij: {badkleedij}
- kaartnummer: {kaartNummer}
");

            Console.ResetColor();

            Console.Write("druk op een toets om verder te gaan...");
            Console.ReadKey();
        }
    }
}