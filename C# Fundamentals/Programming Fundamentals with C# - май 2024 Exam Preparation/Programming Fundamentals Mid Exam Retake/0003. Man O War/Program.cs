// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

List<int> pirateShip = Console.ReadLine()
    .Split(">")
    .Select(int.Parse)
    .ToList();
List<int> warShip = Console.ReadLine()
    .Split(">")
    .Select(int.Parse)
    .ToList();
int maxHealthCapacity = int.Parse(Console.ReadLine());
bool isThereAWinner = false;

string command = "";
while ((command = Console.ReadLine()) != "Retire")
{
    string[] tockens = command.Split(" ");

    int index = 0;
    int damage = 0;
    switch (tockens[0])
    {
        case "Fire":                                      // pirateShip shooting at the warShip
            index = int.Parse(tockens[1]);
            damage = int.Parse(tockens[2]);
            if (index < 0 || index > warShip.Count - 1)   // if index is out of range, skip
            {
                continue;
            }

            warShip[index] -= damage;                     // apply damage to warShip
            if (warShip[index] <= 0)
            {
                Console.WriteLine("You won! The enemy ship has sunken.");
                isThereAWinner = true;
                break;
            }

            break;

        case "Defend":
            int startIndex = int.Parse(tockens[1]);
            int endIndex = int.Parse(tockens[2]);
            damage = int.Parse(tockens[3]);

            bool isStop = false;
            if (startIndex < 0 || startIndex > pirateShip.Count - 1 || endIndex < 0 || endIndex > pirateShip.Count - 1)
            {
                continue;
            }

            var elementsToChange = pirateShip.GetRange(startIndex, endIndex - startIndex + 1);

            for (int i = 0; i < elementsToChange.Count; i++)
            {
                elementsToChange[i] -= damage;
                if (elementsToChange[i] <= 0)
                {
                    isStop = true; break;
                }
            }

            if (isStop)
            {
                Console.WriteLine("You lost! The pirate ship has sunken.");
                isThereAWinner = true;
                break;
            }
            pirateShip.RemoveRange(startIndex, endIndex - startIndex + 1); 
            pirateShip.InsertRange(startIndex, elementsToChange); 
            elementsToChange.Clear();

            break;

        case "Repair":
            index = int.Parse(tockens[1]);
            int health = int.Parse(tockens[2]);

            if (index < 0 || index > pirateShip.Count - 1) // if index is out of range, skip
            {
                continue;
            }

            pirateShip[index] += health;
            if (pirateShip[index] > maxHealthCapacity)
            {
                pirateShip[index] = maxHealthCapacity;
            }

            break;

        case "Status":
            int damageCounter = 0;

            for (int i = 0; i < pirateShip.Count; i++)
            {
                if (((double)pirateShip[i] / maxHealthCapacity) * 100 < 20)
                {
                    damageCounter++;
                }
            }

            if (damageCounter > 0)
            {
                Console.WriteLine($"{damageCounter} sections need repair.");
            }

            break;
    }

    if (isThereAWinner)
    {
        break;
    }
}

if (!isThereAWinner)
{
    int pointsPirate = pirateShip.Sum();
    int pointsWarShip = warShip.Sum();
    Console.WriteLine($"Pirate ship status: {pointsPirate}");
    Console.WriteLine($"Warship status: {pointsWarShip}");
}