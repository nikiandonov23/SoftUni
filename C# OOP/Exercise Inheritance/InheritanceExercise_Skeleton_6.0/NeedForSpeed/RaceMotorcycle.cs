namespace NeedForSpeed;

public class RaceMotorcycle:Motorcycle
{
    public override double FuelConsumption  => 8;

    public RaceMotorcycle(double fuel, int horsePower) : base(fuel, horsePower)
    {
    }
}