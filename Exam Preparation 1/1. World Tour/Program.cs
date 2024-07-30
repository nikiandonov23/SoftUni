using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine(); 

        string command = "";
        while ((command = Console.ReadLine()) != "Travel")
        {
            string[] tockens = command.Split(":");

            string action = tockens[0];

            switch (action)
            {
                case "Add Stop":
                    int index = int.Parse(tockens[1]);
                    string stringg = tockens[2];

                    if (index >= 0 && index <= input.Length) 
                    {
                        input = input.Insert(index, stringg);
                    }
                    Console.WriteLine(input);
                    break;

                case "Remove Stop":
                    int startIndex = int.Parse(tockens[1]);
                    int endIndex = int.Parse(tockens[2]);

                    if (startIndex >= 0 && startIndex <= endIndex && endIndex < input.Length) 
                    {
                        input = input.Remove(startIndex, endIndex - startIndex + 1);
                    }
                    Console.WriteLine(input);
                    break;

                case "Switch":
                    string oldString = tockens[1];
                    string newString = tockens[2];

                    if (input.Contains(oldString)) 
                    {
                        input = input.Replace(oldString, newString);
                    }

                    Console.WriteLine(input);
                    break;
            }
        }

        Console.WriteLine($"Ready for world tour! Planned stops: {input}");
    }
}