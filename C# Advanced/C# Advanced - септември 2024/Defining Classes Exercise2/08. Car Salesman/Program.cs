// See https://aka.ms/new-console-template for more information


using System.Text;
using _08._Car_Salesman;
List<Engine> allEngines = new List<Engine>();




int n = int.Parse(Console.ReadLine());
string input = "";
for (int i = 0; i < n; i++)
{
    input = Console.ReadLine();
    string[] tockens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    string engineModel = "";
    int enginePower = 0;

    int? engineDisplacement = null;
    string? engineEfficiency = null;


    if (tockens.Length == 2)   //ako imame samo 2 parametura
    {
        engineModel = tockens[0];
        enginePower = int.Parse(tockens[1]);
    }
    else if (tockens.Length == 3)   //ako imame 3 parametyra trqbva da proverim 3tiq kakuv shte bude
    {
        if (int.TryParse(tockens[2], out int result))   //na4i  parametura e displacement
        {
            engineModel = tockens[0];
            enginePower = int.Parse(tockens[1]);
            engineDisplacement = int.Parse(tockens[2]);
        }
        else
        {
            engineModel = tockens[0];
            enginePower = int.Parse(tockens[1]);
            engineEfficiency = tockens[2];
        }
    }

    else if (tockens.Length == 4)   //ako imame 4 parametura
    {
        engineModel = tockens[0];
        enginePower = int.Parse(tockens[1]);
        engineDisplacement = int.Parse(tockens[2]);
        engineEfficiency = tockens[3];

    }



    Engine currentEngine = new Engine(engineModel, enginePower, engineDisplacement, engineEfficiency);
    allEngines.Add(currentEngine);
}


List<Car> allCars = new List<Car>();



int m = int.Parse(Console.ReadLine());
input = "";
for (int i = 0; i < m; i++)
{
    input = Console.ReadLine();
    string[] tockens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    string carModel = "";
    string engineModel = "";
    int? carWeight = null;
    string? carColor = null;


    if (tockens.Length == 2)    //ako imame samo 2 parametura
    {
        carModel = tockens[0];
        engineModel = tockens[1];
    }

    else if (tockens.Length == 3)
    {
        if (int.TryParse(tockens[2], out int result))
        {
            carModel = tockens[0];
            engineModel = tockens[1];
            carWeight = int.Parse(tockens[2]);
        }
        else
        {
            carModel = tockens[0];
            engineModel = tockens[1];
            carColor = tockens[2];
        }


    }
    else if (tockens.Length == 4)
    {

        carModel = tockens[0];
        engineModel = tockens[1];
        carWeight = int.Parse(tockens[2]);
        carColor = tockens[3];
    }

    Engine engineToBePuted = allEngines.Where(engine => engine.EngineModel == engineModel).FirstOrDefault();

    Car currentCar = new Car(carModel, engineToBePuted, carWeight, carColor);
    allCars.Add(currentCar);
}

foreach (var car in allCars)
{

    StringBuilder result = new StringBuilder();
    result.AppendLine($"{car.Model}:");
    result.AppendLine($"  {car.Engine.EngineModel}:");
    result.AppendLine($"    Power: {car.Engine.Power}");
    result.AppendLine($"    Displacement: {car.Engine.Displacement?.ToString() ?? "n/a"}");
    result.AppendLine($"    Efficiency: {car.Engine.Efficiency?.ToString() ?? "n/a"}");
    result.AppendLine($"  Weight: {car.Weight?.ToString() ?? "n/a"}");
    result.AppendLine($"  Color: {car.Color?.ToString() ?? "n/a"}");



    Console.WriteLine(result.ToString().Trim());
}
