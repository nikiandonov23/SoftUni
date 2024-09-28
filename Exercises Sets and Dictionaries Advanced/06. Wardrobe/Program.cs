// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, int>> allColors = new Dictionary<string, Dictionary<string, int>>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string color = input[0];
    List<string> clothes = input[1].Split(",").ToList();

    if (!allColors.ContainsKey(color))   //Ako cveta go nqma suzdavam cqloto durvo
    {
      
        allColors.Add(color,new Dictionary<string, int>());

        foreach (var cloth in clothes)
        {


            if (!allColors[color].ContainsKey(cloth))
            {
                allColors[color].Add(cloth, 1);
            }
            else
            {
                allColors[color][cloth]++;
            }
            
        }
        
        
    }
    else                             //Ako cveta sushtestvuva
    {
        foreach (var cloth in clothes)
        {

            if (!allColors[color].ContainsKey(cloth))
            {
                allColors[color].Add(cloth,1);
            }
            else
            {
                allColors[color][cloth]++;
            }
        }

    }
}



string []toBeSearched=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
string colorToBeSearched = toBeSearched[0];
string clothToBeSearched = toBeSearched[1];



foreach (var color in allColors)
{
    Console.WriteLine($"{color.Key} clothes:");
    foreach (var dress in color.Value)
    {
       

        if (color.Key==colorToBeSearched&&dress.Key==clothToBeSearched)
        {
            Console.WriteLine($"* {dress.Key} - {dress.Value} (found!)");
          
        }
        else
        {
            Console.WriteLine($"* {dress.Key} - {dress.Value}");
        }

    }


}

Console.WriteLine();