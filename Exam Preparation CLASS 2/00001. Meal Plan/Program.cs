Queue<string> meals = new Queue<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));

Stack<int> calories = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Dictionary<string, int> list = new Dictionary<string, int>()
{
    {"salad",350},
    {"soup",490},
    {"pasta",680},
    {"steak",790},
};

int mealsEaten = 0;

while (meals.Count > 0 && calories.Count > 0)
{
    int currentDayCalories = calories.Pop(); 
    while (currentDayCalories > 0 && meals.Count > 0)
    {
        int currentMealCalories = list[meals.Dequeue()]; 
        mealsEaten++;

        if (currentDayCalories >= currentMealCalories)
        {
            currentDayCalories -= currentMealCalories; 
        }
        else
        {
            
            int remainingMealCalories = currentMealCalories - currentDayCalories;
            currentDayCalories = 0; 

            if (calories.Count > 0)
            {
                int nextDayCalories = calories.Pop(); 
                nextDayCalories -= remainingMealCalories; 
                calories.Push(nextDayCalories); 
            }
        }
    }
}

if (meals.Count == 0)
{
    Console.WriteLine($"John had {mealsEaten} meals.");
    if (calories.Count > 0)
    {
        Console.WriteLine($"For the next few days, he can eat {string.Join(", ", calories.Reverse())} calories.");
    }
}
else
{
    Console.WriteLine($"John ate enough, he had {mealsEaten} meals.");
    Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
}