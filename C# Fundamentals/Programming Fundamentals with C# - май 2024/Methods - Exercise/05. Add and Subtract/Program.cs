// See https://aka.ms/new-console-template for more information


int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

int sum = methodSum(n1, n2);
int result = methodSubstract(sum, n3);
Console.WriteLine(result);


int methodSum(int first,int second)
{
    int sum = first + second;
    return sum;
}

int methodSubstract(int sum,int n3)
{
    int result = sum - n3;
    return result;
}

