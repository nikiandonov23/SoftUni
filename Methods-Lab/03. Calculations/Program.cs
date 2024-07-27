string command = Console.ReadLine();
int a=int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

void add()
{
    Console.WriteLine(a+b);
}

void multiply()
{
    Console.WriteLine(a * b);

}
void subtract()
{
    Console.WriteLine(a - b);

}
void divide()
{
    Console.WriteLine(a / b);

}

switch (command)
{
    case"add":
        add();
        break;
    case "multiply":
        multiply();
        break;
    case "subtract":
        subtract();
        break;
    case "divide":
        divide();
        break;
}