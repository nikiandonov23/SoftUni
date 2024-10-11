namespace _7._Raw_Data;

public class Car
{
	private string model;

	public string Model
	{
		get { return model; }
		set { model = value; }
	}




	private Engine engine;
	public Engine Engine
	{
		get { return engine; }
		set { engine = value; }
	}



	private Cargo cargo;
	public Cargo Cargo
	{
		get { return cargo; }
		set { cargo = value; }
	}





	private List<Tires> tires;
	public List<Tires> Tires
	{
		get { return tires; }
		set { tires = value; }
	}


    public Car(string model, Engine engine, Cargo cargo, List<Tires> tires)
    {
        this.model = model;
        this.engine = engine;
        this.cargo = cargo;
        this.tires = tires;
    }
}