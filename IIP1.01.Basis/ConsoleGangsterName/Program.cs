using System;

class Program
{
   static void Main(string[] args)
   {
      Console.WriteLine($@"***********************
|GANGSTA NAME BUILDER |
***********************");
	
	
	Console.Write("Give the first name of any Disney character: ");
	string disneyName = Console.ReadLine();
	
	Console.Write("Give any workbench tool; ");
	string tool = Console.ReadLine();
	
	Console.Write("What is your last name: ");
	string lastName = Console.ReadLine();
	
	string gangsterName = disneyName + " 'the" + tool + "'" + lastName;
	
	Console.ForegroundColor = ConsoleColor.White;
	Console.Write("Your gangsta name : ");
	
	Console.ForegroundColor = ConsoleColor.Green;
	Console.WriteLine(gangsterName);
	Console.ResetColor();
	 
	  
   }
}