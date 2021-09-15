using System;
using WeatherUtilities = testtry.WeatherUtilities;

namespace testtry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where we are going");
            WeatherUtilities.Report("Oulu",WeatherUtilities.FahrenheitToCelsius(65), 73);
            WeatherUtilities.Report("Denver", WeatherUtilities.FahrenheitToCelsius(77), 55);
            WeatherUtilities.Report("Bologna", 23, 65);
        }

        

    }
}
