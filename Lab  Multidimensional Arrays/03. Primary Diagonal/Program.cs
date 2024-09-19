int rowCol = int.Parse(Console.ReadLine());


int[,] matrix = new int[rowCol, rowCol];


for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = input[j];
        
    }

}


int sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, i];
        break;
    }
}
Console.WriteLine(sum);
