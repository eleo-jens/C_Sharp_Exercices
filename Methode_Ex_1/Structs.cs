using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methode_Ex_1
{
    public struct Celsius
    {
        public double temperature;

        // pourrait s'appeler Conversion()
        public Fahrenheit ToFahrenheit()
        {
            Fahrenheit f = new Fahrenheit();
            f.temperature = (this.temperature * 1.8) + 32;
            return f;
        }
    }

    public struct Fahrenheit
    {
        public double temperature;

        // pourrait s'appeler Conversion()
        public Celsius ToCelsius()
        {
            Celsius c = new Celsius();
            c.temperature = (this.temperature - 32) * .5556;
            return c; 
        }
    }

    public struct Input
    {
        public string GetFormat()
        {
            string input;
            do {
                Console.WriteLine("Si vous voulez entrer une température en Celsius, tapez C\nSi vous voulez entrer une température en Fahrenheit, tapez F");
                input = Console.ReadLine();
            } while (input != "F" && input != "C");
            return input; 
        }

        public double GetDouble()
        {
            string input;
            double temp;
            do
            {
                Console.WriteLine("Entrez une température: ");
                input = Console.ReadLine();

            } while (!double.TryParse(input, out temp)); 
            return temp;
        }
    }
}
