int[] dimentions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int row = dimentions[0];
int col = dimentions[1];

int[,] matrix = new int[row, col];


for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();


    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = input[j];
    }

}

int maxSum = int.MinValue;
int[] maxArray = new int[4];
for (int i = 0; i < matrix.GetLength(0) - 1; i++)
{


    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        int currentsum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
        if (currentsum > maxSum)
        {
            maxSum = currentsum;
            maxArray[0] = matrix[i, j];
            maxArray[1] = matrix[i, j + 1];
            maxArray[2] = matrix[i + 1, j];
            maxArray[3] = matrix[i + 1, j + 1];

        }
    }
}

for (int i = 0; i < maxArray.Length; i++)
{
    if (i==2)
    {
        Console.WriteLine();
    }
    Console.Write(maxArray[i]+" ");
}
Console.WriteLine();
Console.WriteLine(maxSum);