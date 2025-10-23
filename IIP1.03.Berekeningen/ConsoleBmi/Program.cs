using System;
using System.Globalization;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("nl-BE");

            Console.WriteLine("BMI CALCULATOR");
            Console.WriteLine("==============");

            Console.Write("Lengte (in cm): ");
            int lengteCm = int.Parse(Console.ReadLine());

            Console.Write("Gewicht (in kg): ");
            int gewichtKg = int.Parse(Console.ReadLine());

            double lengteM = lengteCm / 100.0;                 
            double bmi = gewichtKg / Math.Pow(lengteM, 2);     
            double bmiAfgerond = Math.Round(bmi, 1);      

            Console.WriteLine($"Je BMI bedraagt: {bmiAfgerond}");
        }
    }
}