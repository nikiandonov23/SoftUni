namespace _7._Raw_Data;

public class Tires
{

	private int age;
	public int Age
	{
		get { return age; }
		set { age = value; }
	}



	private double pressure;
	public double Pressure
	{
		get { return pressure; }
		set { pressure = value; }
	}




    public Tires( double pressure, int age)
    {
        this.age = age;
        this.pressure = pressure;
    }
}