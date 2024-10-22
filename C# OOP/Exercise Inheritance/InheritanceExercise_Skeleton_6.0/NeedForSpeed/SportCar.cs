namespace NeedForSpeed;

public class SportCar:Car
{
    public override double FuelConsumption  => 10;

    public SportCar(double fuel, int horsePower) : base(fuel, horsePower)
    {
    }
}