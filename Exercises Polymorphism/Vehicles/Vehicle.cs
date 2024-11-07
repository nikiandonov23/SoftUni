namespace Vehicles;

public abstract class Vehicle
{
    protected Vehicle( double fuelQuantity, double consumption, double tankCapacity)
    {
       
      
        TankCapacity = tankCapacity;

        FuelQuantity = fuelQuantity <= tankCapacity ? fuelQuantity : 0;

        Consumption = consumption;
    }

    public double TankCapacity { get;  }

    public double FuelQuantity { get; protected set; }
 



    public double Consumption { get; }
    protected virtual double increse { get;  }
    protected virtual double truckPenalty { get; } = 1;

   
   

    public virtual void Drive(double distance)
    {
       

        double fuelNeeded = distance * (this.Consumption + increse);

        if (this.FuelQuantity-fuelNeeded>0)
        {
            this.FuelQuantity -= fuelNeeded;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }
        else
        {
            Console.WriteLine($"{this.GetType().Name} needs refueling");
        }


       
    }

    public virtual void Refuel(double liters)
    {
        if (liters<=0)
        {
            Console.WriteLine("Fuel must be a positive number");
            return;
        }
        if (liters+FuelQuantity<=TankCapacity)
        {
            this.FuelQuantity += liters * truckPenalty;
        }
        else
        {
            Console.WriteLine($"Cannot fit {liters} fuel in the tank");
        }

    }
    

}