// See https://aka.ms/new-console-template for more information

int[] input=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
string command=Console.ReadLine();

int n1 = input[0];
int n2 = input[1];

int[] array =Enumerable.Range(n1,n2-n1+1).ToArray();

Predicate<int> whatIsIt=null;


switch (command)
{
    case"odd":
        whatIsIt = x => x % 2 != 0;
        
        break;

    case"even":
        whatIsIt = x => x % 2 == 0;
        break;
}

array = array.Where(x => whatIsIt(x)).ToArray();
Console.WriteLine(string.Join(" ",array));

