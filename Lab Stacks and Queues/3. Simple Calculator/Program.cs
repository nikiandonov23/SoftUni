// See https://aka.ms/new-console-template for more information


string[] newArray = Console.ReadLine()
    .Split(" ")
    .ToArray();

Stack<int>positiveNum=new Stack<int>();
Stack<int> NegativeNum = new Stack<int>();



for (int i = 0; i < newArray.Length; i++)
{
    if (newArray[i] =="-")
    {
        NegativeNum.Push(int.Parse(newArray[i+1]));
        i++;
    }
    else if (newArray[i]=="+")
    {
        positiveNum.Push(int.Parse(newArray[i+1]));
        i++;
    }
    else
    {
        positiveNum.Push(int.Parse(newArray[i]));
        
    }

}

Console.WriteLine($"{positiveNum.Sum()-NegativeNum.Sum()}");