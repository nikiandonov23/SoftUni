// See https://aka.ms/new-console-template for more information

using CarManufacturer;

Car currentCar=new Car();
currentCar.Make="Toyota";
currentCar.Model="Yaris";
currentCar.Year=2021;
currentCar.FuelQuantity=200;
currentCar.FuelConsumption=5;

currentCar.Drive(1000);
Console.WriteLine(currentCar.WhoAmI());