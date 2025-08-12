// See https://aka.ms/new-console-template for more information
List<double> input=Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

input=input.Select(x=>(x*=1.20)).ToList();

foreach (var number in input)
{
    Console.WriteLine($"{number:f2}");
}