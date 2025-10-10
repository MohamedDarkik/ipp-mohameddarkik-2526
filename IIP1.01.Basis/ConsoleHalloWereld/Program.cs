using System;

class Program
{
   static void Main(string[] args)
   {
      Console.WriteLine("Hallo wereld!");
	  Console.Write("Hoe heet je: ");
	  string naam = Console.ReadLine();
	  Console.ForegroundColor = ConsoleColor.Yellow;
	  Console.WriteLine("Aangenaam kennismaking, " + naam);
	  Console.ResetColor();
	  Console.WriteLine("Druk een toets om verder te gaan...");
	  Console.ReadKey();
	  
   }
}