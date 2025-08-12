// See https://aka.ms/new-console-template for more information

int n=int.Parse(Console.ReadLine());
int[,] matrix = new int[n,n];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] data=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = data[j];
    }
}

int firstDiagonal = 0;
int secondDiagonal = 0;

int start = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    

    for (int j = start; j < matrix.GetLength(1); j++)
    {
        firstDiagonal += matrix[i, j];
        start++;
        break;
    }
}

start = 0;
for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
{


    for (int j = start; j < matrix.GetLength(1); j++)
    {
        secondDiagonal += matrix[i, j];
        start++;
        break;
    }
}

Console.WriteLine($"{Math.Abs(firstDiagonal-secondDiagonal)}");