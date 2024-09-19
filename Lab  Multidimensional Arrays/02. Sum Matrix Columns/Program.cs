// See https://aka.ms/new-console-template for more information

int[] dimentions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int row = dimentions[0];
int col = dimentions[1];

int[,] matrix = new int[row, col];


for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = input[j];
    }

}

int[] values = new int[col];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        values[j] += matrix[i, j];
    }
}

foreach (var value in values)
{
    Console.WriteLine(value);
}
