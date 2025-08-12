// See https://aka.ms/new-console-template for more information



List<string> input = Console.ReadLine()           //Data Types, Objects, Lists
    .Split(" ")
    .ToList();


string command = "";
while ((command = Console.ReadLine()) != "course start")
{
    string[] tockens = command.Split(":");


    switch (tockens[0])
    {
        case "Add":

            if (!input.Contains(tockens[1]))
            {
                input.Add(tockens[1]);
            }
            break;


        case "Insert":
            if (!input.Contains(tockens[1]))
            {
                input.Insert(int.Parse(tockens[2]), tockens[1]);
            }
            break;


        case "Remove":
            if (input.Contains(tockens[1]))
            {
                input.Remove(tockens[1]);
            }
            break;


        case "Swap":
            if (input.Contains(tockens[1]) && input.Contains(tockens[2]))
            {

                int firstIndexToSwap = input.IndexOf(tockens[1]);
                string firstElement = string.Join(" ", tockens[1]);


                int secondIndexToSwap = input.IndexOf(tockens[2]);
                string secondElement = string.Join(" ", tockens[2]);

                input.Remove(firstElement);
                input.Remove(secondElement);

                input.Insert(firstIndexToSwap, secondElement);
                input.Insert(secondIndexToSwap, firstElement);

            }
            break;

        case "Exercise":
            break;
    }
}