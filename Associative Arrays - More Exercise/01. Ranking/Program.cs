// See https://aka.ms/new-console-template for more information


using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

List<string> passwoList = new List<string>();

SortedDictionary<string, Dictionary<string, int>> allUsers = new SortedDictionary<string, Dictionary<string, int>>();  //pazi TANya        C# FUNDAMENALS(key)    350(value)

string input = "";
while ((input = Console.ReadLine()) != "end of contests")
{
    string[] tockens = input.Split(":");

    passwoList.Add(tockens[0] + tockens[1]);

}

input = "";
while ((input = Console.ReadLine()) != "end of submissions")
{
    string[] tockens = input.Split("=>");
    string course = tockens[0];
    string password = tockens[0] + tockens[1];
    string name = tockens[2];
    string points = tockens[3];

    Dictionary<string, int> toAdd = new Dictionary<string, int>();
    toAdd.Add(course, int.Parse(points));

    if (passwoList.Contains(password))
    {


        if (allUsers.ContainsKey(name))         //Ako Tanya e ve4e v spisaka
        {
            if (allUsers[name].ContainsKey(course))
            {

                if (allUsers[name][course] < int.Parse(points))
                {
                    allUsers[name][course] = int.Parse(points);
                }
                else
                {
                    continue;
                }

            }
            else
            {

                allUsers[name].Add(course, int.Parse(points));

            }


        }


        else if (!allUsers.ContainsKey(name))    //Ako Tanya q nqma v allUsers
        {

            allUsers.Add(name, toAdd);         //dobavqme name-Tanya i Dictionary<string course,int=points>

        }




    }



}

int bestPoints = 0;
string bestUser = "";

foreach (var user in allUsers)
{

    int tempPoints = 0;

    foreach (var element in user.Value)
    {
        tempPoints += element.Value;
    }

    if (tempPoints > bestPoints)
    {
        bestPoints = tempPoints;
        bestUser = user.Key;
    }
}



Console.WriteLine($"Best candidate is {bestUser} with total {bestPoints} points.");
Console.WriteLine("Ranking:");

foreach (var user in allUsers)
{
    Console.WriteLine($"{user.Key}");

    foreach (var element in user.Value.OrderByDescending(x => x.Value))
    {
        Console.WriteLine($"#  {element.Key} -> {element.Value}");
    }
}





