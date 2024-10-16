// See https://aka.ms/new-console-template for more information


int[] dimentions = (Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
int rows = dimentions[0];
int cols = dimentions[1];
char[,] matrix = new char[rows, cols];

int startRow = -1;
int startCol = -1;


int nextRow = -1;
int nextCol = -1;
for (int i = 0; i < rows; i++)
{

    string input = Console.ReadLine();
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = input[j];
        if (input[j] == 'B')
        {
            nextRow = i; nextCol = j;
            startRow = i; startCol = j;
        }
    }
}


bool haveBeenOutOfTHeField = false;

int previousRow = nextRow;
int previousCol = nextCol;
string command = "";
while (true)
{
    command = Console.ReadLine();
    switch (command)
    {
        case "up":
            previousRow=nextRow; 
            nextRow--;
           
            break;


        case "down":
            previousRow=nextRow;
            nextRow++;
            break;


        case "left":
            previousCol = nextCol;
            nextCol--;
            break;


        case "right":
            previousCol=nextCol;
            nextCol++;
            break;

    }
    if (nextRow < 0 || nextRow >= rows || nextCol < 0 || nextCol >= cols)
    {
        haveBeenOutOfTHeField = true;
        Console.WriteLine("The delivery is late. Order is canceled.");
        break;
    }


    if (matrix[nextRow, nextCol] == '*') //and he cannot make a move in that direction. He must remain in his current position 
    {
        switch (command)
        {
            case "up":
                nextRow++;
                break;

            case "down":
                nextRow--;
                break;

            case "left":
                nextCol++;
                break;

            case "right":
                nextCol--;
                break;
        }

        continue;
    }

    if (matrix[nextRow,nextCol]=='P')
    {
        matrix[nextRow, nextCol] = 'R';  //kato kolektne pizata P stava R
        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
    }

    if (matrix[nextRow,nextCol]=='-')
    {
        matrix[nextRow, nextCol] = '.';
    }

    if (matrix[nextRow,nextCol]=='A')
    {
        matrix[nextRow, nextCol] = 'P';
        Console.WriteLine("Pizza is delivered on time! Next order...");
        break;
    }

}

if (haveBeenOutOfTHeField)
{
    matrix[startRow, startCol] = ' ';
}
Print(matrix);



void Print(char[,] matrix)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(matrix[i, j]);
        }

        Console.WriteLine();
    }
}