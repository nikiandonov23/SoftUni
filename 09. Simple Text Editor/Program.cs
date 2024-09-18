// See https://aka.ms/new-console-template for more information

using System.Text;

int n = int.Parse(Console.ReadLine());
StringBuilder text = new StringBuilder();
Stack<string> history = new Stack<string>();


for (int i = 0; i < n; i++)
{
    string[] tockens = Console.ReadLine().Split(" ");

    switch (tockens[0])
    {
        case "1":
            history.Push(text.ToString());

            text.Append(tockens[1]);
            break;

        case "2":

           history.Push(text.ToString());
           int count = int.Parse(tockens[1]);

           text.Remove(text.Length - count, count);

            break;

        case "3":
            Console.WriteLine(text[int.Parse(tockens[1])-1]);
            break;

        case "4":
            if (history.Count > 0)
            {
                text.Clear();
                text.Append(history.Pop());
            }

            break;
    }

}