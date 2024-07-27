// See https://aka.ms/new-console-template for more information



List<string> input = Console.ReadLine()           //Data Types, Objects, Lists
    .Split(", ")
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

                if (input.Contains(tockens[1] + "-Exercise"))
                {
                    input.Remove(tockens[1] + "-Exercise");
                }
            }
            break;


        case "Swap":
            if (input.Contains(tockens[1]) && input.Contains(tockens[2]))
            {


                int indexFirstElement = input.IndexOf(tockens[1]);
                int indexSecondElement = input.IndexOf(tockens[2]);

                string temp = input[indexFirstElement];
                input[indexFirstElement] = input[indexSecondElement];
                input[indexSecondElement] = temp;

                if (input.Contains(tockens[1] + "-Exercise"))
                {
                    int newIndex = input.IndexOf(tockens[1]);    //dava indexa na ve4e izmesteniq element
                    input.Remove(tockens[1] + "-Exercise");
                    input.Insert(newIndex + 1, tockens[1] + "-Exercise");

                }
                if (input.Contains(tockens[2] + "-Exercise"))
                {
                    int newIndex2 = input.IndexOf(tockens[2]);
                    input.Remove(tockens[2] + "-Exercise");
                    input.Insert(newIndex2 + 1, tockens[2] + "-Exercise");

                }


            }
            break;

        case "Exercise":
            if (!input.Contains(tockens[1]))     //ako uroka ne sushtestvuva v lista
            {
                input.Add(tockens[1]);               //dobavq uroka na kkraq na lista
                input.Add($"{tockens[1]}-Exercise");  //dobavq i uprajnenieto nai nakraq sled samiq urok
            }

            else if (input.Contains(tockens[1]))        //ako uroka ve4e go ima v lista
            {
                int indexOfTheExistingExercise = input.IndexOf(tockens[1]);
                input.Insert(indexOfTheExistingExercise + 1, $"{tockens[1]}-Exercise");
            }
            break;
    }
}

for (int i = 0; i < input.Count; i++)
{
    Console.WriteLine($"{i + 1}.{input[i]}");
}