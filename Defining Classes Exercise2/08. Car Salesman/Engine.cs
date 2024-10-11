namespace _08._Car_Salesman;

public class Engine
{
    private string engineModel;

    public string EngineModel
    {
        get { return engineModel; }
        set { engineModel = value; }
    }

    
    private int power;
    public int Power
    {
        get { return power; }
        set { power = value; }
    }

    private int? displacement;
    public int? Displacement
    {
        get { return displacement; }
        set { displacement = value; }
    }

    private string? efficiency;
    public string? Efficiency
    {
        get { return efficiency; }
        set { efficiency = value; }
    }


    public Engine(string enginemodel, int power, int? displacement, string? efficiency)
    {
        this.engineModel = enginemodel;
        this.power = power;
        this.displacement = displacement;
        this.efficiency = efficiency;
    }
}