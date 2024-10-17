// See https://aka.ms/new-console-template for more information


int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];


int startRow = -1;
int startCol = -1;

int currentRow = -1;
int currentCol = -1;
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();

    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = input[j];
        if (input[j] == 'S')
        {
            startRow = i; startCol=j; currentRow = i; currentCol = j;
        }
    }
}


matrix[startRow, startCol] = '-';
int directHits = 3;
int battleCruisers = 3;
while (directHits>0&&battleCruisers>0)
{
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

    if (matrix[currentRow,currentCol]=='*')
    {
        directHits--;
        if (directHits==0)
        {
            matrix[currentRow, currentCol] = 'S';
            Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{currentRow}, {currentCol}]!");
            break;
        }
        else
        {
            matrix[currentRow, currentCol] = '-';
        }
        
        continue;
    }

    if (matrix[currentRow,currentCol]=='C')
    {
        battleCruisers--;
        if (battleCruisers == 0)
        {
            matrix[currentRow, currentCol] = 'S';
            Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
            break;
        }
        else
        {
            matrix[currentRow, currentCol] = '-';
        }
        
    }
}

Print(matrix);





















void Print(char[,] matrix)
{
    for (int i = 0; i < n; i++)
    {

        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j]);
        }

        Console.WriteLine();
    }
}
