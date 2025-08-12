// See https://aka.ms/new-console-template for more information



int n = int.Parse(Console.ReadLine());
List<Hero> allHeroes = new List<Hero>();
for (int i = 0; i < n; i++)
{
    List<string> input = Console.ReadLine()
        .Split(" ")
        .ToList();

    Hero currentHero = new Hero();
    currentHero.Name = input[0];
    currentHero.HP=int.Parse(input[1]);
    currentHero.MP=int.Parse(input[2]);

    allHeroes.Add(currentHero);



}

string command = "";
while ((command = Console.ReadLine()) != "End")
{
    string[] tockens = command.Split(" - ");
    string action = tockens[0];
    string heroName = tockens[1];

    switch (action)
    {
        case "CastSpell":
            int mpNeeded = int.Parse(tockens[2]);
            string spellName= tockens[3];


            foreach (var hero in allHeroes)
            {
                if (hero.Name==heroName)
                {
                    if (hero.MP>=mpNeeded)
                    {
                        hero.MP -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {hero.MP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
            }
            break;


        case "TakeDamage":
            int damage= int.Parse(tockens[2]);
            string attacker= tockens[3];

            foreach (var hero in allHeroes)
            {
                if (hero.Name==heroName)
                {
                    hero.HP -= damage;
                    if (hero.HP>0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {hero.HP} HP left!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        allHeroes.Remove(hero);
                        break;
                    }
                }
            }
            break;


        case "Recharge":
            int amount= int.Parse(tockens[2]);

            foreach (var hero in allHeroes)
            {
                if (hero.Name==heroName)
                {
                    int difference = 0;
                    if (hero.MP+amount>200)
                    {
                        difference =  (hero.MP + amount)-200;
                        Console.WriteLine($"{heroName} recharged for {amount-difference} MP!");
                        hero.MP = 200;
                        break;
                    }
                    else
                    {
                        hero.MP+=amount;
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                        break;
                    }
                }
            }
            break;


        case "Heal":
            amount = int.Parse(tockens[2]);

            foreach (var hero in allHeroes)
            {
                if (hero.Name==heroName)
                {
                    int diffrence = 0;

                    if (hero.HP+amount>100)
                    {
                        diffrence= (hero.HP+amount)-100;
                        Console.WriteLine($"{heroName} healed for {amount-diffrence} HP!");
                        hero.HP = 100;
                        break;
                    }
                    else
                    {
                        hero.HP += amount;
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                        break;
                    }
                }
            }
            break;
    }
}

foreach (var hero in allHeroes)
{
    Console.WriteLine($"{hero.Name}");
    Console.WriteLine($"  HP: {hero.HP}");
    Console.WriteLine($"  MP: {hero.MP}");
}

class Hero
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int MP { get; set; }
}