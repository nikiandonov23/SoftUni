// See https://aka.ms/new-console-template for more information



List<City> allCities = new List<City>();
string input = "";
while ((input = Console.ReadLine()) != "Sail")
{
    string[] tockens = input.Split("||");
    City currentCity = new City();

    bool isItContains = false;
    foreach (var city in allCities)
    {
        if (city.Name == tockens[0])
        {
            isItContains = true;
        }
    }

    if (!isItContains)
    {
        currentCity.Name = tockens[0];
        currentCity.Citizens = int.Parse(tockens[1]);
        currentCity.Gold = int.Parse(tockens[2]);

        allCities.Add(currentCity);
        
    }

    else
    {
        foreach (var city in allCities)
        {
            if (city.Name == tockens[0])
            {
                city.Citizens+= int.Parse(tockens[1]);
                city.Gold+= int.Parse(tockens[2]);
                
            }
        }
    }


    
}

string command = "";
while ((command = Console.ReadLine()) != "End")
{
    string[] tockens = command.Split("=>");
    string action = tockens[0];
    string townName=tockens[1];

    switch (action)
    {
        case "Plunder":
            int peopleKilled=int.Parse(tockens[2]);
            int goldStolen=int.Parse(tockens[3]);

            foreach (var city in allCities)
            {
                if (city.Name==townName)
                {
                    Console.WriteLine($"{townName} plundered! {goldStolen} gold stolen, {peopleKilled} citizens killed.");
                    city.Citizens -= peopleKilled;
                    city.Gold-= goldStolen;
                    if (city.Citizens<=0||city.Gold<=0)
                    {
                        Console.WriteLine($"{townName} has been wiped off the map!");
                        allCities.Remove(city);
                        break;
                    }
                }
            }
            break;




        case "Prosper":
            int goldTobeAdded=int.Parse(tockens[2]);
            if (goldTobeAdded<0)
            {
                Console.WriteLine($"Gold added cannot be a negative number!");
                continue;
            }
            else
            {
                foreach (var city in allCities)
                {
                    if (city.Name==townName)
                    {
                        city.Gold += goldTobeAdded;
                        Console.WriteLine($"{goldTobeAdded} gold added to the city treasury. {city.Name} now has {city.Gold} gold.");
                    }
                }
            }

            break;
    }
}

if (allCities.Count>0)
{
    Console.WriteLine($"Ahoy, Captain! There are {allCities.Count} wealthy settlements to go to:");
    foreach (var city in allCities)
    {
        Console.WriteLine($"{city.Name} -> Population: {city.Citizens} citizens, Gold: {city.Gold} kg");
    }
}
else
{
    Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
}




class City
{
    public string Name { get; set; }
    public int Citizens { get; set; }
    public int Gold { get; set; }
}