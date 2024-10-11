namespace _08._Car_Salesman;

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

    
    private int? weight;
    public int? Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    
    private string? color;
    public string? Color
    {
        get { return color; }
        set { color = value; }
    }


    public Car(string model, Engine engine, int? weight, string? color)
    {
        this.model = model;
        this.engine = engine;
        this.weight = weight;
        this.color = color;
    }
}