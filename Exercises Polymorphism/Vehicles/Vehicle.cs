namespace Vehicles;

public abstract class Vehicle
{
    protected Vehicle(double fuelQuantity, double consumption)
    {
        FuelQuantity = fuelQuantity;
        Consumption = consumption;
    }

    public double FuelQuantity { get;  set; }

    public double Consumption { get; }


    public abstract void Drive(double distance);
    public abstract void Refuel(double liters);

}