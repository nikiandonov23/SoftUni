// See https://aka.ms/new-console-template for more information
Queue<int> monsters = new Queue<int>(Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Stack<int> soldiers = new Stack<int>(Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

int totalMonstersKilled = 0;


while (monsters.Count > 0 && soldiers.Count > 0)
{

    int currentMonster = monsters.Peek();
    int currentSoldier = soldiers.Peek();

    if (currentSoldier >= currentMonster)  //	If the soldier's striking impact is greater than or equal to the monster's armor
    {
        totalMonstersKilled++;
        monsters.Dequeue();
        currentSoldier -= currentMonster; //the soldier's strike impact is then decreased by the value of the monster's armor
        soldiers.Pop();

        //The remaining striking impact value is added to the next strike element in the sequence (if any)
        //or is considered to be the last and only element. Zero values should not be pushed back to the sequence.
        if (currentSoldier > 0 && soldiers.Count > 0)
        {
            soldiers.Push(currentSoldier);
        }

    }
    else if (currentSoldier < currentMonster) //If the soldier's striking impact is less than the monster's armor
    {
        currentMonster -= currentSoldier; //monster's armor value is decreased by the original strike value
        soldiers.Pop();  //soldier's striking impact value is removed from the sequence

        monsters.Dequeue();
        monsters.Enqueue(currentMonster); //monster is then moved to the back of the sequence.


    }

}

if (monsters.Count <= 0)
{
    Console.WriteLine("All monsters have been killed!");
}

if (soldiers.Count <= 0)
{
    Console.WriteLine("The soldier has been defeated.");
}

Console.WriteLine($"Total monsters killed: {totalMonstersKilled}");