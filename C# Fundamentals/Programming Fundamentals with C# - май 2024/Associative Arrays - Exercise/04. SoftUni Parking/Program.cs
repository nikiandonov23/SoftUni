// See https://aka.ms/new-console-template for more information


int n = int.Parse(Console.ReadLine());

Dictionary<string, string> allUsers = new Dictionary<string, string>();

string input = "";
for (int i = 0; i < n; i++)
{
    input=Console.ReadLine();
    string[] tockens = input.Split(" ");

    string command = tockens[0];
    

    switch (command)
    {
        case "register":
            string user = tockens[1];
            string regPlate= tockens[2];

            if (!allUsers.ContainsKey(user))          //ako usera go nqma v allUsers
            {
                allUsers.Add(user, regPlate);
                Console.WriteLine($"{user} registered {regPlate} successfully");
            }
            else if (allUsers.ContainsKey(user) && allUsers[user]==regPlate)
            {
                Console.WriteLine($"ERROR: already registered with plate number {allUsers[user]}");
            }

            break;


        case "unregister":
            user = tockens[1];

            if (!allUsers.ContainsKey(user))
            {
                Console.WriteLine($"ERROR: user {user} not found");
            }
            else
            {
                    allUsers.Remove(user);
                    Console.WriteLine($"{user} unregistered successfully");
            }


            break;
    }

}

foreach (var element in allUsers)
{
    Console.WriteLine($"{element.Key} => {element.Value}");
}
