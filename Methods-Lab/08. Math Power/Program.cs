// See https://aka.ms/new-console-template for more information


double n1 = double.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());
method(n1,n2);
double result = method(n1, n2);
Console.WriteLine(result);
static double method(double n1,double n2)
{
    double n3 = n1;

    for (global::System.Int32 i = 1; i < n2; i++)
    {
        n3 *= n1;
    }

   
    return n3;
}