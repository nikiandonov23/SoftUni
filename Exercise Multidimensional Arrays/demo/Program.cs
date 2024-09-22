// See https://aka.ms/new-console-template for more information


int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = data[j];
    }
}

int firstDiagonal = 0;
int secondDiagonal = 0;


for (int i = 0; i < matrix.GetLength(0); i++)
{

    firstDiagonal += matrix[i, i];
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    secondDiagonal += matrix[i, matrix.GetLength(0)-i-1];
}

Console.WriteLine(Math.Abs(firstDiagonal-secondDiagonal));









