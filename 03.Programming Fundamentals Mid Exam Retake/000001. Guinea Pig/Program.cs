// See https://aka.ms/new-console-template for more information


double food = 1000*double.Parse(Console.ReadLine());
double hay = 1000 * double.Parse(Console.ReadLine());
double cover= 1000 * double.Parse(Console.ReadLine());

double weight= 1000 * double.Parse(Console.ReadLine());

int daysCounter = 0;
bool NotEnoughFood = false;

for (int i = 1; i <= 30; i++)
{
    food -= 300;
    if (i%2==0)
    {
        hay -= food * 0.05;

    }

    if (i%3==0)
    {
        cover -= weight / 3;

    }

    if (food<=0||hay<=0||cover<=0)
    {
        NotEnoughFood = true;
        break;
    }



}

if (NotEnoughFood)
{
    Console.WriteLine("Merry must go to the pet store!");
}
else
{
    Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food/1000:f2}, Hay: {hay/1000:f2}, Cover: {cover/1000:f2}.");
}


