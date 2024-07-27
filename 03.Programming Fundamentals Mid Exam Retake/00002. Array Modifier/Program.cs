// See https://aka.ms/new-console-template for more information


List<int> input = Console.ReadLine()         //23 -2 321 87 42 90 -123
    .Split(" ")
    .Select(int.Parse)
    .ToList();


string command="";
while ((command = Console.ReadLine()) != "end")
{
    string[] tockens = command.Split(" ");
    

    switch (tockens[0])
    {
           
        case "swap":
            int index1 = int.Parse(tockens[1]);
            int index2 = int.Parse(tockens[2]);

            int temp = input[index1];
            input[index1] = input[index2];
            input[index2] = temp;
            

            break;
            




        case "multiply":
             index1 = int.Parse(tockens[1]);
             index2 = int.Parse(tockens[2]);

            input[index1]=input[index1]*input[index2];
            break;





        case "decrease":
            for (int i = 0; i < input.Count; i++)
            {
                input[i] -= 1;
            }
            break;
    }


}

Console.WriteLine(string.Join(", ",input));
