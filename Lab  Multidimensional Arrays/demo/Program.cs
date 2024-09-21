// See https://aka.ms/new-console-template for more information

using System.Data;
using System.Xml.Schema;


int n = int.Parse(Console.ReadLine());

int[][] jaggedArray= new int[n][];

for (int i = 0; i < jaggedArray.Length; i++)
{
    int col = i + 1;
    int[]currentLine= new int[col];
    currentLine[0] = 1;
    currentLine[^1] = 1;

    jaggedArray[i] = currentLine;


}

for (int i = 2; i < jaggedArray.Length; i++)
{
    int col = jaggedArray[i].Length;


    for (int j = 1; j <col-1 ; j++)
    {
        jaggedArray[i][j] = jaggedArray[i - 1][j - 1] + jaggedArray[i - 1][j];
    }
}

foreach (var masiv in jaggedArray)
{
    Console.WriteLine(string.Join(" ",masiv));
}