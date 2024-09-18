string input=Console.ReadLine();

if (IsBalanced(input))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}

static bool IsBalanced (string input)
{
    Stack<char>brackets=new Stack<char>();

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i]=='(')
        {
            brackets.Push(')');
        }
        else if (input[i] == '{')
        {
            brackets.Push('}');

        }
        else if (input[i]=='[')
        {
            brackets.Push(']');

        }
        else
        {
            if (brackets.Count == 0)
            {
                return false;
            }

            if (brackets.Pop() != input[i])    // ako elementa e razlichen ot toq v brackets popvai
            {
                return false;
            }

         

        }
    }
    return brackets.Count == 0; // true ili false
}