// See https://aka.ms/new-console-template for more information


int n = int.Parse(Console.ReadLine());
Queue<string> commands = new Queue<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));

char[,] matrix = new char[n, n];
int currentRow = -1;
int currentCol = -1;


int startCoal = 0;
int totalCoal = 0;
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = char.Parse(input[j]);
        if (char.Parse(input[j]) == 's')
        {
            currentRow = i;
            currentCol = j;
        }
        if (char.Parse(input[j]) == 'c')
        {
            totalCoal++;
            startCoal++;
        }
    }
}


bool allCoalCollected = false;
bool endOfTheRoute = false;
while (commands.Count > 0&&totalCoal>0)
{
    int previousRow = currentRow;
    int previousCol = currentCol;
    string currentCommand= commands.Dequeue();
    switch (currentCommand)
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

    if (currentRow<0||currentRow>=n||currentCol<0||currentCol>=n)
    {
        currentRow = previousRow;
        currentCol = previousCol;
        continue;
    }

    if (matrix[currentRow,currentCol]=='c')
    {
        matrix[currentRow, currentCol] = '*';
        totalCoal--;
        if (totalCoal==0)
        {
            Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
            allCoalCollected = true;
            break;
        }
    }

    if (matrix[currentRow, currentCol] == 'e')
    {
        endOfTheRoute = true;
        Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
        break;
    }


}

Console.WriteLine();
if (commands.Count==0&&!endOfTheRoute&&!allCoalCollected)
{
    Console.WriteLine($"{totalCoal} coals left. ({currentRow}, {currentCol})");
}







void Print()
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }

        Console.WriteLine();
    }
}
