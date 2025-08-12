// See https://aka.ms/new-console-template for more information


using System.Numerics;

int[] dimentions=Console.ReadLine().Split(",",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = dimentions[0];
int cols=dimentions[1];

char[,] matrix = new char[rows, cols];

int totalCheese = 0;

int startRow = -1;
int startCol = -1;

int currentRow = -1;
int currentCol = -1;
for (int i = 0; i < rows; i++)
{
    string input=Console.ReadLine();
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = input[j];
        if (input[j]=='M')
        {
            currentRow=i; 
            currentCol=j;

            startRow = i;
            startCol = j;
        }

        if (input[j]=='C')
        {
            totalCheese++;
        }
    }
}


bool trap = false;
bool outsideBounderies = false;

string command = "";
while ((command = Console.ReadLine()) != "danger")
{
    matrix[startRow, startCol] = '*';
    int previousRow=currentRow;
    int previousCol=currentCol;
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
        outsideBounderies = true;
        currentRow = previousRow;
        currentCol = previousCol;
        matrix[currentRow, currentCol] = 'M';
        Console.WriteLine("No more cheese for tonight!");
        break;
    }

    if (matrix[currentRow,currentCol]=='C')
    {
        totalCheese -= 1;
        matrix[currentRow, currentCol] = '*';
        if (totalCheese==0)
        {
            matrix[currentRow, currentCol] = 'M';
            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
            break;
        }
    }

    if (matrix[currentRow, currentCol] == 'T')
    {
        trap=true;
        matrix[currentRow, currentCol] = 'M';
        Console.WriteLine("Mouse is trapped!");
        break;
    }

    if (matrix[currentRow, currentCol] == '@')
    {
        currentRow = previousRow;
        currentCol = previousCol;
        continue;
    }

}



if (totalCheese>0&&trap==false&& outsideBounderies==false)
{
    matrix[currentRow, currentCol] = 'M';
    Console.WriteLine("Mouse will come back later!");
}
Print(matrix);























void Print(char[,] matrix)
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
