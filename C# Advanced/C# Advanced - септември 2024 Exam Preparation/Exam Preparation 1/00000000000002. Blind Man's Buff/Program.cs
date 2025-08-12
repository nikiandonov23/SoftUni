// See https://aka.ms/new-console-template for more information

int[] dimentions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int rows = dimentions[0];
int cols = dimentions[1];
char[,] matrix = new char[rows, cols];

int currentRow = -1;
int currentCol = -1;

int startRow = -1;
int startCol = -1;
for (int i = 0; i < rows; i++)
{
    char[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = data[j];
        if (data[j] == 'B')
        {
            currentRow = i;
            currentCol = j;

            startRow = i;
            startCol = j;

        }
    }
}




int moves = 0;
int opponentsTouched = 0;
string command = "";
matrix[startRow, startCol] = '-';

while (((command = Console.ReadLine()) != "Finish") && opponentsTouched < 3)
{
    int previousRow = currentRow;
    int previousCol = currentCol;
    switch (command)
    {
        case "up":
            currentRow--;
            break;

        case "down":
            currentRow++;
            break;

        case "left":
            currentCol--;
            break;

        case "right":
            currentCol++;
            break;
    }

    if ((currentRow < 0 || currentRow >= rows || currentCol < 0 || currentCol >= cols) || (matrix[currentRow, currentCol] == 'O'))
    {
        currentRow = previousRow;
        currentCol = previousCol;
        continue;
    }

    if (matrix[currentRow,currentCol]=='-')
    {
        moves++;
        continue;
    }
    else if (matrix[currentRow,currentCol]=='P')
    {
        opponentsTouched++;
        matrix[currentRow, currentCol] = '-';
        moves++;
    }

    matrix[currentRow, currentCol] = 'B';
}

Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {opponentsTouched} Moves made: {moves}");








void Print(char[,] matrix)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }

        Console.WriteLine();
    }
}
