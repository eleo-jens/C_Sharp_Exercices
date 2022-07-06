using System;

namespace Methode_Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Input user_input;
            // méthode permettant de demander à l'utilisateur quel format il veut: C ou F
            string format = user_input.GetFormat();
            switch (format)
            {
                // en fonction du format: demander la température que l'utilisateur veut convertir et effectue la conversion
                case "C":
                    Celsius c1;
                    c1.temperature = user_input.GetDouble();
                    Fahrenheit f1 = c1.ToFahrenheit();
                    Console.WriteLine($"{c1.temperature}° Celsius = {f1.temperature}° Fahrenheit");
                    break;
                case "F":
                    Fahrenheit f2; 
                    f2.temperature = user_input.GetDouble();
                    Celsius c2 = f2.ToCelsius();
                    Console.WriteLine($"{f2.temperature}° Fahrenheit = {c2.temperature}° Celsius");
                    break;
            }
        }
    }
}
