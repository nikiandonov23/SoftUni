// See https://aka.ms/new-console-template for more information


int people = int.Parse(Console.ReadLine());             //20


List<int> input = Console.ReadLine()         //0 2 0
    .Split(" ")
    .Select(int.Parse)
    .ToList();

int wagonsCountn = input.Count;



for (int i = 0; i < input.Count; i++)
{
    int freespaceInaWagon = 4 - input[i];

    if( freespaceInaWagon> 0 && input[i] < 4)
    {
        if (people- freespaceInaWagon>0)
        {
            input[i] += freespaceInaWagon;
            people -= freespaceInaWagon;
        }
        else
        {
            input[i] += people;
            people = 0;
        }
        
    }
}


if (people>0)
{
    Console.WriteLine($"There isn't enough space! {people} people in a queue!");
}

bool liftIsEmpty = false;
for (int i = 0; i < input.Count; i++)
{
    if (input[i]!=4)
    {
        liftIsEmpty = true;
        break;
    }
}

if (people<=0&&liftIsEmpty==true)
{
    Console.WriteLine("The lift has empty spots!");
}


Console.WriteLine(string.Join(" ", input));


