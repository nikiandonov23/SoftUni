// See https://aka.ms/new-console-template for more information

//  custumer name
//  product
//  count
//  price


using System.Text.RegularExpressions;

List<Product> allProducts = new List<Product>();

string pattern = @"%(?<name>[A-Z][a-z]+)%.*?<(?<product>\w+)>.*?\|(?<count>\d+)\|(?<price>\d+(\.\d+)?)\$";

string input = "";
while ((input = Console.ReadLine()) != "end of shift")
{

    Product currentProduct = new Product();


    foreach (Match match in Regex.Matches(input, pattern))
    {
       
        
            currentProduct.Name = match.Groups["name"].Value;
            currentProduct.Productt = match.Groups["product"].Value;
            currentProduct.Count = int.Parse(match.Groups["count"].Value);
            currentProduct.Price = double.Parse(match.Groups["price"].Value);

            allProducts.Add(currentProduct);
        


    }

}

foreach (var product in allProducts)
{
    Console.WriteLine($"{product.Name}: {product.Productt} - {product.totalPrice():f2}");
}

double finalPrice = 0;
foreach (var product in allProducts)
{
    finalPrice += product.totalPrice();
}

Console.WriteLine($"Total income: {finalPrice:f2}");


class Product
{
    public string Name { get; set; }
    public string Productt { get; set; }
    public int Count { get; set; }
    public double Price { get; set; }

    public double totalPrice()
    {
        return Price * Count;
    }

}