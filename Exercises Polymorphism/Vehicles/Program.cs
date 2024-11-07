using System.Text;

namespace Vehicles
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, Vehicle> allVehicles = new Dictionary<string, Vehicle>();

            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (input[0])
                {
                    case "Car":
                        Vehicle car = new Car(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
                        allVehicles.Add("car", car);
                        break;


                    case "Truck":
                        Vehicle truck = new Truck(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
                        allVehicles.Add("truck", truck);

                        break;


                    case "Bus":
                        Vehicle bus = new Bus(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
                        allVehicles.Add("bus", bus);
                        break;
                }

            }





            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Refuel":
                        if (command[1] == "Car")
                        {
                            allVehicles["car"].Refuel(double.Parse(command[2]));
                        }
                        else if (command[1] == "Truck")
                        {
                            allVehicles["truck"].Refuel(double.Parse(command[2]));
                        }
                        else
                        {
                            allVehicles["bus"].Refuel(double.Parse(command[2]));

                            

                        }
                        break;


                    case "Drive":
                        if (command[1] == "Car")
                        {
                            allVehicles["car"].Drive(double.Parse(command[2]));
                        }
                        else if (command[1] == "Truck")
                        {
                            allVehicles["truck"].Drive(double.Parse(command[2]));

                        }
                        else
                        {
                            allVehicles["bus"].Drive(double.Parse(command[2]));
                        }
                        break;


                    case "DriveEmpty":

                        if (allVehicles["bus"] is Bus bus)
                        {
                            bus.DriveEmpty(double.Parse(command[2]));
                        }
                        break;


                }


            }


            StringBuilder result = new StringBuilder();
            foreach (var vehicle in allVehicles)
            {
                result.AppendLine($"{vehicle.Value.GetType().Name}: {vehicle.Value.FuelQuantity:f2}");
            }

            Console.WriteLine(result.ToString().Trim());


        }
    }
}
