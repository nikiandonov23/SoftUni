int n=int.Parse(Console.ReadLine());

char[,] matrix=new char[n,n];
int startRow = 0;
int startCol = 0;

int currentRow = 0;
int currentCol = 0;
for (int i = 0; i < n; i++)
{

    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    for (int j = 0; j < n; j++)
    {
        if (char.Parse(input[j])=='P')
        {
            startRow = i; startCol= j; 
            currentRow=i; currentCol=j;
        }
        matrix[i, j] = (char.Parse(input[j]));
        
    }
}

int previousRow=currentRow;
int previousCol = currentCol;

int totalStars=2;
while (totalStars < 10 && totalStars > 0)
{
  

    string command=Console.ReadLine();
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
        currentRow = 0; currentCol=0;
    }

    if (matrix[currentRow,currentCol]=='*')
    {
        totalStars++;
        matrix[currentRow, currentCol] = '.';   //slagame to4ka ako ve4e e vzel zvezdata
      
        
    }

    else if (matrix[currentRow,currentCol]=='#')
    {
        currentRow = previousRow;
        currentCol = previousCol;
        totalStars--;
        
    }




    previousRow = currentRow;
    previousCol = currentCol;
}



matrix[startRow, startCol] = '.';
matrix[currentRow, currentCol] = 'P';


if (totalStars>=10)  //won
{
    Console.WriteLine($"You won! You have collected 10 stars.");
}
else
{
    Console.WriteLine("Game over! You are out of any stars.");
}

Console.WriteLine($"Your final position is [{currentRow}, {currentCol}]");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }

    Console.WriteLine();
}