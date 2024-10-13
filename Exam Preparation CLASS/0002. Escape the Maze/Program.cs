using System;

namespace EscapeTheMaze
{
    public class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int health = 100;

            string[,] maze = new string[size, size];

            int playerRow = -1;
            int playerCol = -1;

            for (int i = 0; i < maze.GetLength(0); i++)
            {
                string row = Console.ReadLine();
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    if (row[j].ToString() == "P")
                    {
                        playerRow = i;
                        playerCol = j;

                        maze[i, j] = "-"; // Маркираме началната позиция като празна
                    }
                    else
                    {
                        maze[i, j] = row[j].ToString();
                    }
                }
            }

            while (true)
            {
                string direction = Console.ReadLine();

                // Предварително изчисляваме следващата позиция
                int nextRow = playerRow;
                int nextCol = playerCol;

                switch (direction)
                {
                    case "up":
                        nextRow--;
                        break;
                    case "down":
                        nextRow++;
                        break;
                    case "right":
                        nextCol++;
                        break;
                    case "left":
                        nextCol--;
                        break;
                }

                // Проверяваме дали следващата позиция е в границите на матрицата
                if (nextRow < 0 || nextRow >= maze.GetLength(0) || nextCol < 0 || nextCol >= maze.GetLength(1))
                {
                    continue; // Пропускаме командата, ако е извън границите
                }

                // Актуализираме позицията на играча
                playerRow = nextRow;
                playerCol = nextCol;

                string position = maze[playerRow, playerCol];

                if (position == "M")
                {
                    health -= 40;
                    if (health <= 0)
                    {
                        health = 0;
                        Console.WriteLine("Player is dead. Maze over!");
                        break;
                    }
                    maze[playerRow, playerCol] = "-"; // Маркираме монстъра като убит
                }
                else if (position == "H")
                {
                    health += 15;
                    if (health > 100)
                    {
                        health = 100; // Не позволява здравето да надвишава 100
                    }
                    maze[playerRow, playerCol] = "-"; // Маркираме аптечката като взета
                }
                else if (position == "X")
                {
                    Console.WriteLine("Player escaped the maze. Danger passed!");
                    break;
                }
            }

            maze[playerRow, playerCol] = "P"; // Поставяме играча на последната му позиция

            Console.WriteLine($"Player's health: {health} units");

            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    Console.Write(maze[i, j].ToString());
                }
                Console.WriteLine();
            }
        }
    }
}