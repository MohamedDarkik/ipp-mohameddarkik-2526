using System;

internal class Program
{

    const double hoorntje = 0.5;
    const double bakje = 0.3;
   const double slagroom = 0.7 ;
   const double bol = 1.0;


      static void Main(string[] args)
   {



	Console.WriteLine($@"***********************
  Ijssalon `t Bolleke
***********************");
   
   Console.WriteLine("wat wil je bestellen:");
   Console.WriteLine("a) schepijs🍦");
   Console.WriteLine("b) smoothie🍸");
   Console.WriteLine("maak je keuze: ");
   string keuze = Console.ReadLine();

   switch (keuze)
   {
      case "a":
         Console.WriteLine("je hebt gekozen voor schepijs");
         break;
      case "b":
         Console.WriteLine("je hebt gekozen voor smoothie");
         break;
      default:
         Console.WriteLine("ongeldige keuze");
         break;
   }

   if (keuze == "a")
   {
      Console.WriteLine("Wil je een hoorntje of een bakje (h/b): ");
      string houder = Console.ReadLine();
      if (houder == "h")
      {
         Console.WriteLine ("Voeg een bol toe (Vanille, Aardbei, Chocolade, mokka; laat leeg om te stoppen): ");
         string bol1 = Console.ReadLine();
         Console.WriteLine ("Voeg een bol toe (Vanille, Aardbei, Chocolade, mokka; laat leeg om te stoppen): ");
         string bol2 = Console.ReadLine();
         Console.WriteLine ("Voeg een bol toe (Vanille, Aardbei, Chocolade, mokka; laat leeg om te stoppen): ");
         string bol3 = Console.ReadLine();
      }
      else if (houder == "b")
      {
         Console.WriteLine ("Voeg een bol toe (Vanille, Aardbei, Chocolade, mokka; laat leeg om te stoppen): ");
         string bol4 = Console.ReadLine();
         Console.WriteLine ("Voeg een bol toe (Vanille, Aardbei, Chocolade, mokka; laat leeg om te stoppen): ");
         string bol5 = Console.ReadLine();
         Console.WriteLine ("Voeg een bol toe (Vanille, Aardbei, Chocolade, mokka; laat leeg om te stoppen): ");
         string bol6 = Console.ReadLine();
      }

      Console.WriteLine("Wil je slagroom (j/n): ");
      string slagroom = Console.ReadLine();
           
      
   
      
   }






   else if (keuze == "b")
   {
      Console.WriteLine("maak je keuze: b");
      Console.WriteLine("Je hebt gekozen voor smoothie. Kies exact welke drie fruitsoorten.");

     

   

   };

} 
}