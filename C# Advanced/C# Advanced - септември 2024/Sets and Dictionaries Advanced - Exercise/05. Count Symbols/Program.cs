// See https://aka.ms/new-console-template for more information

string input = Console.ReadLine();

char[] charArray = input.ToCharArray();
Dictionary<char,int>allChars=new Dictionary<char,int>();

foreach (char c in charArray)
{
    if (!allChars.ContainsKey(c))
    {
        allChars.Add(c,1);
    }
    else
    {

        allChars[c]+=1;
    }
}

allChars=allChars.OrderBy(x=>x.Key).ToDictionary(x=>x.Key,x=>x.Value);
foreach (var c in allChars)
{
    Console.WriteLine($"{c.Key}: {c.Value} time/s");
}