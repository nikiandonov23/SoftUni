using System.Text;

namespace CarManufacturer;

public class Car
{
    private string make;

    public string Make
    {
        get { return make; }
        set { make = value; }
    }





    private string model;
    public string Model
    {
        get { return model; }
        set { model = value; }
    }




    private int year;
    public int Year
    {
        get { return year; }
        set { year = value; }

    }



    private double fuelQuantity;
    public double FuelQuantity
    {
        get { return fuelQuantity; }
        set { fuelQuantity = value; }
    }



    private double fuelConsumption;
    public double FuelConsumption
    {
        get { return fuelConsumption; }
        set { fuelConsumption = value; }
    }

    public Car()
    {
        Make = "VW";
        Model = "Golf";
        Year = 2025;
        FuelQuantity = 200;
        FuelConsumption = 10;
    }

    public Car(string make, string model, int year) :this()
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
    }

    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) :this(make,model,year)
    {
        
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
    }




    private Engine engine;

    public Engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }

    private Tire[] tires;

    public Tire[] Tires
    {
        get { return tires; }
        set { tires = value; }
    }

    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) 
        :this(make,model,year,fuelQuantity,fuelConsumption)
    {
       
        this.Engine = engine;
        this.Tires = tires;
    }













    public void Drive(double distance)
    {
        double neededFuel = distance * this.FuelConsumption / 100;
        if (fuelQuantity - neededFuel > 0)
        {
            fuelQuantity -= neededFuel;
        }
        else
        {
            Console.WriteLine("Not enough fuel to perform this trip!");
        }
    }

    public string WhoAmI()
    {
        StringBuilder result = new StringBuilder();
        result.AppendLine($"Make: {this.Make}");
        result.AppendLine($"Model: {this.Model}");
        result.AppendLine($"Year: {this.Year}");
        result.AppendLine($"Fuel: {this.FuelQuantity:F2}");

        return result.ToString().Trim();
    }
}