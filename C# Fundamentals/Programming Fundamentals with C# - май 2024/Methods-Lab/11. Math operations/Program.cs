// See https://aka.ms/new-console-template for more information



int n1 = int.Parse(Console.ReadLine());
string operation=Console.ReadLine();
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine(method(n1,operation,n2));

int method(int first, string action, int second)
{
    if (action=="/")
    {
        int result=first/second;
        return result;
    }
    else if (action== "*")
    {
        int result = first * second;
        return  result;
    }
    else if (action=="+")
    {
        int result = first + second;
        return  result;
    }
    else
    {
        int result = first - second;
        return  result;
    }
}

