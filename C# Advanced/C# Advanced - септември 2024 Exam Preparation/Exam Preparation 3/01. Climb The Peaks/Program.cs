// See https://aka.ms/new-console-template for more information

Stack<int> foods = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Queue<int> stamina = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));



Dictionary<int, string> peeks = new Dictionary<int, string>()
{
    {80,"Vihren"},   //80
    {90,"Kutelo"},   //90
    {100,"Banski Suhodol"},   //100 
    {60,"Polezhan"},  //60
    {70,"Kamenitza"},  //70


};
int peeksInitialCount = peeks.Count;
List<string> conqueredPeeks = new List<string>();

while (foods.Count > 0 && stamina.Count > 0 && peeks.Count > 0)
{

    int currentFood = foods.Peek();
    int currentStamina = stamina.Peek();

    int currentSum = currentFood + currentStamina;


    var peekToCompare = peeks.First();
    if (peekToCompare.Key <= currentSum)
    {
        conqueredPeeks.Add(peekToCompare.Value);
        peeks.Remove(peeks.First().Key);

        foods.Pop();
        stamina.Dequeue();

    }
    else if (peekToCompare.Key > currentSum)
    {
        foods.Pop();
        stamina.Dequeue();
    }

}

if (peeks.Count != 0)
{
    Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
}
else if (peeks.Count == 0)
{
    Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");

}

if (conqueredPeeks.Count != 0)
{
    Console.WriteLine("Conquered peaks:");
    foreach (var peek in conqueredPeeks)
    {
        Console.WriteLine(peek.Trim());
    }
}