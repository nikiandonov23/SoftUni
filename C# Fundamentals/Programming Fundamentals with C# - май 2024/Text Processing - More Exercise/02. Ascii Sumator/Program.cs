// See https://aka.ms/new-console-template for more information


char first=char.Parse(Console.ReadLine());
char second = char.Parse(Console.ReadLine());
int firstValue = Convert.ToInt32(first);
int secondValue = Convert.ToInt32(second);

string input = Console.ReadLine();

int sum = 0;

foreach (var character in input)
{
    if (character> firstValue&&character<secondValue)
    {
        sum += character;
    }


}

Console.WriteLine(sum);