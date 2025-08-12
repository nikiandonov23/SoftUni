// See https://aka.ms/new-console-template for more information




string input = Console.ReadLine();
string data = Console.ReadLine();

string methodSting(string enter)
{
    string newString = $"${data}$";
    return newString;
}

int methodInt(int number)
{
    return number * 2;
}
double methodDouble(double number)
{
    return number * 1.5;
}

if (input=="int")
{
    int number=int.Parse(data);
    Console.WriteLine(methodInt(number));
}
else if (input == "real")
{
    double number=double.Parse(data);
    Console.WriteLine($"{(methodDouble(number)):f2}");
    
}
else if (input=="string")
{
    Console.WriteLine(methodSting(data));
}