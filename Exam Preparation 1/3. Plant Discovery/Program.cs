// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());

List<Plant> allPlants = new List<Plant>();
for (int i = 0; i < n; i++)
{
    List<string> input = Console.ReadLine()
        .Split("<->")
        .ToList();

    Plant currentPlant = new Plant();
    currentPlant.Name = input[0];
    currentPlant.Rarity = int.Parse(input[1]);

    allPlants.Add(currentPlant);

}

string command = "";
while ((command = Console.ReadLine()) != "Exhibition")
{
    string[] tockens = command.Split(": ");

    switch (tockens[0])
    {
        case "Rate":
            string[] actions = tockens[1].Split(" - ");
            string plantName = actions[0];
            double plantRating = double.Parse(actions[1]);


            Plant foundPlant = allPlants.Find(x => x.Name == plantName);
            if (foundPlant != null)
            {
                foreach (var plant in allPlants)
                {

                    if (plant.Name == plantName)
                    {
                        plant.Rating += plantRating;
                        plant.RatingCounter++;
                    }
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            
            break;


        case "Update":
            actions = tockens[1].Split(" - ");
            plantName = actions[0];
            string newRarity = actions[1];

             foundPlant = allPlants.Find(x => x.Name == plantName);
            if (foundPlant != null)
            {
                foreach (var plant in allPlants)
                {
                    if (plant.Name == plantName)
                    {
                        plant.Rarity = int.Parse(newRarity);
                    }
                }
            }
            else
            {
                Console.WriteLine("error");
            }


            break;


        case "Reset":
            actions = tockens[1].Split(" - ");
            plantName = actions[0];



            foundPlant = allPlants.Find(x => x.Name == plantName);
            if (foundPlant != null)
            {

                foreach (var plant in allPlants)
                {
                    if (plant.Name == plantName)
                    {
                        plant.Rating = 0;
                        plant.RatingCounter = 0;

                    }


                }
            }
            else
            {
                Console.WriteLine("error");
            }


            break;
    }
}

Console.WriteLine("Plants for the exhibition:");
foreach (var plant in allPlants)
{
    Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {plant.Avarage():f2}");
}


class Plant
{
    public string Name { get; set; }
    public int Rarity { get; set; }
    public double Rating { get; set; }     //sumira vsi4ki reitinzi
    public int RatingCounter { get; set; }   //broi kolko puti e davan reiting za da moga da namerq avarage rating

    public double Avarage()
    {
        double avarage = Rating / RatingCounter;

        if (Rating==0)
        {
            return 0;
        }
        else
        {
            return avarage;
        }
    }
}

