// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

List<string> contestOrder = new List<string>();

Dictionary<string, Dictionary<string, int>> allContests = new Dictionary<string, Dictionary<string, int>>();  //string contest,  Dictionary<user , points>

string input = "";
while ((input = Console.ReadLine()) != "no more time")
{
    string[] tokens = input.Split(" -> ");

    string userName = tokens[0];
    string contestName = tokens[1];
    int points = int.Parse(tokens[2]);

    if (!contestOrder.Contains(contestName))
    {
        contestOrder.Add(contestName);
    }

    if (!allContests.ContainsKey(contestName))        
    {
        allContests[contestName] = new Dictionary<string, int>();
    }

    if (allContests[contestName].ContainsKey(userName)) 
    {
        if (allContests[contestName][userName] < points)
        {
            allContests[contestName][userName] = points; 
        }
    }
    else 
    {
        allContests[contestName].Add(userName, points);  
    }
}

var allContestsSorted = allContests
    .OrderBy(x => contestOrder.IndexOf(x.Key))
    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

foreach (var contest in allContestsSorted)
{
    int counter = 0;
    Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
    foreach (var name in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
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

var sortedDictionary = individual
    .OrderByDescending(kvp => kvp.Value)
    .ThenBy(kvp => kvp.Key)
    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

int count = 0;
foreach (var element in sortedDictionary)
{
    count++;
    Console.WriteLine($"{count}. {element.Key} -> {element.Value}");
}
