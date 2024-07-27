// See https://aka.ms/new-console-template for more information


List<string> input = Console.ReadLine()
    .Split("!")
    .ToList();


string command = "";
while ((command = Console.ReadLine()) != "Go Shopping!")
{
    string[] tockens = command.Split(" ");


    switch (tockens[0])
    {
        case "Urgent":
            string item = tockens[1];
            if (input.Contains(item))
            {
                continue;
            }
            else
            {
                input.Insert(0,item);
            }
            break;



        case "Unnecessary":
            item=tockens[1];
            if (input.Contains(item))
            {
                input.Remove(item);
            }
            else
            {
                    continue;
            }
            break;




        case "Correct":
            string oldItem = tockens[1];
            string newItem = tockens[2];

            if (input.Contains(oldItem))
            {
                int index = input.IndexOf(oldItem);
                input.RemoveAt(index);
                input.Insert(index,newItem);
            }
            else
            {
                    continue;
            }
            break;




        case "Rearrange":
            item = tockens[1];
            if (input.Contains(item))
            {
                input.Remove(item);
                input.Add(item);
            }
            else
            {
                continue;
            }
            break;
    }


}

Console.WriteLine(string.Join(", ",input));
