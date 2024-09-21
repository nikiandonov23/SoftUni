int n = int.Parse(Console.ReadLine()); // n ROWS

int[][] jaggedArray = new int[n][];

for (int i = 0; i < jaggedArray.Length; i++)
{

    jaggedArray[i] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
}

string command = "";
while ((command = Console.ReadLine()) != "END")
{
    string[] tockens = command.Split(" ");
    string action= tockens[0];
    int row=int.Parse(tockens[1]);
    int col=int.Parse(tockens[2]);
    int value=int.Parse(tockens[3]);

    if (row < 0 || row >= jaggedArray.Length || col < 0 || col >= jaggedArray[row].Length)
    {
        Console.WriteLine("Invalid coordinates");
        continue;
    }

    switch (action)
    {
        case "Add":
            jaggedArray[row][col] += value;
            break;

        case "Subtract":
            jaggedArray[row][col]-=value;
            break;
    }
}

for (int i = 0; i < jaggedArray.Length; i++)
{

    Console.WriteLine(string.Join(" ", jaggedArray[i]));
}

