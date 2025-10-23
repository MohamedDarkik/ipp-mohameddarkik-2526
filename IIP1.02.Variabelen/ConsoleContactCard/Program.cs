using System;
using System.Globalization;

namespace PersoonsInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Culture instellen op Belgisch/Nederlands voor juiste €-weergave
            CultureInfo.CurrentCulture = new CultureInfo("nl-BE");

            // Variabelen
            string naam = "Bobby Peru";
            bool gehuwd = false;
            string telefoon = "0486/33.22.19";
            int leeftijd = 25;
            decimal salaris = 2500.00m;
            char geslacht = 'm';
            double lengte = 1.75;

            // Multiline string met interpolatie
            string output = $"""
            ----------------
            *
            * Naam: {naam}
            * Gehuwd: {(gehuwd ? "ja" : "nee")}
            * Telefoon: {telefoon}
            * Leeftijd: {leeftijd} jaar
            * Salaris: {salaris:C} per maand
            * Geslacht: {geslacht}
            * Lengte: {lengte:F2}m
            *
            ----------------
            """;

            Console.WriteLine(output);
            Console.Write("druk op een toets om verder te gaan...");
            Console.ReadKey();
        }
    }
}