// See https://aka.ms/new-console-template for more information


using System.Text.RegularExpressions;

List<string> input = Console.ReadLine()          //  George, Peter, Bill, Tom
    .Split(", ")
    .ToList();

Dictionary<string ,int> participants = new Dictionary<string ,int>();

string command = "";
while ((command = Console.ReadLine()) != "end of race")    // G4e@55or%6g6!68e!!@
{
    string namePattern = @"[A-Za-z]";
    string distancePattern = @"[0-9]";

    string currentName = "";
    int currentDistance = 0;

    foreach (Match match in Regex.Matches(command, namePattern))
    {
        currentName += match.Value;
    }
    foreach (Match match in Regex.Matches(command, distancePattern))
    {
        currentDistance += int.Parse(match.Value);
    }

    if (input.Contains(currentName))
    {
        if (participants.ContainsKey(currentName))
        {
            participants[currentName] += currentDistance;
        }
        else
        {
            participants.Add(currentName, currentDistance);
        }

        
    }
    


}

var sortedDictionary = participants //sortedDictionary is new variable.namesAndAges is your old variable
    .OrderByDescending(kvp => kvp.Value)
    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

int counter = 1;
foreach (var element in sortedDictionary)
{
    if (counter>3)
    {
        break;
    }
    if (counter==1)
    {
        Console.WriteLine($"1st place: {element.Key}");
        counter++;
    }
    else if (counter == 2)
    {
        Console.WriteLine($"2nd place: {element.Key}");
        counter++;

    }
    else if (counter == 3)
    {
        Console.WriteLine($"3rd place: {element.Key}");
        counter++;

    }


}