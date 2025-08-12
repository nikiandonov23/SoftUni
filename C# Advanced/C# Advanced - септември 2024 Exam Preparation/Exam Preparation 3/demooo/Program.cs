// See https://aka.ms/new-console-template for more information


var food = new Stack<int>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));


var stamina = new Queue<int>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));


var peaks = new Dictionary<string, int>();
peaks.Add("Vihren", 80);
peaks.Add("Kutelo", 90);
peaks.Add("Banski Suhodol", 100);
peaks.Add("Polezhan", 60);
peaks.Add("Kamenitza", 70);

var conqueredPeaks = new List<string>();

foreach (var peak in peaks)
{
    if (food.Pop() + stamina.Dequeue() >= peak.Value)
    {
        conqueredPeaks.Add(peak.Key);
    }
}

if (peaks.Count == conqueredPeaks.Count)
{

    Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");



    Console.WriteLine("Conquered peaks:");
    foreach (var peak in conqueredPeaks)
    {
        
        Console.WriteLine(peak);
    }
}
else
{
    
    Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
    if (conqueredPeaks.Count > 0)
    {
        Console.WriteLine("Conquered peaks:");
        foreach (var peak in conqueredPeaks)
        {
            Console.WriteLine(peak);
        }
    }
}
