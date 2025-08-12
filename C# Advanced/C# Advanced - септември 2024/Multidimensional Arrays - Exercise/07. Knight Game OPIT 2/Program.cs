
using System.Numerics;

int n = int.Parse(Console.ReadLine());
char[,] matrix = new char[n,n];
matrix = readMethod(n);

int[][] allMovements = new[]   //vsi4ki vuzmojni dvijeniq na konq po duskata
{
    new int[] { 2, 1 },
    new int[] { 2, -1 },
    new int[] { -2, 1 },
    new int[] { -2, -1 },
    new int[] { 1, 2 },
    new int[] { 1, -2 },
    new int[] { -1, 2 },
    new int[] { -1, -2 }

};


int removedKnights = 0;

bool hasConflicts = true;
while (hasConflicts)
{
    int maxConflicts = 0;
    int maxConflictRow = 0;
    int maxConflictCol = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matrix[i,j]=='K')
            {
                int currentConflicts = mostConflictKnight(matrix, i, j);
                if (maxConflicts<currentConflicts)
                {
                    maxConflicts=currentConflicts;
                    maxConflictRow=i;
                    maxConflictCol = j;
                   
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
        matrix[maxConflictRow, maxConflictCol] = '0';
        removedKnights++;
    }
}

Console.WriteLine(removedKnights);









int mostConflictKnight(char[,]matrix ,int row,int col)
{
    int conflictCount = 0;
    foreach (var move in allMovements)
    {
        int nextRow = row + move[0];
        if (nextRow<0||nextRow>=matrix.GetLength(0))
        {
            continue;
        }

        int nextCol = col + move[1];
        if (nextCol<0||nextCol>=matrix.GetLength(1))
        {
            continue;
        }

        if (matrix[nextRow,nextCol]=='K')
        {
            conflictCount++;
        }
    }

    return conflictCount;

}
char[,] readMethod(int n)
{
    char[,] matrix2 = new char[n,n];
    for (int i = 0; i < n; i++)
    {
        string input=Console.ReadLine();

        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = input[j];
        }
    }

    return matrix;
}


