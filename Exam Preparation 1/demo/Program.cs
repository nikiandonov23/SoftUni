// See https://aka.ms/new-console-template for more information


using System.Text.RegularExpressions;
using System.Xml.Linq;


List<Item> allitems = new List<Item>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string[] tockens = input.Split("|");

    string piece = tockens[0];
    string composer = tockens[1];
    string key = tockens[2];
    Item currentItem = new Item();

    currentItem.Name = piece;
    currentItem.Composer = composer;
    currentItem.Key = key;

    allitems.Add(currentItem);

}

string command = "";
while ((command = Console.ReadLine()) != "Stop")
{
    string[] tockens = command.Split("|");
    string action = tockens[0];
    string piece = tockens[1];

    switch (action)
    {
        case "Add":
            string composer = tockens[2];
            string key = tockens[3];
            Item currItem = new Item();
            currItem.Name = piece;
            currItem.Composer = composer;
            currItem.Key = key;

            Item pieceToUpdate = allitems.FirstOrDefault(x => x.Name == piece);
            if (pieceToUpdate != null)
            {
                Console.WriteLine($"{piece} is already in the collection!");
                break;
            }
            else
            {

                allitems.Add(currItem);
                Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                break;
            }

            break;


        case "Remove":
            piece = tockens[1];
            Item toBeChecked = allitems.FirstOrDefault(x => x.Name == piece);

            if (toBeChecked != null)
            {
                Console.WriteLine($"Successfully removed {piece}!");
                allitems.Remove(toBeChecked);

            }

            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }

            break;


        case "ChangeKey":
            piece = tockens[1];
            string newKey = tockens[2];

            toBeChecked = allitems.FirstOrDefault(x => x.Name == piece);
            if (toBeChecked!=null)
            {
                toBeChecked.Key=newKey;

                Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                break;
            }
            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                break;
            }
            break;
    }
}

foreach (var piece in allitems)
{
    Console.WriteLine($"{piece.Name} -> Composer: {piece.Composer}, Key: {piece.Key}");
}

class Item
{
    public string Name { get; set; }
    public string Composer { get; set; }
    public string Key { get; set; }
}
