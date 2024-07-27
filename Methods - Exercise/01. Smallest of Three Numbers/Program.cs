// See https://aka.ms/new-console-template for more information


int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

Console.WriteLine(method(n1,n2,n3));
int method(int one, int two, int three)
{
    int result = 0;
    int smallestNum1 = Math.Min(one, two);

    int smallestNum2 = Math.Min(two, three);

    if (smallestNum1 == smallestNum2)
    {
        result = two;
    }

    else if (smallestNum1 < smallestNum2)
    {
        result = smallestNum1;
    }
    else if (smallestNum2 < smallestNum1)
    {
        result = smallestNum2;
    }

    return result;


}

