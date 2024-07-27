// See https://aka.ms/new-console-template for more information


List<string> input = Console.ReadLine()
    .Split("|")
    .ToList();

string command = "";
while ((command = Console.ReadLine()) != "Yohoho!")
{
    string[] tockens = command.Split(" ");    //•	"Loot {item1} {item2}…{item9}"

    switch (tockens[0])
    {
        case "Loot":
            for (int i = 1; i < tockens.Length; i++)
            {
                if (!input.Contains(tockens[i]))
                {
                    input.Insert(0, tockens[i]);

                }
            }
            break;


        case "Drop":
            int index = int.Parse(tockens[1]);
            if (index < 0 || index > input.Count - 1)
            {
                break;
            }
            else
            {
                string temp = input[index];
                input.RemoveAt(index);
                input.Add(temp);
            }

            break;


        case "Steal":
            int count = int.Parse(tockens[1]);
            if (count > input.Count)
            {
                Console.WriteLine(string.Join(", ", input));
                input.Clear();

            }
            else
            {
                List<string> stolenItems = input.GetRange(input.Count - count, count);
                input.RemoveRange(input.Count - count, count);
                Console.WriteLine(string.Join(", ", stolenItems));
            }



            break;
    }

}

if (input.Count <= 0)
{
    Console.WriteLine("Failed treasure hunt.");
}
else
{
    double sum = 0;
    for (int i = 0; i < input.Count; i++)
    {
        sum += input[i].Length;
    }
    sum /= input.Count;
    Console.WriteLine($"Average treasure gain: {sum:f2} pirate credits.");
}