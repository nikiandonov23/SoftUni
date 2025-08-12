// See https://aka.ms/new-console-template for more information


Queue<int> contestents=new Queue<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Stack<int> pies = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

while (pies.Count>0&&contestents.Count>0)
{
    int currentContestent = contestents.Peek();
    int currentPie = pies.Peek();

    if (currentContestent>=currentPie)
    {
        pies.Pop();                      //
        currentContestent -= currentPie;
        if (currentContestent<=0)
        {
            contestents.Dequeue();    //pie-eating capacity reaches 0  remove the contestant
        }
        else
        {
            contestents.Dequeue();
            contestents.Enqueue(currentContestent);
        }
    }
    else                            //the pie's size exceeds the contestant's pie-eating capacity
    {
        
        currentPie-=currentContestent;

        if (currentPie <= 1 && pies.Count>1)     // pie's size reaches 1 piece, remove the pie, adding the remaining piece to the next pie 
        {
            
            pies.Pop();
            int pieToBeMergedWith = pies.Pop();

            pies.Push(pieToBeMergedWith+currentPie);
        }
        else
        {
            pies.Pop();
            pies.Push(currentPie);
        }

        contestents.Dequeue();
    }

  
}

if (pies.Count<=0&&contestents.Count>0)
{
    Console.WriteLine("We will have to wait for more pies to be baked!");
    Console.WriteLine($"Contestants left: {string.Join(", ",contestents)}");
}
else if (contestents.Count<=0&&pies.Count>0)
{
    Console.WriteLine("Our contestants need to rest!");
    Console.WriteLine($"Pies left: {string.Join(", ",pies)}");
}
else
{
    Console.WriteLine("We have a champion!");
}