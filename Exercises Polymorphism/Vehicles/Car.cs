namespace Vehicles;

public class Car : Vehicle
{
    protected override double increse => 0.9;
        protected override double truckPenalty => 1;

        public Car(double fuelQuantity, double consumption, double tankCapacity) : base(fuelQuantity, consumption, tankCapacity)
        {
        }
}