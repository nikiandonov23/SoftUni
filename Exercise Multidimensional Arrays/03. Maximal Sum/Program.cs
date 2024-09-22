// See https://aka.ms/new-console-template for more information


int[] dimentions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int row = dimentions[0];
int col = dimentions[1];
if (row < 3 || col < 3)
{
    Console.WriteLine("Sum = 0");
    return;
}

int[,] matrix = new int[row, col];


for (int i = 0; i < row; i++)
{
    int[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


    for (int j = 0; j <col; j++)
    {
        matrix[i, j] = input[j];
    }

}
int maxSum = int.MinValue;
int[] array=new int[9];

for (int i = 0; i < row - 2; i++)
{


    for (int j = 0; j < col - 2; j++)
    {
        int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                         matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                         matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
        if (maxSum<currentSum)
        {
            maxSum=currentSum;
             array = new[]
            {
                matrix[i, j], matrix[i, j + 1], matrix[i, j + 2],
                matrix[i + 1, j], matrix[i + 1, j + 1], matrix[i + 1, j + 2],
                matrix[i + 2, j], matrix[i + 2, j + 1], matrix[i + 2, j + 2]
                
            };
            
        }
    }
}

Console.WriteLine($"Sum = {maxSum}");


for (int i = 0; i < 9; i+=3)
{
    Console.WriteLine($"{array[i]} {array[i+1]} {array[i+2]}");  
}