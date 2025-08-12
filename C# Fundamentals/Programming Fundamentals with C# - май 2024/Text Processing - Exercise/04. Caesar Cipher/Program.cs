// See https://aka.ms/new-console-template for more information


string input = Console.ReadLine();

List<int> inputAscii=new List<int>();
string encrypted = "";

foreach (var character in input)
{
    inputAscii.Add((int)(character));
}

for (int i = 0; i < inputAscii.Count; i++)
{
    inputAscii[i] += 3;
}

foreach (var number in inputAscii)
{
    encrypted += (char)number;
}

Console.WriteLine(encrypted);
