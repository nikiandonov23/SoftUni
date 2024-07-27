// See https://aka.ms/new-console-template for more information


using System.Runtime.InteropServices;

int n = int.Parse(Console.ReadLine());

List<Songs> allSongs = new List<Songs>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split("_").ToArray();

    string type = input[0];
    string name = input[1];
    string time = input[2];

    Songs currentSong = new Songs();

    currentSong.TypeList = type;
    currentSong.Name = name;
    currentSong.Time = time;


    allSongs.Add(currentSong);

}

string typeToPrint = Console.ReadLine();

foreach (Songs currentSong in allSongs)
{

    if (currentSong.TypeList == typeToPrint)
    {
        Console.WriteLine(currentSong.Name);
    }

}

foreach (Songs currentSong in allSongs)
{
    if (typeToPrint == "all")
    {
        Console.WriteLine(currentSong.Name);
    }

}

class Songs
{
    public string TypeList { get; set; }

    public string Name { get; set; }

    public string Time { get; set; }





}