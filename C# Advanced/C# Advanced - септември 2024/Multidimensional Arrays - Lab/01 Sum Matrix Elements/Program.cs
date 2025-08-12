using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

int[] dimentions=Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int[,]matrix=new int[dimentions[0],dimentions[1]];
int sum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j]=input[j];
        sum += input[j];
    }
}
Console.WriteLine(dimentions[0]);
Console.WriteLine(dimentions[1]);
Console.WriteLine(sum);