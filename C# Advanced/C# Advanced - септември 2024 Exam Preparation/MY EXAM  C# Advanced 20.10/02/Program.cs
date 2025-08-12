// See https://aka.ms/new-console-template for more information


int[] dimentions=Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = dimentions[0];
int cols= dimentions[1];


int startRow = -1;
int startCol = -1;

int currentRow = -1;
int currentCol = -1;
char[,] matrix=new char[rows,cols];
for (int i = 0; i < rows; i++)
{
    string input = Console.ReadLine();
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = input[j];
        if (input[j]=='C')
        {
            startRow = i;
            startCol=j;
            currentRow = i;
            currentCol=j;
        }
    }
}

Console.WriteLine();

int timeRemaining = 16;
bool defused = false;
bool killed = false;
bool bombHasExploded = false;

while (defused==false&&killed==false&&timeRemaining>0)   // ili ako vremeto svurshi i bombata explodira
{
    int previousRow=currentRow;
    int previousCol = currentCol;
    string command=Console.ReadLine();

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

    if (currentRow<0||currentRow>=rows||currentCol<0||currentCol>=cols)
    {
        currentRow = previousRow;
        currentCol = previousCol;
        timeRemaining--;
        continue;
    }

    if (command== "defuse" && matrix[currentRow,currentCol]!='B')
    {
        timeRemaining -= 2;
        continue;
    }

    if (matrix[currentRow,currentCol]=='*')
    {
        timeRemaining--;
        continue;
    }

    if (matrix[currentRow,currentCol]=='B')
    {
        if (command== "defuse" && matrix[currentRow,currentCol]=='B')
        {
            if (timeRemaining-4>=0)  //success
            {
                matrix[currentRow, currentCol] = 'D';
                timeRemaining -= 4;
                defused = true;
                break;
            }

            if (timeRemaining-4<0)   //fail
            {
                matrix[currentRow, currentCol] = 'X';
                timeRemaining -= 4;
                bombHasExploded = true;

                break;
            }
        }
        else
        {
            timeRemaining--;
            continue;
        }
    }

    if (matrix[currentRow,currentCol]=='T')
    {
        killed=true;
        matrix[currentRow, currentCol] = '*';
        break;
    }

}

if (!defused&&timeRemaining<=0)
{
    Console.WriteLine("Terrorists win!");
    Console.WriteLine("Bomb was not defused successfully!");
    Console.WriteLine($"Time needed: {Math.Abs(timeRemaining)} second/s.");
}

if (defused)
{
    Console.WriteLine("Counter-terrorist wins!");
    Console.WriteLine($" Bomb has been defused: {timeRemaining} second/s remaining.");
}

if (killed)
{
    matrix[startRow, startCol] = 'C';
    Console.WriteLine("Terrorists win!");
}
Print();






















void Print()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(matrix[i,j]);
        }

        Console.WriteLine();
    }
}
