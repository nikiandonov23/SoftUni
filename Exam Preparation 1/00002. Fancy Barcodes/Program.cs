// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

string pattern = @"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";
Regex regex = new Regex(pattern);

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{

    string input = Console.ReadLine();

    Match match = regex.Match(input);
    string group = "";
    if (match.Success)
    {
      
        for (int j = 0; j < input.Length; j++)
        {
            if (Char.IsDigit(input[j]))
            {
                group += input[j]-'0';
            }
            
        }

        if (group=="")
        {
            group = "00";
        }

        Console.WriteLine($"Product group: {group}");
    }
    else
    {
        Console.WriteLine("Invalid barcode");
    }

}


