// See https://aka.ms/new-console-template for more information
string command = "";


Queue<string> names=new Queue<string>();

while (command!="End")
{
    command=Console.ReadLine();

    if (command=="Paid")
    {
        int count = names.Count;
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(names.Dequeue());
        }
    }
    else if (command != "Paid"&&command!="End")
    {
        names.Enqueue(command);
    }

}

Console.WriteLine($"{names.Count} people remaining.");
