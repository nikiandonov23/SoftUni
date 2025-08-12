// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];

int enemyCount = 0;

int armor = 300;


int currentRow = 0;
int currentCol = 0;

int startRow = 0;
int startCol = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    string input = Console.ReadLine();


    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        matrix[i, j] = input[j];

        if (matrix[i, j] == 'J')
        {
            currentRow = i; currentCol = j;
            startRow = i; startCol = j;
        }

        if (matrix[i, j] == 'E')
        {
            enemyCount++;
        }
    }

}

while (enemyCount > 0 && armor > 0)   // The program will end when аll enemy planes are shot down or the jetfighter’s armor becomes 0
{
    matrix[startRow, startCol] = '-';


    string command = Console.ReadLine();
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

    if (matrix[currentRow, currentCol] == '-')
    {
        continue;
    }
    else if (matrix[currentRow, currentCol] == 'E')
    {
        enemyCount--;
        matrix[currentRow, currentCol] = '-';

        if (enemyCount>0)
        {
            armor -= 100;
            if (armor<=0)
            {
                Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{currentRow}, {currentCol}]!");
                matrix[currentRow, currentCol] = 'J';

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix[i,j]);
                    }

                    Console.WriteLine();
                }
                break;
            }
        }
        else
        {
            Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
            matrix[currentRow, currentCol] = 'J';

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
            break;
        }
    }
    else if (matrix[currentRow, currentCol] == 'R')
    {
        armor = 300;
        matrix[currentRow, currentCol] = '-';
       

    }
}