// See https://aka.ms/new-console-template for more information

using _09._Pokemon_Trainer;

List<Trainer> allTrainers = new List<Trainer>();

string input="";
while ((input = Console.ReadLine()) != "Tournament")
{
    string[] tockens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    string trainerName = tockens[0];
    string pokemonName= tockens[1];
    string pokemonElement= tockens[2];
    int pokemonHealth = int.Parse(tockens[3]);

    Pokemon currentPockemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);


    Trainer currentTrainer = allTrainers.FirstOrDefault(trainer => trainer.TrainerName == trainerName);
    if (currentTrainer==null)
    {
        currentTrainer=new Trainer(trainerName,new List<Pokemon>());
        currentTrainer.AddPockemon(currentPockemon);
        allTrainers.Add(currentTrainer);
    }
    else
    {
            currentTrainer.AddPockemon(currentPockemon);
    }




}

 input="";
while ((input = Console.ReadLine()) != "End")
{
    string elementTobeChecked = input;
    foreach (var trainer in allTrainers)
    {

        if (trainer.PokemonList.Any(pokemon=>pokemon.Element==elementTobeChecked))
        {
            trainer.Badges += 1;
        }
        else
        {
            foreach (var pokemon in trainer.PokemonList)
            {
                pokemon.Health -= 10;
               
            }

            trainer.PokemonList.RemoveAll(heealth => heealth.Health <= 0);
        }
    }
}

allTrainers=allTrainers.OrderByDescending(badges=>badges.Badges).ToList();
foreach (var trainer in allTrainers)
{
    Console.WriteLine($"{trainer.TrainerName} {trainer.Badges} {trainer.PokemonList.Count}");
}