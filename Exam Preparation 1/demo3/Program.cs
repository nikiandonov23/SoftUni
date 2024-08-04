// See https://aka.ms/new-console-template for more information


string input = "";
List<Plant> allPlants = new List<Plant>();
Dictionary<string, int> allSections = new Dictionary<string, int>();   //pazq sekciite s jadni razteniq i vodata

while ((input = Console.ReadLine()) != "EndDay")
{
    string[] commands = input.Split(": ");
    string command = commands[0];
    string theRestOfTheCommand = commands[1];

    if (command == "Plant")
    {
        string[] tockens = theRestOfTheCommand.Split("-");
        string plantName = tockens[0];
        int waterNeeded = int.Parse(tockens[1]);
        string section = tockens[2];

        Plant currentPlant = new Plant();
        currentPlant.Name = plantName;
        currentPlant.WaterNeeded = waterNeeded;
        currentPlant.Section = section;

        Plant plantToUpdate = allPlants.FirstOrDefault(x => x.Name == plantName);   
        if (plantToUpdate != null)
        {
            foreach (var plant in allPlants)
            {
                if (plant.Name == plantName)
                {
                    plant.WaterNeeded += waterNeeded;
                    break;
                }
            }

            continue;
        }
        else
        {
            allPlants.Add(currentPlant);
            if (allSections.ContainsKey(section))
            {
                allSections[section]++;
            }
            else
            {
                allSections[section] = 1;
            }
            continue;
        }




    }

    else if (command == "Water")
    {

        string[] tockens = theRestOfTheCommand.Split("-");
        string plantName = tockens[0];
        int water = int.Parse(tockens[1]);

        Plant plantToBeChecked = allPlants.FirstOrDefault(x => x.Name == plantName);

        if (plantToBeChecked != null)
        {
            foreach (var plant in allPlants)
            {
                if (plant.Name == plantName)
                {
                    plant.WaterNeeded -= water;
                    if (plant.WaterNeeded <= 0)
                    {
                        Console.WriteLine($"{plantName} has been sufficiently watered.");
                        allPlants.Remove(plant);



                        allSections[plant.Section]--;               //namalqvame s 1      
                        if (allSections[plant.Section] == 0)    //ako stane 0 napravo q maham 
                        {
                            allSections.Remove(plant.Section);
                        }


                        break;
                    }
                }
            }
        }
        else
        {
            continue;
        }

    }
}

Console.WriteLine("Plants needing water:");
foreach (var plant in allPlants)
{
    Console.WriteLine($" {plant.Name} -> {plant.WaterNeeded}ml left");
}

Console.WriteLine("Sections with thirsty plants:");
foreach (var section in allSections)
{
    Console.WriteLine($" {section.Key}: {section.Value}");
}

class Plant
{
    public string Name { get; set; }
    public int WaterNeeded { get; set; }
    public string Section { get; set; }
}