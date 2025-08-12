// See https://aka.ms/new-console-template for more information


List<int> input = Console.ReadLine()
    .Split("@")
    .Select(int.Parse)
    .ToList();
bool isTrue = true;
int currentIndex = 0;
int failedCounter = 0;
string command = "";
while ((command = Console.ReadLine()) != "Love!")
{
    string[] tockens = command.Split(" ");

    switch (tockens[0])
    {
        case "Jump":
            int jumpLenght = int.Parse(tockens[1]);
            currentIndex += jumpLenght;
            if (currentIndex > input.Count - 1)
            {
                currentIndex = 0;
            }

            break;
    }

    if (input[currentIndex] > 0)
    {
        input[currentIndex] -= 2;
        if (input[currentIndex] <= 0)
        {
            Console.WriteLine($"Place {currentIndex} has Valentine's day.");  //ako sega stane 0
            input[currentIndex] = 0;
        }


    }
    else if (input[currentIndex] == 0)
    {
        Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
    }

}

Console.WriteLine($"Cupid's last position was {currentIndex}.");

for (int i = 0; i < input.Count; i++)
{
    if (input[i] != 0)
    {
        isTrue = false;
        failedCounter++;
    }


}

if (isTrue)
{
    Console.WriteLine("Mission was successful.");
}
else
{
    Console.WriteLine($"Cupid has failed {failedCounter} places.");
}