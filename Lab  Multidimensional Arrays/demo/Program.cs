// See https://aka.ms/new-console-template for more information

using System.Xml.Schema;

int[,] matrix = new int[,]
{
    {1,2,3},
    {4,5,6},
    {7,8,9},
    {10,11,12},
    {13,14,15},

};


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] += 1;
        Console.Write(matrix[i, j]);


    }

    Console.WriteLine();
}
