// See https://aka.ms/new-console-template for more information


List<double> input=Console.ReadLine()              //5 2 3 4 -10 30 40 50 20 50 60 60 51
    .Split(" ")
    .Select(double.Parse)
    .ToList();


double avarageValue=Math.Round((input.Sum()/input.Count),2);

List<double> final=new List<double>();

for (int i = 0; i < input.Count; i++)
{
    if (input[i]>avarageValue)
    {
        final.Add(input[i]);

    }
}

if (final.Count==0)
{
    Console.WriteLine("No");
}
else if (final.Count>5)
{
    final.Sort();
    final.Reverse();
    List<double> finalfinal=new List<double>();
    finalfinal.InsertRange(0, final.GetRange(0,5));

    Console.WriteLine(string.Join(" ",finalfinal));
}
else
{
    final.Sort();
    final.Reverse();
    Console.WriteLine(string.Join(" ", final));
}