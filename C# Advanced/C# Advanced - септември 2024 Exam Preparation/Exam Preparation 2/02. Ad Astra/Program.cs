// See https://aka.ms/new-console-template for more information

using System.Reflection;
using System.Text.RegularExpressions;

string input = Console.ReadLine();   //  #Bread#19/03/21#4000#|Invalid|03/03.20||Apples|08/10/20|200||Carrots|06/08/20|500||Not right|6.8.20|5|

string pattern = @"[#](?<name>[a-zA-Z\s]+)[#](?<expirationDate>\d{2}/\d{2}/\d{2})[#](?<calories>\d{1,4})[#]|[|](?<name>[a-zA-Z\s]+)[|](?<expirationDate>\d{2}/\d{2}/\d{2})[|](?<calories>\d{1,4})[|]";

List<Items>AllItems=new List<Items>();
int totalCalories = 0;



foreach (Match match in Regex.Matches(input, pattern))
{
    
        Items currItem = new Items();

        currItem.Name = match.Groups["name"].Value;
        currItem.ExpirationDate = match.Groups["expirationDate"].Value;
        currItem.Calories = int.Parse(match.Groups["calories"].Value);
        totalCalories += int.Parse(match.Groups["calories"].Value);

        AllItems.Add(currItem);
    

  
}

int daysToLast = totalCalories / 2000;
Console.WriteLine($"You have food to last you for: {daysToLast} days!");

foreach (var item in AllItems)
{
    Console.WriteLine($"Item: {item.Name}, Best before: {item.ExpirationDate}, Nutrition: {item.Calories}");
}
class Items
{
    public string Name { get; set; }
    public string ExpirationDate { get; set; }
    public int Calories { get; set; }

}

