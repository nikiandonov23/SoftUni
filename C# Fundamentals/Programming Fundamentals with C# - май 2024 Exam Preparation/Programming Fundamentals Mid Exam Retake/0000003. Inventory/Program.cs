// See https://aka.ms/new-console-template for more information



List<string> input = Console.ReadLine()
    .Split(", ")
    .ToList();

string command="";
while ((command = Console.ReadLine()) != "Craft!")
{
    string[] tockens = command.Split(" - ");
    


    switch (tockens[0])
    {
        case "Collect":
            string item = tockens[1];
            if (!input.Contains(item))
            {
                input.Add(item);
            }
            break;




        case "Drop":
            item=tockens[1];
            if (input.Contains(item))
            {
                input.Remove(item);
            }
            break;




        case "Combine Items":

            string oldAndNew = tockens[1];
            string[] oldAndNewArray = oldAndNew.Split(":");
            string oldItem=oldAndNewArray[0];
            string newItem = oldAndNewArray[1];

            if (input.Contains(oldItem))
            {
                int oldItemIndex=input.IndexOf(oldItem);
                input.Insert(oldItemIndex+1, newItem);
            }

            break;





        case "Renew":
             item=tockens[1];
             if (input.Contains(item))
             {
                 input.Remove(item);
                 input.Add(item);
             }

            break;
    }


}

Console.WriteLine(string.Join(", ",input));