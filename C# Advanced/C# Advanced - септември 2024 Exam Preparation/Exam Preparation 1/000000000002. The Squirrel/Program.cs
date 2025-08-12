// See https://aka.ms/new-console-template for more information


using System.Text;

int n = int.Parse(Console.ReadLine());
List<string>tockens=Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToList();

Queue<string>commands=new Queue<string>();
foreach (var element in tockens)
{
    commands.Enqueue(element);
}



int startRow = -1;
int startCol = -1;

int currentRow = -1;
int currentCol = -1;

char[,] matrix = new char[n, n];
for (int i = 0; i < n; i++)
{

    string data = Console.ReadLine();
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = data[j];
        if (data[j] == 's')
        {
            startRow = i;
            startCol = j;
            currentRow = i;
            currentCol = j;
        }
    }
}



int hazelNuts = 0;
bool trap = false;
bool movesOutTheBounderies = false;

while (hazelNuts < 3 && !trap && !movesOutTheBounderies && commands.Count > 0)
{
    string currentCommand = commands.Dequeue();

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

    if (currentRow < 0 || currentRow >= n || currentCol < 0 || currentCol >= n)
    {
        movesOutTheBounderies = true;
        Console.WriteLine("The squirrel is out of the field.");
        break;
    }

    if (matrix[currentRow, currentCol] == 't')
    {
        trap = true;
        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
        break;
    }

    if (matrix[currentRow, currentCol] == 'h')
    {
        hazelNuts++;
        matrix[currentRow, currentCol] = '*';
        if (hazelNuts >= 3)
        {
            matrix[currentRow, currentCol] = 's';
            break;
        }
    }

    if (matrix[currentRow, currentCol] == '*')
    {
        continue;
    }
}

if (hazelNuts < 3 && !movesOutTheBounderies && !trap)
{
    Console.WriteLine("There are more hazelnuts to collect.");
}
else if (hazelNuts >= 3 && !movesOutTheBounderies && !trap)
{
    Console.WriteLine("Good job! You have collected all hazelnuts!");
}


Console.WriteLine($"Hazelnuts collected: {hazelNuts}");


