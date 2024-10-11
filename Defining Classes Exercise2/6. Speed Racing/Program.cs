// See https://aka.ms/new-console-template for more information


using _6._Speed_Racing;

List<Car>allCars=new List<Car>();

int n = int.Parse(Console.ReadLine());
string input = "";
for (int i = 0; i < n; i++)
{
   

    input =Console.ReadLine();
    string[] tockens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string model = tockens[0];
    double fuelAmout=double.Parse(tockens[1]);
    double fuelConsuptionPerLiter=double.Parse(tockens[2]);

    Car currentCar = new Car(model,fuelAmout,fuelConsuptionPerLiter);
    allCars.Add(currentCar);
    


}

input = "";
while ((input = Console.ReadLine()) != "End")
{
    string[] tockens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string carModel=tockens[1];
    int amaountOfKm=int.Parse(tockens[2]);

    Car carToDrive = allCars.Where(car => (car.Model == carModel)).FirstOrDefault();
    
    carToDrive.Drive(carToDrive,amaountOfKm);
    
    
}

foreach (var car in allCars)
{
    Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
}

