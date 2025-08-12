// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];


int totalWoodBranches = 0;

int startRow = -1;
int startCol = -1;

int currentRow = -1;
int currentCol = -1;
for (int i = 0; i < n; i++)
{

    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = char.Parse(input[j]);

        if (char.Parse(input[j]) == 'B')
        {
            startRow = i;
            startCol = j;
            currentRow = i;
            currentCol = j;


        }

        if (char.IsLower(char.Parse(input[j])))
        {
            totalWoodBranches++;
        }
    }
}

Queue<char> woodBranches = new Queue<char>();
int counter = 0;
string command = "";
matrix[currentRow, currentCol] = '-';
while (((command = Console.ReadLine()) != "end") && totalWoodBranches - counter > 0)
{
    int previousRow = currentRow;
    int previousCol = currentCol;

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
    if (currentRow < 0 || currentRow >= n || currentCol < 0 || currentCol >= n)
    {

        currentRow = previousRow;
        currentCol = previousCol;    //stoi i ne murda
        if (woodBranches.Count > 0)
        {
            woodBranches.Dequeue();   // drops the las woodShit
        }
        continue;
    }
    if (char.IsLower(matrix[currentRow, currentCol]))
    {
        counter++;
        woodBranches.Enqueue(matrix[currentRow, currentCol]);
        matrix[currentRow, currentCol] = '-';
        continue;
    }
    if (matrix[currentRow, currentCol] == 'F')
    {
        matrix[currentRow, currentCol] = '-';
        switch (command)
        {
            case "up":
                if (currentRow == 0)
                {
                    currentRow = n - 1;
                }
                else if (currentRow == n - 1)
                {
                    currentRow = 0;
                }
                break;


            case "down":
                if (currentRow == 0)
                {
                    currentRow = n - 1;
                }
                else if (currentRow == n - 1)
                {
                    currentRow = 0;
                }
                break;


            case "left":
                if (currentCol == 0)
                {
                    currentCol = n - 1;
                }
                else if (currentCol == n - 1)
                {
                    currentCol = 0;
                }
                break;


            case "right":
                if (currentCol == 0)
                {

                }
                else if (currentCol == n - 1)
                {

                }
                break;
        }

        if (char.IsLower(matrix[currentRow, currentCol]))
        {
            counter++;
            woodBranches.Enqueue(matrix[currentRow, currentCol]);
        }

        matrix[currentRow, currentCol] = '-';
    }



}

matrix[currentRow, currentCol] = 'B';







if (totalWoodBranches - counter == 0)
{
    Console.WriteLine($"The Beaver successfully collect {woodBranches.Count} wood branches: {string.Join(", ", woodBranches)}.");
}
else
{
    Console.WriteLine($"The Beaver failed to collect every wood branch. There are {totalWoodBranches - counter} branches left.");
}
Print();















void Print()
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            // Проверка дали текущият индекс е последният в реда
            if (j == n - 1)
            {
                Console.Write(matrix[i, j]); // Печатаме последния без интервал
            }
            else
            {
                Console.Write(matrix[i, j] + " "); // Печатаме с интервал
            }
        }
        Console.WriteLine(); // Печатаме нов ред след всеки ред от матрицата
    }
}