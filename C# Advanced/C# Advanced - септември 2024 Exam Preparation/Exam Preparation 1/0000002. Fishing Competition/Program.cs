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
            startRow = i;
            startCol = j;
            currentRow = i;
            currentCol = j;
        }
    }
}

bool fallIntoAWhirpool = false;
int totalFish = 0;
string command = "";
matrix[startRow, startCol] = '-';
while ((command = Console.ReadLine()) != "collect the nets")
{

    switch (command)
    {
        case "up":
            currentRow--;
            if (currentRow < 0)
            {
                currentRow = n - 1;
            }
            break;


        case "down":
            currentRow++;
            if (currentRow >= n)
            {
                currentRow = 0;
            }
            break;


        case "left":
            currentCol--;
            if (currentCol < 0)
            {
                currentCol = n - 1;
            }
            break;


        case "right":
            currentCol++;
            if (currentCol >= n)
            {
                currentCol = 0;
            }
            break;
    }


    if (char.IsDigit(matrix[currentRow, currentCol]))
    {
        totalFish += matrix[currentRow, currentCol] - '0'; //•	If you move to a fish passage, you collect the amount equal to the digit there, the passage disappears and should be replaced by '-'.
        matrix[currentRow, currentCol] = '-';
    }
    else if (matrix[currentRow, currentCol] == 'W')

    {
        totalFish = 0;    //program should end
        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{currentRow},{currentCol}]");
        return;
    }



}

if (!fallIntoAWhirpool)   //ako ne e padal v peralnqta
{
    if (totalFish >= 20)
    {
        Console.WriteLine("Success! You managed to reach the quota!");
    }
    else
    {
        Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - totalFish} tons of fish more.");

    }
}

if (totalFish > 0)
{
    Console.WriteLine($"Amount of fish caught: {totalFish} tons.");
}

if (!fallIntoAWhirpool)
{
    matrix[currentRow, currentCol] = 'S';
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j]);
        }

        Console.WriteLine();
    }
}



