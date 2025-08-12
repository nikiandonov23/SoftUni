namespace _7._Raw_Data;

public class Cargo
{
	private string type;

	public string Type
	{
		get { return type; }
		set { type = value; }
	}
	private int weight;

	public int Weight
	{
		get { return weight; }
		set { weight = value; }
	}




    public Cargo(string type, int weight)
    {
        this.type = type;
        this.weight = weight;
    }
}