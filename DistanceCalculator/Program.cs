// See https://aka.ms/new-console-template for more information

using System;
using System.Threading.Tasks;
using DistanceCalculator;

public class Program
{
    public static async Task Main(string[] args)
    {
        var calculator = new LocationDistanceCalculator();

        // Example postal codes and countries
        string country1 = "US";
        string postalCode1 = "90210";
        string country2 = "CA";
        string postalCode2 = "M5H";

        try
        {
            double distance = await calculator.GetDistanceBetweenPostalCodesAsync(country1, postalCode1, country2, postalCode2);
            Console.WriteLine($"Distance: {distance} km");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
