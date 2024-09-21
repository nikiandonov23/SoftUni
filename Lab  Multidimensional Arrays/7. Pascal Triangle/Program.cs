// See https://aka.ms/new-console-template for more information

using System.Linq.Expressions;

int n = int.Parse(Console.ReadLine());

long[][] juggedArray=new long[n][];

for (int i = 0; i < n; i++)
{
    long[] currentLine = new long[i + 1];
    juggedArray[i] = currentLine;

    juggedArray[i][0] = 1;
    juggedArray[i][^1] = 1;
    
}


for (int i = 2; i < juggedArray.Length; i++)
{

    int col = juggedArray[i].Length;

    for (int j = 1; j < col-1; j++)
    {
        juggedArray[i][j] = (juggedArray[i - 1][j - 1] + juggedArray[i - 1][j]);
    }
}

foreach (var element in juggedArray)
{
    Console.WriteLine(string.Join(" ",element));
}