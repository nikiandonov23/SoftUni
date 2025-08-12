// See https://aka.ms/new-console-template for more information

int greenLight = int.Parse(Console.ReadLine());  //vremeto v koeto moje da trugne kola
int freeWindow=int.Parse(Console.ReadLine());   //vremeto v koeto ve4e trugnala kola moje da se iztegli bezopastno

Queue<string> allCars=new Queue<string>();
int carsPassed = 0;
bool weHaveACrash = false;

string input = "";
while ((input = Console.ReadLine()) != "END")
{
    if (weHaveACrash)
    {
        break;
    }
    
    if (input=="green")
    {
        int remainingTime = greenLight;

        while (remainingTime>0&&allCars.Count>0)
        {
            string currentCar=allCars.Dequeue();
            remainingTime -= currentCar.Length;

            if (remainingTime<0&&Math.Abs(remainingTime)>freeWindow)
            {
                int partWhereCrashOccured = remainingTime + freeWindow;
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{currentCar} was hit at {currentCar[currentCar.Length+partWhereCrashOccured]}.");
            
                weHaveACrash=true;
                break;
            }

            carsPassed++;
        }
    }
    else
    {
            allCars.Enqueue(input);
           
    }
}



if (weHaveACrash==false)
{
    Console.WriteLine("Everyone is safe.");
    Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
}
