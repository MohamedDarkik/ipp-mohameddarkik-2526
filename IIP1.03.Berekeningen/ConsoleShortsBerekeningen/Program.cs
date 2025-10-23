using System;

class Program
{
    static void Main(string[] args)
    {
        /* --- Oefening 1: Optellen en delen --- */
        int score1 = 80;
        int score2 = 95;
        int totaalScore = score1 + score2;
        double gemiddelde = totaalScore / 2.0;
        Console.WriteLine(gemiddelde);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 2: Modulo en Increment --- */
        int aantalItems = 15;
        int itemsPerDoos = 4;
        int rest = aantalItems % itemsPerDoos;
        aantalItems++;
        Console.WriteLine($"De rest is: {rest}");
        Console.WriteLine($"Het nieuwe aantal is: {aantalItems}");

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 3: Afronden met Math --- */
        double totaalbedrag = 45.75;
        double fooi = Math.Ceiling(totaalbedrag * 0.15);
        Console.WriteLine(fooi);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 4: Karakter en string concatenatie --- */
        char prefix = 'P';
        int nummer = 123;
        string productCode = prefix + nummer.ToString();
        Console.WriteLine(productCode);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 5: Werken met strings --- */
        string gebruikersNaam = "  frank";
        string bewerkteNaam = gebruikersNaam.Trim().ToUpper();
        Console.WriteLine(bewerkteNaam);
        Console.WriteLine(bewerkteNaam.Length);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 6: Logische AND-operator --- */
        bool isVoldoendeScore = true;
        bool heeftAanwezigheid = true;
        bool geslaagd = isVoldoendeScore && heeftAanwezigheid;
        Console.WriteLine(geslaagd);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 7: Typeconversie (string naar int) --- */
        Console.Write("Voer een getal in: ");
        string invoerTekst = Console.ReadLine();
        int invoerGetal = Convert.ToInt32(invoerTekst);
        Console.WriteLine($"Het ingevoerde getal is: {invoerGetal}");

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 8: Decimale conversie en ToString() --- */
        double prijs = 9.995;
        string geformatteerdePrijs = prijs.ToString("F2");
        Console.WriteLine(geformatteerdePrijs);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 9: DateTime en Properties --- */
        DateTime huidigeDatum = DateTime.Now;
        Console.WriteLine($"Vandaag is dag {huidigeDatum.Day} in maand {huidigeDatum.Month}");

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 10: Berekenen met DateTime --- */
        DateTime vandaag = DateTime.Today;
        DateTime toekomstDatum = vandaag.AddDays(14);
        Console.WriteLine(toekomstDatum);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 11: Delen van gehele getallen --- */
        int totaalAppels = 10;
        int aantalStudenten = 3;
        int appelsPerStudent = totaalAppels / aantalStudenten;
        Console.WriteLine(appelsPerStudent);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 12: Verkorte toewijzing --- */
        int score = 85;
        score += 10;
        Console.WriteLine(score);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 13: Logische NOT-operator --- */
        bool isActief = true;
        bool isInactief = !isActief;
        Console.WriteLine(isInactief);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 14: Logische OR-operator --- */
        bool isWachtwoordCorrect = false;
        bool isEmailCorrect = true;
        bool inloggenMogelijk = isWachtwoordCorrect || isEmailCorrect;
        Console.WriteLine(inloggenMogelijk);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 15: String vergelijking --- */
        const string AdminNaam = "admin";
        Console.Write("Voer uw naam in: ");
        string ingevoerdeNaam = Console.ReadLine();
        bool isGelijk = AdminNaam == ingevoerdeNaam;
        Console.WriteLine(isGelijk);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 16: Typeconversie (string naar char) --- */
        Console.Write("Voer uw naam in: ");
        string naam = Console.ReadLine();
        char eersteLetter = naam[0];
        Console.WriteLine(eersteLetter);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 17: String met speciale tekens --- */
        string pad = "C:\\Users\\documents\\file.txt";
        Console.WriteLine(pad);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 18: Gebruik van Math.Round --- */
        double prijsExclBtw = 24.99;
        double btwTarief = 0.21;
        double prijsInclBtw = Math.Round(prijsExclBtw * (1 + btwTarief), 2);
        Console.WriteLine(prijsInclBtw);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 19: String eigenschappen en methoden --- */
        Console.Write("Voer uw wachtwoord in: ");
        string wachtwoord = Console.ReadLine();
        Console.WriteLine($"Lengte: {wachtwoord.Length}");
        Console.WriteLine($"Eerste karakter: {wachtwoord[0]}");

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 20: Complexere booleanse uitdrukking --- */
        bool toets1Geslaagd = true;
        bool toets2Geslaagd = false;
        bool projectGeslaagd = true;
        bool geslaagdVoorSemester = (toets1Geslaagd && toets2Geslaagd) || (toets1Geslaagd && projectGeslaagd) || (toets2Geslaagd && projectGeslaagd);
        Console.WriteLine(geslaagdVoorSemester);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 21: Datum weergeven in een specifiek formaat --- */
        DateTime nu = DateTime.Now;
        string geformatteerdeDatum = nu.ToString("dd MMMM yyyy");
        Console.WriteLine(geformatteerdeDatum);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 22: Berekening van leeftijd --- */
        DateTime geboorteDatum = new DateTime(1990, 5, 15);
        int leeftijd = (int)((DateTime.Today - geboorteDatum).TotalDays / 365.25);
        Console.WriteLine($"Leeftijd: {leeftijd}");

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 23: Gebruik van Math.PI --- */
        double straal = 7;
        double omtrek = 2 * straal * Math.PI;
        Console.WriteLine(omtrek);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 24: `char` naar `int` conversie --- */
        char hoofdletter = 'A';
        int asciiWaarde = Convert.ToInt32(hoofdletter);
        Console.WriteLine(asciiWaarde);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 25: `int` naar `char` conversie --- */
        int getal = 66;
        char karakter = Convert.ToChar(getal);
        Console.WriteLine(karakter);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 26: String naar int en optellen --- */
        Console.Write("Voer het eerste getal in: ");
        int getal1 = int.Parse(Console.ReadLine());
        Console.Write("Voer het tweede getal in: ");
        int getal2 = int.Parse(Console.ReadLine());
        int som = getal1 + getal2;
        Console.WriteLine(som);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 27: Booleaanse waarden van strings --- */
        Console.Write("Ben je tevreden? (true/false): ");
        bool isTevreden = bool.Parse(Console.ReadLine());
        Console.WriteLine(isTevreden);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 28: Complexere string manipulatie --- */
        Console.Write("Voornaam: ");
        string voornaam = Console.ReadLine();
        Console.Write("Achternaam: ");
        string achternaam = Console.ReadLine();
        string gebruikersnaam = (voornaam + "." + achternaam).ToLower();
        bool geldig = gebruikersnaam.Contains(".");
        Console.WriteLine($"gebruikersnaam: {gebruikersnaam}");
        Console.WriteLine($"Geldig: {geldig}");

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 29: Typeconversie (`ToString`) --- */
        int aantal = 10;
        bool isKlaar = true;
        Console.WriteLine($"Het aantal is: {aantal.ToString()}");
        Console.WriteLine($"De status is: {isKlaar.ToString()}");

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 30: `DateTime` operaties --- */
        DateTime vandaag2 = DateTime.Today;
        DateTime volgendeMaand = vandaag2.AddMonths(1);
        Console.WriteLine(volgendeMaand.ToString("dd/MM/yyyy"));
    }
}
