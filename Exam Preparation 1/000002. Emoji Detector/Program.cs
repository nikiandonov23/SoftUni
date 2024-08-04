// See https://aka.ms/new-console-template for more information


using System.Numerics;
using System.Text.RegularExpressions;

string pattern = @"(::|\*\*)([A-Z][a-z]{2,})\1";

string input=Console.ReadLine();

BigInteger threshold = 1;
for (int i = 0; i < input.Length; i++)
{
    if (Char.IsDigit(input[i]))
    {

        threshold *= input[i] - '0';
        
    }
}


Dictionary<string,int>allEmojis=new Dictionary<string,int>();
foreach (Match match in Regex.Matches(input, pattern))
{
    
   string currentEmoji = match.Groups[2].Value;
   int power = 0;
   for (int i = 0; i < currentEmoji.Length; i++)
   {
       power += currentEmoji[i];
   }
   allEmojis.Add(match.Value, power);
}

Console.WriteLine($"Cool threshold: {threshold}");
Console.WriteLine($"{allEmojis.Count} emojis found in the text. The cool ones are:");
foreach (var emoji in allEmojis)
{
    if (emoji.Value> threshold)
    {
        Console.WriteLine(emoji.Key);
    }
}
