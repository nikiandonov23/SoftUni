// See https://aka.ms/new-console-template for more information


int initialEnergy = int.Parse(Console.ReadLine());

string command = "";

int winCounter = 0;
while ((command = Console.ReadLine()) != "End of battle")
{

    int distance = int.Parse(command);

    if (initialEnergy >= distance)
    {
        initialEnergy -= distance;
        winCounter++;
        if (winCounter % 3 == 0)
        {
            initialEnergy += winCounter;
        }
    }

    else if (initialEnergy < distance)
    {
        Console.WriteLine($"Not enough energy! Game ends with {winCounter} won battles and {initialEnergy} energy");
        break;
    }


}

if (command == "End of battle")
{
    Console.WriteLine($"Won battles: {winCounter}. Energy left: {initialEnergy}");
}
