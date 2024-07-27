// See https://aka.ms/new-console-template for more information

double total = 0;
double taxes = 0;
List<double> prices = new List<double>();



string command = "";
while ((command = Console.ReadLine()) != "special" && command != "regular")
{
    if (double.Parse(command) < 0)
    {
        Console.WriteLine("Invalid price!");
        continue;
    }

    prices.Add(double.Parse(command));

    total = prices.Sum();

}

taxes = total * 0.2;

if (total == 0)
{
    Console.WriteLine("Invalid order!");
}

else if (command == "regular")
{
    Console.WriteLine("Congratulations you've just bought a new computer!");
    Console.WriteLine($"Price without taxes: {total:f2}$");
    Console.WriteLine($"Taxes: {taxes:f2}$");
    Console.WriteLine("-----------");
    Console.WriteLine($"Total price: {(total + taxes):f2}$");

}

else if (command == "special")
{
    double finalPrice = total + taxes;
    double addDiscount = finalPrice - finalPrice * 0.1;
    Console.WriteLine("Congratulations you've just bought a new computer!");
    Console.WriteLine($"Price without taxes: {total:f2}$");
    Console.WriteLine($"Taxes: {taxes:f2}$");
    Console.WriteLine("-----------");
    Console.WriteLine($"Total price: {addDiscount:f2}$");

}