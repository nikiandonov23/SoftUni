// See https://aka.ms/new-console-template for more information

int originalDuration = int.Parse(Console.ReadLine());  //vremeto v koeto moje da trugne kola
int freeWindow=int.Parse(Console.ReadLine());   //vremeto v koeto ve4e trugnala kola moje da se iztegli bezopastno

Queue<string> allCars=new Queue<string>();
int carsPassed = 0;

string input = "";
while ((input = Console.ReadLine()) != "END")
{
    if (input=="green")
    {
        int duration = originalDuration;
        while (allCars.Count>0&& duration>0)
        {
            if (allCars.Peek().Length>duration)   // imame katastrofa
            {
                int remainingTime = duration + freeWindow;
                Console.WriteLine($"CRASH");
                Console.WriteLine($"{allCars.Peek()} was hit at {allCars.Peek()[remainingTime]}.");
            }

            carsPassed++;
            duration-=allCars.Peek().Length;
            allCars.Dequeue();
            
        }
      
    }
    else
    {
            allCars.Enqueue(input);
           
    }
}

if (carsPassed>0)
{
    Console.WriteLine("Everyone is safe.");
    Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
}