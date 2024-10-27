using System.Text;
using System;

namespace ShoppingSpree;

public class Person
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

    private decimal money;

    public decimal Money
    {
        get { return money; }
        set
        {
            if (value < 0) throw new ArgumentException("Money cannot be negative");
            money = value;
        }
    }

    private List<Product> bagOfProducts;

    public List<Product> BagOfProducts //tuka moje i da ne e public mai4e
    {
        get { return bagOfProducts; }
        set { bagOfProducts = value; }
    }

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        BagOfProducts = new List<Product>();
    }

    public bool TryPurchase(Product product)
    {
        if (this.Money >= product.Cost)
        {
            this.Money -= product.Cost;
            this.bagOfProducts.Add(product);
            return true;
        }
        return false;
    }


    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        if (BagOfProducts.Count > 0)
        {
            result.Append($"{this.Name} - {string.Join(", ", this.BagOfProducts)}");
        }
        else
        {
            result.Append($"{this.Name} - Nothing bought");
        }





        return result.ToString().Trim();
    }
}