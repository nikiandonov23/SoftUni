// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n,n];

int startRow = -1;
int startCol = -1;

int currentRow = -1;
int currentCol = -1;


for (int i = 0; i < n; i++)
{
    string input=Console.ReadLine();
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = input[j];
        if (input[j]=='V')
        {
            startRow = i;
            startCol=j;

            currentRow = i;
            currentCol = j;
        }
    }
}



int holesCount = 1;
int rodsCount = 0;
bool electrocuted = false;

matrix[startRow, startCol] = '*';
string command = "";
while ((command = Console.ReadLine()) != "End")
{
    int previousRow=currentRow;
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

    if (currentRow<0||currentRow>=n||currentCol<0||currentCol>=n)
    {
        currentRow = previousRow;
        currentCol=previousCol;
        
    }

    else if (matrix[currentRow,currentCol]=='R')  //Vanko did not make a hole beee
    {
        rodsCount++;
        Console.WriteLine("Vanko hit a rod!");
        currentRow = previousRow;
        currentCol = previousCol;
    }

    else if (matrix[currentRow,currentCol]=='C')
    {
        electrocuted = true;
        matrix[currentRow, currentCol] = 'E'; //     'E' letter is considered a successfully created hole.
        holesCount++;
        break;
    }

    else if (matrix[currentRow,currentCol]=='*')
    {
        Console.WriteLine($"The wall is already destroyed at position [{currentRow}, {currentCol}]!");
    }
    else
    {
        matrix[currentRow, currentCol] = '*';
        holesCount++;
    }
    
}

if (!electrocuted)
{
    matrix[currentRow, currentCol] = 'V';
}





if (!electrocuted)
{
    Console.WriteLine($"Vanko managed to make {holesCount} hole(s) and he hit only {rodsCount} rod(s).");
}

if (electrocuted)
{
    Console.WriteLine($"Vanko got electrocuted, but he managed to make {holesCount} hole(s).");
}


Print(matrix);




void Print(char[,] matrix)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i,j]);
        }

        Console.WriteLine();
    }
}