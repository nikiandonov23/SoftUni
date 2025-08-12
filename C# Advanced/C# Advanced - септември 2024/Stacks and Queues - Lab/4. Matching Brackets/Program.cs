// See https://aka.ms/new-console-template for more information

string input = Console.ReadLine();         // 1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5

Stack<int>brackets=new Stack<int>();


for (int i = 0; i < input.Length; i++)
{

    if (input[i]=='(')
    {
        brackets.Push(i);
    }
    else if (input[i] == ')')
    {
        Console.WriteLine(input.Substring(brackets.Peek(),i-brackets.Peek()+1));

        brackets.Pop();
    }
}


