// See https://aka.ms/new-console-template for more information

using System.Numerics;

int n = int.Parse(Console.ReadLine());
char[,] matrix = readMatrix(n);

int[][] directions = new int[][]                //vuzmojnite posoki na dvijenie na konq
{
    new int[] {-2,1},
    new int[] {-1,2},
    new int[] {1,2},
    new int[] {2,1},
    new int[] {2,-1},
    new int[] {1,-2},
    new int[] {-1,-2},
    new int[] {-2,-1}


};




int removedKnights = 0;
bool hasConflicts = true;
while (hasConflicts)
{
    int maxConflicts = 0;
    int maxConflictsRow = 1;
    int maxConflictsCol = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matrix[i, j] == 'K')        //otkrivame vsi4ki kone na duskata
            {
                int currentConflixts = conflictCounter(matrix, i, j);
                if (currentConflixts > maxConflicts)
                {
                    maxConflicts = currentConflixts;     //ako otkrie kon s pove4e konflikti prezapisva broikata na nai konfliktniq kon
                    maxConflictsRow = i;                //koordinati na noviq nai konflikten kon
                    maxConflictsCol = j;                 //koordinati na noviq nai konflikten kon
                }
            }
        }
    }

    if (maxConflicts == 0)
    {
        hasConflicts = false;
    }
    else
    {
        matrix[maxConflictsRow, maxConflictsCol] = '0';
        removedKnights++;
    }
}

Console.WriteLine(removedKnights);



int conflictCounter(char[,] matrix, int row, int col)
{
    int counter = 0;
    foreach (var direction in directions)     //za vsqka edna posoka na dvijenieto iskam da mi iz4islish nextRow i nextCol
    {
        int nextRow = row + direction[0];     //{-2,1} -2  taka izpolzvaiki vazmojnite indexi za dvijenie na konq ot directions pridvijvame konq na sledvashta poziciq
        if (nextRow < 0 || nextRow >= matrix.GetLength(0))
        {
            continue;
        }
        int nextCol = col + direction[1];     //{-2,1} 1 taka izpolzvaiki vazmojnite indexi za dvijenie na konq ot directions pridvijvame konq na sledvashta poziciq
        if (nextCol < 0 || nextCol >= matrix.GetLength(1))
        {
            continue;
        }

        if (matrix[nextRow, nextCol] == 'K')
        {
            counter++;
        }
    }

    return counter;
}




char[,] readMatrix(int n)
{
    char[,] matrix = new char[n, n];

    for (int i = 0; i < n; i++)
    {
        string input = Console.ReadLine();

        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = input[j];
        }
    }
    return matrix;
}



