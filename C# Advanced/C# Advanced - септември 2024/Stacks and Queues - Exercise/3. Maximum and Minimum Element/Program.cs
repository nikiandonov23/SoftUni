// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());


Stack<int>numbers=new Stack<int>();
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();

    string[] tockens = input.Split(" ");


    switch (tockens[0])
    {
        case"1":
            numbers.Push(int.Parse(tockens[1]));
            break;

        case "2":
            if (numbers.Count>0)
            {
                numbers.Pop();
            }
            
            break;

        case "3":
            if (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Max());

            }
            break;

        case "4":
            if (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Min());

            }
            break;
    }
}

Console.WriteLine(string.Join(", ",numbers));

