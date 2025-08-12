// See https://aka.ms/new-console-template for more information

using _7._Raw_Data;


List<Car>allCars=new List<Car>();

int n = int.Parse(Console.ReadLine());
string input = "";
for (int i = 0; i < n; i++)
{
    input=Console.ReadLine();
    string[] tockens=input.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
    string model = tockens[0];


    Engine currentEngine = new Engine(int.Parse(tockens[1]), int.Parse(tockens[2]));
    Cargo currentCargo = new Cargo(tockens[4], int.Parse(tockens[3]));

    Tires tire1 = new Tires(double.Parse(tockens[5]), int.Parse(tockens[6]));
    Tires tire2 = new Tires(double.Parse(tockens[7]), int.Parse(tockens[8]));
    Tires tire3 = new Tires(double.Parse(tockens[9]), int.Parse(tockens[10]));
    Tires tire4 = new Tires(double.Parse(tockens[11]), int.Parse(tockens[12]));

    List<Tires>currentTires=new List<Tires>(){tire1,tire2,tire3,tire4};

    Car currentCar = new Car(model, currentEngine, currentCargo, currentTires);
    allCars.Add(currentCar);
}

input=Console.ReadLine();

if (input== "fragile")
{
    allCars=allCars.Where(cargo=>cargo.Cargo.Type== "fragile").ToList();
 
    foreach (var car in allCars)
    {
        foreach (var tire in car.Tires)
        {
            if (tire.Pressure<1)
            {
                Console.WriteLine(car.Model);
                break;
            }
        }
    }
}
else if (input == "flammable")
{
    allCars = allCars.Where(typeCargo => typeCargo.Cargo.Type == "flammable").Where(power=>power.Engine.Power>=250).ToList();
    foreach (var car in allCars)
    {
        Console.WriteLine(car.Model);
    }


}
