namespace Vehicles;

public class Truck : Vehicle
{

    protected override   double increse => 1.6;
    protected override double truckPenalty => 0.95;


    public Truck(double fuelQuantity, double consumption, double tankCapacity) : base(fuelQuantity, consumption, tankCapacity)
    {
    }
}