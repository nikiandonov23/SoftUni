// See https://aka.ms/new-console-template for more information

using System;
using System.Text.RegularExpressions;




List<Furniture> furnitures=new List<Furniture>();
string pattern = @"\>+\>+([A-Za-z]+)\<+\<+(\d+.\d+|\d+)+\!+(\d+)";

decimal totalSum = 0;
string command = "";
while ((command = Console.ReadLine()) != "Purchase")
{
    foreach (Match match in Regex.Matches(command, pattern))
    {

        Furniture furniture=new Furniture();      //suzdavame nov obekt ot tip Furniture

        furniture.Name=match.Groups[1].Value;
        furniture.Price = decimal.Parse(match.Groups[2].Value);
        furniture.Quantity = int.Parse(match.Groups[3].Value);

        furnitures.Add(furniture);    //pulnim dadeniq obekt ot tip Furniture vuv lista s obekti furnitures


    }
}


Console.WriteLine("Bought furniture:");
foreach (var furniture in furnitures)
{
    totalSum += furniture.Total();
    Console.WriteLine(furniture.Name);
}
Console.WriteLine($"Total money spend: {totalSum:f2}");

class Furniture
{
    public string Name;
    public decimal Price;
    public int Quantity;

    public decimal Total()
    {
        return Price * Quantity;
    }

}










