// See https://aka.ms/new-console-template for more information

int[] dimentions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int row = dimentions[0];
int col = dimentions[1];

string[,] matrix = new string[row, col];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    string[] data = Console.ReadLine().Split(" ").ToArray();


    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = data[j];
    }
}

string firstLineMatch = "";
string secondLineMatch = "";
int matchesCounter = 0;
for (int i = 0; i < matrix.GetLength(0) - 1; i++)
{

    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        if (matrix[i, j] == matrix[i, j + 1] && matrix[i, j] == matrix[i + 1, j] && matrix[i, j] == matrix[i + 1, j + 1])
        {
            {
                matchesCounter++;
             
            }

        }
    }
}

Console.WriteLine(matchesCounter);