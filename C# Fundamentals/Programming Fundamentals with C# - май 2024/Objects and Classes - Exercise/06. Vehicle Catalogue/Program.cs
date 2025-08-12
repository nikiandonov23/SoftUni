// See https://aka.ms/new-console-template for more information


using System.Runtime.InteropServices;



List<Vehicle> allVehicles = new List<Vehicle>();
string input = "";

while ((input = Console.ReadLine()) != "End")   //" {typeOfVehicle} {model} {color} {horsepower}"
{
    string[] command = input.Split(" ");

    string typeOfVehicle = command[0];
    if (typeOfVehicle == "car")
    {
        typeOfVehicle = "Car";
    }

    if (typeOfVehicle == "truck")
    {
        typeOfVehicle = "Truck";
    }


    string model = command[1];
    string color = command[2];
    double horsepower = double.Parse(command[3]);

    Vehicle currentVehicle = new Vehicle(typeOfVehicle, model, color, horsepower);     //suzdavam promenliva ot klasa vehicle a ne list i palnq klasa !!!!
    allVehicles.Add(currentVehicle);

}

while ((input = Console.ReadLine()) != "Close the Catalogue")
{
    string command = input;


    foreach (var vehicle in allVehicles)
    {
        if (vehicle.Model == command)
        {
            Console.WriteLine(vehicle);
        }

    }


}

double avarageHP = 0;

var cars = allVehicles.Where(v => v.Type == "Car").ToList();        //pravi list samo s kolite
var trucks = allVehicles.Where(v => v.Type == "Truck").ToList();      //pravi list samo s kamionite

if (cars.Count > 0)
{
    avarageHP = allVehicles.Where(vehicle => vehicle.Type == "Car")
        .Select(vehicle => vehicle.Hp)
        .Average();

    Console.WriteLine($"Cars have average horsepower of: {avarageHP:f2}.");
}
else
{
    Console.WriteLine($"Cars have average horsepower of: 0.00.");
}

if (trucks.Count > 0)
{
    avarageHP = allVehicles.Where(vehicle => vehicle.Type == "Truck")
        .Select(vehicle => vehicle.Hp)
        .Average();

    Console.WriteLine($"Trucks have average horsepower of: {avarageHP:f2}.");
}
else
{
    Console.WriteLine($"Trucks have average horsepower of: 0.00.");
}









public enum Type

{
    Car,
    Truck
}


class Vehicle
{
    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public double Hp { get; set; }

    public Vehicle(string type, string model, string color, double hp)
    {
        Type = type;
        Model = model;
        Color = color;
        Hp = hp;
    }

    public override string ToString()
    {
        return
            $"Type: {Type}\nModel: {Model} \nColor: {Color}\nHorsepower: {Hp}";


    }
}