// See https://aka.ms/new-console-template for more information


List<Car> allCars = new List<Car>();
int n = int.Parse(Console.ReadLine());

string input = "";
for (int i = 0; i < n; i++)
{
    input = Console.ReadLine();
    string[] tockens=input.Split("|");
    string car = tockens[0];
    int millage=int.Parse(tockens[1]);
    int fuel=int.Parse(tockens[2]);

    Car currentCar = new Car();

    currentCar.CarName = car;
    currentCar.Millage = millage;
    currentCar.Fuel = fuel;
    
    allCars.Add(currentCar);

}

while ((input = Console.ReadLine()) != "Stop")
{
    string[] tockens = input.Split(" : ");
    string command = tockens[0];
    string car = tockens[1];


    switch (command)
    {
        case "Drive":
            car = tockens[1];
            int distance=int.Parse(tockens[2]);
            int fuel=int.Parse(tockens[3]);

            foreach (var carr in allCars)
            {
                if (carr.CarName==car)
                {
                    if (carr.Fuel>=fuel)
                    {
                        carr.Fuel -= fuel;
                        carr.Millage += distance;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        if (carr.Millage>=100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            allCars.Remove(carr);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Not enough fuel to make that ride");
                    }
                } 
            }
            break;


        case "Refuel":
            car=tockens[1];
            fuel = int.Parse(tockens[2]);

            foreach (var carr in allCars)
            {
                if (carr.CarName == car)
                {
                    if (carr.Fuel + fuel > 75)
                    {
                        Console.WriteLine($"{car} refueled with {75-carr.Fuel} liters");
                        carr.Fuel =75;
                    }
                    else
                    {
                        carr.Fuel += fuel;
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                }

               
            }
            break;


        case "Revert":
            car = tockens[1];
            int kilometers=int.Parse(tockens[2]);

            foreach (var carr in allCars)
            {
                if (carr.CarName==car)
                {
                    carr.Millage-=kilometers;
                    Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    if (carr.Millage<10000)
                    {
                        carr.Millage = 10000;
                    }
                }
            }

            break;
    }


}

foreach (var carr in allCars)
{
    Console.WriteLine($"{carr.CarName} -> Mileage: {carr.Millage} kms, Fuel in the tank: {carr.Fuel} lt.");
}


class Car
{
    public string CarName { get; set; }
    public int Millage { get; set; }
    public int Fuel { get; set; }

    
}
