namespace NeedForSpeed;

public class Car:Vehicle
{
    public override double FuelConsumption => 3;

  
    public Car(double fuel, int horsePower) : base(fuel, horsePower)
    {
    }

  
}