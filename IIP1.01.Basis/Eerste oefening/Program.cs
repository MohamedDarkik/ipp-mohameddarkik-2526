using System;

class Program
{
   static void Main(string[] args)
   {
	  
	  Console.OutputEncoding = Encoding.UTF8;
	   
	   
	  Console.Clear();
	  Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Geef uw naam in: ");
	  Console.ResetColor();
	  string voornaam = Console.ReadLine();
	  
	  Console.ForegroundColor = ConsoleColor.Green;
	  Console.BackgroundColor = ConsoleColor.Yellow;
	  Console.WriteLine("Geef uw leeftijd in: ");
	  Console.ResetColor();
	  int leeftijd = Convert.ToInt32(Console.ReadLine());
	  
	  Console.WriteLine("Geef uw lievelingskarakter in: ");
	  char lievelingskarakter = Console.ReadKey().KeyChar;
	  
	  Console.WriteLine("Jouw naam is " + voornaam + " en je leeftijd is" + leeftijd + "jaar" + " en jouw lievelingskarakter is " + lievelingskarakter );
	  
	  
   }
}