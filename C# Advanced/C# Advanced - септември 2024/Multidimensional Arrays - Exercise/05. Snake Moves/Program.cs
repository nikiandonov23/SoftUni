// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

int[] dimentions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
string input=Console.ReadLine();

int row = dimentions[0];
int col = dimentions[1];
int currentIndex = 0;

char[] snake = input.ToCharArray(0, input.Length);
char[,] matrix = new char[row, col];

for (int i = 0; i < row; i++)
{

    if (i % 2 == 0) 
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = snake[currentIndex];
            currentIndex = (currentIndex + 1) % snake.Length;
        }
    }
    else  
    {
        for (int j = col - 1; j >= 0; j--)
        {

            matrix[i,j]=snake[currentIndex];
            currentIndex=(currentIndex+1)%snake.Length;
        }
    }

    
}

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        Console.Write(matrix[i,j]);
    }
    Console.WriteLine();
}
