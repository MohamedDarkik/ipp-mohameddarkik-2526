using System;

class Program
{
    static void Main(string[] args)
    {
        #region DEEL A: Basisvariabelen en eenvoudige output

        /* --- Oefening A.1: Eerste variabelen --- */
        Console.WriteLine("\n\nOefening A.1: Eerste variabelen\n------------\n");
        string naamStudent = "Sarah";
        int studentScore = 85;
        Console.WriteLine(naamStudent);
        Console.WriteLine(studentScore);

        /* --- Oefening A.2: Favoriete kleur en leeftijd --- */
        Console.WriteLine("\n\nOefening A.2: Favoriete kleur en leeftijd\n------------\n");
        string favorieteKleur = "blauw";
        int leeftijd = 22;
        Console.WriteLine($"Mijn favoriete kleur is {favorieteKleur} en ik ben {leeftijd} jaar oud.");

        /* --- Oefening A.3: Productgegevens --- */
        Console.WriteLine("\n\nOefening A.3: Productgegevens\n------------\n");
        string productNaam = "Laptop";
        double productPrijs = 1250.75;
        Console.WriteLine($"Product: {productNaam}");
        Console.WriteLine($"Prijs: {productPrijs} euro");

        /* --- Oefening A.4: Variabele hergebruiken --- */
        Console.WriteLine("\n\nOefening A.4: Variabele hergebruiken\n------------\n");
        int aantalBezoekers = 100;
        Console.WriteLine($"Begin aantal bezoekers: {aantalBezoekers}");
        aantalBezoekers = 150;
        Console.WriteLine($"Nieuw aantal bezoekers: {aantalBezoekers}");

        /* --- Oefening A.5: Karakter en status --- */
        Console.WriteLine("\n\nOefening A.5: Karakter en status\n------------\n");
        char bestelStatus = 'V';
        bool isVerzonden = true;
        string bestelID = "ABC1234";
        Console.WriteLine($"Bestel-ID: {bestelID}");
        Console.WriteLine($"Statuscode: {bestelStatus}");
        Console.WriteLine($"Is verzonden: {isVerzonden}");

        #endregion


        #region DEEL B: Invoer en combinaties

        /* --- Oefening B.1: Gebruikersgegevens --- */
        Console.WriteLine("\n\nOefening B1: Gebruikersgegevens\n------------\n");
        Console.Write("Wat is je naam? ");
        string gebruikerNaam = Console.ReadLine();
        Console.Write("Waar woon je? ");
        string woonplaats = Console.ReadLine();
        Console.WriteLine($"Welkom, {gebruikerNaam} uit {woonplaats}!");

        /* --- Oefening B.2: Bioscoop uitnodiging --- */
        Console.WriteLine("\n\nOefening B.2: Bioscoop uitnodiging\n------------\n");
        Console.Write("Welke film wil je zien? ");
        string filmNaam = Console.ReadLine();
        Console.Write("Wat is de naam van de gast? ");
        string gastNaam = Console.ReadLine();
        const string BioscoopLocatie = "Kinepolis";
        Console.WriteLine($"Beste {gastNaam}, je bent uitgenodigd voor de film {filmNaam} bij {BioscoopLocatie}.");

        /* --- Oefening B.3: Booleaanse vlag en status --- */
        Console.WriteLine("\n\nOefening B.3: Booleaanse vlag en status\n------------\n");
        bool isAan = true;
        string lampKleur = "geel";
        Console.WriteLine($"De lamp is {(isAan ? "aan" : "uit")} en heeft de kleur {lampKleur}.");

        /* --- Oefening B.4: Constante groet --- */
        Console.WriteLine("\n\nOefening B.4: Constante groet\n------------\n");
        const string Groet = "Hallo";
        Console.Write("Wat is je naam? ");
        string naamInput = Console.ReadLine();
        Console.WriteLine($"{Groet}, {naamInput}!");

        /* --- Oefening B.5: Restaurantbestelling --- */
        Console.WriteLine("\n\nOefening B.5: Restaurantbestelling\n------------\n");
        Console.Write("Welk gerecht wil je bestellen? ");
        string gerecht = Console.ReadLine();
        Console.Write("Welk drankje wil je erbij? ");
        string drankje = Console.ReadLine();
        const string BedanktBoodschap = "Eet smakelijk!";
        Console.WriteLine($"Je bestelling: {gerecht} en {drankje}.");
        Console.WriteLine(BedanktBoodschap);

        #endregion
    }
}
