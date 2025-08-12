// See https://aka.ms/new-console-template for more information



int n = int.Parse(Console.ReadLine());

List<string> guests=new List<string>();

for (int i = 1; i <= n; i++)
{
    string command = Console.ReadLine();
    string[] tockens = command.Split();

    if (!guests.Contains(tockens[0]))
    {
        if (tockens[2]=="going!")
        {
            guests.Add(tockens[0]);
        }

        if (tockens[2]== "not")
        {
            Console.WriteLine($"{tockens[0]} is not in the list!");
        }
    }

   else if (guests.Contains(tockens[0]))
    {
        if (tockens[2]=="going!")
        {
            Console.WriteLine($"{tockens[0]} is already in the list!");
        }

        if (tockens[2]=="not")
        {
            guests.Remove(tockens[0]);
        }
    }
  
}

for (int i = 0; i < guests.Count; i++)
{
    Console.WriteLine(guests[i]);
}

