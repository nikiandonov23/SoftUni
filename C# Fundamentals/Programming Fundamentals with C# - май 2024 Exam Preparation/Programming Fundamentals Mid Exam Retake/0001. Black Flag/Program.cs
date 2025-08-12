// See https://aka.ms/new-console-template for more information


int days = int.Parse(Console.ReadLine());
int dailyPlunder = int.Parse(Console.ReadLine());
double expectedPlunder=double.Parse(Console.ReadLine());

double profit = 0;


int counter = 1;
for (int i = 1; i <= days; i++)
{
    profit += dailyPlunder;
    if (i%3==0)
    {
        profit += dailyPlunder*0.5;
    }

    if (i%5==0)
    {
        profit -= profit * 30 / 100;
    }



    counter++;
}

if (profit>=expectedPlunder)
{
    Console.WriteLine($"Ahoy! {profit:f2} plunder gained.");
}
else
{
    double diffrence = expectedPlunder - profit;
    double procentage = diffrence / expectedPlunder * 100;
    Console.WriteLine($"Collected only {100-procentage:f2}% of the plunder.");
}
