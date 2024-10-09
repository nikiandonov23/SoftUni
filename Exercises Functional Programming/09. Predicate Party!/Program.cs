// See https://aka.ms/new-console-template for more information

List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();



string command = "";
while ((command = Console.ReadLine()) != "Party!")
{
    string[] tockens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string action = tockens[0];
    string criteria = tockens[1];
    string argument = tockens[2];

    Predicate<string> predicate = null;
    if (action == "Remove")
    {
        if (criteria == "StartsWith")
        {
            predicate = names => names.StartsWith(argument);
            names.RemoveAll(predicate);

        }
        else if (criteria == "EndsWith")
        {
            predicate=names => names.EndsWith(argument);
            names.RemoveAll(predicate);
        }
    }



    else if (action == "Double")
    {
        if (criteria == "StartsWith")
        {
         
        }
        else if (criteria == "EndsWith")
        {

        }
    }


}
