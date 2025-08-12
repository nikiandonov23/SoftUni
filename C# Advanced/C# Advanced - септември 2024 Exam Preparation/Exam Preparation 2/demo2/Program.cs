// See https://aka.ms/new-console-template for more information


using System.Drawing;
using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = @"[@#]+([a-z]{3,})[@#]+[^a-zA-Z0-9]*\/+(\d+)\/+";  //@ i # nqma nujda da sa edni i sushti.Samo malki bukvi.Cvete e minimum 3 simvola.

foreach (Match match in Regex.Matches(input, pattern))
{
    int amount = int.Parse(match.Groups[2].Value);
    string color = match.Groups[1].Value;
    Console.WriteLine($"You found {amount} {color} eggs!");
}
