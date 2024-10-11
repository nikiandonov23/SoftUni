namespace _09._Pokemon_Trainer;

public class Pokemon
{
	private string pokemonName;
	public string PokemonName
	{
		get { return pokemonName; }
		set { pokemonName = value; }
	}


	private string element;
	public string Element
	{
		get { return element; }
		set { element = value; }
	}


	private int health;
	public int Health
	{
		get { return health; }
		set { health = value; }
	}


    public Pokemon(string pokemonName, string element, int health)
    {
        this.pokemonName = pokemonName;
        this.element = element;
        this.health = health;
    }
}