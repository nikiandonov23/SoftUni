// See https://aka.ms/new-console-template for more information


using System;
using System.Text.RegularExpressions;



double totalPrice = 0;
List<FurnitureData> allFurnitures = new List<FurnitureData>();
string pattern = @"\>\>+([A-Za-z]+)\<\<(\d+\.\d+|\d+)\!(\d+)";
string input = "";
while ((input = Console.ReadLine()) != "Purchase")
{

    foreach (Match match in Regex.Matches(input, pattern))
    {
        FurnitureData currentFurniture = new FurnitureData();

        currentFurniture.Name = match.Groups[1].Value;
        currentFurniture.Price = double.Parse(match.Groups[2].Value);
        currentFurniture.Quantity = int.Parse(match.Groups[3].Value);

        allFurnitures.Add(currentFurniture);

    }

}

Console.WriteLine("Bought furniture:");

foreach (var furniture in allFurnitures)
{
    totalPrice += furniture.CalculatePrice();
    Console.WriteLine(furniture.Name);
}

Console.WriteLine($"Total money spend: {totalPrice:f2}");



class FurnitureData
{
    public string Name;
    public double Price;
    public int Quantity;


    public double CalculatePrice()
    {
        return Price * Quantity;
    }

}