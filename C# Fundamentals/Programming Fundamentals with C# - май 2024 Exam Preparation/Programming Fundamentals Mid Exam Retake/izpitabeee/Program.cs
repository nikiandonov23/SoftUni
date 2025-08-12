// See https://aka.ms/new-console-template for more information


using System.Data;

List<string> input = Console.ReadLine()
    .Split(", ")
    .ToList();

int n = int.Parse(Console.ReadLine());
string command = "";


for (int i = 1; i <= n; i++)
{
    command = Console.ReadLine();
    string[] tockens = command.Split(", ");

    switch (tockens[0])
    {
        case "Add":
            string cardName = tockens[1];
            if (input.Contains(cardName))
            {
                Console.WriteLine($"Card is already in the deck");
               
            }
            else
            {
                    input.Add(cardName);
                    Console.WriteLine("Card successfully added");
            }

            break;





        case "Remove":
            cardName = tockens[1];
            if (input.Contains(cardName))
            {
                input.Remove(cardName);
                Console.WriteLine("Card successfully removed");
            }
            else
            {
                Console.WriteLine("Card not found");
            }
            break;





        case "Remove At":
            int index = int.Parse(tockens[1]);

            if (index>=0&&index<=input.Count-1)
            {
                input.RemoveAt(index);
                Console.WriteLine("Card successfully removed");
            }
            else
            {
                Console.WriteLine("Index out of range");
            }

            break;





        case "Insert":
            index = int.Parse(tockens[1]);
            cardName = tockens[2];

            if (index<0||index>input.Count-1)
            {
                Console.WriteLine("Index out of range");
            }
            else 
            {
                if (input.Contains(cardName))
                {
                    Console.WriteLine("Card is already added");
                }
                else
                {
                    input.Insert(index,cardName);
                    Console.WriteLine("Card successfully added");
                }
            }

            break;




    }

}

Console.WriteLine(string.Join(", ",input));
