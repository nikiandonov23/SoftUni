// See https://aka.ms/new-console-template for more information


using System.Text.RegularExpressions;

string pattern = @"(=|\/)([A-Z][A-Za-z]{2,})\1";

string input=Console.ReadLine();
List<string> allDestinations=new List<string>();
int travelPoints = 0;
foreach (Match match in Regex.Matches(input, pattern))
{
    travelPoints += (match.Groups[2].Value).Length;
    allDestinations.Add(match.Groups[2].Value);
}

Console.WriteLine($"Destinations: {string.Join(", ", allDestinations)}");
Console.WriteLine($"Travel Points: {travelPoints}");