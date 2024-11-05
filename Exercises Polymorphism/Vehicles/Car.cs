namespace Vehicles;

public class Car : Vehicle
{
    private const double increse = 0.9;

    public Car(double fuelQuantity, double consumption) : base(fuelQuantity, consumption)
    {
    }

    public override void Drive(double distance)
    {
        if ((this.FuelQuantity - (distance * (this.Consumption + increse))) > 0)
        {
            this.FuelQuantity -= (distance * (this.Consumption + increse));
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }
        else
        {
            Console.WriteLine($"{this.GetType().Name} needs refueling");

        }
    }

    public override void Refuel(double liters)
    {
        this.FuelQuantity += liters;
    }
}