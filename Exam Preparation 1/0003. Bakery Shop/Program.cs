using System;
using System.Collections.Generic;

string input = "";
List<Food> allFood = new List<Food>();
int totalSold = 0;

while ((input = Console.ReadLine()) != "Complete")
{
    string[] tockens = input.Split(" ");
    string action = tockens[0];
    int quantity = int.Parse(tockens[1]);
    string foodName = tockens[2];

    Food currentFood = new Food();
    currentFood.Name = foodName;
    currentFood.Quantity = quantity;

    switch (action)
    {
        case "Receive":
            bool isFound = false;
            if (quantity <= 0)
            {
                break;
            }
            foreach (var food in allFood)
            {
                if (food.Name == foodName)
                {
                    isFound = true;
                    food.Quantity += quantity;
                    break;
                }
            }
            if (!isFound)
            {
                allFood.Add(currentFood);
            }
            break;

        case "Sell":
            isFound = false;
            foreach (var food in allFood)
            {
                if (food.Name == foodName)
                {
                    isFound = true;
                    if (food.Quantity < quantity)
                    {
                        Console.WriteLine($"There aren't enough {foodName}. You sold the last {food.Quantity} of them.");
                        totalSold += food.Quantity;
                        allFood.Remove(food);
                    }
                    else
                    {
                        food.Quantity -= quantity;
                        totalSold += quantity;
                        Console.WriteLine($"You sold {quantity} {foodName}.");
                        if (food.Quantity == 0)
                        {
                            allFood.Remove(food);
                        }
                    }
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"You do not have any {foodName}.");
            }
            break;
    }
}

foreach (var food in allFood)
{
    Console.WriteLine($"{food.Name}: {food.Quantity}");
}
Console.WriteLine($"All sold: {totalSold} goods");

class Food
{
    public string Name;
    public int Quantity;
    public int Sold;
}