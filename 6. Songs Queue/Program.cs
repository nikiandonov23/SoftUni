// See https://aka.ms/new-console-template for more information

List<string> input=Console.ReadLine()
    .Split(", ")
    .ToList();

Queue<string> allSongs=new Queue<string>(input);

string command = "";
while (allSongs.Count>0)
{
    command=Console.ReadLine();
    string[] tockens = command.Split(" ");
    string action = tockens[0];
    

    switch (action)
    {
        case"Play":
            allSongs.Dequeue();
            break;

        case "Add":
            string currentSong = command.Substring(4);
            if (allSongs.Contains(currentSong))
            {
                Console.WriteLine($"{currentSong} is already contained!");
            }
            else
            {
                    allSongs.Enqueue(currentSong);
            }
            break;

        case "Show":
            Console.WriteLine(string.Join(", ",allSongs));
            break;

        
    }

}

if (allSongs.Count==0)
{
    Console.WriteLine("No more songs!");
}
