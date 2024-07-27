// See https://aka.ms/new-console-template for more information
class ArrayManipulator
{
    static void Main(string[] args)
    {
        
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }

            string[] commandParts = input.Split();
            string command = commandParts[0];

            switch (command)
            {
                case "exchange":
                    int index = int.Parse(commandParts[1]);
                    array = Exchange(array, index);
                    break;
                case "max":
                    string maxType = commandParts[1];
                    Max(array, maxType);
                    break;
                case "min":
                    string minType = commandParts[1];
                    Min(array, minType);
                    break;
                case "first":
                    int firstCount = int.Parse(commandParts[1]);
                    string firstType = commandParts[2];
                    First(array, firstCount, firstType);
                    break;
                case "last":
                    int lastCount = int.Parse(commandParts[1]);
                    string lastType = commandParts[2];
                    Last(array, lastCount, lastType);
                    break;
            }
        }

        
        Console.WriteLine($"[{string.Join(", ", array)}]");
    }

    static int[] Exchange(int[] array, int index)
    {
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Invalid index");
            return array;
        }

        int[] firstPart = array.Take(index + 1).ToArray();
        int[] secondPart = array.Skip(index + 1).ToArray();
        return secondPart.Concat(firstPart).ToArray();
    }

    static void Max(int[] array, string type)
    {
        int[] filtered = FilterByType(array, type);
        if (filtered.Length == 0)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            int maxElement = filtered.Max();
            int index = Array.LastIndexOf(array, maxElement);
            Console.WriteLine(index);
        }
    }

    static void Min(int[] array, string type)
    {
        int[] filtered = FilterByType(array, type);
        if (filtered.Length == 0)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            int minElement = filtered.Min();
            int index = Array.LastIndexOf(array, minElement);
            Console.WriteLine(index);
        }
    }

    static void First(int[] array, int count, string type)
    {
        if (count > array.Length)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        int[] filtered = FilterByType(array, type);
        int[] result = filtered.Take(count).ToArray();
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }

    static void Last(int[] array, int count, string type)
    {
        if (count > array.Length)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        int[] filtered = FilterByType(array, type);
        int[] result = filtered.Reverse().Take(count).Reverse().ToArray();
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }

    static int[] FilterByType(int[] array, string type)
    {
        return type == "even" ? array.Where(x => x % 2 == 0).ToArray() : array.Where(x => x % 2 != 0).ToArray();
    }
}