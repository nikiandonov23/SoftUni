// See https://aka.ms/new-console-template for more information

int n =int.Parse(Console.ReadLine());

int[,] matrix = readSquareMatrix(n);
int[,] bombCoordinates = readBombCoordinates();

for (int i = 0; i < bombCoordinates.GetLength(0); i++)
{
    int bombRow=bombCoordinates[i,0];
    int bombCol=bombCoordinates[i,1];


    explodeBomb(matrix, bombRow, bombCol);    //vikam metoda eto ti matricata eto ti current row current col na bombata
    

}

int aliveCellsCount = 0;
int aliveCellsSum = 0;

Print(matrix, aliveCellsCount, aliveCellsSum);



static void Print(int[,] matrix,int aliveCellsCount,int aliveCellsSum)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > 0)
            {
                aliveCellsCount++;
                aliveCellsSum += matrix[i, j];
            }
        }
    }
    Console.WriteLine($"Alive cells: {aliveCellsCount}");
    Console.WriteLine($"Sum: {aliveCellsSum}");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j > 0)
            {
                Console.Write(' ');
            }
            Console.Write(matrix[i, j]);
        }

        Console.WriteLine();
    }
}

static void explodeBomb(int[,]matrix , int row,int col)
{
    if (matrix[row, col] <= 0) 
    {
        return; // AKO IMAME MURTVA KLETKA NA BOMBATA NE  MOJE DA GRUMNE
    }

    int bombPower = matrix[row, col];

    int rowIterStart = Math.Max(row - 1,0);  //vmesto if proverka .Ako row<0 zapochva ot 0
    int rowIterEnd = Math.Min(row + 1,matrix.GetLength(0)-1);  //vmesto if proverka. Ako col>=matrix.Lenght

    int colIterStart = Math.Max(col - 1, 0);  
    int colIterEnd = Math.Min(col + 1, matrix.GetLength(1)-1);

    for (int i = rowIterStart; i <= rowIterEnd; i++)
    {

        for (int j = colIterStart; j <= colIterEnd; j++)
        {
            if (matrix[i,j]>0)
            {
                matrix[i, j] -= bombPower;
                
            }
           
        }
    }

    matrix[row, col] = 0;
}

int[,] readBombCoordinates()
{
    string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    int[,] bombCoordinates = new int[data.Length, 2];
    for (int i = 0; i < bombCoordinates.GetLength(0); i++)
    {
        int[] coordinates = data[i].Split(",").Select(int.Parse).ToArray();

        for (int j = 0; j < bombCoordinates.GetLength(1); j++)
        {
            bombCoordinates[i,j]=coordinates[j];

        }
    }

    return bombCoordinates;
}

int[,] readSquareMatrix(int n)
{
    int[,] matrix = new int[n, n];

    for (int i = 0; i < n; i++)
    {
        int[] data=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = data[j];

        }
    }
    return matrix;
}

