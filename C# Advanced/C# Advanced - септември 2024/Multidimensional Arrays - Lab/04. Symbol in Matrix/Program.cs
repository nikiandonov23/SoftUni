
using System.Numerics;

int dimentions = int.Parse(Console.ReadLine());


string[,] matrix = new string[dimentions, dimentions];


for (int i = 0; i < matrix.GetLength(0); i++)
{
    char[] input = Console.ReadLine().ToCharArray();


    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = input[j].ToString();
    }

}

string symbol=Console.ReadLine();
bool isFound=false;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i,j]==symbol)
        {
            Console.WriteLine($"({i}, {j})");
            isFound = true;
            break;
        }

        if (isFound)
        {
            break;
        }
    }
}

if (!isFound)
{
    Console.WriteLine($"{symbol} does not occur in the matrix");
}

