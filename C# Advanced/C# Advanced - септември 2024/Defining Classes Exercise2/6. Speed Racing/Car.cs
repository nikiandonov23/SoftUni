using System.Runtime.CompilerServices;

namespace _6._Speed_Racing;

public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumptionPerKilometer;
    private double travelledDistance;



    public string Model
    {
        get => model;
        set => model = value;
    }

    public double FuelAmount
    {
        get => fuelAmount;
        set => fuelAmount = value;
    }

    public double FuelConsumptionPerKilometer
    {
        get => fuelConsumptionPerKilometer;
        set => fuelConsumptionPerKilometer = value;
    }

    public double TravelledDistance
    {
        get => travelledDistance;
        set => travelledDistance = value;
    }

    public Car()
    {
        TravelledDistance = 0;
    }

    public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer) :this()
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
    }


    public void Drive(Car car,int kilometersToDrive)
    {
        double fuelNeededTodrive = kilometersToDrive * car.FuelConsumptionPerKilometer;

        if (car.FuelAmount>=fuelNeededTodrive)
        {
            car.FuelAmount -= fuelNeededTodrive;
            car.TravelledDistance += kilometersToDrive;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }

    }

}