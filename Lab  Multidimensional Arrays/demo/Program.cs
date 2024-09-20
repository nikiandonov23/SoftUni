// See https://aka.ms/new-console-template for more information

using System.Data;
using System.Xml.Schema;

int[] dimentions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int row = dimentions[0];
int col = dimentions[1];

int[,]matrix=new int[row, col];
int[] sumElements = new int [col];


for (int i = 0; i < matrix.GetLength(1); i++)
{
    int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        
        matrix[i,j]= input[j];
    }
}