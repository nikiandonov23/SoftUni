using System;


List<Car> allCars = new List<Car>();
List<Truck> allTrucks = new List<Truck>();

string input = "";
while ((input = Console.ReadLine()) != "end")
{
    string[] tockens = input.Split("/");   //"{type}/{brand}/{model}/{horse power / weight}"

    switch (tockens[0])
    {
        case "Car":

            string brandCar = tockens[1];
            string modelCar = tockens[2];
            string powerCar = tockens[3];

            Car newCar = new Car();

            newCar.BrandCar = brandCar;
            newCar.ModelCar = modelCar;
            newCar.PowerCar = powerCar;

            allCars.Add(newCar);

            break;













        case "Truck":

            string brandTruck = tockens[1];
            string modelTruck = tockens[2];
            string weightTruck = tockens[3];

            Truck newTruck = new Truck();

            newTruck.BrandTruck = brandTruck;
            newTruck.ModelTruck = modelTruck;
            newTruck.WeightTruck = weightTruck;

            allTrucks.Add(newTruck);

            break;
    }


}
allCars.Sort((c1, c2) => c1.BrandCar.CompareTo(c2.BrandCar));
allTrucks.Sort((t1, t2) => t1.BrandTruck.CompareTo(t2.BrandTruck));


if (allCars.Count>0)
{
    Console.WriteLine("Cars:");
    foreach (var car in allCars)
    {

        Console.WriteLine($"{car.BrandCar}: {car.ModelCar} - {car.PowerCar}hp");
    }
}




if (allTrucks.Count>0)
{
    Console.WriteLine("Trucks:");
    foreach (var truck in allTrucks)
    {

        Console.WriteLine($"{truck.BrandTruck}: {truck.ModelTruck} - {truck.WeightTruck}kg");
    }
}



class Truck
{
    public string BrandTruck { get; set; }
    public string ModelTruck { get; set; }
    public string WeightTruck { get; set; }

}

class Car
{
    public string BrandCar { get; set; }
    public string ModelCar { get; set; }
    public string PowerCar { get; set; }

}