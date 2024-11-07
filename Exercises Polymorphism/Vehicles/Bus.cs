namespace Vehicles;

public class Bus:Vehicle,IDriveEmpty
{

    protected override double increse => 1.4;
    

    public Bus(double fuelQuantity, double consumption, double tankCapacity) : base(fuelQuantity, consumption, tankCapacity)
    {
    }

    public  void DriveEmpty(double distance)
    {
       
       double fuelNeeded = distance * (this.Consumption );

       if (this.FuelQuantity - fuelNeeded > 0)
       {
           this.FuelQuantity -= fuelNeeded;
           Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
       }
       else
       {
           Console.WriteLine($"{this.GetType().Name} needs refueling");
       }
    }


 
}