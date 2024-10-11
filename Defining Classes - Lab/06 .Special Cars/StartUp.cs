using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main()
        {
            List<Tire[]> allTires = new List<Tire[]>();

            List<Engine> allEngines = new List<Engine>();


            List<Car> allCars = new List<Car>();

            string input = "";
            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] tockens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();



                Tire currentTire1 = new Tire(int.Parse(tockens[0]), double.Parse(tockens[1]));
                Tire currentTire2 = new Tire(int.Parse(tockens[2]), double.Parse(tockens[3]));
                Tire currentTire3 = new Tire(int.Parse(tockens[4]), double.Parse(tockens[5]));
                Tire currentTire4 = new Tire(int.Parse(tockens[6]), double.Parse(tockens[7]));


                Tire[] allLineTires = new Tire[4];

                allLineTires[0] = (currentTire1);
                allLineTires[1] = (currentTire2);
                allLineTires[2] = (currentTire3);
                allLineTires[3] = (currentTire4);

                allTires.Add(allLineTires);


            }



            input = "";
            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] tockens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                Engine currentEngine = new Engine(int.Parse(tockens[0]), double.Parse(tockens[1]));
                allEngines.Add(currentEngine);


            }

            input = "";
            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] tockens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string make = tockens[0];
                string model = tockens[1];
                int year = int.Parse(tockens[2]);
                double fuelQuantity = double.Parse(tockens[3]);
                double fuelConsumptuion = double.Parse(tockens[4]);
                int engineIndex = int.Parse(tockens[5]);
                int tireIndex = int.Parse(tockens[6]);


                Car currentCar = new Car(make, model, year, fuelQuantity, fuelConsumptuion, allEngines[engineIndex],
                    allTires[tireIndex]);
                allCars.Add(currentCar);

            }



            foreach (var car in allCars)
            {
                double tirePressureSum = car.Tires.Sum(x => x.Pressure);

                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && tirePressureSum >= 9 && tirePressureSum <= 10)
                {
                    car.Drive(20);
                    StringBuilder result = new StringBuilder();
                    result.AppendLine($"Make: {car.Make}");
                    result.AppendLine($"Model: {car.Model}");
                    result.AppendLine($"Year: {car.Year}");
                    result.AppendLine($"HorsePowers: {car.Engine.HorsePower}");
                    result.AppendLine($"FuelQuantity: {car.FuelQuantity}");
                    Console.WriteLine(result.ToString().Trim());
                }
            }


        }

    }
}