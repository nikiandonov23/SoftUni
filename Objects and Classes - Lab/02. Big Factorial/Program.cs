 using System.Numerics;

BigInteger num=BigInteger.Parse(Console.ReadLine());

BigInteger factorial = 1;


for (int i = 2; i <= num; i++)
{
    factorial *= i;
}

Console.WriteLine(factorial);

