namespace NeedForSpeed;

public class Vehicle
{

    public virtual double FuelConsumption { get; } = 1.25;
    public double Fuel { get; private set; }
    public int 	HorsePower  { get;  }


    public virtual void Drive(double kilometers)
    {
        double fuelToReduce = kilometers * FuelConsumption;
        this.Fuel -= fuelToReduce;
    }


    public Vehicle(double fuel, int horsePower)
    {
        this.Fuel = fuel;
        this.HorsePower = horsePower;
    }
}