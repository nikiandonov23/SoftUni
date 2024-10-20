// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        
        List<string> guests = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

       
        while (true)
        {
            string input = Console.ReadLine();

            if (input == "Party!")
                break;

            string[] commandParts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string action = commandParts[0]; 
            string criteria = commandParts[1]; 
            string value = commandParts[2]; 

           
            Func<string, bool> filter = criteria switch
            {
                "StartsWith" => name => name.StartsWith(value),
                "EndsWith" => name => name.EndsWith(value),
                "Length" => name => name.Length == int.Parse(value),
                _ => null
            };

            if (action == "Remove")
            {
                guests = guests.Where(guest => !filter(guest)).ToList();
            }
            else if (action == "Double")
            {
                List<string> guestsToAdd = guests.Where(filter).ToList();
                guests.AddRange(guestsToAdd); 
            }
        }

        if (guests.Any())
        {
            Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
        }
        else
        {
            Console.WriteLine("Nobody is going to the party!");
        }
    }
}