// See https://aka.ms/new-console-template for more information



string input1 = Console.ReadLine();
string input2 = Console.ReadLine();
string input3 = Console.ReadLine();




bool method(string n)
{
    bool isNegative = false;
    for (int i = 0; i < n.Length; i++)
    {
        string digit = (n[i]).ToString();

        if (digit == "-")
        {
            isNegative = true;
        }
    }

    return isNegative;
}

if (methodZERO(input1) || methodZERO(input2) || methodZERO(input3))
{
    Console.WriteLine("zero");
   
}
else 
{
    int minusCounter = 0;

    if (method(input1))
    {
        minusCounter++;
    }                      //count -
    if (method(input2))
    {
        minusCounter++;
    }                      //count -
    if (method(input3))
    {
        minusCounter++;
    }                      //count -

    if (minusCounter % 2 == 1)       //ako ima NeCheten broi minusi zna4i rezultata e minus
    {

        Console.WriteLine("negative");

    }
    else
    {
        Console.WriteLine("positive");
    }
}




bool methodZERO(string n)
{
    bool isZero = false;

    if (n[0] == 48)
    {
        isZero = true;
    }

    return isZero;
}