// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information
int[] dimentions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int row = dimentions[0];
int col = dimentions[1];

char[][] jaggedArray = new char[row][];

for (int i = 0; i < row; i++)
{
    jaggedArray[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

}

int matchcounter = 0;
for (int i = 0; i < row - 1; i++)
{

    for (int j = 0; j < col - 1; j++)
    {
        if (jaggedArray[i][j] == jaggedArray[i][j + 1] && jaggedArray[i][j] == jaggedArray[i + 1][j] && jaggedArray[i][j] == jaggedArray[i + 1][j + 1])
        {
            matchcounter++;
        }
    }
}

Console.WriteLine(matchcounter);
