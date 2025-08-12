// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());
string input = "";

List<Teams> allTeams = new List<Teams>();

for (int i = 0; i < n; i++)
{
    input = Console.ReadLine();
    string[] tokens = input.Split("-");
    string creator = tokens[0];
    string teamName = tokens[1];

    Teams foundCreator = allTeams.Find(x => x.Creator == creator);
    Teams foundTeam = allTeams.Find(x => x.TeamName == teamName);

    if (foundCreator != null)
    {
        Console.WriteLine($"{creator} cannot create another team!");
    }
    else if (foundTeam != null)
    {
        Console.WriteLine($"Team {teamName} was already created!");
    }
    else
    {
        Teams currentTeam = new Teams
        {
            Creator = creator,
            TeamName = teamName
        };
        allTeams.Add(currentTeam);
        Console.WriteLine($"Team {teamName} has been created by {creator}!");
    }
}

while ((input = Console.ReadLine()) != "end of assignment")
{
    string[] tokens = input.Split("->");
    string member = tokens[0];
    string team = tokens[1];

    Teams foundTeam = allTeams.Find(x => x.TeamName == team);
    Teams memberIsFound = allTeams.Find(t => t.Members.Contains(member) || t.Creator == member);

    if (foundTeam == null)
    {
        Console.WriteLine($"Team {team} does not exist!");
    }
    else if (memberIsFound != null)
    {
        Console.WriteLine($"Member {member} cannot join team {team}!");
    }
    else
    {
        foundTeam.Members.Add(member);
    }
}


List<Teams> disbandedTeams = allTeams
    .Where(t => t.Members.Count == 0)
    .OrderBy(t => t.TeamName)
    .ToList();






List<Teams> validTeams = allTeams
    .Where(t => t.Members.Count > 0)
    .OrderByDescending(t => t.Members.Count)
    .ThenBy(t => t.TeamName)
    .ToList();


foreach (var team in validTeams)
{
    team.Print();
}

Console.WriteLine("Teams to disband:");
foreach (var team in disbandedTeams)
{
    Console.WriteLine(team.TeamName);
}

class Teams
{
    public string TeamName { get; set; }
    public string Creator { get; set; }
    public List<string> Members { get; set; } = new List<string>();

    public void Print()
    {
        Console.WriteLine(TeamName);
        Console.WriteLine($"- {Creator}");
        foreach (var member in Members.OrderBy(m => m))
        {
            Console.WriteLine($"-- {member}");
        }
    }
}