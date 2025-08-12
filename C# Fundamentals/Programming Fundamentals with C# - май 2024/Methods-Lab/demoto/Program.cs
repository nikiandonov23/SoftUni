// See https://aka.ms/new-console-template for more information

string input = Console.ReadLine();
int inputAsInt = int.Parse(input);
int inputAsIntPositive = Math.Abs(inputAsInt);
string number = inputAsIntPositive.ToString();


int sumOdd = methodOdd(int.Parse(number));
int sumEven = methodEven(int.Parse(number));
int result = methodMultiple(int.Parse(number));

Console.WriteLine(result);



int methodOdd(int n)
{
    int sumOdd = 0;

    foreach (char i in number)
    {
        int num = i - '0';

        if (num % 2 != 0)
        {
            sumOdd += num;
        }

    }

    return sumOdd;

}

int methodEven(int n)
{
    sumEven = 0;

    foreach (char i in number)
    {
        int num = i - '0';
        if (num%2==0)
        {
            sumEven += num;
        }
    }
    return sumEven;
}

int methodMultiple(int n)
{
    int result = sumOdd * sumEven;
    return result;
}

