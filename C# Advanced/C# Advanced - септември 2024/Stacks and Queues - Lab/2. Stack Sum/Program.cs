// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

int[] input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

Stack<int> data=new Stack<int>(input);




string command = "";
while ((command = Console.ReadLine().ToLower()) != "end")
{
    string[] tockens = command.Split(" ");
    string action = tockens[0];

    switch (action)
    {
        case "add":
            int n1 = int.Parse(tockens[1]);
            int n2 = int.Parse(tockens[2]);

            data.Push(n1);
            data.Push(n2);



            break;


        case "remove":
            int count = int.Parse(tockens[1]);

            if (data.Count>=count)
            {
                for (int i = 0; i < count; i++)
                {
                    data.Pop();
                    
                }
            }
          
            break;

    }
}

Console.WriteLine($"Sum: {data.Sum()}");