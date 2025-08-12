// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());
int[] array=Enumerable.Range(1, n-1+1).ToArray();

int[] numbers=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

Func<int,bool> function= numberToDevide =>
{
    bool isItTrue = true;
    foreach (var devider in numbers)
    {
        if (numberToDevide%devider!=0)
        {
            isItTrue=false;
        }
    }
    return isItTrue;
};

array=array.Where(function).ToArray();
Console.WriteLine(string.Join(" ",array));
