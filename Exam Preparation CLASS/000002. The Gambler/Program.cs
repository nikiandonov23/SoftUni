// See https://aka.ms/new-console-template for more information

using System.Numerics;
int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];

int currentRow = -1;
int currentCol = -1;

int startRow = 0;
int startCol = 0;

bool jackPotWin = false;
bool leaveMatrix = false;
bool youLostEverything = false;
int money = 100;
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = input[j];
        if (matrix[i, j] == 'G')
        {
            startRow = i;
            startCol = j;
            currentRow = i; currentCol = j;
        }
    }
}

matrix[startRow, startCol] = '-';
string command = "";
while ((command = Console.ReadLine()) != "end")
{

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

    if ((currentRow < 0 || currentRow >= n || currentCol < 0 || currentCol >= n))
    {
        leaveMatrix = true;
        money = 0;
        break;
    }

    if (matrix[currentRow, currentCol] == 'W')
    {
        money += 100;
        matrix[currentRow, currentCol] = '-';
    }
    if (matrix[currentRow, currentCol] == 'P')
    {
        matrix[currentRow, currentCol] = '-';
        money -= 200;
        if (money <= 0)
        {
            youLostEverything=true;
            
            money = 0;
            break;
        }
    }
    if (matrix[currentRow, currentCol] == 'J')
    {
        jackPotWin = true;
        money += 100000;
        break;
    }



}

matrix[currentRow, currentCol] = 'G';

if (jackPotWin)
{
    Console.WriteLine("You win the Jackpot!");
    Console.WriteLine($"End of the game. Total amount: {money}$");
}

else if (!jackPotWin)
{
    if (youLostEverything)
    {
        Console.WriteLine("Game over! You lost everything!");
    }
    else
    {
        Console.WriteLine($"End of the game. Total amount: {money}$");
    }
    
}

if (leaveMatrix)
{
    Console.WriteLine("Game over! You lost everything!");
}



if (money > 0)
{
    Print(matrix);
}



















void Print(char[,] matrix)
{

    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(matrix[i, j]);
        }

        Console.WriteLine();
    }

}