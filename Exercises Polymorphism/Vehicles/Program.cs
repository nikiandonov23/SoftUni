namespace Vehicles
{
    public class Program
    {
        public static void Main()
        {
            

            string[] carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Car car = new Car(double.Parse(carData[1]), double.Parse(carData[2]));


            string[] truckData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Truck truck = new Truck(double.Parse(truckData[1]), double.Parse(truckData[2]));


            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = data[0];
                string type = data[1];


                switch (command)
                {
                    case "Drive":
                        double distance = double.Parse(data[2]);
                        if (type== "Car")
                        {
                            car.Drive(distance);
                        }
                        else if (type== "Truck")
                        {
                            truck.Drive(distance);
                        }
                        break;


                    case "Refuel":
                        double liters=double.Parse(data[2]);
                        if (type == "Car")
                        {
                            car.Refuel(liters);
                        }
                        else if (type == "Truck")
                        {
                            truck.Refuel(liters);
                        }
                        break;


                }

            }

            if (car.FuelQuantity>0)
            {
                Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            }

            if (truck.FuelQuantity>0)
            {
                Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            }
            


        }
    }
}
