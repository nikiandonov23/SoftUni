namespace _09._Pokemon_Trainer;

public class Trainer
{
	private string trainerName;

	public string TrainerName
	{
		get { return trainerName; }
		set { trainerName = value; }
	}

	private int badges;

	public int Badges
	{
		get { return badges; }
		set { badges = value; }
	}

	private List<Pokemon> pokemonList;

	public List<Pokemon> PokemonList
	{
		get { return pokemonList; }
		set { pokemonList = value; }
	}

    public Trainer()
    {
		pokemonList = new List<Pokemon>();
        badges = 0;

    }

    public Trainer(string trainerName, List<Pokemon> pokemonList) : this()
    {
        this.trainerName = trainerName;
        this.pokemonList = pokemonList;
    }

 


    public void AddPockemon(Pokemon pokemon)
    {
		pokemonList.Add(pokemon);
    }
}