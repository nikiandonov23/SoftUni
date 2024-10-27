namespace ShoppingSpree;

public class Product
{
    

    private string name;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentException("Name cannot be empty");
            name = value;
        }
    }


    private decimal cost;

    public decimal Cost
    {
        get { return cost; }
        set
        {
            if (value < 0) throw new ArgumentException("Money cannot be negative");
            cost = value;
        }
    }

    public Product(string name, decimal cost)
    {
        this.Name = name;
        this.Cost = cost;
    
    }

    public override string ToString()
    {
        return this.Name;
    }
}