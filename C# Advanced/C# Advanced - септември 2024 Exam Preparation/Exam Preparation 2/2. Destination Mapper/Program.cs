// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = @"([=/])([A-Z][a-zA-Z]{2,})\1";

int travelpoints = 0;
List<string> allDestinations = new List<string>();

foreach (Match match in Regex.Matches(input, pattern))
{
    allDestinations.Add(match.Groups[2].Value);
    travelpoints += (match.Groups[2].Value).Length;
}


Console.WriteLine($"Destinations: {string.Join(", ", allDestinations)}");


Console.WriteLine($"Travel Points: {travelpoints}");