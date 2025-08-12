// See https://aka.ms/new-console-template for more information



using System.Threading;

List<string> input = Console.ReadLine()            //   cat 10|potion 30|orc 10|chest 10|snake 25|chest 110
    .Split("|")
    .ToList();

int health = 100;
int loot = 0;
int bestLoot = 0;
int totalLoot = 0;





for (int i = 0; i < input.Count; i++)
{
    string[] commands = input[i].Split(" ");
    string command = commands[0];
    int numberTo = int.Parse(commands[1]);


    if (command == "potion")
    {

        int temp = health;
        health += numberTo;
        if (health > 100)
        {
            
            health = 100;
            Console.WriteLine($"You healed for {100-temp} hp.");            //ako jivota e nad 100 sus hiilnati vkliu4itelno
            Console.WriteLine($"Current health: {health} hp.");
        }
        else
        {
            Console.WriteLine($"You healed for {numberTo} hp.");            //ako jivota e pod 100 sus hiilnati vkliu4itelno
            Console.WriteLine($"Current health: {health} hp.");
        }
        
    }



    else if (command == "chest")
    {
        loot = numberTo;
        totalLoot += loot;

        if (loot > bestLoot)
        {
            bestLoot = loot;

        }

        Console.WriteLine($"You found {loot} bitcoins.");
    }


    else
    {
        health -= numberTo;

        if (health <= 0)                                           //ako umresh
        {
            Console.WriteLine($"You died! Killed by {command}.");
            Console.WriteLine($"Best room: {i + 1}");                //nai golmoto nivo koeto si stignal
            break;
        }
        else
        {
            Console.WriteLine($"You slayed {command}.");
        }
    }


}





if (health > 0)
{
    Console.WriteLine("You've made it!");
    Console.WriteLine($"Bitcoins: {totalLoot}");
    Console.WriteLine($"Health: {health}");
}