// See https://aka.ms/new-console-template for more information




using System;


List<Box> allBoxes = new List<Box>();

string input = "";
while ((input = Console.ReadLine()) != "end")
{
    string[] tockens = input.Split(" ");
    string serialNum = tockens[0];
    string name = tockens[1];
    double quantity = double.Parse(tockens[2]);
    double price = double.Parse(tockens[3]);

    Box newBox = new Box();
    Item newItem = new Item();

    newItem.Name = name;
    newItem.Price = price;
    newBox.SerialNum = serialNum;
    newBox.Quantity = quantity;

    newBox.Item = newItem;         //zaduljitelno kazvam na newBox 4e parametara Item e raven na drugiq klas !!1

    allBoxes.Add(newBox);

}


allBoxes.Sort((b1, b2) => b2.PriceForBox.CompareTo(b1.PriceForBox));


foreach (var kutiq in allBoxes)
{
    Console.WriteLine($"{kutiq.SerialNum}");
    Console.WriteLine($"-- {kutiq.Item.Name} - ${kutiq.Item.Price:f2}: {kutiq.Quantity}");
    Console.WriteLine($"-- ${kutiq.PriceForBox:f2}");
}


class Box
{
    public Item Item = new Item();

    public string SerialNum { get; set; }
    public double Quantity { get; set; }
    public double PriceForBox => Quantity * Item.Price;     //dostupvam cenata ot obekta vuv drugiq klas


}

class Item
{
    public string Name { get; set; }
    public double Price { get; set; }


}