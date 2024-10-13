// See https://aka.ms/new-console-template for more information

Stack<int> packages=new Stack<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Queue<int>couriers=new Queue<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));


int totalWeightDelivered = 0;
while (packages.Count>0&&couriers.Count>0)
{
    int currentPackage=packages.Pop();
    int currentCourier = couriers.Dequeue();

    if (currentCourier>=currentPackage)   //the capacity of the courier is equal to or greater than the weight of the package
    {
        totalWeightDelivered += currentPackage;
        currentCourier = currentCourier - 2 * currentPackage;
        if (currentCourier>0)   //	If the new courier's capacity is positive, the courier moves at the back of the sequence with the updated capacity.
        {
            couriers.Enqueue(currentCourier);
        }
    }

    else if (currentCourier<currentPackage)  //•	capacity of the courier is less than the weight of the package
    {
        currentPackage -= currentCourier;
        totalWeightDelivered += currentCourier;
        packages.Push(currentPackage);

    }


}

Console.WriteLine($"Total weight: {totalWeightDelivered} kg");
if (packages.Count==0&&couriers.Count==0)
{
    Console.WriteLine("Congratulations, all packages were delivered successfully by the couriers today.");
}
else if (packages.Count>0&&couriers.Count==0)
{
    Console.WriteLine($"Unfortunately, there are no more available couriers to deliver the following packages: {string.Join(", ",packages)}");
}
else if (packages.Count == 0 && couriers.Count > 0)
{
    Console.WriteLine($"Couriers are still on duty: {string.Join(", ",couriers)} but there are no more packages to deliver.");
}