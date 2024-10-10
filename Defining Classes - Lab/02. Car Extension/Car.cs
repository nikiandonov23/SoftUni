using System.Text;

namespace CarManufacturer;

public class Car
{
    private string make;
    private string model;
    private int year;
    private double fuelQuantity;
    private double fuelConsumption;



    public string Make
    {
        get { return make; }
        set { make = value; }
    }






    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public double FuelQuantity
    {
        get { return fuelQuantity; }
        set { fuelQuantity = value; }
    }

    public double FuelConsumption
    {
        get { return fuelConsumption;}
        set { fuelConsumption = value; }
    }


    public void Drive(double distance)
    {
        double neededFuelForTheDistance = distance * fuelConsumption/100;
         if (fuelQuantity-neededFuelForTheDistance<0)
         {
             Console.WriteLine("Not enough fuel to perform this trip!");
         }
         else
         {
             fuelQuantity -= neededFuelForTheDistance;
         }
    }

    public string WhoAmI()
    {
        StringBuilder result=new StringBuilder();
        result.AppendLine($"Make: {Make}");
        result.AppendLine($"Model: {Model}");
        result.AppendLine($"Year: {Year}");
        result.AppendLine($"Fuel: {FuelQuantity}");

        return result.ToString().Trim();


    }
}