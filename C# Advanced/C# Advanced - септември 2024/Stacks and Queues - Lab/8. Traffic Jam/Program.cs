// See https://aka.ms/new-console-template for more information


int passCount = int.Parse(Console.ReadLine());

string input = "";
Queue<string> cars = new Queue<string>();
int counter = 0;
while ((input = Console.ReadLine()) != "end")
{
    if (input != "green")
    {
        cars.Enqueue(input);
    }
    else if (input == "green")
    {


        for (int i = 0; i < passCount; i++)
        {
            if (cars.Count > 0)
            {
                counter++;
                Console.WriteLine($"{cars.Dequeue()} passed!");
            }
            

        }



    }
}

Console.WriteLine($"{counter} cars passed the crossroads.");
