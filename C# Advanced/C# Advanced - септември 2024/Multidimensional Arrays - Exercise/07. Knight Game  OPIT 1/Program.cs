// See https://aka.ms/new-console-template for more information

using System.Data;

int n = int.Parse(Console.ReadLine());
char[,] matrix = ReadingMatrixMethod(n);

int[][] directions = new int[][]
{
   new int[] {1,2},
   new int[] {1,-2},
   new int[] {2,1},
   new int[] {2,-1},
   new int[] {-1,2},
   new int[] {-1,-2},
   new int[] {-2,1},
   new int[] {-2,-1}


};

int removedKnights = 0;
bool HasConflicts = true;
while (HasConflicts)
{
    int maxConflicts = 0;
    int maxConflictKnightRow = 0;
    int maxConflictKnightCol = 0;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matrix[i, j] == 'K')    //do tuka raboti
            {
                int currentConflicts = conflictsCounter(matrix, i, j);
                if (currentConflicts > maxConflicts)
                {
                    maxConflicts = currentConflicts;
                    maxConflictKnightRow = i;
                    maxConflictKnightCol = j;
                }
            }
        }
    }

    if (maxConflicts == 0) 
    {
        HasConflicts=false;
    }
    else
    {
        matrix[maxConflictKnightRow, maxConflictKnightCol] = '0';
        removedKnights++;
    }

}

Console.WriteLine(removedKnights);


int conflictsCounter(char[,] matrix ,int row,int col)
{
    int conflictCounter = 0;
    foreach (var direction in directions)
    {
        int nextRow = row + direction[0];
        if (nextRow < 0 || nextRow >= matrix.GetLength(0))
        {
            continue;
        }

        int nextCol = col + direction[1];
        if (nextCol < 0 || nextCol >= matrix.GetLength(1))
        {
            continue;
        }

        if (matrix[nextRow,nextCol]=='K')
        {
            conflictCounter++;
        }
    }
    return conflictCounter;
}

char[,] ReadingMatrixMethod(int n)
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
}    //raboti

