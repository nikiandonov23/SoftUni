// See https://aka.ms/new-console-template for more information


int armor = int.Parse(Console.ReadLine());

int n = int.Parse(Console.ReadLine()); // n ROWS

char[][] jaggedArray = new char[n][];

for (int i = 0; i < jaggedArray.Length; i++)
{
    string input = Console.ReadLine();
    for (int j = 0; j < input.Length; j++)
    {
        jaggedArray[i] = input.ToCharArray();
    }
}

Console.WriteLine();