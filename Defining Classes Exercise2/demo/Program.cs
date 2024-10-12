using System;

int n = int.Parse(Console.ReadLine());

int beeRow = 0;
int beeCol = 0;

int totalEnergy = 15;
int totalHoneyCollected = 0;
bool alreadyRestored = false;

char[,] matrix = new char[n, n];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string input = Console.ReadLine();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = input[col];
        if (matrix[row, col] == 'B')
        {
            beeRow = row;
            beeCol = col;
        }
    }
}

string command = "";
while (true)
{
    command = Console.ReadLine();

    // Преместваме пчелата на нова позиция
    matrix[beeRow, beeCol] = '-';

    switch (command)
    {
        case "up":
            beeRow--;
            if (beeRow < 0) beeRow = n - 1;
            break;
        case "down":
            beeRow++;
            if (beeRow >= n) beeRow = 0;
            break;
        case "left":
            beeCol--;
            if (beeCol < 0) beeCol = n - 1;
            break;
        case "right":
            beeCol++;
            if (beeCol >= n) beeCol = 0;
            break;
    }

    // Намаляване на енергията с всяко движение
    totalEnergy--;

    // Проверка за достигане на кошера
    if (matrix[beeRow, beeCol] == 'H')
    {
        break;
    }

    // Проверка за изчерпване на енергията
    if (totalEnergy <= 0)
    {
        if (totalHoneyCollected >= 30 && !alreadyRestored)
        {
            // Възстановяване на енергията само веднъж
            int energyToRestore = totalHoneyCollected - 30;
            totalEnergy += energyToRestore;
            totalHoneyCollected = 30;
            alreadyRestored = true;
        }
        else
        {
            // Ако вече е възстановено веднъж или нямаме достатъчно мед
            matrix[beeRow, beeCol] = 'B';
            Console.WriteLine("This is the end! Beesy ran out of energy.");
            break;
        }
    }

    // Проверка дали пчелата стъпва на цвете (цифра)
    if (char.IsDigit(matrix[beeRow, beeCol]))
    {
        totalHoneyCollected += matrix[beeRow, beeCol] - '0';
        matrix[beeRow, beeCol] = '-';
    }
}

// Извеждане на резултата в зависимост от това дали пчелата е стигнала кошера
if (matrix[beeRow, beeCol] == 'H')
{
    if (totalHoneyCollected >= 30)
    {
        Console.WriteLine($"Great job, Beesy! The hive is full. Energy left: {totalEnergy}");
    }
    else
    {
        Console.WriteLine("Beesy did not manage to collect enough nectar.");
    }
}


matrix[beeRow, beeCol] = 'B';
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}