// See https://aka.ms/new-console-template for more information

Stack<int> money = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Queue<int> foodPrice = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

int foodsEaten = 0;
while (money.Count > 0 && foodPrice.Count > 0)
{
    int currentMoney = money.Pop();  
    int currentFoodPrice = foodPrice.Peek();  

    if (currentMoney == currentFoodPrice)
    {
        foodPrice.Dequeue();  
        foodsEaten++;  
    }
    else if (currentMoney > currentFoodPrice)
    {
        int change = currentMoney - currentFoodPrice;
        foodPrice.Dequeue();  
        foodsEaten++;  

        if (money.Count > 0)
        {
            int nextMoney = money.Pop();  
            money.Push(nextMoney + change);  
        }
        else
        {
            money.Push(change);  
        }
    }
    else
    {
        
        foodPrice.Dequeue();
    }
}


if (foodsEaten >= 4)
{
    Console.WriteLine($"Gluttony of the day! Henry ate {foodsEaten} foods.");
}
else if (foodsEaten > 1)
{
    Console.WriteLine($"Henry ate: {foodsEaten} foods.");
}
else if (foodsEaten == 1)
{
    Console.WriteLine($"Henry ate: {foodsEaten} food.");
}
else
{
    Console.WriteLine("Henry remained hungry. He will try next weekend again.");
}