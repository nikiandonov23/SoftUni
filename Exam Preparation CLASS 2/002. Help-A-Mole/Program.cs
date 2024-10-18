// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];



int startRow = -1;
int startCol = -1;

int currentRow = -1;
int currentCol = -1;

bool location1Found = false;

int specialRow1 = 0;
int specialCol1 = 0;

int specialRow2 = 0;
int specialCol2 = 0;

for (int i = 0; i < n; i++)
{

    string input = Console.ReadLine();
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = input[j];
        if (input[j] == 'M')
        {
            startRow = i;
            startCol = j;
            currentRow = i;
            currentCol = j;
        }

        else if (input[j] == 'S')
        {
            if (!location1Found)
            {
                location1Found = true;
                specialRow1 = i;
                specialCol1 = j;
            }
            else if (location1Found)
            {
                specialRow2 = i;
                specialCol2 = j;
            }
        }

    }
}






int totslPoints = 0;
matrix[startRow, startCol] = '-';

string command = "";
while (((command = Console.ReadLine()) != "End") && totslPoints < 25)
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

    if (currentRow < 0 || currentRow >= n || currentCol < 0 || currentCol >= n)
    {
        currentRow = previousRow;
        currentCol = previousCol;
        Console.WriteLine("Don't try to escape the playing field!");
        continue;
    }

    if (char.IsDigit(matrix[currentRow, currentCol]))   //AKO E DIGIT
    {
        totslPoints += matrix[currentRow, currentCol] - '0';
        matrix[currentRow, currentCol] = '-';

    }
    else if (matrix[currentRow, currentCol] == 'S')
    {
        totslPoints -= 3;
        if (currentRow == specialRow1 && currentCol == specialCol1)   //zna4i se namira na purviq S
        {
            matrix[currentRow, currentCol] = '-';   //stariq S stava -

            currentRow = specialRow2;       // otiva na NOVIQ S
            currentCol = specialCol2;       // otiva na NOVIQ S

            matrix[currentRow, currentCol] = 'M';

        }
        else   //zna4i se namira na vtoriq S
        {
            matrix[currentRow, currentCol] = '-'; //vtoriq S stava na -

            currentRow = specialRow1;
            currentCol = specialCol1;
            matrix[currentRow, currentCol] = 'M';
               
        }
    }    //AKO E S

    matrix[currentRow, currentCol] = '-';
}


matrix[currentRow, currentCol] = 'M';

if (totslPoints >= 25)
{
    Console.WriteLine("Yay! The Mole survived another game!");
    Console.WriteLine($"The Mole managed to survive with a total of {totslPoints} points.");
}

else if (totslPoints < 25)
{
    Console.WriteLine("Too bad! The Mole lost this battle!");
    Console.WriteLine($"The Mole lost the game with a total of {totslPoints} points.");
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