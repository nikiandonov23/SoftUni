// See https://aka.ms/new-console-template for more information


using System.Diagnostics.Metrics;
List<string> contestOrder = new List<string>();


Dictionary<string, Dictionary<string, int>> allContests = new Dictionary<string, Dictionary<string, int>>();  //string contest,  Dictionary<user , points>

string input = "";
while ((input = Console.ReadLine()) != "no more time")
{
    string[] tockens = input.Split(" -> ");

    string userName = tockens[0];
    string contestName = tockens[1];
    string points = tockens[2];

    if (!contestOrder.Contains(contestName))
    {
        contestOrder.Add(contestName);
    }

    Dictionary<string, int> toAdd = new Dictionary<string, int>();
    toAdd.Add(userName, int.Parse(points));

    if (!allContests.ContainsKey(contestName))         //Ako kursa go nqma v allContests
    {
        allContests.Add(contestName, toAdd);
    }
    else                                              //Ako kursa go ima v allContests
    {
        if (allContests[contestName].ContainsKey(userName))                  //check if the current user is participating in the contest and take the higher score
        {
            if (allContests[contestName][userName] < int.Parse(points))        //Ako to4nite na konkretniq user v toq contest sa < ot points
            {
                allContests[contestName][userName] = int.Parse(points);      //replace them madakafakaaaaa
            }
        }
        else                               //otherwise, just add it. 
        {
            allContests[contestName].Add(userName, int.Parse(points));  //dobavqm usera i points kum ve4e sushtestvuvasht contest
        }


    }

}

var allContestsSorted = allContests
    .OrderBy(x => contestOrder.IndexOf(x.Key))
    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

foreach (var contest in allContestsSorted)
{
    int counter = 0;
    Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
    foreach (var name in contest.Value.OrderByDescending(x => x.Value))
    {
        counter++;
        Console.WriteLine($"{counter}. {name.Key} <::> {name.Value}");

    }
}

Console.WriteLine("Individual standings:");


Dictionary<string, int> individual = new Dictionary<string, int>();

foreach (var contest in allContestsSorted)
{

    foreach (var element in contest.Value)
    {

        if (!individual.ContainsKey(element.Key))
        {
            individual.Add(element.Key, element.Value);
        }
        else
        {
            individual[element.Key] += element.Value;
        }

    }
}

var sortedDictionary = individual //sortedDictionary is new variable.namesAndAges is your old variable
    .OrderByDescending(kvp => kvp.Value)
    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);


 int count = 0;
foreach (var element in sortedDictionary)
{
    count++;

    Console.WriteLine($"{count}. {element.Key} -> {element.Value}");
}